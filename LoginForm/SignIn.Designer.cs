namespace LoginForm {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassowrd = new System.Windows.Forms.TextBox();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.LoginFormWrapper = new System.Windows.Forms.PictureBox();
            this.LabelNotRegistred = new System.Windows.Forms.Label();
            this.LinkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.LinkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.LinkLabelExit = new System.Windows.Forms.LinkLabel();
            this.LinkLabelClearLoginPassowrd = new System.Windows.Forms.LinkLabel();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormWrapper)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.White;
            this.LabelLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.LabelLogin.Location = new System.Drawing.Point(205, 55);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(52, 23);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.White;
            this.LabelPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.LabelPassword.Location = new System.Drawing.Point(205, 122);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(86, 23);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxLogin.Location = new System.Drawing.Point(209, 81);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(192, 27);
            this.TextBoxLogin.TabIndex = 2;
            // 
            // TextBoxPassowrd
            // 
            this.TextBoxPassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxPassowrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassowrd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxPassowrd.Location = new System.Drawing.Point(209, 148);
            this.TextBoxPassowrd.Name = "TextBoxPassowrd";
            this.TextBoxPassowrd.PasswordChar = '*';
            this.TextBoxPassowrd.Size = new System.Drawing.Size(192, 27);
            this.TextBoxPassowrd.TabIndex = 3;
            this.TextBoxPassowrd.TabStop = false;
            this.TextBoxPassowrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassowrd_KeyPress);
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(66)))));
            this.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignIn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.ButtonSignIn.Location = new System.Drawing.Point(209, 181);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(192, 38);
            this.ButtonSignIn.TabIndex = 4;
            this.ButtonSignIn.Text = "LOGIN";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // LoginFormWrapper
            // 
            this.LoginFormWrapper.BackColor = System.Drawing.Color.White;
            this.LoginFormWrapper.Location = new System.Drawing.Point(135, 30);
            this.LoginFormWrapper.Name = "LoginFormWrapper";
            this.LoginFormWrapper.Size = new System.Drawing.Size(386, 292);
            this.LoginFormWrapper.TabIndex = 5;
            this.LoginFormWrapper.TabStop = false;
            // 
            // LabelNotRegistred
            // 
            this.LabelNotRegistred.AutoSize = true;
            this.LabelNotRegistred.BackColor = System.Drawing.Color.White;
            this.LabelNotRegistred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNotRegistred.ForeColor = System.Drawing.Color.Gray;
            this.LabelNotRegistred.Location = new System.Drawing.Point(208, 231);
            this.LabelNotRegistred.Name = "LabelNotRegistred";
            this.LabelNotRegistred.Size = new System.Drawing.Size(92, 16);
            this.LabelNotRegistred.TabIndex = 6;
            this.LabelNotRegistred.Text = "Not registred?";
            // 
            // LinkLabelSignUp
            // 
            this.LinkLabelSignUp.ActiveLinkColor = System.Drawing.SystemColors.ScrollBar;
            this.LinkLabelSignUp.AutoSize = true;
            this.LinkLabelSignUp.BackColor = System.Drawing.Color.White;
            this.LinkLabelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(66)))));
            this.LinkLabelSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(66)))));
            this.LinkLabelSignUp.Location = new System.Drawing.Point(306, 233);
            this.LinkLabelSignUp.Name = "LinkLabelSignUp";
            this.LinkLabelSignUp.Size = new System.Drawing.Size(95, 13);
            this.LinkLabelSignUp.TabIndex = 7;
            this.LinkLabelSignUp.TabStop = true;
            this.LinkLabelSignUp.Text = "Create an account";
            this.LinkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSignUp_LinkClicked);
            // 
            // LinkLabelHelp
            // 
            this.LinkLabelHelp.AutoSize = true;
            this.LinkLabelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabelHelp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LinkLabelHelp.Location = new System.Drawing.Point(12, 367);
            this.LinkLabelHelp.Name = "LinkLabelHelp";
            this.LinkLabelHelp.Size = new System.Drawing.Size(52, 16);
            this.LinkLabelHelp.TabIndex = 8;
            this.LinkLabelHelp.TabStop = true;
            this.LinkLabelHelp.Text = "🔘 Help";
            this.LinkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelHelp_LinkClicked);
            // 
            // LinkLabelExit
            // 
            this.LinkLabelExit.AutoSize = true;
            this.LinkLabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabelExit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LinkLabelExit.Location = new System.Drawing.Point(585, 367);
            this.LinkLabelExit.Name = "LinkLabelExit";
            this.LinkLabelExit.Size = new System.Drawing.Size(29, 16);
            this.LinkLabelExit.TabIndex = 9;
            this.LinkLabelExit.TabStop = true;
            this.LinkLabelExit.Text = "Exit";
            this.LinkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelExit_LinkClicked);
            // 
            // LinkLabelClearLoginPassowrd
            // 
            this.LinkLabelClearLoginPassowrd.AutoSize = true;
            this.LinkLabelClearLoginPassowrd.BackColor = System.Drawing.Color.White;
            this.LinkLabelClearLoginPassowrd.LinkColor = System.Drawing.Color.Red;
            this.LinkLabelClearLoginPassowrd.Location = new System.Drawing.Point(407, 89);
            this.LinkLabelClearLoginPassowrd.Name = "LinkLabelClearLoginPassowrd";
            this.LinkLabelClearLoginPassowrd.Size = new System.Drawing.Size(41, 13);
            this.LinkLabelClearLoginPassowrd.TabIndex = 10;
            this.LinkLabelClearLoginPassowrd.TabStop = true;
            this.LinkLabelClearLoginPassowrd.Text = "X Clear";
            this.LinkLabelClearLoginPassowrd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelClearLoginPassowrd_LinkClicked);
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.BackColor = System.Drawing.Color.White;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(410, 155);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(101, 17);
            this.CheckBoxShowPassword.TabIndex = 11;
            this.CheckBoxShowPassword.Text = "Show password";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = false;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(626, 392);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.LinkLabelClearLoginPassowrd);
            this.Controls.Add(this.LinkLabelExit);
            this.Controls.Add(this.LinkLabelHelp);
            this.Controls.Add(this.LinkLabelSignUp);
            this.Controls.Add(this.LabelNotRegistred);
            this.Controls.Add(this.ButtonSignIn);
            this.Controls.Add(this.TextBoxPassowrd);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LoginFormWrapper);
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormWrapper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassowrd;
        private System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.PictureBox LoginFormWrapper;
        private System.Windows.Forms.Label LabelNotRegistred;
        private System.Windows.Forms.LinkLabel LinkLabelSignUp;
        private System.Windows.Forms.LinkLabel LinkLabelHelp;
        private System.Windows.Forms.LinkLabel LinkLabelExit;
        private System.Windows.Forms.LinkLabel LinkLabelClearLoginPassowrd;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
    }
}

