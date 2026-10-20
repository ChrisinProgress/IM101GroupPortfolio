using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroupOneCode
{
    public partial class RanolaContactUs : Form
    {
        bool sidebarExpand = true;
        int openWidth, closedWidth;
        const int step = 10;

        public RanolaContactUs()
        {
            InitializeComponent();
            SetAnchors();
        }

        private void SetAnchors()
        {
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            HomeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Aboutus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Contactus.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            nameTag.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureOne.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            CruzPic.Anchor = AnchorStyles.None;
            LimPic.Anchor = AnchorStyles.None;
            RanolaPic.Anchor = AnchorStyles.None;
            VicentePic.Anchor = AnchorStyles.None;

            label1.Anchor = AnchorStyles.None;
            label2.Anchor = AnchorStyles.None;
            label3.Anchor = AnchorStyles.None;
            label5.Anchor = AnchorStyles.None;

            textBox1.Anchor = AnchorStyles.None;
            textBox2.Anchor = AnchorStyles.None;
            textBox3.Anchor = AnchorStyles.None;
            textBox4.Anchor = AnchorStyles.None;

            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox10.Anchor = AnchorStyles.None;
            pictureBox11.Anchor = AnchorStyles.None;
            pictureBox12.Anchor = AnchorStyles.None;
            pictureBox13.Anchor = AnchorStyles.None;
            pictureBox14.Anchor = AnchorStyles.None;
            pictureBox15.Anchor = AnchorStyles.None;
            pictureBox16.Anchor = AnchorStyles.None;
            pictureBox17.Anchor = AnchorStyles.None;

            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            panelThree.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Left;
        }
        // ---------- FORM LOAD ----------z
        private void Register_Load(object sender, EventArgs e)
        {
            CenterPanel();

            openWidth = panel2.MaximumSize.Width > 0 ? panel2.MaximumSize.Width : 260;
            closedWidth = panel2.MinimumSize.Width > 0 ? panel2.MinimumSize.Width : 100;

            panel2.Width = closedWidth;
            panel2.BringToFront();

            UpdateSidebarVisuals();
        }

        private void Register_Resize(object sender, EventArgs e) => CenterPanel();

        private void CenterPanel()
        {
            panelThree.Left = (ClientSize.Width - panelThree.Width) / 2;
            panelThree.Top = (ClientSize.Height - panelThree.Height) / 2;
        }

        // ---------- SIDEBAR ANIMATION ----------
        private void timer1_Tick(object sender, EventArgs e)
        {
            int targetWidth = sidebarExpand ? closedWidth : openWidth;
            int direction = sidebarExpand ? -step : step;

            panel2.Width = Math.Max(closedWidth, Math.Min(openWidth, panel2.Width + direction));

            if (panel2.Width == targetWidth)
            {
                timer1.Stop();
                sidebarExpand = !sidebarExpand;
                UpdateSidebarVisuals();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
        }

        // ---------- SIDEBAR VISUALS ----------
        private void UpdateSidebarVisuals()
        {
            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    string label = btn.Tag?.ToString() ?? btn.Text;

                    if (sidebarExpand)
                    {
                        btn.Text = "  " + label;
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        btn.Text = btn.Image != null ? "" : label.Substring(0, 1);
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                    }

                    btn.Width = panel2.Width - 8;
                }
                else if (ctrl is Label lab)
                {
                    lab.Visible = sidebarExpand;
                }
            }
        }

        // ---------- LOGOUT ----------
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaProfile = new RanolaProfile();
            ranolaProfile.WindowState = this.WindowState; // added

            ranolaProfile.Load += (s, ev) =>
            {
                var sidebarField = ranolaProfile.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = ranolaProfile.GetType()
                    .GetField("panel2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaProfile) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaProfile, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaProfile.Show();
            this.Close();
        }

        // ---------- PROFILE ----------
        private void button1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaProfile = new RanolaProfile();
            ranolaProfile.WindowState = this.WindowState; // added

            ranolaProfile.Load += (s, ev) =>
            {
                var sidebarField = ranolaProfile.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaProfile.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaProfile) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaProfile, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaProfile.Show();
            this.Close();
        }

        // ---------- SKILLS ----------
        private void button3_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaSkills = new RanolaSkills();
            ranolaSkills.WindowState = this.WindowState; // added

            ranolaSkills.Load += (s, ev) =>
            {
                var sidebarField = ranolaSkills.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaSkills.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaSkills) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaSkills, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaSkills.Show();
            this.Close();
        }

        // ---------- ABOUT US ----------
        private void Aboutus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaAboutUs = new RanolaAboutUs();
            ranolaAboutUs.WindowState = this.WindowState; // added

            ranolaAboutUs.Load += (s, ev) =>
            {
                var sidebarField = ranolaAboutUs.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaAboutUs.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaAboutUs) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaAboutUs, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaAboutUs.Show();
            this.Close();
        }

        // ---------- LOGIN ----------
        private void button6_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var login = new Login();
            login.WindowState = this.WindowState; // added

            login.Show();
            this.Close();
        }

        // ---------- HOME ----------
        private async void button7_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var homepage = new HomePage { Opacity = 0 };
            homepage.WindowState = this.WindowState; // added
            homepage.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                homepage.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        // ---------- EDUCATION ----------
        private void button2_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaEducation = new RanolaEducation();
            ranolaEducation.WindowState = this.WindowState; // added

            ranolaEducation.Load += (s, ev) =>
            {
                var sidebarField = ranolaEducation.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaEducation.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaEducation) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaEducation, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaEducation.Show();
            this.Close();
        }

        // ---------- HOBBIES ----------
        private void button4_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaHobbies = new RanolaHobbies();
            ranolaHobbies.WindowState = this.WindowState; // added

            ranolaHobbies.Load += (s, ev) =>
            {
                var sidebarField = ranolaHobbies.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaHobbies.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaHobbies) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaHobbies, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaHobbies.Show();
            this.Close();
        }

        // ---------- MESSAGE ----------
        private void button5_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var ranolaMessage = new RanolaMessage();
            ranolaMessage.WindowState = this.WindowState; // added

            ranolaMessage.Load += (s, ev) =>
            {
                var sidebarField = ranolaMessage.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = ranolaMessage.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(ranolaMessage) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(ranolaMessage, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            ranolaMessage.Show();
            this.Close();
        }
    }
}
