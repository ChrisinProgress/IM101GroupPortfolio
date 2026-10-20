using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneCode
{
    public partial class LimSkills : Form
    {
        bool sidebarExpand = false;
        int openWidth, closedWidth;
        const int step = 10;

        public LimSkills()
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

            LimPic.Anchor = AnchorStyles.None;
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

        // ---------------- Navigation Buttons ----------------

        private void button1_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limProfile = new LimProfile();
            limProfile.WindowState = this.WindowState;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limEducation = new LimEducation();
            limEducation.WindowState = this.WindowState;

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

        private void Aboutus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limAboutUs = new LimAboutUs();
            limAboutUs.WindowState = this.WindowState;

            limAboutUs.Load += (s, ev) =>
            {
                var sidebarField = limAboutUs.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = limAboutUs.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limAboutUs) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limAboutUs, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limAboutUs.Show();
            this.Close();
        }

        private void Contactus_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limContactUs = new LimContactUs();
            limContactUs.WindowState = this.WindowState;

            limContactUs.Load += (s, ev) =>
            {
                var sidebarField = limContactUs.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = limContactUs.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limContactUs) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limContactUs, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limContactUs.Show();
            this.Close();
        }

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

        private void button6_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var login = new Login();
            login.WindowState = this.WindowState;
            login.Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limProfile = new LimProfile();
            limProfile.WindowState = this.WindowState;

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limHobbies = new LimHobbies();
            limHobbies.WindowState = this.WindowState;

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

        private void button5_Click(object sender, EventArgs e)
        {
            if (sidebarExpand && !timer1.Enabled)
                timer1.Start();

            var limMessage = new LimMessage();
            limMessage.WindowState = this.WindowState;

            limMessage.Load += (s, ev) =>
            {
                var sidebarField = limMessage.GetType().GetField("sidebarExpand",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var panel2Field = limMessage.GetType().GetField("panel2",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .GetValue(limMessage) as Panel;

                if (sidebarField != null && panel2Field != null)
                {
                    sidebarField.SetValue(limMessage, sidebarExpand);
                    panel2Field.Width = sidebarExpand ? openWidth : closedWidth;
                }
            };

            limMessage.Show();
            this.Close();
        }
    }
}
