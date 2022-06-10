using project_gui.Forms.DataForms;

namespace project_gui
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			//Application.Run(new LocationWindow());
			//Application.Run(new ErrorBoxFlex("asd", "asd"));
			Application.Run(new UniversityWindow());
		}
	}
}