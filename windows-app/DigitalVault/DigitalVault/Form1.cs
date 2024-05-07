using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalVault
{

    public partial class DigitalVault : Form
    {
        public DigitalVault()
        {
            InitializeComponent();
        }
        private void login(string username,string password)
        {
            string apiAddress = "http://digitalvault.eastus.cloudapp.azure.com:8000";
            var httpClient = new HttpClient();
            var url = $"{apiAddress}/login";

            var content = new StringContent($"grant_type=&username={username}&password={password}&scope=&client_id=&client_secret=", Encoding.UTF8, "application/x-www-form-urlencoded");

            var response = httpClient.PostAsync(url, content).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;

            dynamic json = JsonConvert.DeserializeObject(responseContent);

            if (json.status == true)
            {
                if (rememberCheck.Checked)
                {
                    Properties.Settings.Default.username = usernameInput.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.Save();
                }

                string token = json.access_token;
                string fernetKey = json.fernet_key;

                Form2 form2 = new Form2(token,fernetKey);
                form2.Show();

                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("An error occurred while logging in.");
                if (json.message != null)
                {
                    //MessageBox.Show(json.message);
                }
                return;
            }
        }

        private void DigitalVault_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                usernameInput.Text = Properties.Settings.Default.username;
                rememberCheck.Checked = true;
                passwordInput.TabIndex = 0;
                usernameInput.TabIndex = 1;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            login(username, password);

        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void createAccountLink_Click(object sender, EventArgs e)
        {
            string createAccountUrl = "http://digitalvault.eastus.cloudapp.azure.com/login#register";
            System.Diagnostics.Process.Start(createAccountUrl);
        }
    }
}
