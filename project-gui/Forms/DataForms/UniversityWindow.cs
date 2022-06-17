using project_gui.DataModels;
using project_gui.DataModels._uitl;

namespace project_gui.Forms.DataForms
{
	public partial class UniversityWindow : Form
	{
		public UniversityWindow()
		{
			InitializeComponent();
			_ = UpdateSubjectsTableAsync(null);
			_ = UpdateDeparmentsTableAsync(null);
			_ = UpdateUniversitiesTableAsync();
			_ = InitializeForeignTables();
		}

		private async Task InitializeForeignTables()
		{
			comboBox_addUniversityCity.DataSource = await CitiesController.GetCities();
			comboBox_editUniversityCity.DataSource = await CitiesController.GetCities();

			comboBox_addUniversityCity.ValueMember = "Id";
			comboBox_addUniversityCity.DisplayMember = "Name";
			comboBox_editUniversityCity.ValueMember = "Id";
			comboBox_editUniversityCity.DisplayMember = "Name";
		}

		#region Subjects
		private async Task UpdateSubjectsTableAsync(int? departmentId)
		{
			if (departmentId != null)
				dataGridView_subjects.DataSource = await SubjectsController.GetSubjectsInDepartment(departmentId);
			else
				dataGridView_subjects.DataSource = await SubjectsController.GetSubjects();
			dataGridView_subjects.ClearSelection();

			if (dataGridView_subjects.Rows.Count == 0)
				return;

			dataGridView_subjects
				.Columns[dataGridView_subjects.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

			if (comboBox_editSubjectDepartment.Items.Count == 0)
				comboBox_editSubjectDepartment.SelectedIndex = -1;
			else
				comboBox_editSubjectDepartment.SelectedValue = subject.Department?.Id ?? -1;

			if (subject.Department == null)
				checkBox_editSubjectDepartment.Checked = false;
			else
				checkBox_editSubjectDepartment.Checked = true;
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
				Name = textBox_addSubjectName.Text,
				Department = checkBox_addSubjectDepartment.Checked
					? await DepartmentsController.GetDepartmentById((int?)comboBox_addSubjectDepartment.SelectedValue)
					: null
			};

			if (await SubjectsController.CreateSubject(subject))
				await UpdateSubjectsTableAsync(null);

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addSubject,
				groupBox_editSubject
			});

			dataGridView_departments.ClearSelection();
		}

		private async void Button_editSubject_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_subjects) == null)
				return;

			Subjects subject = new()
			{
				Id = HelperFuncs.GetSelectedRowId(dataGridView_subjects),
				Name = textBox_editSubjectName.Text,
				Department = checkBox_editSubjectDepartment.Checked
					? await DepartmentsController.GetDepartmentById((int?)comboBox_editSubjectDepartment.SelectedValue)
					: null
			};

			int? selectedRowIndex = HelperFuncs.GetSelectedRowId(dataGridView_subjects);

			if (await SubjectsController.UpdateSubjects(subject))
				await UpdateSubjectsTableAsync(null);

			HelperFuncs.SelectRowById(selectedRowIndex, dataGridView_subjects, DataGridView_subjects_CellClick);
		}

		private async void Button_deleteSubject_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_subjects) == null)
				return;

			if (await SubjectsController.DeleteSubject(HelperFuncs.GetSelectedRowId(dataGridView_subjects)))
				await UpdateSubjectsTableAsync(null);
			dataGridView_departments.ClearSelection();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addSubject,
				groupBox_editSubject
			});
		}

		#endregion

		#region Department

		private async Task UpdateDeparmentsTableAsync(int? universityId)
		{
			if (universityId == null)
				dataGridView_departments.DataSource = await DepartmentsController.GetDepartments();
			else
				dataGridView_departments.DataSource = await DepartmentsController.GetDepatmentsInUniversity(universityId);

			dataGridView_departments.ClearSelection();
			await UpdateSubjectsComboBoxes();

			if (dataGridView_departments.Rows.Count == 0)
				return;

			dataGridView_departments
				.Columns[dataGridView_departments.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			async Task UpdateSubjectsComboBoxes()
			{
				comboBox_addSubjectDepartment.DataSource = await DepartmentsController.GetDepartments();
				comboBox_editSubjectDepartment.DataSource = await DepartmentsController.GetDepartments();

				if (comboBox_addSubjectDepartment.Items.Count != 0)
				{
					comboBox_addSubjectDepartment.ValueMember = "Id";
					comboBox_addSubjectDepartment.DisplayMember = "Name";
					comboBox_editSubjectDepartment.ValueMember = "Id";
					comboBox_editSubjectDepartment.DisplayMember = "Name";
				}
			}
		}

		private void DataGridView_departments_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
				dataGridView_departments.Columns[e.ColumnIndex].Name,
				(List<dynamic>)dataGridView_departments.DataSource
			);

			dataGridView_departments.DataSource = sortedList;
			dataGridView_departments.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addDepartment,
				groupBox_editDepartment
			});
		}

		private async void DataGridView_departments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_departments.Rows.Count == 0)
				return;

			var departments = await DepartmentsController.GetDepartmentById(HelperFuncs.GetSelectedRowId(dataGridView_departments));
			if (departments == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editDepartmentName.Text = departments.Name;

			if (comboBox_editDepartmentUniversity.Items.Count == 0)
				comboBox_editDepartmentUniversity.SelectedIndex = -1;
			else
				comboBox_editDepartmentUniversity.SelectedValue = departments.University?.Id ?? -1;

			if (departments.University == null)
				checkBox_editDepartmentUniversity.Checked = false;
			else
				checkBox_editDepartmentUniversity.Checked = true;

			await UpdateSubjectsTableAsync(departments.Id);
		}

		private void Button_searchDepartments_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchDepartment.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_searchDepartments.Text) ? textBox_searchDepartments.Text : null,
					((IEnumerable<dynamic>)dataGridView_departments.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_departments.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_departments, currencyManager);
		}

		private async void Button_addDepartment_Click(object sender, EventArgs e)
		{
			Departments? department = new()
			{
				Id = 0,
				Name = textBox_addDepartmentName.Text,
				University = checkBox_addDepartmentUniversity.Checked
					? await UniversitiesController.GetUniversityById((int?)comboBox_addDepartmentUniversity.SelectedValue)
					: null
			};

			if (await DepartmentsController.CreateDepartment(department))
			{
				await UpdateDeparmentsTableAsync(null);
				await UpdateSubjectsTableAsync(null);
			}

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addDepartment,
				groupBox_editDepartment,
				groupBox_addSubject,
				groupBox_editSubject
			});
		}

		private async void Button_editDepartment_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_departments) == null)
				return;

			Departments? department = new()
			{
				Id = HelperFuncs.GetSelectedRowId(dataGridView_departments),
				Name = textBox_editDepartmentName.Text,
				University = checkBox_editDepartmentUniversity.Checked
					? await UniversitiesController.GetUniversityById((int?)comboBox_editDepartmentUniversity.SelectedValue)
					: null
			};

			int? selectedRowIndex = HelperFuncs.GetSelectedRowId(dataGridView_departments);

			if (await DepartmentsController.UpdateDepartment(department))
			{
				await UpdateDeparmentsTableAsync(null);
				await UpdateSubjectsTableAsync(null);
			}

			HelperFuncs.SelectRowById(selectedRowIndex, dataGridView_departments, DataGridView_departments_CellClick);
		}

		private async void Button_deleteDepartment_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_departments) == null)
				return;

			if (await DepartmentsController.DeleteDepartment(HelperFuncs.GetSelectedRowId(dataGridView_departments)))
				await UpdateDeparmentsTableAsync(null);

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addDepartment,
				groupBox_editDepartment
			});
		}

		#endregion

		#region University

		private async Task UpdateUniversitiesTableAsync()
		{
			dataGridView_universities.DataSource = await UniversitiesController.GetUniversities();
			dataGridView_universities.ClearSelection();
			await UpdateDepartmentsComboBoxes();

			if (dataGridView_universities.Rows.Count == 0)
				return;

			dataGridView_universities
				.Columns[dataGridView_universities.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


			async Task UpdateDepartmentsComboBoxes()
			{
				comboBox_addDepartmentUniversity.DataSource = await UniversitiesController.GetUniversities();
				comboBox_editDepartmentUniversity.DataSource = await UniversitiesController.GetUniversities();

				comboBox_addDepartmentUniversity.ValueMember = "Id";
				comboBox_addDepartmentUniversity.DisplayMember = "Name";
				comboBox_editDepartmentUniversity.ValueMember = "Id";
				comboBox_editDepartmentUniversity.DisplayMember = "Name";
			}
		}

		private void DataGridView_universities_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
					dataGridView_universities.Columns[e.ColumnIndex].Name,
					(List<dynamic>)dataGridView_universities.DataSource
				);

			dataGridView_universities.DataSource = sortedList;
			dataGridView_universities.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addUniversity,
				groupBox_editUniversity
			});
		}

		private async void DataGridView_universities_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_universities.Rows.Count == 0)
				return;

			var university = await UniversitiesController.GetUniversityById(HelperFuncs.GetSelectedRowId(dataGridView_universities));
			if (university == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editUniversityName.Text = university.Name;
			textBox_editUniversityAddress.Text = university.Address?.MainAddress;

			if (comboBox_editUniversityCity.Items.Count == 0)
				comboBox_editUniversityCity.SelectedIndex = -1;
			else
				comboBox_editUniversityCity.SelectedValue = university.Address.City?.Id ?? -1;

			if (university.Address.City == null)
				checkBox_editUniversityCity.Checked = false;
			else
				checkBox_editUniversityCity.Checked = true;

			await UpdateDeparmentsTableAsync(university.Id);
		}

		private void Button_searchUniversity_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchUniversity.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_searchUniversity.Text) ? textBox_searchUniversity.Text : null,
					((IEnumerable<dynamic>)dataGridView_universities.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_universities.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_universities, currencyManager);
		}

		private async void Button_addUniversity_Click(object sender, EventArgs e)
		{
			Universities university = new()
			{
				Id = 0,
				Name = textBox_addUniversityName.Text,
				Address = new Addresses()
				{
					Id = 0,
					MainAddress = textBox_addUniversityAddress.Text,
					City = checkBox_addUniversityCity.Checked
					? await CitiesController.GetCityById((int?)comboBox_addUniversityCity.SelectedValue)
					: null
				}
			};

			if (await UniversitiesController.CreateUniversity(university))
			{
				await UpdateUniversitiesTableAsync();
				await UpdateDeparmentsTableAsync(null);
			}

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addUniversity,
				groupBox_editUniversity,
				groupBox_addDepartment,
				groupBox_editDepartment
			});
		}

		private async void Button_editUniversity_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_universities) == null)
				return;

			Universities? university = await UniversitiesController
				.GetUniversityById(HelperFuncs.GetSelectedRowId(dataGridView_universities));
			university.Name = textBox_editUniversityName.Text;
			university.Address.MainAddress = textBox_editUniversityAddress.Text;
			university.Address.City = checkBox_editUniversityCity.Checked
				? await CitiesController.GetCityById((int?)comboBox_editUniversityCity.SelectedValue)
				: null;

			int? selectedRowIndex = HelperFuncs.GetSelectedRowId(dataGridView_universities);
			if (await UniversitiesController.UpdateUniversity(university))
				await UpdateUniversitiesTableAsync();

			HelperFuncs.SelectRowById(selectedRowIndex, dataGridView_universities, DataGridView_universities_CellClick);
		}

		private async void Button_deleteUniversity_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_universities) == null)
				return;

			if (await UniversitiesController.DeleteUniversity(HelperFuncs.GetSelectedRowId(dataGridView_universities)))
				await UpdateUniversitiesTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addUniversity,
				groupBox_editUniversity
			});
		}

		#endregion

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			HelperFuncs.HandleComboBoxes((CheckBox)sender, this);
			#region old checkbox check
			/*switch (((CheckBox)sender).Name)
			{
				case "checkBox_addUniversityCity":
					if (checkBox_addUniversityCity.Checked)
						comboBox_addUniversityCity.Enabled = true;
					else
						comboBox_addUniversityCity.Enabled = false;
					break;

				case "checkBox_editUniversityCity":
					if (checkBox_editUniversityCity.Checked)
						comboBox_editUniversityCity.Enabled = true;
					else
						comboBox_editUniversityCity.Enabled = false;
					break;
			}*/
			#endregion
		}

		private async void Button_reset_Click(object sender, EventArgs e)
		{
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addUniversity,
				groupBox_editUniversity,
				groupBox_addDepartment,
				groupBox_editDepartment,
				groupBox_addSubject,
				groupBox_editSubject
			});

			await UpdateDeparmentsTableAsync(null);
			await UpdateSubjectsTableAsync(null);
			await UpdateUniversitiesTableAsync();
		}
	}
}
