namespace TestDataBase
{
    partial class sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.registration = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.registration);
            this.panel1.Location = new System.Drawing.Point(98, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 80);
            this.panel1.TabIndex = 1;
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
            // registration
            // 
            this.registration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.registration.BackColor = System.Drawing.SystemColors.Control;
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration.Location = new System.Drawing.Point(10, 23);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(186, 34);
            this.registration.TabIndex = 0;
            this.registration.Text = "Регистрация";
            this.registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(215, 157);
            this.loginBox.Multiline = true;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(180, 40);
            this.loginBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(215, 203);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 40);
            this.passwordBox.TabIndex = 3;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(129, 157);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 40);
            this.login.TabIndex = 4;
            this.login.Text = "Логин:";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(114, 203);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(95, 40);
            this.password.TabIndex = 5;
            this.password.Text = "Пароль:";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(215, 270);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(180, 40);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Создать аккаунт";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // openEye
            // 
            this.openEye.BackColor = System.Drawing.Color.DarkGray;
            this.openEye.Image = ((System.Drawing.Image)(resources.GetObject("openEye.Image")));
            this.openEye.Location = new System.Drawing.Point(401, 203);
            this.openEye.Name = "openEye";
            this.openEye.Size = new System.Drawing.Size(40, 40);
            this.openEye.TabIndex = 7;
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
            this.closedEye.TabIndex = 6;
            this.closedEye.TabStop = false;
            this.closedEye.Click += new System.EventHandler(this.closedEye_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::TestDataBase.Properties.Resources.registration;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.openEye);
            this.Controls.Add(this.closedEye);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sign_up";
            this.Text = "sign_up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sign_up_FormClosing);
            this.Load += new System.EventHandler(this.sign_up_Load);
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
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.PictureBox closedEye;
        private System.Windows.Forms.PictureBox openEye;
        private System.Windows.Forms.Button createButton;
    }
}