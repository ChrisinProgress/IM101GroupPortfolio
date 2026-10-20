using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneCode
{
    public partial class VicenteProfile : Form
    {
        bool sidebarExpand = false; // starts collapsed
        int openWidth, closedWidth;
        const int step = 10;

        public VicenteProfile()
        {
            InitializeComponent();
            SetAnchors();
        }

        // ---------- PANEL EVENTS ----------
        private void SetAnchors()
        {
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            HomeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Aboutus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Contactus.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            nameTag.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureOne.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            VicentePic.Anchor = AnchorStyles.None;
            label1.Anchor = AnchorStyles.None;
            label2.Anchor = AnchorStyles.None;
            label3.Anchor = AnchorStyles.None;
            label4.Anchor = AnchorStyles.None;
            textBox1.Anchor = AnchorStyles.None;

            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            panelThree.Dock = DockStyle.Fill;
            panel2.Dock = DockStyle.Left;
        }

        // ---------- FORM LOAD & CENTERING ----------
        private void Register_Load(object sender, EventArgs e)
        {
            CenterPanel();

            openWidth = panel2.MaximumSize.Width > 0 ? panel2.MaximumSize.Width : 260;
            closedWidth = panel2.MinimumSize.Width > 0 ? panel2.MinimumSize.Width : 100;

            panel2.Width = closedWidth;   // Sidebar starts collapsed
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

            UpdateSidebarVisuals();

            if (panel2.Width == targetWidth)
            {
                timer1.Stop();
                sidebarExpand = !sidebarExpand;
                UpdateSidebarVisuals();
            }
        }

        // ---------- TOGGLE SIDEBAR ----------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
        }

        // ---------- UPDATE SIDEBAR VISUALS ----------
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

        // ---------- NAVIGATION BUTTONS ----------
        private void button1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();
        }

        // --- Education ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteEducation = new VicenteEducation();
            vicenteEducation.WindowState = this.WindowState;

            vicenteEducation.Load += (s, ev) =>
            {
                var sidebarField = vicenteEducation.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteEducation.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteEducation) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteEducation, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteEducation.Show();
            this.Close();
        }

        // --- About Us ---
        private void Aboutus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteAboutUs = new VicenteAboutUs();
            vicenteAboutUs.WindowState = this.WindowState;

            vicenteAboutUs.Load += (s, ev) =>
            {
                var sidebarField = vicenteAboutUs.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteAboutUs.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteAboutUs) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteAboutUs, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteAboutUs.Show();
            this.Close();
        }

        // --- Contact Us ---
        private void Contactus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteContactUs = new VicenteContactUs();
            vicenteContactUs.WindowState = this.WindowState;

            vicenteContactUs.Load += (s, ev) =>
            {
                var sidebarField = vicenteContactUs.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteContactUs.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteContactUs) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteContactUs, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteContactUs.Show();
            this.Close();
        }

        // --- Skills ---
        private void button3_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteSkills = new VicenteSkills();
            vicenteSkills.WindowState = this.WindowState;

            vicenteSkills.Load += (s, ev) =>
            {
                var sidebarField = vicenteSkills.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteSkills.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteSkills) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteSkills, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteSkills.Show();
            this.Close();
        }

        // --- Hobbies ---
        private void button4_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteHobbies = new VicenteHobbies();
            vicenteHobbies.WindowState = this.WindowState;

            vicenteHobbies.Load += (s, ev) =>
            {
                var sidebarField = vicenteHobbies.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteHobbies.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteHobbies) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteHobbies, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteHobbies.Show();
            this.Close();
        }

        // --- Message ---
        private void button5_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var vicenteMessage = new VicenteMessage();
            vicenteMessage.WindowState = this.WindowState;

            vicenteMessage.Load += (s, ev) =>
            {
                var sidebarField = vicenteMessage.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                var panel2Field = vicenteMessage.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(vicenteMessage) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(vicenteMessage, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            vicenteMessage.Show();
            this.Close();
        }

        // --- Homepage Transition ---
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
            homepage.WindowState = this.WindowState;

            homepage.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                homepage.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        // --- Logout ---
        private void button6_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var login = new Login();
            login.WindowState = this.WindowState;

            login.Show();
            this.Close();
        }
    }
}
