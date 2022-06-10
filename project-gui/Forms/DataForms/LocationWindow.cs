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
			_ = UpdateCitiesTableAsync(null);
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
				comboBox_addCityCountry.DataSource = await CountriesController.GetCountries();
				comboBox_editCityCountry.DataSource = await CountriesController.GetCountries();

				comboBox_addCityCountry.ValueMember = "Id";
				comboBox_addCityCountry.DisplayMember = "Name";
				comboBox_editCityCountry.ValueMember = "Id";
				comboBox_editCityCountry.DisplayMember = "Name";
			}
		}

		private void DataGridView_countries_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
					dataGridView_countries.Columns[e.ColumnIndex].Name,
					(List<dynamic>)dataGridView_countries.DataSource
				);

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


			var country = await CountriesController.GetCountryById(HelperFuncs.GetSelectedRowId(dataGridView_countries));
			if (country == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editCountryName.Text = country.Name;
			textBox_editCountryContinent.Text = country.Continent;

			await UpdateCitiesTableAsync(country.Id);
		}

		private void Button_searchCountries_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchByCountry.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_searchCountries.Text) ? textBox_searchCountries.Text : null,
					((IEnumerable<dynamic>)dataGridView_countries.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_countries.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_countries, currencyManager);
		}

		private async void Button_addCountry_Click(object sender, EventArgs e)
		{
			Countries? country = new()
			{
				// posting country with id = 0 triggers the auto-increment opiton in efcore
				Id = 0,
				Name = textBox_addCountryName.Text,
				Continent = !string.IsNullOrEmpty(textBox_addCountryContinent.Text) ? textBox_addCountryContinent.Text : null
			};

			if (await CountriesController.CreateCountry(country))
				await UpdateCountriesTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addCountry
			});
		}

		private async void Button_editCountry_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_countries) == null)
				return;

			Countries? country = new()
			{
				Id = HelperFuncs.GetSelectedRowId(dataGridView_countries),
				Name = textBox_editCountryName.Text,
				Continent = !string.IsNullOrEmpty(textBox_editCountryContinent.Text) ? textBox_editCountryContinent.Text : null
			};

			int selectedRowIndex = dataGridView_countries.SelectedCells[0].RowIndex;

			if (await CountriesController.UpdateCountry(country))
				await UpdateCountriesTableAsync();

			dataGridView_countries.Rows[selectedRowIndex].Selected = true;
		}
		private async void Button_deleteCountry_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_countries) == null)
				return;

			if (await CountriesController.DeleteCountry(HelperFuncs.GetSelectedRowId(dataGridView_countries)))
				await UpdateCountriesTableAsync();

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addCountry,
				groupBox_editCountry
			});
		}

		#endregion

		#region Cities
		private async Task UpdateCitiesTableAsync(int? countryId)
		{
			dataGridView_cities.DataSource = await CitiesController.GetCities(countryId);
			dataGridView_cities.ClearSelection();

			if (dataGridView_cities.Rows.Count == 0)
				return;

			dataGridView_cities
				.Columns[dataGridView_cities.ColumnCount - 1]
				.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void DataGridView_cities_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var sortedList = HelperFuncs.SortTable(
					dataGridView_cities.Columns[e.ColumnIndex].Name,
					(List<dynamic>)dataGridView_cities.DataSource
				);

			#region old sort
			/*switch (e.ColumnIndex)
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
					if (!sortedList.OrderBy(s => s.Region).SequenceEqual(sortedList))
						sortedList = sortedList.OrderBy(s => s.Region).ToList();
					else
						sortedList = sortedList.OrderByDescending(s => s.Region).ToList();
					break;
				case 3:
					if (!sortedList.OrderBy(s => s.Population).SequenceEqual(sortedList))
						sortedList = sortedList.OrderBy(s => s.Population).ToList();
					else
						sortedList = sortedList.OrderByDescending(s => s.Population).ToList();
					break;
			}*/
			#endregion

			dataGridView_cities.DataSource = sortedList;
			dataGridView_cities.ClearSelection();
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addCity,
				groupBox_editCity
			});
		}

		private async void DataGridView_cities_CellClickAsync(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || dataGridView_cities.Rows.Count == 0)
				return;

			var city = await CitiesController.GetCityById(HelperFuncs.GetSelectedRowId(dataGridView_cities));
			if (city == null)
			{
				MessageBox.Show("There was an error retrieving the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_editCityName.Text = city.Name;
			textBox_editCityRegion.Text = city.Region;
			numericUpDown_editCityPopulation.Value = city.Population != null ? (int)city.Population : 0;
			comboBox_editCityCountry.SelectedValue = city.Country?.Id ?? -1;
		}

		private void Button_searchCities_Click(object sender, EventArgs e)
		{
			var checkedButton = groupBox_searchByCity.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

			if (checkedButton == null)
				return;

			var searchList = HelperFuncs
				.GetObjectByAttribute(
					checkedButton.Tag.ToString(),
					!string.IsNullOrEmpty(textBox_searchCities.Text) ? textBox_searchCities.Text : null,
					((IEnumerable<dynamic>)dataGridView_cities.DataSource).ToList()
				);

			CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataGridView_cities.DataSource];
			HelperFuncs.DisplaySearchList(searchList, dataGridView_cities, currencyManager);
		}

		private async void Button_addCity_ClickAsync(object sender, EventArgs e)
		{
			Cities? city = new()
			{
				// posting country with id = 0 triggers the auto-increment opiton in efcore
				Id = 0,
				Name = textBox_addCityName.Text,
				Region = textBox_addCityRegion.Text,
				Population = (int?)numericUpDown_addCityPopulation.Value,
				Country = checkBox_addCityCountry.Checked ? await CountriesController.GetCountryById((int?)comboBox_addCityCountry.SelectedValue) : null
			};

			if (await CitiesController.CreateCity(city))
				await UpdateCitiesTableAsync(null);

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addCity
			});
		}

		private async void Button_editCity_ClickAsync(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_cities) == null)
				return;

			Cities? city = new()
			{
				Id = HelperFuncs.GetSelectedRowId(dataGridView_cities),
				Name = textBox_editCityName.Text,
				Region = textBox_editCityRegion.Text,
				Population = (int?)numericUpDown_editCityPopulation.Value,
				Country = checkBox_editCityCountry.Checked ? await CountriesController.GetCountryById((int?)comboBox_editCityCountry.SelectedValue) : null
			};

			int selectedRowIndex = dataGridView_cities.SelectedCells[0].RowIndex;

			if (await CitiesController.UpdateCity(city))
				await UpdateCitiesTableAsync(null);

			dataGridView_cities.Rows[selectedRowIndex].Selected = true;
		}

		private async void Button_deleteCity_Click(object sender, EventArgs e)
		{
			if (HelperFuncs.GetSelectedRowId(dataGridView_cities) == null)
				return;

			if (await CitiesController.DeleteCity(HelperFuncs.GetSelectedRowId(dataGridView_cities)))
				await UpdateCitiesTableAsync(null);

			HelperFuncs.ClearFields(new List<GroupBox>
			{
				groupBox_addCity,
				groupBox_editCity
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

		#endregion

		private void Button_reset_Click(object sender, EventArgs e)
		{
			_ = UpdateCountriesTableAsync();
			_ = UpdateCitiesTableAsync(null);
			HelperFuncs.ClearFields(new List<GroupBox>()
			{
				groupBox_addCity,
				groupBox_editCity,
				groupBox_addCountry,
				groupBox_editCountry
			});
		}
	}
}
