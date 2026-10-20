
namespace GroupOneCode
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelTwo = new Panel();
            showpassTwo = new CheckBox();
            signinButton = new Button();
            regButton = new Label();
            validationTwo = new Label();
            pictureTwo = new PictureBox();
            textGroup2 = new Label();
            textWelcome2 = new Label();
            PasswordTwo = new TextBox();
            UsernameTwo = new TextBox();
            panelTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTwo).BeginInit();
            SuspendLayout();
            // 
            // panelTwo
            // 
            panelTwo.Anchor = AnchorStyles.None;
            panelTwo.BackColor = Color.FromArgb(37, 39, 65);
            panelTwo.Controls.Add(showpassTwo);
            panelTwo.Controls.Add(signinButton);
            panelTwo.Controls.Add(regButton);
            panelTwo.Controls.Add(validationTwo);
            panelTwo.Controls.Add(pictureTwo);
            panelTwo.Controls.Add(textGroup2);
            panelTwo.Controls.Add(textWelcome2);
            panelTwo.Controls.Add(PasswordTwo);
            panelTwo.Controls.Add(UsernameTwo);
            panelTwo.Location = new Point(0, 0);
            panelTwo.Name = "panelTwo";
            panelTwo.Size = new Size(1414, 922);
            panelTwo.TabIndex = 1;
            panelTwo.Paint += panelTwo_Paint;
            panelTwo.Resize += Register_Resize;
            // 
            // showpassTwo
            // 
            showpassTwo.Anchor = AnchorStyles.None;
            showpassTwo.AutoSize = true;
            showpassTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showpassTwo.ForeColor = SystemColors.ButtonShadow;
            showpassTwo.Location = new Point(493, 587);
            showpassTwo.Name = "showpassTwo";
            showpassTwo.Size = new Size(140, 24);
            showpassTwo.TabIndex = 9;
            showpassTwo.Text = "Show Password";
            showpassTwo.UseVisualStyleBackColor = true;
            showpassTwo.CheckedChanged += showpassTwo_CheckedChanged;
            // 
            // signinButton
            // 
            signinButton.Anchor = AnchorStyles.None;
            signinButton.BackColor = Color.FromArgb(209, 163, 221);
            signinButton.Cursor = Cursors.Hand;
            signinButton.FlatStyle = FlatStyle.Popup;
            signinButton.Font = new Font("Segoe UI", 12F);
            signinButton.Location = new Point(565, 637);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(334, 40);
            signinButton.TabIndex = 7;
            signinButton.Text = "Sign in";
            signinButton.TextAlign = ContentAlignment.TopCenter;
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // regButton
            // 
            regButton.AllowDrop = true;
            regButton.Anchor = AnchorStyles.None;
            regButton.AutoSize = true;
            regButton.BackColor = Color.Transparent;
            regButton.Cursor = Cursors.Hand;
            regButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            regButton.ForeColor = Color.FromArgb(209, 163, 221);
            regButton.Location = new Point(789, 694);
            regButton.Name = "regButton";
            regButton.Size = new Size(90, 28);
            regButton.TabIndex = 6;
            regButton.Text = "Register";
            regButton.TextAlign = ContentAlignment.MiddleCenter;
            regButton.UseMnemonic = false;
            regButton.Click += regButton_Click;
            // 
            // validationTwo
            // 
            validationTwo.AllowDrop = true;
            validationTwo.Anchor = AnchorStyles.None;
            validationTwo.AutoSize = true;
            validationTwo.BackColor = Color.Transparent;
            validationTwo.Font = new Font("Segoe UI", 12F);
            validationTwo.ForeColor = Color.White;
            validationTwo.Location = new Point(576, 694);
            validationTwo.Name = "validationTwo";
            validationTwo.Size = new Size(216, 28);
            validationTwo.TabIndex = 5;
            validationTwo.Text = "Don’t have an account?";
            validationTwo.TextAlign = ContentAlignment.MiddleCenter;
            validationTwo.UseMnemonic = false;
            // 
            // pictureTwo
            // 
            pictureTwo.Anchor = AnchorStyles.None;
            pictureTwo.BackColor = Color.Transparent;
            pictureTwo.BackgroundImageLayout = ImageLayout.None;
            pictureTwo.Image = (Image)resources.GetObject("pictureTwo.Image");
            pictureTwo.Location = new Point(642, 246);
            pictureTwo.Name = "pictureTwo";
            pictureTwo.Size = new Size(150, 89);
            pictureTwo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTwo.TabIndex = 4;
            pictureTwo.TabStop = false;
            // 
            // textGroup2
            // 
            textGroup2.AllowDrop = true;
            textGroup2.Anchor = AnchorStyles.None;
            textGroup2.AutoSize = true;
            textGroup2.BackColor = Color.Transparent;
            textGroup2.Font = new Font("Segoe UI", 15F);
            textGroup2.ForeColor = Color.White;
            textGroup2.Location = new Point(596, 415);
            textGroup2.Name = "textGroup2";
            textGroup2.Size = new Size(232, 35);
            textGroup2.TabIndex = 3;
            textGroup2.Text = "Created by Group 1";
            textGroup2.TextAlign = ContentAlignment.MiddleCenter;
            textGroup2.UseMnemonic = false;
            // 
            // textWelcome2
            // 
            textWelcome2.AllowDrop = true;
            textWelcome2.Anchor = AnchorStyles.None;
            textWelcome2.AutoSize = true;
            textWelcome2.BackColor = Color.Transparent;
            textWelcome2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            textWelcome2.ForeColor = Color.White;
            textWelcome2.Location = new Point(322, 338);
            textWelcome2.Name = "textWelcome2";
            textWelcome2.Size = new Size(815, 67);
            textWelcome2.TabIndex = 2;
            textWelcome2.Text = "Welcome to our Profile Portfolio!";
            textWelcome2.TextAlign = ContentAlignment.MiddleCenter;
            textWelcome2.UseMnemonic = false;
            textWelcome2.Click += textWelcome2_Click;
            // 
            // PasswordTwo
            // 
            PasswordTwo.Anchor = AnchorStyles.None;
            PasswordTwo.Location = new Point(481, 544);
            PasswordTwo.Name = "PasswordTwo";
            PasswordTwo.Size = new Size(487, 27);
            PasswordTwo.TabIndex = 1;
            PasswordTwo.TextChanged += PasswordTwo_TextChanged;
            // 
            // UsernameTwo
            // 
            UsernameTwo.Anchor = AnchorStyles.None;
            UsernameTwo.Location = new Point(481, 494);
            UsernameTwo.Name = "UsernameTwo";
            UsernameTwo.Size = new Size(487, 27);
            UsernameTwo.TabIndex = 0;
            UsernameTwo.TextChanged += UsernameOne_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 39, 65);
            ClientSize = new Size(1414, 922);
            Controls.Add(panelTwo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Register_Load;
            Resize += Register_Resize;
            panelTwo.ResumeLayout(false);
            panelTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTwo).EndInit();
            ResumeLayout(false);
        }

        private void panelTwo_Paint(object sender, PaintEventArgs e)
        {
            panelTwo.BringToFront();
            panelTwo.Visible = true; // optional if you hide other panels
        }

        #endregion

        private Panel panelTwo;
        private CheckBox showpassTwo;
        private Button signinButton;
        private Label regButton;
        private Label validationTwo;
        private PictureBox pictureTwo;
        private Label textGroup2;
        private Label textWelcome2;
        private TextBox PasswordTwo;
        private TextBox UsernameTwo;
    }
}