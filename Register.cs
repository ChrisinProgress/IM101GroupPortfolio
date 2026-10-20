using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Microsoft.Data.SqlClient;

namespace GroupOneCode
{
    public partial class Register : Form
    {
        // ---------- DLL Imports ----------
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;

        // ---------- Constructor ----------
        public Register()
        {
            InitializeComponent();
            SetAnchors(); // added

            // Apply Segoe UI font
            var segoe = new Font("Segoe UI", 10f);
            UsernameOne.Font = segoe;
            PasswordOne.Font = segoe;

            // Set placeholders
            SetPlaceholder(UsernameOne, "Username");
            SetPlaceholder(PasswordOne, "Password");

            // No masking (no circles)
            PasswordOne.UseSystemPasswordChar = false;
        }

        // anchors setup
        private void SetAnchors()
        {

            pictureOne.Anchor = AnchorStyles.None;
            textWelcome1.Anchor = AnchorStyles.None;
            textGroup1.Anchor = AnchorStyles.None;
            UsernameOne.Anchor = AnchorStyles.None;
            PasswordOne.Anchor = AnchorStyles.None;
            showpassOne.Anchor = AnchorStyles.None;
            registerButton.Anchor = AnchorStyles.None;
            loginButton.Anchor = AnchorStyles.None;
            validationOne.Anchor = AnchorStyles.None;
            panelOne.Dock = DockStyle.Fill;
        }

        // ---------- Placeholder Helper ----------
        void SetPlaceholder(TextBox tb, string text) =>
            SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)0, text);

        // ---------- Event Handlers ----------
        private void UsernameOne_TextChanged(object sender, EventArgs e) { }

        private void WelcomeOne_Click(object sender, EventArgs e) { }

        private void PasswordOne_TextChanged(object sender, EventArgs e)
        {
            // If empty, don't mask (so placeholder can be seen)
            // Otherwise mask/unmask based on the checkbox state
            if (string.IsNullOrEmpty(PasswordOne.Text))
                PasswordOne.UseSystemPasswordChar = false;
            else
                PasswordOne.UseSystemPasswordChar = !showpassOne.Checked;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {    
            // Navigate to Login form
            Login loginForm = new Login();
            loginForm.WindowState = this.WindowState;
            loginForm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void pictureOne_Click(object sender, EventArgs e) { }

        // ---------- Register Button ----------
        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameOne.Text.Trim();
            string password = PasswordOne.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!");
                return;
            }

            // Connection string to SQL Server
            string connectionString =
                "Server=LAPTOP-D9U5NFOO\\SQLEXPRESS;Database=DatabaseGroupOne;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Insert into Users table
                    string query = "INSERT INTO Users (Username, UserPassword) VALUES (@username, @password)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute SQL command
                    int rows = cmd.ExecuteNonQuery();

                    // Success or fail message
                    if (rows > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        UsernameOne.Clear();
                        PasswordOne.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed!");
                    }
                }
                catch (SqlException ex)
                {
                    // Error 2627 = duplicate username
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Username already exists! Try another.");
                    }
                    else
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // General error
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ---------- Show Password Checkbox ----------
        private void showpassOne_CheckedChanged(object sender, EventArgs e)
        {
            // If checked => show password (no mask)
            // If unchecked => mask only when there is text
            if (showpassOne.Checked)
                PasswordOne.UseSystemPasswordChar = false;
            else
                PasswordOne.UseSystemPasswordChar = !string.IsNullOrEmpty(PasswordOne.Text);
        }

        // ---------- Form Centering ----------
        private void Register_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            // Centers the panel horizontally and vertically
            panelOne.Left = (this.ClientSize.Width - panelOne.Width) / 2;
            panelOne.Top = (this.ClientSize.Height - panelOne.Height) / 2;
        }
    }
}
