namespace Lab0519_login
{
    partial class loginForm1
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
            this.login_btn = new System.Windows.Forms.Button();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.foundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(374, 246);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "登入";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(335, 110);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(114, 22);
            this.accountTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(335, 182);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(114, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(154, 120);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(29, 12);
            this.accountLabel.TabIndex = 3;
            this.accountLabel.Text = "帳號";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(154, 169);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(29, 12);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "密碼";
            // 
            // foundLabel
            // 
            this.foundLabel.AutoSize = true;
            this.foundLabel.Location = new System.Drawing.Point(154, 251);
            this.foundLabel.Name = "foundLabel";
            this.foundLabel.Size = new System.Drawing.Size(53, 12);
            this.foundLabel.TabIndex = 5;
            this.foundLabel.Text = "查無此人";
            // 
            // loginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foundLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.login_btn);
            this.Name = "loginForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label foundLabel;
    }
}

