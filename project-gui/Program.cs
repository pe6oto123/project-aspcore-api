using project_gui.Forms;

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
			//Application.Run(new UniversityWindow());
			//Application.Run(new TeachersWindow());
			//Application.Run(new StudentWindow());

			Application.Run(new MainWindow());
		}
	}
}