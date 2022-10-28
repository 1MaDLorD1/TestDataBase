namespace TestDataBase
{
    partial class log_in
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
            this.authorization = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.openEye = new System.Windows.Forms.PictureBox();
            this.closedEye = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.authorization);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Location = new System.Drawing.Point(98, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 80);
            this.panel1.TabIndex = 1;
            // 
            // authorization
            // 
            this.authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization.Location = new System.Drawing.Point(10, 23);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(190, 34);
            this.authorization.TabIndex = 2;
            this.authorization.Text = "Авторизация";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton.Image = global::TestDataBase.Properties.Resources.pencil;
            this.clearButton.Location = new System.Drawing.Point(420, 20);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(40, 40);
            this.clearButton.TabIndex = 2;
            this.clearButton.TabStop = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(129, 157);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 40);
            this.login.TabIndex = 2;
            this.login.Text = "Логин:";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(114, 203);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(95, 40);
            this.password.TabIndex = 3;
            this.password.Text = "Пароль:";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(215, 157);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(180, 40);
            this.loginBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(215, 203);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 40);
            this.passwordBox.TabIndex = 7;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(215, 270);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(180, 40);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(253, 330);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(104, 13);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Ещё нет аккаунта?";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // openEye
            // 
            this.openEye.BackColor = System.Drawing.Color.DarkGray;
            this.openEye.Image = global::TestDataBase.Properties.Resources.eye2;
            this.openEye.Location = new System.Drawing.Point(401, 203);
            this.openEye.Name = "openEye";
            this.openEye.Size = new System.Drawing.Size(40, 40);
            this.openEye.TabIndex = 5;
            this.openEye.TabStop = false;
            this.openEye.Click += new System.EventHandler(this.openEye_Click);
            // 
            // closedEye
            // 
            this.closedEye.BackColor = System.Drawing.Color.DarkGray;
            this.closedEye.Image = global::TestDataBase.Properties.Resources.eye;
            this.closedEye.Location = new System.Drawing.Point(401, 203);
            this.closedEye.Name = "closedEye";
            this.closedEye.Size = new System.Drawing.Size(40, 40);
            this.closedEye.TabIndex = 4;
            this.closedEye.TabStop = false;
            this.closedEye.Click += new System.EventHandler(this.closedEye_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::TestDataBase.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.openEye);
            this.Controls.Add(this.closedEye);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "log_in";
            this.Text = "log_in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_in_FormClosing);
            this.Load += new System.EventHandler(this.log_in_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.Label authorization;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.PictureBox closedEye;
        private System.Windows.Forms.PictureBox openEye;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}