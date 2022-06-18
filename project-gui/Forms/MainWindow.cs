using project_gui.DataModels;
using project_gui.Forms.DataForms;
namespace project_gui.Forms
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			_ = InitializeTables();
		}

		private async Task InitializeTables()
		{
			await UpdateStudents();
		}

		private async Task UpdateStudents()
		{
			dataGridView_students.DataSource = await StudentsController.GetStudents();
			dataGridView_students.ClearSelection();

			if (dataGridView_students.Rows.Count == 0)
				return;

			dataGridView_students
				.Columns[dataGridView1.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private async Task UpdateStudents(int? id)
		{
			//dataGridView1.DataSource = await StudentsController.getsu;
			dataGridView1.ClearSelection();

			if (dataGridView1.Rows.Count == 0)
				return;

			dataGridView1
				.Columns[dataGridView1.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var window = new LocationWindow())
			{
				window.StartPosition = FormStartPosition.CenterScreen;
				window.ShowDialog();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var window = new UniversityWindow())
			{
				window.StartPosition = FormStartPosition.CenterScreen;
				window.ShowDialog();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (var window = new TeachersWindow())
			{
				window.StartPosition = FormStartPosition.CenterScreen;
				window.ShowDialog();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (var window = new StudentWindow())
			{
				window.StartPosition = FormStartPosition.CenterScreen;
				window.ShowDialog();
			}
		}

		private void dataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
