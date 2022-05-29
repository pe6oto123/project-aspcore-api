namespace project_gui.Forms.AccountForms
{
	partial class RegisterWindow
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
			this.label_userName = new System.Windows.Forms.Label();
			this.register_userName = new System.Windows.Forms.TextBox();
			this.loginField = new System.Windows.Forms.GroupBox();
			this.checkBox_isAdmin = new System.Windows.Forms.CheckBox();
			this.label_Password = new System.Windows.Forms.Label();
			this.registerBtn = new System.Windows.Forms.Button();
			this.register_password = new System.Windows.Forms.TextBox();
			this.loginField.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_userName
			// 
			this.label_userName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_userName.AutoSize = true;
			this.label_userName.Location = new System.Drawing.Point(16, 17);
			this.label_userName.Name = "label_userName";
			this.label_userName.Size = new System.Drawing.Size(61, 13);
			this.label_userName.TabIndex = 3;
			this.label_userName.Text = "User name:";
			// 
			// register_userName
			// 
			this.register_userName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.register_userName.Location = new System.Drawing.Point(19, 33);
			this.register_userName.MaxLength = 30;
			this.register_userName.Name = "register_userName";
			this.register_userName.Size = new System.Drawing.Size(192, 20);
			this.register_userName.TabIndex = 0;
			// 
			// loginField
			// 
			this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginField.Controls.Add(this.checkBox_isAdmin);
			this.loginField.Controls.Add(this.label_Password);
			this.loginField.Controls.Add(this.label_userName);
			this.loginField.Controls.Add(this.registerBtn);
			this.loginField.Controls.Add(this.register_password);
			this.loginField.Controls.Add(this.register_userName);
			this.loginField.Location = new System.Drawing.Point(12, 12);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(240, 137);
			this.loginField.TabIndex = 1;
			this.loginField.TabStop = false;
			// 
			// checkBox_isAdmin
			// 
			this.checkBox_isAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkBox_isAdmin.AutoSize = true;
			this.checkBox_isAdmin.Location = new System.Drawing.Point(19, 98);
			this.checkBox_isAdmin.Name = "checkBox_isAdmin";
			this.checkBox_isAdmin.Size = new System.Drawing.Size(113, 17);
			this.checkBox_isAdmin.TabIndex = 5;
			this.checkBox_isAdmin.Text = "Is the user Admin?";
			this.checkBox_isAdmin.UseVisualStyleBackColor = true;
			// 
			// label_Password
			// 
			this.label_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label_Password.AutoSize = true;
			this.label_Password.Location = new System.Drawing.Point(16, 56);
			this.label_Password.Name = "label_Password";
			this.label_Password.Size = new System.Drawing.Size(56, 13);
			this.label_Password.TabIndex = 4;
			this.label_Password.Text = "Password:";
			// 
			// registerBtn
			// 
			this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.registerBtn.Location = new System.Drawing.Point(136, 98);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(75, 27);
			this.registerBtn.TabIndex = 2;
			this.registerBtn.Text = "Register";
			this.registerBtn.UseVisualStyleBackColor = true;
			// 
			// register_password
			// 
			this.register_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.register_password.Location = new System.Drawing.Point(19, 72);
			this.register_password.MaxLength = 50;
			this.register_password.Name = "register_password";
			this.register_password.PasswordChar = '*';
			this.register_password.Size = new System.Drawing.Size(192, 20);
			this.register_password.TabIndex = 1;
			// 
			// RegisterWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 161);
			this.Controls.Add(this.loginField);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(280, 200);
			this.Name = "RegisterWindow";
			this.Text = "Register";
			this.loginField.ResumeLayout(false);
			this.loginField.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_userName;
		private System.Windows.Forms.TextBox register_userName;
		private System.Windows.Forms.GroupBox loginField;
		private System.Windows.Forms.Label label_Password;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.TextBox register_password;
		private System.Windows.Forms.CheckBox checkBox_isAdmin;
	}
}