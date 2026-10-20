namespace GroupOneCode
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            UsernameOne = new TextBox();
            PasswordOne = new TextBox();
            textWelcome1 = new Label();
            textGroup1 = new Label();
            pictureOne = new PictureBox();
            validationOne = new Label();
            loginButton = new Label();
            registerButton = new Button();
            showpassOne = new CheckBox();
            panelOne = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureOne).BeginInit();
            panelOne.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameOne
            // 
            UsernameOne.Anchor = AnchorStyles.None;
            UsernameOne.Location = new Point(481, 494);
            UsernameOne.Name = "UsernameOne";
            UsernameOne.Size = new Size(487, 27);
            UsernameOne.TabIndex = 0;
            UsernameOne.TextChanged += UsernameOne_TextChanged;
            // 
            // PasswordOne
            // 
            PasswordOne.Anchor = AnchorStyles.None;
            PasswordOne.Location = new Point(481, 544);
            PasswordOne.Name = "PasswordOne";
            PasswordOne.Size = new Size(487, 27);
            PasswordOne.TabIndex = 1;
            PasswordOne.TextChanged += PasswordOne_TextChanged;
            // 
            // textWelcome1
            // 
            textWelcome1.AllowDrop = true;
            textWelcome1.Anchor = AnchorStyles.None;
            textWelcome1.AutoSize = true;
            textWelcome1.BackColor = Color.Transparent;
            textWelcome1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            textWelcome1.ForeColor = Color.White;
            textWelcome1.Location = new Point(322, 338);
            textWelcome1.Name = "textWelcome1";
            textWelcome1.Size = new Size(815, 67);
            textWelcome1.TabIndex = 2;
            textWelcome1.Text = "Welcome to our Profile Portfolio!";
            textWelcome1.TextAlign = ContentAlignment.MiddleCenter;
            textWelcome1.UseMnemonic = false;
            textWelcome1.Click += WelcomeOne_Click;
            // 
            // textGroup1
            // 
            textGroup1.AllowDrop = true;
            textGroup1.Anchor = AnchorStyles.None;
            textGroup1.AutoSize = true;
            textGroup1.BackColor = Color.Transparent;
            textGroup1.Font = new Font("Segoe UI", 15F);
            textGroup1.ForeColor = Color.White;
            textGroup1.Location = new Point(596, 415);
            textGroup1.Name = "textGroup1";
            textGroup1.Size = new Size(232, 35);
            textGroup1.TabIndex = 3;
            textGroup1.Text = "Created by Group 1";
            textGroup1.TextAlign = ContentAlignment.MiddleCenter;
            textGroup1.UseMnemonic = false;
            textGroup1.Click += label1_Click_1;
            // 
            // pictureOne
            // 
            pictureOne.Anchor = AnchorStyles.None;
            pictureOne.BackColor = Color.Transparent;
            pictureOne.BackgroundImageLayout = ImageLayout.None;
            pictureOne.Image = (Image)resources.GetObject("pictureOne.Image");
            pictureOne.Location = new Point(642, 246);
            pictureOne.Name = "pictureOne";
            pictureOne.Size = new Size(150, 89);
            pictureOne.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOne.TabIndex = 4;
            pictureOne.TabStop = false;
            pictureOne.Click += pictureOne_Click;
            // 
            // validationOne
            // 
            validationOne.AllowDrop = true;
            validationOne.Anchor = AnchorStyles.None;
            validationOne.AutoSize = true;
            validationOne.BackColor = Color.Transparent;
            validationOne.Font = new Font("Segoe UI", 12F);
            validationOne.ForeColor = Color.White;
            validationOne.Location = new Point(576, 694);
            validationOne.Name = "validationOne";
            validationOne.Size = new Size(234, 28);
            validationOne.TabIndex = 5;
            validationOne.Text = "Already have an account?";
            validationOne.TextAlign = ContentAlignment.MiddleCenter;
            validationOne.UseMnemonic = false;
            validationOne.Click += label2_Click;
            // 
            // loginButton
            // 
            loginButton.AllowDrop = true;
            loginButton.Anchor = AnchorStyles.None;
            loginButton.AutoSize = true;
            loginButton.BackColor = Color.Transparent;
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(209, 163, 221);
            loginButton.Location = new Point(807, 694);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(70, 28);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log in";
            loginButton.TextAlign = ContentAlignment.MiddleCenter;
            loginButton.UseMnemonic = false;
            loginButton.Click += label3_Click;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.BackColor = Color.FromArgb(209, 163, 221);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Segoe UI", 12F);
            registerButton.Location = new Point(565, 637);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(334, 40);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.TextAlign = ContentAlignment.TopCenter;
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += button1_Click;
            // 
            // showpassOne
            // 
            showpassOne.Anchor = AnchorStyles.None;
            showpassOne.AutoSize = true;
            showpassOne.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showpassOne.ForeColor = SystemColors.ButtonShadow;
            showpassOne.Location = new Point(493, 587);
            showpassOne.Name = "showpassOne";
            showpassOne.Size = new Size(140, 24);
            showpassOne.TabIndex = 9;
            showpassOne.Text = "Show Password";
            showpassOne.UseVisualStyleBackColor = true;
            showpassOne.CheckedChanged += showpassOne_CheckedChanged;
            // 
            // panelOne
            // 
            panelOne.Anchor = AnchorStyles.None;
            panelOne.BackColor = Color.FromArgb(37, 39, 65);
            panelOne.Controls.Add(showpassOne);
            panelOne.Controls.Add(registerButton);
            panelOne.Controls.Add(loginButton);
            panelOne.Controls.Add(validationOne);
            panelOne.Controls.Add(pictureOne);
            panelOne.Controls.Add(textGroup1);
            panelOne.Controls.Add(textWelcome1);
            panelOne.Controls.Add(PasswordOne);
            panelOne.Controls.Add(UsernameOne);
            panelOne.Location = new Point(0, 0);
            panelOne.Name = "panelOne";
            panelOne.Size = new Size(1414, 922);
            panelOne.TabIndex = 0;
            panelOne.Resize += Register_Resize;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 39, 65);
            ClientSize = new Size(1414, 922);
            Controls.Add(panelOne);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            Resize += Register_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureOne).EndInit();
            panelOne.ResumeLayout(false);
            panelOne.PerformLayout();
            ResumeLayout(false);
        }

        private void panelOne_Paint(object sender, PaintEventArgs e) {
            panelOne.BringToFront();

         }


        #endregion

        private TextBox UsernameOne;
        private TextBox PasswordOne;
        private Label textWelcome1;
        private Label textGroup1;
        private PictureBox pictureOne;
        private Label validationOne;
        private Label loginButton;
        private Button registerButton;
        private CheckBox showpassOne;
        private Panel panelOne;
    }
}
