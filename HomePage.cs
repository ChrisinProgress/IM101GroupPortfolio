using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneCode
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            SetAnchors(); // added
        }

        // anchors setup
        private void SetAnchors()
        {

            pictureOne.Anchor = AnchorStyles.None;
            LabelOne.Anchor = AnchorStyles.None;
            CruzPic.Anchor = AnchorStyles.None;
            LimPic.Anchor = AnchorStyles.None;
            RanolaPic.Anchor = AnchorStyles.None;
            VicentePic.Anchor = AnchorStyles.None;

            LabelTwo.Anchor = AnchorStyles.None;
            LogOutButton.Anchor = AnchorStyles.None;

            nameOne.Anchor = AnchorStyles.None;
            NameTwo.Anchor = AnchorStyles.None;
            NameThree.Anchor = AnchorStyles.None;
            NameFour.Anchor = AnchorStyles.None;

            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            panelThree.Dock = DockStyle.Fill;

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
            panelThree.Left = (this.ClientSize.Width - panelThree.Width) / 2;
            panelThree.Top = (this.ClientSize.Height - panelThree.Height) / 2;
        }

        // --- Text and Label Events ---
        private async void NameFour_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var vicenteProfile = new VicenteProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            vicenteProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                vicenteProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.WindowState = this.WindowState; // added
            login.Show();
            this.Close();
        }

        private async void CruzPic_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var cruzprofile = new CruzProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            cruzprofile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                cruzprofile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private async void nameOne_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var cruzprofile = new CruzProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            cruzprofile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                cruzprofile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        // --- Duplicate Paint Event ---
        private void panelThree_Paint_1(object sender, PaintEventArgs e) { }

        private async void LimPic_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var limProfile = new LimProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            limProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                limProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private async void NameThree_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var limProfile = new LimProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            limProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                limProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private async void VicentePic_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var vicenteProfile = new VicenteProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            vicenteProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                vicenteProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private async void RanolaPic_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var ranolaProfile = new RanolaProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            ranolaProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                ranolaProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }

        private async void NameTwo_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }

            var ranolaProfile = new RanolaProfile
            {
                Opacity = 0,
                WindowState = this.WindowState // added
            };
            ranolaProfile.Show();

            for (double i = 0; i <= 1.0; i += 0.1)
            {
                ranolaProfile.Opacity = i;
                await Task.Delay(10);
            }

            this.Close();
        }
    }
}
