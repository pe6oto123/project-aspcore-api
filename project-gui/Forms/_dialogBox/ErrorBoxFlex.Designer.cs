namespace project_gui.Forms._dialogBox
{
	partial class ErrorBoxFlex
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.richTextBox_errorMessage = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::project_gui.Properties.Resources.greyBox;
			this.pictureBox1.Location = new System.Drawing.Point(0, 197);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(234, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button_cancel
			// 
			this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_cancel.Location = new System.Drawing.Point(154, 205);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 1;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			// 
			// button_ok
			// 
			this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_ok.Location = new System.Drawing.Point(74, 205);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(75, 23);
			this.button_ok.TabIndex = 2;
			this.button_ok.Text = "OK";
			this.button_ok.UseVisualStyleBackColor = true;
			// 
			// richTextBox_errorMessage
			// 
			this.richTextBox_errorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox_errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox_errorMessage.Location = new System.Drawing.Point(12, 12);
			this.richTextBox_errorMessage.Name = "richTextBox_errorMessage";
			this.richTextBox_errorMessage.ReadOnly = true;
			this.richTextBox_errorMessage.Size = new System.Drawing.Size(210, 179);
			this.richTextBox_errorMessage.TabIndex = 3;
			this.richTextBox_errorMessage.Text = "";
			// 
			// ErrorBoxFlex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 234);
			this.ControlBox = false;
			this.Controls.Add(this.richTextBox_errorMessage);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.pictureBox1);
			this.MinimumSize = new System.Drawing.Size(250, 250);
			this.Name = "ErrorBoxFlex";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ErrorBoxFlex";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox pictureBox1;
		private Button button_cancel;
		private Button button_ok;
		private RichTextBox richTextBox_errorMessage;
	}
}