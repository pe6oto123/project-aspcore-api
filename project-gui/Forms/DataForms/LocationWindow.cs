using project_gui.DataModels;
using project_gui.DataModels._uitl;

namespace project_gui.Forms.DataForms
{
	public partial class LocationWindow : Form
	{
		public LocationWindow()
		{
			InitializeComponent();
			_ = UpdateCountriesTableAsync();
		}
		#region Countries
		private async Task UpdateCountriesTableAsync()
		{
			dataGridView_countries.DataSource = await CountriesController.GetCountries();
			dataGridView_countries.ClearSelection();
			await UpdateCountriesComboboxes();

			if (dataGridView_countries.Rows.Count == 0)
				return;

			dataGridView_countries
				.Columns[dataGridView_countries.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			async Task UpdateCountriesComboboxes()
			{
				comboBox_addCityCountry.ValueMember = "Id";
				comboBox_addCityCountry.DisplayMember = "Name";
				comboBox_editCityCountry.ValueMember = "Id";
				comboBox_editCityCountry.DisplayMember = "Name";

				comboBox_addCityCountry.DataSource = await CountriesController.GetCountries();
				comboBox_editCityCountry.DataSource = await CountriesController.GetCountries();
			}

		}

		private void DataGridView_countries_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = (List<dynamic>)dataGridView_countries.DataSource;
			switch (e.ColumnIndex)
			{
				case 0:
					if (!sortedList.OrderBy(s => s.Id).SequenceEqual(sortedList))
						sortedList = sortedList.OrderBy(s => s.Id).ToList();
					else
						sortedList = sortedList.OrderByDescending(s => s.Id).ToList();
					break;
				case 1:
					if (!sortedList.OrderBy(s => s.Name).SequenceEqual(sortedList))
						sortedList = sortedList.OrderBy(s => s.Name).ToList();
					else
						sortedList = sortedList.OrderByDescending(s => s.Name).ToList();
					break;
				case 2:
					if (!sortedList.OrderBy(s => s.Continent).SequenceEqual(sortedList))
						sortedList = sortedList.OrderBy(s => s.Continent).ToList();
					else
						sortedList = sortedList.OrderByDescending(s => s.Continent).ToList();
					break;
			}
			dataGridView_countries.DataSource = sortedList;
			dataGridView_countries.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addCountry,
				groupBox_editCountry
			});
		}

		private async void DataGridView_countries_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_countries.Rows.Count == 0)
				return;

			await UpdateCountryEdit();

			async Task UpdateCountryEdit()
			{
				var countries = await CountriesController.GetCountryById(HelperFuncs.GetSelectedRowId(dataGridView_countries));
				if (countries == null)
				{
					MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				textBox_editCountryName.Text = countries.Name;
				textBox_editCountryContinent.Text = countries.Continent;
			}
		}

		private void Button_searchCountries_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchByCountry.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = CountriesController
				.GetCountriesByAttribute(
					checkedButton.Text,
					!string.IsNullOrEmpty(textBox_searchCountries.Text) ? textBox_searchCountries.Text : null,
					((IEnumerable<dynamic>)dataGridView_countries.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_countries.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_countries, currencyManager);
		}

		private async void Button_addCountry_Click(object sender, EventArgs e)
		{
			await UpdateCountry();

			async Task UpdateCountry()
			{
				Countries? country = new()
				{
					Name = textBox_addCountryName.Text,
					Continent = !string.IsNullOrEmpty(textBox_addCountryContinent.Text) ? textBox_addCountryContinent.Text : null
				};

				await CountriesController.CreateCountry(country);
				await UpdateCountriesTableAsync();
			}
		}

		private async void Button_editCountry_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_countries) == null)
				return;

			await UpdateCountry();

			async Task UpdateCountry()
			{
				Countries? country = new()
				{
					Id = HelperFuncs.GetSelectedRowId(dataGridView_countries),
					Name = textBox_editCountryName.Text,
					Continent = !string.IsNullOrEmpty(textBox_editCountryContinent.Text) ? textBox_editCountryContinent.Text : null
				};

				await CountriesController.UpdateCountry(country);

				await UpdateCountriesTableAsync();
			}
		}
		private void Button_deleteCountry_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_countries) == null)
				return;

			_ = DeleteCountry();

			async Task DeleteCountry()
			{
				await CountriesController.DeleteCountry(HelperFuncs.GetSelectedRowId(dataGridView_countries));
				await UpdateCountriesTableAsync();
			}
		}

		#endregion

		private void Button_reset_Click(object sender, EventArgs e)
		{
			_ = UpdateCountriesTableAsync();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addCity,
				groupBox_editCity,
				groupBox_addCountry,
				groupBox_editCountry
			});
		}

		private void CheckBox_CityCountry_CheckedChanged(object sender, EventArgs e)
		{
			switch (((CheckBox)sender).Name)
			{
				case "checkBox_addCityCountry":
					if (checkBox_addCityCountry.Checked)
						comboBox_addCityCountry.Enabled = true;
					else
						comboBox_addCityCountry.Enabled = false;
					break;

				case "checkBox_editCityCountry":
					if (checkBox_editCityCountry.Checked)
						comboBox_editCityCountry.Enabled = true;
					else
						comboBox_editCityCountry.Enabled = false;
					break;
			}
		}


	}
}
