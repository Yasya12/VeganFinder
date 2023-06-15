namespace RegistrationAndLoginn
{
    partial class Login
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
            this.labelLUserName = new System.Windows.Forms.Label();
            this.labelLPassword = new System.Windows.Forms.Label();
            this.textBoxLUserName = new System.Windows.Forms.TextBox();
            this.textBoxLPassword = new System.Windows.Forms.TextBox();
            this.buttonLLogin = new System.Windows.Forms.Button();
            this.buttonLRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLUserName
            // 
            this.labelLUserName.AutoSize = true;
            this.labelLUserName.Location = new System.Drawing.Point(44, 43);
            this.labelLUserName.Name = "labelLUserName";
            this.labelLUserName.Size = new System.Drawing.Size(78, 20);
            this.labelLUserName.TabIndex = 0;
            this.labelLUserName.Text = "UserName";
            // 
            // labelLPassword
            // 
            this.labelLPassword.AutoSize = true;
            this.labelLPassword.Location = new System.Drawing.Point(44, 107);
            this.labelLPassword.Name = "labelLPassword";
            this.labelLPassword.Size = new System.Drawing.Size(70, 20);
            this.labelLPassword.TabIndex = 1;
            this.labelLPassword.Text = "Password";
            // 
            // textBoxLUserName
            // 
            this.textBoxLUserName.Location = new System.Drawing.Point(174, 43);
            this.textBoxLUserName.Name = "textBoxLUserName";
            this.textBoxLUserName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLUserName.TabIndex = 2;
            // 
            // textBoxLPassword
            // 
            this.textBoxLPassword.Location = new System.Drawing.Point(174, 104);
            this.textBoxLPassword.Name = "textBoxLPassword";
            this.textBoxLPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxLPassword.TabIndex = 3;
            // 
            // buttonLLogin
            // 
            this.buttonLLogin.Location = new System.Drawing.Point(118, 180);
            this.buttonLLogin.Name = "buttonLLogin";
            this.buttonLLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonLLogin.TabIndex = 4;
            this.buttonLLogin.Text = "Login";
            this.buttonLLogin.UseVisualStyleBackColor = true;
            this.buttonLLogin.Click += new System.EventHandler(this.buttonLLogin_Click);
            // 
            // buttonLRegister
            // 
            this.buttonLRegister.Location = new System.Drawing.Point(118, 245);
            this.buttonLRegister.Name = "buttonLRegister";
            this.buttonLRegister.Size = new System.Drawing.Size(94, 29);
            this.buttonLRegister.TabIndex = 5;
            this.buttonLRegister.Text = "Register";
            this.buttonLRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 340);
            this.Controls.Add(this.buttonLRegister);
            this.Controls.Add(this.buttonLLogin);
            this.Controls.Add(this.textBoxLPassword);
            this.Controls.Add(this.textBoxLUserName);
            this.Controls.Add(this.labelLPassword);
            this.Controls.Add(this.labelLUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLUserName;
        private Label labelLPassword;
        private TextBox textBoxLUserName;
        private TextBox textBoxLPassword;
        private Button buttonLLogin;
        private Button buttonLRegister;
    }
}