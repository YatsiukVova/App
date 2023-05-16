using System.Text;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes.
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Check if the username and password are valid.
            bool isAuthenticated = CheckCredentials(username, password);

            // If the credentials are valid, show the welcome message.
            if (isAuthenticated)
            {
                if (username == "admin")
                {
                    MessageBox.Show("Welcome, admin");
                    new AdminForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Welcome, " + username);
                    new MainForm().Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private bool CheckCredentials(string username, string password)
        {
            string filePath = "data.txt";
            // Create a dictionary to store the usernames and passwords.
            Dictionary<string, string> users = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Розділення рядка на ключ та значення за комою
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        // Додавання ключа та значення до словника
                        string key = parts[0];
                        string value = parts[1];
                        users[key] = value;
                    }
                }
            }
            // Check if the username and password are in the dictionary.
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}