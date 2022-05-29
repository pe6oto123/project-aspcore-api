namespace project_gui.Forms.AccountForms
{
	partial class LoginWindow
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
			this.loginField = new System.Windows.Forms.GroupBox();
			this.link_Register = new System.Windows.Forms.LinkLabel();
			this.label_Register = new System.Windows.Forms.Label();
			this.label_Password = new System.Windows.Forms.Label();
			this.label_userName = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.login_password = new System.Windows.Forms.TextBox();
			this.login_userName = new System.Windows.Forms.TextBox();
			this.loginField.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginField
			// 
			this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.loginField.Controls.Add(this.link_Register);
			this.loginField.Controls.Add(this.label_Register);
			this.loginField.Controls.Add(this.label_Password);
			this.loginField.Controls.Add(this.label_userName);
			this.loginField.Controls.Add(this.loginBtn);
			this.loginField.Controls.Add(this.login_password);
			this.loginField.Controls.Add(this.login_userName);
			this.loginField.Location = new System.Drawing.Point(12, 12);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(340, 317);
			this.loginField.TabIndex = 0;
			this.loginField.TabStop = false;
			// 
			// link_Register
			// 
			this.link_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.link_Register.AutoSize = true;
			this.link_Register.Location = new System.Drawing.Point(65, 218);
			this.link_Register.Name = "link_Register";
			this.link_Register.Size = new System.Drawing.Size(46, 13);
			this.link_Register.TabIndex = 6;
			this.link_Register.TabStop = true;
			this.link_Register.Text = "Register";
			// 
			// label_Register
			// 
			this.label_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_Register.AutoSize = true;
			this.label_Register.Location = new System.Drawing.Point(65, 201);
			this.label_Register.Name = "label_Register";
			this.label_Register.Size = new System.Drawing.Size(122, 13);
			this.label_Register.TabIndex = 5;
			this.label_Register.Text = "Don\'t have an account?";
			// 
			// label_Password
			// 
			this.label_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_Password.AutoSize = true;
			this.label_Password.Location = new System.Drawing.Point(65, 144);
			this.label_Password.Name = "label_Password";
			this.label_Password.Size = new System.Drawing.Size(56, 13);
			this.label_Password.TabIndex = 4;
			this.label_Password.Text = "Password:";
			// 
			// label_userName
			// 
			this.label_userName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_userName.AutoSize = true;
			this.label_userName.Location = new System.Drawing.Point(65, 74);
			this.label_userName.Name = "label_userName";
			this.label_userName.Size = new System.Drawing.Size(61, 13);
			this.label_userName.TabIndex = 3;
			this.label_userName.Text = "User name:";
			// 
			// loginBtn
			// 
			this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.loginBtn.Location = new System.Drawing.Point(193, 201);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(75, 30);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "Log in";
			this.loginBtn.UseVisualStyleBackColor = true;
			// 
			// login_password
			// 
			this.login_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.login_password.Location = new System.Drawing.Point(68, 160);
			this.login_password.MaxLength = 50;
			this.login_password.Name = "login_password";
			this.login_password.PasswordChar = '*';
			this.login_password.Size = new System.Drawing.Size(200, 20);
			this.login_password.TabIndex = 1;
			// 
			// login_userName
			// 
			this.login_userName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.login_userName.Location = new System.Drawing.Point(68, 90);
			this.login_userName.MaxLength = 30;
			this.login_userName.Name = "login_userName";
			this.login_userName.Size = new System.Drawing.Size(200, 20);
			this.login_userName.TabIndex = 0;
			// 
			// LoginWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 341);
			this.Controls.Add(this.loginField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.loginField.ResumeLayout(false);
			this.loginField.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox loginField;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.TextBox login_password;
		private System.Windows.Forms.TextBox login_userName;
		private System.Windows.Forms.Label label_Password;
		private System.Windows.Forms.Label label_userName;
		private System.Windows.Forms.LinkLabel link_Register;
		private System.Windows.Forms.Label label_Register;
	}
}

