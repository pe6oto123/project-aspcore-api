namespace project_gui.Forms._dialogBox
{
	public partial class ErrorBoxFlex : Form
	{
		public ErrorBoxFlex(string title, string message)
		{
			InitializeComponent();
			this.Text = title;
			this.richTextBox_errorMessage.Text = message;
		}
	}
}
