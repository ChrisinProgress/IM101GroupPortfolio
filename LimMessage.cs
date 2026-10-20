using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneCode
{
    public partial class LimMessage : Form
    {
        // Sidebar
        bool sidebarExpand = false;
        int openWidth, closedWidth;
        const int step = 10;

        public LimMessage()
        {
            InitializeComponent();
            SetAnchors(); // added
        }

        // ----- Anchors -----
        private void SetAnchors()
        {
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            HomeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Aboutus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Contactus.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            nameTag.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureOne.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            LimPic.Anchor = AnchorStyles.None;
            label1.Anchor = AnchorStyles.None;
            label2.Anchor = AnchorStyles.None;
            label4.Anchor = AnchorStyles.None;
            textBox1.Anchor = AnchorStyles.None;

            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            panelThree.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Left;
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int targetWidth = sidebarExpand ? closedWidth : openWidth;
            int direction = sidebarExpand ? -step : step;

            panel2.Width = Math.Max(closedWidth, Math.Min(openWidth, panel2.Width + direction));
            UpdateSidebarVisuals();

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

        private void UpdateSidebarVisuals()
        {
            bool expanded = panel2.Width > (openWidth + closedWidth) / 2;

            foreach (Control ctrl in panel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    string label = btn.Tag?.ToString() ?? btn.Text;

                    if (expanded)
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
                    lab.Visible = expanded;
                }
            }
        }

        // ------ Profile ------
        private void button1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limProfile = new LimProfile();
            limProfile.WindowState = this.WindowState; // added

            limProfile.Load += (s, ev) =>
            {
                var sidebarField = limProfile.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limProfile.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limProfile) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limProfile, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limProfile.Show();
            this.Close();
        }

        // ------ Education ------
        private void button2_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limEducation = new LimEducation();
            limEducation.WindowState = this.WindowState; // added

            limEducation.Load += (s, ev) =>
            {
                var sidebarField = limEducation.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limEducation.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limEducation) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limEducation, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limEducation.Show();
            this.Close();
        }

        // ------ About Us ------
        private void Aboutus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limaboutus = new LimAboutUs();
            limaboutus.WindowState = this.WindowState; // added

            limaboutus.Load += (s, ev) =>
            {
                var sidebarField = limaboutus.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limaboutus.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limaboutus) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limaboutus, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limaboutus.Show();
            this.Close();
        }

        // ------ Contact Us ------
        private void Contactus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limcontactus = new LimContactUs();
            limcontactus.WindowState = this.WindowState; // added

            limcontactus.Load += (s, ev) =>
            {
                var sidebarField = limcontactus.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limcontactus.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limcontactus) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limcontactus, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limcontactus.Show();
            this.Close();
        }

        // ------ Home ------
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

        // ------ Login ------
        private void button6_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var login = new Login();
            login.WindowState = this.WindowState; // added
            login.Show();
            this.Close();
        }

        private void LimPic_Click(object sender, EventArgs e) { }

        // ------ Log Out ------
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limProfile = new LimProfile();
            limProfile.WindowState = this.WindowState; // added

            limProfile.Load += (s, ev) =>
            {
                var sidebarField = limProfile.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limProfile.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limProfile) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limProfile, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limProfile.Show();
            this.Close();
        }

        // ------ Skills ------
        private void button3_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limSkills = new LimSkills();
            limSkills.WindowState = this.WindowState; // added

            limSkills.Load += (s, ev) =>
            {
                var sidebarField = limSkills.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limSkills.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limSkills) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limSkills, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limSkills.Show();
            this.Close();
        }

        // ------ Hobbies ------
        private void button4_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limHobbies = new LimHobbies();
            limHobbies.WindowState = this.WindowState; // added

            limHobbies.Load += (s, ev) =>
            {
                var sidebarField = limHobbies.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = limHobbies.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limHobbies) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limHobbies, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limHobbies.Show();
            this.Close();
        }

        // ------ Message (current) ------
        private void button5_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();
        }
    }
}
