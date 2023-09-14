namespace RegistrationAndLoginn
{
    partial class Registration
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
            this.buttonRRegister = new System.Windows.Forms.Button();
            this.buttonRLogin = new System.Windows.Forms.Button();
            this.textBoxRPassword = new System.Windows.Forms.TextBox();
            this.textBoxRUserName = new System.Windows.Forms.TextBox();
            this.labelRPassword = new System.Windows.Forms.Label();
            this.labelRUserName = new System.Windows.Forms.Label();
            this.textBoxRCPassword = new System.Windows.Forms.TextBox();
            this.labelRCPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRRegister
            // 
            this.buttonRRegister.Location = new System.Drawing.Point(147, 274);
            this.buttonRRegister.Name = "buttonRRegister";
            this.buttonRRegister.Size = new System.Drawing.Size(94, 29);
            this.buttonRRegister.TabIndex = 11;
            this.buttonRRegister.Text = "Register";
            this.buttonRRegister.UseVisualStyleBackColor = true;
            this.buttonRRegister.Click += new System.EventHandler(this.buttonRRegister_Click);
            // 
            // buttonRLogin
            // 
            this.buttonRLogin.Location = new System.Drawing.Point(147, 220);
            this.buttonRLogin.Name = "buttonRLogin";
            this.buttonRLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonRLogin.TabIndex = 10;
            this.buttonRLogin.Text = "Login";
            this.buttonRLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxRPassword
            // 
            this.textBoxRPassword.Location = new System.Drawing.Point(203, 109);
            this.textBoxRPassword.Name = "textBoxRPassword";
            this.textBoxRPassword.PasswordChar = '*';
            this.textBoxRPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxRPassword.TabIndex = 9;
            // 
            // textBoxRUserName
            // 
            this.textBoxRUserName.Location = new System.Drawing.Point(203, 48);
            this.textBoxRUserName.Name = "textBoxRUserName";
            this.textBoxRUserName.Size = new System.Drawing.Size(125, 27);
            this.textBoxRUserName.TabIndex = 8;
            // 
            // labelRPassword
            // 
            this.labelRPassword.AutoSize = true;
            this.labelRPassword.Location = new System.Drawing.Point(49, 109);
            this.labelRPassword.Name = "labelRPassword";
            this.labelRPassword.Size = new System.Drawing.Size(70, 20);
            this.labelRPassword.TabIndex = 7;
            this.labelRPassword.Text = "Password";
            // 
            // labelRUserName
            // 
            this.labelRUserName.AutoSize = true;
            this.labelRUserName.Location = new System.Drawing.Point(49, 51);
            this.labelRUserName.Name = "labelRUserName";
            this.labelRUserName.Size = new System.Drawing.Size(78, 20);
            this.labelRUserName.TabIndex = 6;
            this.labelRUserName.Text = "UserName";
            // 
            // textBoxRCPassword
            // 
            this.textBoxRCPassword.Location = new System.Drawing.Point(203, 167);
            this.textBoxRCPassword.Name = "textBoxRCPassword";
            this.textBoxRCPassword.PasswordChar = '*';
            this.textBoxRCPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxRCPassword.TabIndex = 12;
            // 
            // labelRCPassword
            // 
            this.labelRCPassword.AutoSize = true;
            this.labelRCPassword.Location = new System.Drawing.Point(49, 174);
            this.labelRCPassword.Name = "labelRCPassword";
            this.labelRCPassword.Size = new System.Drawing.Size(127, 20);
            this.labelRCPassword.TabIndex = 13;
            this.labelRCPassword.Text = "Confirm Password";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 350);
            this.Controls.Add(this.labelRCPassword);
            this.Controls.Add(this.textBoxRCPassword);
            this.Controls.Add(this.buttonRRegister);
            this.Controls.Add(this.buttonRLogin);
            this.Controls.Add(this.textBoxRPassword);
            this.Controls.Add(this.textBoxRUserName);
            this.Controls.Add(this.labelRPassword);
            this.Controls.Add(this.labelRUserName);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRRegister;
        private Button buttonRLogin;
        private TextBox textBoxRPassword;
        private TextBox textBoxRUserName;
        private Label labelRPassword;
        private Label labelRUserName;
        private TextBox textBoxRCPassword;
        private Label labelRCPassword;
    }
}