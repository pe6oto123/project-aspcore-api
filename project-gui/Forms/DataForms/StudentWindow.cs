using project_gui.DataModels;
using project_gui.DataModels._uitl;

namespace project_gui.Forms.DataForms
{
	public partial class StudentWindow : Form
	{
		public StudentWindow()
		{
			InitializeComponent();
			_ = InitializeForeignTables();
		}

		private async Task InitializeForeignTables()
		{
			await UpdateStudentsTableAsync();
			await AwaitUpdates();

			async Task AwaitUpdates()
			{
				comboBox_addCity.DataSource = await CitiesController.GetCities();
				comboBox_editCity.DataSource = await CitiesController.GetCities();
				if (comboBox_addCity.Items.Count != 0)
				{
					comboBox_addCity.ValueMember = "Id";
					comboBox_addCity.DisplayMember = "Name";
					comboBox_editCity.ValueMember = "Id";
					comboBox_editCity.DisplayMember = "Name";
				}

				comboBox_addUniversity.DataSource = await UniversitiesController.GetUniversities();
				comboBox_editUniversity.DataSource = await UniversitiesController.GetUniversities();
				if (comboBox_addUniversity.Items.Count != 0)
				{
					comboBox_addUniversity.ValueMember = "Id";
					comboBox_addUniversity.DisplayMember = "Name";
					comboBox_editUniversity.ValueMember = "Id";
					comboBox_editUniversity.DisplayMember = "Name";
				}
			}
		}
		private async Task UpdateStudentsTableAsync()
		{
			dataGridView_students.DataSource = await StudentsController.GetStudents();
			dataGridView_students.ClearSelection();

			if (dataGridView_students.Rows.Count == 0)
				return;

			dataGridView_students
				.Columns[dataGridView_students.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void DataGridView_students_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
				dataGridView_students.Columns[e.ColumnIndex].Name,
				(List<dynamic>)dataGridView_students.DataSource
			);

			dataGridView_students.DataSource = sortedList;
			dataGridView_students.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_add,
				groupBox_edit
			});
		}

		private async void DataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_students.Rows.Count == 0)
				return;

			var student = await StudentsController.GetStudentById(HelperFuncs.GetSelectedRowId(dataGridView_students));
			if (student == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editFirstName.Text = student.FirstName;
			textBox_editLastName.Text = student.LastName;
			textBox_editAddress.Text = student.Address?.MainAddress;

			if (comboBox_editCity.Items.Count == 0)
				comboBox_editCity.SelectedIndex = -1;
			else
				comboBox_editCity.SelectedValue = student.Address.City?.Id ?? -1;

			if (student.Address.City == null)
				checkBox_editCity.Checked = false;
			else
				checkBox_editCity.Checked = true;

			if (comboBox_editUniversity.Items.Count == 0)
				comboBox_editUniversity.SelectedIndex = -1;
			else
				comboBox_editUniversity.SelectedValue = student.Universities?.Id ?? -1;

			dateTimePicker_editDate.Value = student.EnrolmentDate.Date;

			comboBox_editDepartment.DataSource = await DepartmentsController
				.GetDepatmentsInUniversity((int?)comboBox_editUniversity.SelectedValue);
			if (comboBox_editDepartment.Items.Count == 0)
				comboBox_editDepartment.SelectedIndex = -1;
			else
			{
				comboBox_editDepartment.ValueMember = "Id";
				comboBox_editDepartment.DisplayMember = "Name";
				comboBox_editDepartment.SelectedValue = student.Department?.Id ?? -1;
			}

			checkedListBox_editSubjects.DataSource = await SubjectsController
				.GetSubjectsInDepartmentFull((int?)comboBox_editDepartment.SelectedValue);
			if (checkedListBox_editSubjects.Items.Count != 0)
			{
				checkedListBox_editSubjects.ValueMember = "Id";
				checkedListBox_editSubjects.DisplayMember = "Name";
				var selectedSubjects = student.StudentsSubjects?.Select(s => s.SubjectsId).ToList();
				for (int i = 0; i < checkedListBox_editSubjects.Items.Count; i++)
					if (selectedSubjects.Contains(((Subjects)checkedListBox_editSubjects.Items[i]).Id))
						checkedListBox_editSubjects.SetItemChecked(i, true);
					else
						checkedListBox_editSubjects.SetItemChecked(i, false);
			}
		}

		private void Button_search_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_search.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_search.Text) ? textBox_search.Text : null,
					((IEnumerable<dynamic>)dataGridView_students.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_students.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_students, currencyManager);
		}

		private async void Button_add_Click(object sender, EventArgs e)
		{
			var checkedSubjects = from subject in checkedListBox_addSubjects.CheckedItems.Cast<Subjects>()
								  select new StudentsSubjects
								  {
									  SubjectsId = subject.Id,
									  StudentsId = 0,
									  Grade = null
								  };

			Students student = new()
			{
				Id = 0,
				FirstName = textBox_addFirstName.Text,
				LastName = textBox_addLastName.Text,
				Address = new Addresses()
				{
					Id = 0,
					MainAddress = textBox_addAddress.Text,
					City = checkBox_addCity.Checked
						? await CitiesController.GetCityById((int?)comboBox_addCity.SelectedValue)
						: null
				},
				Universities = await UniversitiesController.GetUniversityById((int?)comboBox_addUniversity.SelectedValue),
				EnrolmentDate = dateTimePicker_addDate.Value.Date,
				Department = await DepartmentsController.GetDepartmentById((int?)comboBox_addDepartment.SelectedValue),
				StudentsSubjects = checkedSubjects.ToList()
			};

			if (await StudentsController.CreateStudent(student))
				await UpdateStudentsTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_add,
				groupBox_edit
			});

			comboBox_editDepartment.DataSource = null;
			checkedListBox_editSubjects.DataSource = null;
		}

		private async void Button_edit_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_students) == null)
			{
				MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var checkedSubjects = from subject in checkedListBox_editSubjects.CheckedItems.Cast<Subjects>()
								  select new StudentsSubjects
								  {
									  SubjectsId = subject.Id,
									  StudentsId = HelperFuncs.GetSelectedRowId(dataGridView_students),
									  Grade = null
								  };

			Students? student = await StudentsController
				.GetStudentById(HelperFuncs.GetSelectedRowId(dataGridView_students));
			student.FirstName = textBox_editFirstName.Text;
			student.LastName = textBox_editLastName.Text;
			student.Address.MainAddress = textBox_editAddress.Text;
			student.Address.City = checkBox_editCity.Checked
					? await CitiesController.GetCityById((int?)comboBox_editCity.SelectedValue)
					: null;

			student.Universities = await UniversitiesController.GetUniversityById((int?)comboBox_editUniversity.SelectedValue);
			student.EnrolmentDate = dateTimePicker_editDate.Value.Date;
			student.Department = await DepartmentsController.GetDepartmentById((int?)comboBox_editDepartment.SelectedValue);
			student.StudentsSubjects = checkedSubjects.ToList();

			int? selectedRowIndex = HelperFuncs.GetSelectedRowId(dataGridView_students);
			if (await StudentsController.UpdateStudent(student))
				await UpdateStudentsTableAsync();

			HelperFuncs.SelectRowById(selectedRowIndex, dataGridView_students, DataGridView_students_CellClick);
		}

		private async void Button_delete_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_students) == null)
			{
				MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (await StudentsController.DeleteStudent(HelperFuncs.GetSelectedRowId(dataGridView_students)))
				await UpdateStudentsTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_add,
				groupBox_edit
			});

			comboBox_editDepartment.DataSource = null;
			checkedListBox_editSubjects.DataSource = null;
		}

		private async void ComboBox_addUniversity_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItemId = (sender as ComboBox).SelectedValue as int?;
			if (selectedItemId != null)
			{
				comboBox_addDepartment.DataSource = await DepartmentsController.GetDepatmentsInUniversity(selectedItemId);
				if (comboBox_addDepartment.Items.Count != 0)
				{
					comboBox_addDepartment.ValueMember = "Id";
					comboBox_addDepartment.DisplayMember = "Name";
				}
			}
			else
			{
				comboBox_addDepartment.DataSource = null;
				comboBox_addDepartment.SelectedIndex = -1;
			}
		}

		private async void ComboBox_addDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItemId = (sender as ComboBox).SelectedValue as int?;
			if (selectedItemId != null)
			{
				checkedListBox_addSubjects.DataSource = await SubjectsController
					.GetSubjectsInDepartmentFull(selectedItemId);

				checkedListBox_addSubjects.ValueMember = "Id";
				checkedListBox_addSubjects.DisplayMember = "Name";
			}
			else
				checkedListBox_addSubjects.DataSource = null;
		}

		private async void ComboBox_editDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItemId = (sender as ComboBox).SelectedValue as int?;
			if (selectedItemId != null)
			{
				checkedListBox_editSubjects.DataSource = await SubjectsController
					.GetSubjectsInDepartmentFull((int?)((ComboBox)sender).SelectedValue);
				if (checkedListBox_editSubjects.Items.Count != 0)
				{
					checkedListBox_editSubjects.ValueMember = "Id";
					checkedListBox_editSubjects.DisplayMember = "Name";
				}
			}
			else
				checkedListBox_editSubjects.DataSource = null;

			var ids = await StudentsController.GetSubjectsIds(HelperFuncs.GetSelectedRowId(dataGridView_students));
			if (ids != null)
				for (int i = 0; i < checkedListBox_editSubjects.Items.Count; i++)
				{
					int? id = ((Subjects)checkedListBox_editSubjects.Items[i]).Id;
					if (ids.Contains(id))
						checkedListBox_editSubjects.SetItemChecked(i, true);
					else
						checkedListBox_editSubjects.SetItemChecked(i, false);
				}
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			HelperFuncs.HandleComboBoxes((CheckBox)sender, this);
		}

		private async void Button_reset_Click(object sender, EventArgs e)
		{
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_add,
				groupBox_edit,
				groupBox_addSubjects,
				groupBox_editSubjects
			});

			comboBox_editDepartment.DataSource = null;
			checkedListBox_editSubjects.DataSource = null;
			await UpdateStudentsTableAsync();
		}
	}
}
