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

namespace DigitalVault
{
    public partial class Form2 : Form
    {
        private static readonly string apiAddress = "http://digitalvault.eastus.cloudapp.azure.com:8000";

        public class passwordEntry
        {
            public int id { get; set; }
            public string service { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string notes { get; set; }
        }

        public class User
        {
            public string token { get; set; }
            public string fernetKey { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public List<passwordEntry> passwords { get; private set; }


            public async Task getInfo(string apiAddress)
            {
                var httpClient = new HttpClient();
                var url = $"{apiAddress}/users/me/info";

                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = httpClient.GetAsync(url).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                username = json.username;
                email = json.email;
            }

            public async Task getPasswords(string apiAddress)
            {
                var httpClient = new HttpClient();
                var url = $"{apiAddress}/users/me/getPasswords";
                var info = "?fernetKey=" + fernetKey;
                //add token and fernet key to headers
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var response = httpClient.GetAsync(url+info).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                dynamic json = JsonConvert.DeserializeObject(responseContent);

                passwords = new List<passwordEntry>();

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
            public async Task addPassword(string apiAddress,string service,string username,string password,string notes)
            {
                string url = $"{apiAddress}/users/me/newPassword";
                string info = $"?fernetKey={fernetKey}&service={service}&username={username}&password={password}&notes={notes}";

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                    HttpResponseMessage response = await httpClient.PostAsync(url + info, null);
                    response.EnsureSuccessStatusCode();

                    string responseContent = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);

                    if (jsonResponse.success == "true")
                    {
                        MessageBox.Show("Password added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add password!");
                    }
                }

            }
        }

        private readonly User _user;

        public Form2(string token,string fernetKey)
        {
            InitializeComponent();

            _user = new User
            {
                token = token,
                fernetKey = fernetKey
            };
            _user.getInfo(apiAddress).Wait();
            _user.getPasswords(apiAddress).Wait();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello, " + _user.username + "!";
            foreach (var entry in _user.passwords)
            {
                passwordGrid.Rows.Add(entry.id, entry.service, entry.username, entry.password, entry.notes);
            }

        }

        private void syncTimer_Tick(object sender, EventArgs e)
        {

        }

        private void passwordGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            _user.addPassword(apiAddress, passwordGrid.Rows[e.Row.Index].Cells[1].Value.ToString(), passwordGrid.Rows[e.Row.Index].Cells[2].Value.ToString(), passwordGrid.Rows[e.Row.Index].Cells[3].Value.ToString(), passwordGrid.Rows[e.Row.Index].Cells[4].Value.ToString()).Wait();
        }

        private void passwordGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }

        private void passwordGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
