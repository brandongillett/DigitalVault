using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Management.Instrumentation;
using static DigitalVault.Form2;

namespace DigitalVault
{
    public partial class Form2 : Form
    {
        private static readonly string apiAddress = "http://digitalvault.eastus.cloudapp.azure.com:8000";
        private readonly User _user;

        public Form2(string token, string fernetKey)
        {
            InitializeComponent();

            _user = new User
            {
                token = token,
                fernetKey = fernetKey
            };
            _user.getInfo(apiAddress).Wait();
            _user.getLastUpdate(apiAddress).Wait();
            _user.getPasswords(apiAddress).Wait();
            _user.getCards(apiAddress).Wait();

        }

        public class passwordEntry
        {
            public int id { get; set; }
            public string service { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string notes { get; set; }
        }
        public class cardEntry
        {
            public int id { get; set; }
            public string type { get; set; }
            public string number { get; set; }
            public string expiration { get; set; }
            public string cvc { get; set; }
        }

        public class User
        {
            public string token { get; set; }
            public string fernetKey { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string lastUpdate { get; set; }
            public List<passwordEntry> passwords { get; private set; }
            public List<cardEntry> cards { get; private set; }


            public async Task getInfo(string apiAddress)
            {
                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/info";

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = _httpClient.GetAsync(url).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                username = json.username;
                email = json.email;
            }

            public async Task getLastUpdate(string apiAddress)
            {
                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/getTimestamp";

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = _httpClient.GetAsync(url).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                lastUpdate = json;
            }

            public async Task getPasswords(string apiAddress)
            {
                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/getPasswords";
                var info = "?fernetKey=" + fernetKey;

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = _httpClient.GetAsync(url+info).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                passwords = new List<passwordEntry>();

                if (json == null)
                {
                    return;
                }

                foreach (var entry in json)
                {
                    passwords.Add(new passwordEntry
                    {
                        id = entry.id,
                        service = entry.service,
                        username = entry.username,
                        password = entry.password,
                        notes = entry.notes
                    });
                }
            }

            public async Task getCards(string apiAddress)
            {
                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/getCards";
                var info = "?fernetKey=" + fernetKey;

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = _httpClient.GetAsync(url + info).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);
                
                cards = new List<cardEntry>();



                if (json == null)
                {
                    return;
                }

                foreach (var entry in json)
                {
                    cards.Add(new cardEntry
                    {
                        id = entry.id,
                        type = entry.cardType,
                        number = entry.cardNumber,
                        expiration = entry.expiration,
                        cvc = entry.cvc
                    });
                }

            }


            public async Task delPassword(int id)
            {
                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/delPassword";
                var info = $"?passId={id}";

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = _httpClient.DeleteAsync(url + info).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);
            }
        }

        private void updatePasswords()
        {
            _user.getPasswords(apiAddress).Wait();
            passwordGrid.Rows.Clear();

            foreach (var entry in _user.passwords)
            {
                passwordGrid.Rows.Add(entry.id, entry.service, entry.username, entry.password, entry.notes);
            }
        }

        private void updateCards()
        {
            _user.getCards(apiAddress).Wait();
            cardGrid.Rows.Clear();

            foreach (var entry in _user.cards)
            {
                cardGrid.Rows.Add(entry.id, entry.type, entry.number, entry.expiration, entry.cvc);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello, " + _user.username + "!";
            foreach (var entry in _user.passwords)
            {
                passwordGrid.Rows.Add(entry.id, entry.service, entry.username, entry.password, entry.notes);
            }

            foreach (var entry in _user.cards)
            {
                cardGrid.Rows.Add(entry.id, entry.type, entry.number, entry.expiration, entry.cvc);
            }

            syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void syncTimer_Tick(object sender, EventArgs e)
        {
            string current = _user.lastUpdate;
            _user.getLastUpdate(apiAddress).Wait();
            if (_user.lastUpdate != "NULL" && _user.lastUpdate != current)
            {
                updatePasswords();
                updateCards();
                syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }

        }

        private void passwordGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            int id = (int)passwordGrid.Rows[e.Row.Index].Cells[0].Value;
            HttpClient _httpClient = new HttpClient();

            var url = $"{apiAddress}/users/me/delPassword";
            var info = $"?passId={id}";

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

            var response = _httpClient.DeleteAsync(url + info).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            dynamic json = JsonConvert.DeserializeObject(responseContent);

            if (json.status == "true")
            {
                _user.getLastUpdate(apiAddress).Wait();
                syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                MessageBox.Show("Failed to delete password!");
                e.Cancel = true;
            }
        }

        private void passwordGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (passwordGrid.Rows[e.RowIndex].Cells[0].Value != null)
            {

                int id = (int)passwordGrid.Rows[e.RowIndex].Cells[0].Value;
                //check if the cell is empty
                if (passwordGrid.Rows[e.RowIndex].Cells[1].Value == null || passwordGrid.Rows[e.RowIndex].Cells[2].Value == null || passwordGrid.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    MessageBox.Show("Cant leave field blank.");
                    updatePasswords();
                    return;
                    
                }
                string service = passwordGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string username = passwordGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string password = passwordGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string notes = "";
                if (passwordGrid.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    notes = passwordGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                }

                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/editPassword";
                var info = $"?fernetKey={_user.fernetKey}&passId={id}&service={service}&username={username}&password={password}&notes={notes}";

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

                var response = _httpClient.PutAsync(url + info, null).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                if (json.status == "true")
                {
                    _user.getLastUpdate(apiAddress).Wait();
                    syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("Failed to edit password!");
                    updatePasswords();
                    return;
                }
            }
            else
            {
                if (passwordGrid.Rows[e.RowIndex].Cells[1].Value != null && passwordGrid.Rows[e.RowIndex].Cells[2].Value != null && passwordGrid.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    string service = passwordGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string username = passwordGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string password = passwordGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string notes = "";
                    if (passwordGrid.Rows[e.RowIndex].Cells[4].Value != null)
                    {
                        notes = passwordGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                    HttpClient _httpClient = new HttpClient();

                    var url = $"{apiAddress}/users/me/newPassword";
                    var info = $"?fernetKey={_user.fernetKey}&service={service}&username={username}&password={password}&notes={notes}";

                    _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

                    var response = _httpClient.PostAsync(url + info, null).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;

                    dynamic json = JsonConvert.DeserializeObject(responseContent);

                    if (json.status == "true")
                    {
                        _user.getLastUpdate(apiAddress).Wait();
                        updatePasswords();
                        syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add password!");
                        updatePasswords();
                    }
                }
            }
        }

        private void passwordSearchInput_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in passwordGrid.Rows)
            {
                string cell1Value = row.Cells[1].Value?.ToString();
                if (cell1Value != null)
                {

                    if (row.Cells[1].Value.ToString().Contains(passwordSearchInput.Text) || row.Cells[2].Value.ToString().Contains(passwordSearchInput.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void cardGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int id = (int)cardGrid.Rows[e.Row.Index].Cells[0].Value;
            HttpClient _httpClient = new HttpClient();

            var url = $"{apiAddress}/users/me/delCard";
            var info = $"?cardId={id}";

            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

            var response = _httpClient.DeleteAsync(url + info).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            dynamic json = JsonConvert.DeserializeObject(responseContent);

            if (json.status == "true")
            {
                _user.getLastUpdate(apiAddress).Wait();
                syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                MessageBox.Show("Failed to delete card!");
                e.Cancel = true;
            }
        }

        private void cardGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (cardGrid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int id = (int)cardGrid.Rows[e.RowIndex].Cells[0].Value;
                if (cardGrid.Rows[e.RowIndex].Cells[1].Value == null || cardGrid.Rows[e.RowIndex].Cells[2].Value == null || cardGrid.Rows[e.RowIndex].Cells[3].Value == null || cardGrid.Rows[e.RowIndex].Cells[4].Value == null)
                {
                    MessageBox.Show("Cant leave field blank.");
                    updateCards();
                    return;
                }
                string cardType = cardGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cardNumber = cardGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string expiration = cardGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string cvc = cardGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                HttpClient _httpClient = new HttpClient();

                var url = $"{apiAddress}/users/me/editCard";
                var info = $"?fernetKey={_user.fernetKey}&cardId={id}&cardType={cardType}&cardNumber={cardNumber}&expiration={expiration}&cvc={cvc}";

                _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

                var response = _httpClient.PutAsync(url + info, null).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                if (json.status == "true")
                {
                    _user.getLastUpdate(apiAddress).Wait();
                    syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("Failed to edit card!");
                    updateCards();
                    return;
                }
            }
            else
            {
                if (cardGrid.Rows[e.RowIndex].Cells[1].Value != null && cardGrid.Rows[e.RowIndex].Cells[2].Value != null && cardGrid.Rows[e.RowIndex].Cells[3].Value != null && cardGrid.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    string cardType = cardGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string cardNumber = cardGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string expiration = cardGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string cvc = cardGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

                    HttpClient _httpClient = new HttpClient();

                    var url = $"{apiAddress}/users/me/newCard";
                    var info = $"?fernetKey={_user.fernetKey}&cardType={cardType}&cardNumber={cardNumber}&expiration={expiration}&cvc={cvc}";

                    _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _user.token);

                    var response = _httpClient.PostAsync(url + info, null).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;

                    dynamic json = JsonConvert.DeserializeObject(responseContent);

                    if (json.status == "true")
                    {
                        _user.getLastUpdate(apiAddress).Wait();
                        updateCards();
                        syncTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add card!");
                        updateCards();
                    }
                }
            }



        }

        private void cardSearchInput_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cardGrid.Rows)
            {
                string cell1Value = row.Cells[1].Value?.ToString();
                if (cell1Value != null)
                {

                    if (row.Cells[1].Value.ToString().Contains(cardSearchInput.Text) || row.Cells[2].Value.ToString().Contains(cardSearchInput.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void autoLogout_Tick(object sender, EventArgs e)
        {
            //show form1
            DigitalVault form1 = new DigitalVault();
            form1.Show();
            this.Close();

            MessageBox.Show("You have been logged out due to time limit.");



        }
    }
}
