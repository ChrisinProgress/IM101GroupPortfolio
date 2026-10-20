using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GroupOneCode
{
    public partial class Login : Form
    {
        // ---------- DLL Imports ----------
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        const int EM_SETCUEBANNER = 0x1501;

        // ---------- Constructor ----------
        public Login()
        {
            InitializeComponent();
            SetAnchors(); // added

            // Apply Segoe UI font
            var segoe = new Font("Segoe UI", 10f);
            UsernameTwo.Font = segoe;
            PasswordTwo.Font = segoe;

            // Set placeholders
            SetPlaceholder(UsernameTwo, "Username");
            SetPlaceholder(PasswordTwo, "Password");

            // No masking (no circles)
            PasswordTwo.UseSystemPasswordChar = false;
        }

        // anchors setup
        private void SetAnchors()
        {

            pictureTwo.Anchor = AnchorStyles.None;
            textWelcome2.Anchor = AnchorStyles.None;
            textGroup2.Anchor = AnchorStyles.None;
            UsernameTwo.Anchor = AnchorStyles.None;
            PasswordTwo.Anchor = AnchorStyles.None;
            showpassTwo.Anchor = AnchorStyles.None;
            signinButton.Anchor = AnchorStyles.None;
            regButton.Anchor = AnchorStyles.None;
            validationTwo.Anchor = AnchorStyles.None;
            panelTwo.Dock = DockStyle.Fill;
        }

        // ---------- Placeholder Helper ----------
        void SetPlaceholder(TextBox tb, string text) =>
            SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)0, text);

        // ---------- Event Handlers ----------
        private void UsernameOne_TextChanged(object sender, EventArgs e) { }

        private void textWelcome2_Click(object sender, EventArgs e) { }

        private void PasswordTwo_TextChanged(object sender, EventArgs e)
        {
            // If empty, don't mask (so placeholder can be seen).
            // Otherwise mask/unmask based on the checkbox state.
            if (string.IsNullOrEmpty(PasswordTwo.Text))
                PasswordTwo.UseSystemPasswordChar = false;
            else
                PasswordTwo.UseSystemPasswordChar = !showpassTwo.Checked;
        }

        private void showpassTwo_CheckedChanged(object sender, EventArgs e)
        {
            // If checked => show password (no mask).
            // If unchecked => mask only when there is text.
            if (showpassTwo.Checked)
                PasswordTwo.UseSystemPasswordChar = false;
            else
                PasswordTwo.UseSystemPasswordChar = !string.IsNullOrEmpty(PasswordTwo.Text);
        }

        // ---------- Login Button ----------
        private void signinButton_Click(object sender, EventArgs e)
        {
            // 1. Set up your SQL connection string
            string connectionString =
                "Server=LAPTOP-D9U5NFOO\\SQLEXPRESS;Database=DatabaseGroupOne;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            // 2. Open SQL connection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // 3. Create query (check if username + password match)
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@user AND UserPassword=@pass";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", UsernameTwo.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", PasswordTwo.Text.Trim());

                con.Open();

                // 4. Run query
                int result = (int)cmd.ExecuteScalar();
                // ung scalar ibig sabihin nyan kinukuha nya ung sinngle value

                // 5. Check result
                if (result > 0)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();

                    HomePage form2 = new HomePage();
                    form2.WindowState = this.WindowState;
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        // ---------- Register Button ----------
        private void regButton_Click(object sender, EventArgs e)
        {
            Register loginForm = new Register();
            loginForm.WindowState = this.WindowState;
            loginForm.Show();
            this.Hide();
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
            panelTwo.Left = (this.ClientSize.Width - panelTwo.Width) / 2;
            panelTwo.Top = (this.ClientSize.Height - panelTwo.Height) / 2;
        }
    }
}