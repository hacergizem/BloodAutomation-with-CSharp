namespace BloodManagment
{
    partial class LoginPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPswHideShow = new System.Windows.Forms.LinkLabel();
            this.loginAcceptTermChx = new MetroFramework.Controls.MetroCheckBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.loginPaswTextbox = new MetroFramework.Controls.MetroTextBox();
            this.loginPasswordTitle = new MetroFramework.Controls.MetroLabel();
            this.loginUsernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.loginUsarnameTitle = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginPswHideShow);
            this.panel1.Controls.Add(this.loginAcceptTermChx);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.loginPaswTextbox);
            this.panel1.Controls.Add(this.loginPasswordTitle);
            this.panel1.Controls.Add(this.loginUsernameTextbox);
            this.panel1.Controls.Add(this.loginUsarnameTitle);
            this.panel1.Location = new System.Drawing.Point(17, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 477);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BloodManagment.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(128, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodManagment.Properties.Resources.donor;
            this.pictureBox1.Location = new System.Drawing.Point(53, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginPswHideShow
            // 
            this.loginPswHideShow.AutoSize = true;
            this.loginPswHideShow.Location = new System.Drawing.Point(240, 254);
            this.loginPswHideShow.Name = "loginPswHideShow";
            this.loginPswHideShow.Size = new System.Drawing.Size(51, 17);
            this.loginPswHideShow.TabIndex = 7;
            this.loginPswHideShow.TabStop = true;
            this.loginPswHideShow.Text = "Goster";
            this.loginPswHideShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginPswHideShow_LinkClicked);
            // 
            // loginAcceptTermChx
            // 
            this.loginAcceptTermChx.AutoSize = true;
            this.loginAcceptTermChx.Location = new System.Drawing.Point(34, 348);
            this.loginAcceptTermChx.Name = "loginAcceptTermChx";
            this.loginAcceptTermChx.Size = new System.Drawing.Size(271, 34);
            this.loginAcceptTermChx.TabIndex = 5;
            this.loginAcceptTermChx.Text = "Kullanıcı Sözleşmesi ve uygulama kullanım \r\nşartlarını kabul ediyorum";
            this.loginAcceptTermChx.UseSelectable = true;
            this.loginAcceptTermChx.CheckedChanged += new System.EventHandler(this.loginAcceptTermChx_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(128, 400);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 41);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPaswTextbox
            // 
            // 
            // 
            // 
            this.loginPaswTextbox.CustomButton.Image = null;
            this.loginPaswTextbox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.loginPaswTextbox.CustomButton.Name = "";
            this.loginPaswTextbox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.loginPaswTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginPaswTextbox.CustomButton.TabIndex = 1;
            this.loginPaswTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginPaswTextbox.CustomButton.UseSelectable = true;
            this.loginPaswTextbox.CustomButton.Visible = false;
            this.loginPaswTextbox.Lines = new string[0];
            this.loginPaswTextbox.Location = new System.Drawing.Point(78, 284);
            this.loginPaswTextbox.MaxLength = 32767;
            this.loginPaswTextbox.Name = "loginPaswTextbox";
            this.loginPaswTextbox.PasswordChar = '\0';
            this.loginPaswTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginPaswTextbox.SelectedText = "";
            this.loginPaswTextbox.SelectionLength = 0;
            this.loginPaswTextbox.SelectionStart = 0;
            this.loginPaswTextbox.ShortcutsEnabled = true;
            this.loginPaswTextbox.Size = new System.Drawing.Size(213, 37);
            this.loginPaswTextbox.TabIndex = 3;
            this.loginPaswTextbox.UseSelectable = true;
            this.loginPaswTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginPaswTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginPasswordTitle
            // 
            this.loginPasswordTitle.AutoSize = true;
            this.loginPasswordTitle.Location = new System.Drawing.Point(78, 251);
            this.loginPasswordTitle.Name = "loginPasswordTitle";
            this.loginPasswordTitle.Size = new System.Drawing.Size(39, 20);
            this.loginPasswordTitle.TabIndex = 2;
            this.loginPasswordTitle.Text = "Şifre:";
            // 
            // loginUsernameTextbox
            // 
            // 
            // 
            // 
            this.loginUsernameTextbox.CustomButton.Image = null;
            this.loginUsernameTextbox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.loginUsernameTextbox.CustomButton.Name = "";
            this.loginUsernameTextbox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.loginUsernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginUsernameTextbox.CustomButton.TabIndex = 1;
            this.loginUsernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginUsernameTextbox.CustomButton.UseSelectable = true;
            this.loginUsernameTextbox.CustomButton.Visible = false;
            this.loginUsernameTextbox.Lines = new string[0];
            this.loginUsernameTextbox.Location = new System.Drawing.Point(78, 185);
            this.loginUsernameTextbox.MaxLength = 32767;
            this.loginUsernameTextbox.Name = "loginUsernameTextbox";
            this.loginUsernameTextbox.PasswordChar = '\0';
            this.loginUsernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginUsernameTextbox.SelectedText = "";
            this.loginUsernameTextbox.SelectionLength = 0;
            this.loginUsernameTextbox.SelectionStart = 0;
            this.loginUsernameTextbox.ShortcutsEnabled = true;
            this.loginUsernameTextbox.Size = new System.Drawing.Size(213, 37);
            this.loginUsernameTextbox.TabIndex = 1;
            this.loginUsernameTextbox.UseSelectable = true;
            this.loginUsernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginUsernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginUsarnameTitle
            // 
            this.loginUsarnameTitle.AutoSize = true;
            this.loginUsarnameTitle.Location = new System.Drawing.Point(78, 152);
            this.loginUsarnameTitle.Name = "loginUsarnameTitle";
            this.loginUsarnameTitle.Size = new System.Drawing.Size(86, 20);
            this.loginUsarnameTitle.TabIndex = 0;
            this.loginUsarnameTitle.Text = "Kullanıcı Adı:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(305, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 519);
            this.panel2.TabIndex = 1;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::BloodManagment.Properties.Resources.Passion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 596);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroCheckBox loginAcceptTermChx;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox loginPaswTextbox;
        private MetroFramework.Controls.MetroLabel loginPasswordTitle;
        private MetroFramework.Controls.MetroTextBox loginUsernameTextbox;
        private MetroFramework.Controls.MetroLabel loginUsarnameTitle;
        private System.Windows.Forms.LinkLabel loginPswHideShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}

