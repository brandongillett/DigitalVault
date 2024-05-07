namespace DigitalVault
{
    partial class DigitalVault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalVault));
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.createAccountLink = new MetroFramework.Controls.MetroLink();
            this.usernameLine = new System.Windows.Forms.Panel();
            this.passwordLine = new System.Windows.Forms.Panel();
            this.rememberCheck = new System.Windows.Forms.CheckBox();
            this.passwordLogo = new System.Windows.Forms.PictureBox();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.cloudLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginButton.Location = new System.Drawing.Point(190, 204);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(222, 40);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(104, 99);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(308, 22);
            this.usernameInput.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(123, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(321, 75);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "DigitalVault";
            // 
            // passwordInput
            // 
            this.passwordInput.AcceptsReturn = true;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(104, 165);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(308, 22);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            // 
            // createAccountLink
            // 
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.createAccountLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createAccountLink.Location = new System.Drawing.Point(52, 204);
            this.createAccountLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(113, 40);
            this.createAccountLink.TabIndex = 8;
            this.createAccountLink.TabStop = false;
            this.createAccountLink.Text = "Create Account";
            this.createAccountLink.Click += new System.EventHandler(this.createAccountLink_Click);
            // 
            // usernameLine
            // 
            this.usernameLine.BackColor = System.Drawing.Color.Red;
            this.usernameLine.Location = new System.Drawing.Point(52, 129);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.Size = new System.Drawing.Size(360, 1);
            this.usernameLine.TabIndex = 11;
            // 
            // passwordLine
            // 
            this.passwordLine.BackColor = System.Drawing.Color.Red;
            this.passwordLine.Location = new System.Drawing.Point(52, 195);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(360, 1);
            this.passwordLine.TabIndex = 12;
            // 
            // rememberCheck
            // 
            this.rememberCheck.AutoSize = true;
            this.rememberCheck.Location = new System.Drawing.Point(295, 136);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Size = new System.Drawing.Size(117, 24);
            this.rememberCheck.TabIndex = 13;
            this.rememberCheck.TabStop = false;
            this.rememberCheck.Text = "Remember Me";
            this.rememberCheck.UseVisualStyleBackColor = true;
            // 
            // passwordLogo
            // 
            this.passwordLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordLogo.Image = ((System.Drawing.Image)(resources.GetObject("passwordLogo.Image")));
            this.passwordLogo.Location = new System.Drawing.Point(52, 162);
            this.passwordLogo.Name = "passwordLogo";
            this.passwordLogo.Size = new System.Drawing.Size(35, 27);
            this.passwordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordLogo.TabIndex = 10;
            this.passwordLogo.TabStop = false;
            // 
            // userLogo
            // 
            this.userLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userLogo.Image = ((System.Drawing.Image)(resources.GetObject("userLogo.Image")));
            this.userLogo.Location = new System.Drawing.Point(52, 96);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(35, 27);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLogo.TabIndex = 9;
            this.userLogo.TabStop = false;
            // 
            // cloudLogo
            // 
            this.cloudLogo.Image = ((System.Drawing.Image)(resources.GetObject("cloudLogo.Image")));
            this.cloudLogo.Location = new System.Drawing.Point(35, 14);
            this.cloudLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloudLogo.Name = "cloudLogo";
            this.cloudLogo.Size = new System.Drawing.Size(80, 74);
            this.cloudLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudLogo.TabIndex = 5;
            this.cloudLogo.TabStop = false;
            // 
            // DigitalVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 267);
            this.Controls.Add(this.rememberCheck);
            this.Controls.Add(this.passwordLine);
            this.Controls.Add(this.usernameLine);
            this.Controls.Add(this.passwordLogo);
            this.Controls.Add(this.userLogo);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.cloudLogo);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DigitalVault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalVault";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DigitalVault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox cloudLogo;
        private System.Windows.Forms.TextBox passwordInput;
        private MetroFramework.Controls.MetroLink createAccountLink;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.PictureBox passwordLogo;
        private System.Windows.Forms.Panel usernameLine;
        private System.Windows.Forms.Panel passwordLine;
        private System.Windows.Forms.CheckBox rememberCheck;
    }
}

