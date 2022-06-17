using project_gui.DataModels;
using project_gui.DataModels._uitl;
using System.Data;

namespace project_gui.Forms.DataForms
{
	public partial class TeachersWindow : Form
	{
		public TeachersWindow()
		{
			InitializeComponent();
			_ = UpdateTeachersTableAsync();
			_ = InitializeForeignTables();
		}

		private async Task InitializeForeignTables()
		{
			await AwaitUpdates();

			async Task AwaitUpdates()
			{
				comboBox_addCity.DataSource = await CitiesController.GetCities();
				comboBox_editCity.DataSource = await CitiesController.GetCities();
				comboBox_addCity.ValueMember = "Id";
				comboBox_addCity.DisplayMember = "Name";
				comboBox_editCity.ValueMember = "Id";
				comboBox_editCity.DisplayMember = "Name";

				comboBox_addUniversity.DataSource = await UniversitiesController.GetUniversities();
				comboBox_editUniversity.DataSource = await UniversitiesController.GetUniversities();
				comboBox_addUniversity.ValueMember = "Id";
				comboBox_addUniversity.DisplayMember = "Name";
				comboBox_editUniversity.ValueMember = "Id";
				comboBox_editUniversity.DisplayMember = "Name";

				checkedListBox_addDepartments.DataSource = await DepartmentsController
					.GetDepatmentsInUniversityFull((int?)comboBox_addUniversity.SelectedValue);
				checkedListBox_addDepartments.ValueMember = "Id";
				checkedListBox_addDepartments.DisplayMember = "Name";
			}
		}

		private async Task UpdateTeachersTableAsync()
		{
			dataGridView_teachers.DataSource = await TeachersController.GetTeachers();
			dataGridView_teachers.ClearSelection();

			if (dataGridView_teachers.Rows.Count == 0)
				return;

			dataGridView_teachers
				.Columns[dataGridView_teachers.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void DataGridView_teachers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
				dataGridView_teachers.Columns[e.ColumnIndex].Name,
				(List<dynamic>)dataGridView_teachers.DataSource
			);

			dataGridView_teachers.DataSource = sortedList;
			dataGridView_teachers.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_add,
				groupBox_edit
			});
		}

		private async void DataGridView_teachers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_teachers.Rows.Count == 0)
				return;

			var teacher = await TeachersController.GetTeacherById(HelperFuncs.GetSelectedRowId(dataGridView_teachers));
			if (teacher == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editFirstName.Text = teacher.FirstName;
			textBox_editLastName.Text = teacher.LastName;
			textBox_editPosition.Text = teacher.Position;
			textBox_editAddress.Text = teacher.Address?.MainAddress;

			if (comboBox_editCity.Items.Count == 0)
				comboBox_editCity.SelectedIndex = -1;
			else
				comboBox_editCity.SelectedValue = teacher.Address.City?.Id ?? -1;

			if (teacher.Address.City == null)
				checkBox_editCity.Checked = false;
			else
				checkBox_editCity.Checked = true;

			if (comboBox_editUniversity.Items.Count == 0)
				comboBox_editUniversity.SelectedIndex = -1;
			else
				comboBox_editUniversity.SelectedValue = teacher.Universities?.Id ?? -1;
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
					((IEnumerable<dynamic>)dataGridView_teachers.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_teachers.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_teachers, currencyManager);
		}

		private async void Button_add_Click(object sender, EventArgs e)
		{
			var checkedDepartments = from department in checkedListBox_addDepartments.CheckedItems.Cast<Departments>()
									 select new TeachersDepartments
									 {
										 DepartmentsId = department.Id,
										 TeachersId = 0
									 };

			Teachers teacher = new()
			{
				Id = 0,
				FirstName = textBox_addFirstName.Text,
				LastName = textBox_addLastName.Text,
				Position = textBox_addPosition.Text,
				Address = new Addresses()
				{
					Id = 0,
					MainAddress = textBox_addAddress.Text,
					City = checkBox_addCity.Checked
						? await CitiesController.GetCityById((int?)comboBox_addCity.SelectedValue)
						: null
				},
				Universities = await UniversitiesController.GetUniversityById((int?)comboBox_addUniversity.SelectedValue),
				TeachersDepartments = checkedDepartments.ToList(),
			};

			if (await TeachersController.CreateTeacher(teacher))
				await UpdateTeachersTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_add,
				groupBox_edit
			});
		}

		private async void Button_edit_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_teachers) == null)
				return;

			var checkedDepartments = from department in checkedListBox_editDepartments.CheckedItems.Cast<Departments>()
									 select new TeachersDepartments
									 {
										 DepartmentsId = department.Id,
										 TeachersId = HelperFuncs.GetSelectedRowId(dataGridView_teachers)
									 };

			Teachers? teacher = await TeachersController
				.GetTeacherById(HelperFuncs.GetSelectedRowId(dataGridView_teachers));
			teacher.FirstName = textBox_editFirstName.Text;
			teacher.LastName = textBox_editLastName.Text;
			teacher.Position = textBox_editPosition.Text;
			teacher.Address.City = checkBox_editCity.Checked
						? await CitiesController.GetCityById((int?)comboBox_editCity.SelectedValue)
						: null;
			teacher.Universities = await UniversitiesController.GetUniversityById((int?)comboBox_editUniversity.SelectedValue);
			teacher.TeachersDepartments = checkedDepartments.ToList();

			int? selectedRowIndex = HelperFuncs.GetSelectedRowId(dataGridView_teachers);
			if (await TeachersController.UpdateTeacher(teacher))
				await UpdateTeachersTableAsync();

			HelperFuncs.SelectRowById(selectedRowIndex, dataGridView_teachers, DataGridView_teachers_CellClick);
		}

		private async void Button_delete_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_teachers) == null)
				return;

			if (await TeachersController.DeleteTeacher(HelperFuncs.GetSelectedRowId(dataGridView_teachers)))
				await UpdateTeachersTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_add,
				groupBox_edit
			});
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			HelperFuncs.HandleComboBoxes((CheckBox)sender, this);
		}

		private async void ComboBox_addUniversity_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItemId = (sender as ComboBox).SelectedValue as int?;
			if (selectedItemId != null)
			{
				checkedListBox_addDepartments.DataSource = await DepartmentsController
					.GetDepatmentsInUniversityFull((int?)((ComboBox)sender).SelectedValue);

				checkedListBox_addDepartments.ValueMember = "Id";
				checkedListBox_addDepartments.DisplayMember = "Name";
			}
			else
				checkedListBox_addDepartments.DataSource = null;
		}

		private async void ComboBox_editUniversity_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItemId = (sender as ComboBox).SelectedValue as int?;
			if (selectedItemId != null)
			{
				checkedListBox_editDepartments.DataSource = await DepartmentsController
					.GetDepatmentsInUniversityFull((int?)((ComboBox)sender).SelectedValue);

				checkedListBox_editDepartments.ValueMember = "Id";
				checkedListBox_editDepartments.DisplayMember = "Name";
			}
			else
				checkedListBox_editDepartments.DataSource = null;

			/*var ids = await TeachersController.GetDepartmentsIds(HelperFuncs.GetSelectedRowId(dataGridView_teachers));
			if (ids != null)
				for (int i = 0; i < checkedListBox_editDepartments.Items.Count; i++)
				{
					int? id = ((Departments)checkedListBox_editDepartments.Items[i]).Id;
					if (ids.Contains(id))
						checkedListBox_editDepartments.SetItemChecked(i, true);
					else
						checkedListBox_editDepartments.SetItemChecked(i, false);
				}*/
		}

		private async void Button_reset_Click(object sender, EventArgs e)
		{
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_add,
				groupBox_edit,
				groupBox_addDepartment,
				groupBox_editDepartment
			});

			await UpdateTeachersTableAsync();
		}
	}
}
