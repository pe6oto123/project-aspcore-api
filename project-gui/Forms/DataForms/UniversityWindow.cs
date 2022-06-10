using project_gui.DataModels;
using project_gui.DataModels._uitl;

namespace project_gui.Forms.DataForms
{
	public partial class UniversityWindow : Form
	{
		public UniversityWindow()
		{
			InitializeComponent();
			_ = UpdateSubjectsTableAsync();
		}
		#region Subjects
		private async Task UpdateSubjectsTableAsync()
		{
			dataGridView_subjects.DataSource = await SubjectsController.GetSubjects();
			dataGridView_subjects.ClearSelection();
			//await UpdateSubjectsTableAsync();

			if (dataGridView_subjects.Rows.Count == 0)
				return;

			dataGridView_subjects
				.Columns[dataGridView_subjects.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			/*async Task UpdateSubjectsTableAsync()
			{
				checkedListBox_addSubjectsDepartment.ValueMember = "Id";
				checkedListBox_addSubjectsDepartment.DisplayMember = "Name";
				checkedListBox_editSubjectsDepartment.ValueMember = "Id";
				checkedListBox_editSubjectsDepartment.DisplayMember = "Name";
			}*/
		}
		private void DataGridView_subjects_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
					dataGridView_subjects.Columns[e.ColumnIndex].Name,
					(List<dynamic>)dataGridView_subjects.DataSource
				);

			dataGridView_subjects.DataSource = sortedList;
			dataGridView_subjects.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addSubject,
				groupBox_editSubject
			});
		}

		private async void DataGridView_subjects_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_subjects.Rows.Count == 0)
				return;

			var subject = await SubjectsController.GetSubjectById(HelperFuncs.GetSelectedRowId(dataGridView_subjects));
			if (subject == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editSubjectName.Text = subject.Name;
		}

		private void Button_searchSubjects_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchSubject.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_searchSubjects.Text) ? textBox_searchSubjects.Text : null,
					((IEnumerable<dynamic>)dataGridView_subjects.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_subjects.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_subjects, currencyManager);
		}

		private async void Button_addSubject_Click(object sender, EventArgs e)
		{
			Subjects subject = new()
			{
				Id = 0,
				Name = textBox_addSubjectName.Text
			};

			if (await SubjectsController.CreateSubject(subject))
				await UpdateSubjectsTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addSubject
			});
		}

		private async void Button_editSubject_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_subjects) == null)
				return;

			Subjects subject = new()
			{
				Id = HelperFuncs.GetSelectedRowId(dataGridView_subjects),
				Name = textBox_editSubjectName.Text
			};

			int selectedRowIndex = dataGridView_subjects.SelectedCells[0].RowIndex;

			if (await SubjectsController.UpdateSubjects(subject))
				await UpdateSubjectsTableAsync();

			dataGridView_subjects.Rows[selectedRowIndex].Selected = true;
		}

		private async void Button_deleteSubject_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_subjects) == null)
				return;

			if (await SubjectsController.DeleteSubject(HelperFuncs.GetSelectedRowId(dataGridView_subjects)))
				await UpdateSubjectsTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addSubject,
				groupBox_editSubject
			});
		}


		#endregion

		private void Button_reset_Click(object sender, EventArgs e)
		{

		}
	}
}
