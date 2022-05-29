namespace project_gui.Forms.DataForms
{
	partial class LocationWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox_departmentsTable = new System.Windows.Forms.GroupBox();
			this.dataGridView_countries = new System.Windows.Forms.DataGridView();
			this.button_searchDepartments = new System.Windows.Forms.Button();
			this.textBox_searchDepartments = new System.Windows.Forms.TextBox();
			this.groupBox_search = new System.Windows.Forms.GroupBox();
			this.groupBox_searchByCity = new System.Windows.Forms.GroupBox();
			this.radioButton_cityPopulation = new System.Windows.Forms.RadioButton();
			this.radioButton_cityRegion = new System.Windows.Forms.RadioButton();
			this.radioButton_cityName = new System.Windows.Forms.RadioButton();
			this.groupBox_searchByCountry = new System.Windows.Forms.GroupBox();
			this.radioButton_countryContinent = new System.Windows.Forms.RadioButton();
			this.radioButton_countryName = new System.Windows.Forms.RadioButton();
			this.groupBox_citiesTable = new System.Windows.Forms.GroupBox();
			this.dataGridView_cities = new System.Windows.Forms.DataGridView();
			this.button_searchCities = new System.Windows.Forms.Button();
			this.textBox_searchCities = new System.Windows.Forms.TextBox();
			this.groupBox_editCountry = new System.Windows.Forms.GroupBox();
			this.button_editCountry = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_editCountryName = new System.Windows.Forms.TextBox();
			this.textBox_editCountryContinent = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox_addCountry = new System.Windows.Forms.GroupBox();
			this.button_addCountry = new System.Windows.Forms.Button();
			this.label_addCountryContinent = new System.Windows.Forms.Label();
			this.textBox_addCountryContinent = new System.Windows.Forms.TextBox();
			this.label_addCountryName = new System.Windows.Forms.Label();
			this.textBox_addCountryName = new System.Windows.Forms.TextBox();
			this.groupBox_editCity = new System.Windows.Forms.GroupBox();
			this.checkBox_editCityHasCountry = new System.Windows.Forms.CheckBox();
			this.comboBox_editCityCountry = new System.Windows.Forms.ComboBox();
			this.button_editCity = new System.Windows.Forms.Button();
			this.numericUpDown_editCityPopulation = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox_editCityRegion = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_editCityName = new System.Windows.Forms.TextBox();
			this.groupBox_addCity = new System.Windows.Forms.GroupBox();
			this.checkBox_addCityHasCountry = new System.Windows.Forms.CheckBox();
			this.comboBox_addCityCountry = new System.Windows.Forms.ComboBox();
			this.numericUpDown_addCityPopulation = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button_addCity = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_addCityName = new System.Windows.Forms.TextBox();
			this.textBox_addCityRegion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox_deleteCity = new System.Windows.Forms.GroupBox();
			this.button_deleteCity = new System.Windows.Forms.Button();
			this.groupBox_deleteCountry = new System.Windows.Forms.GroupBox();
			this.button_deleteCountry = new System.Windows.Forms.Button();
			this.groupBox_reset = new System.Windows.Forms.GroupBox();
			this.button_reset = new System.Windows.Forms.Button();
			this.groupBox_departmentsTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_countries)).BeginInit();
			this.groupBox_search.SuspendLayout();
			this.groupBox_searchByCity.SuspendLayout();
			this.groupBox_searchByCountry.SuspendLayout();
			this.groupBox_citiesTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_cities)).BeginInit();
			this.groupBox_editCountry.SuspendLayout();
			this.groupBox_addCountry.SuspendLayout();
			this.groupBox_editCity.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_editCityPopulation)).BeginInit();
			this.groupBox_addCity.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addCityPopulation)).BeginInit();
			this.groupBox_deleteCity.SuspendLayout();
			this.groupBox_deleteCountry.SuspendLayout();
			this.groupBox_reset.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_departmentsTable
			// 
			this.groupBox_departmentsTable.Controls.Add(this.dataGridView_countries);
			this.groupBox_departmentsTable.Controls.Add(this.button_searchDepartments);
			this.groupBox_departmentsTable.Controls.Add(this.textBox_searchDepartments);
			this.groupBox_departmentsTable.Location = new System.Drawing.Point(12, 12);
			this.groupBox_departmentsTable.Name = "groupBox_departmentsTable";
			this.groupBox_departmentsTable.Size = new System.Drawing.Size(288, 657);
			this.groupBox_departmentsTable.TabIndex = 0;
			this.groupBox_departmentsTable.TabStop = false;
			this.groupBox_departmentsTable.Text = "Countries";
			// 
			// dataGridView_countries
			// 
			this.dataGridView_countries.AllowUserToAddRows = false;
			this.dataGridView_countries.AllowUserToDeleteRows = false;
			this.dataGridView_countries.AllowUserToResizeColumns = false;
			this.dataGridView_countries.AllowUserToResizeRows = false;
			this.dataGridView_countries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_countries.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_countries.Location = new System.Drawing.Point(6, 51);
			this.dataGridView_countries.Name = "dataGridView_countries";
			this.dataGridView_countries.RowHeadersVisible = false;
			this.dataGridView_countries.RowTemplate.Height = 25;
			this.dataGridView_countries.Size = new System.Drawing.Size(276, 600);
			this.dataGridView_countries.TabIndex = 2;
			// 
			// button_searchDepartments
			// 
			this.button_searchDepartments.Location = new System.Drawing.Point(216, 22);
			this.button_searchDepartments.Name = "button_searchDepartments";
			this.button_searchDepartments.Size = new System.Drawing.Size(66, 23);
			this.button_searchDepartments.TabIndex = 1;
			this.button_searchDepartments.Text = "Search";
			this.button_searchDepartments.UseVisualStyleBackColor = true;
			// 
			// textBox_searchDepartments
			// 
			this.textBox_searchDepartments.Location = new System.Drawing.Point(6, 22);
			this.textBox_searchDepartments.Name = "textBox_searchDepartments";
			this.textBox_searchDepartments.Size = new System.Drawing.Size(204, 23);
			this.textBox_searchDepartments.TabIndex = 0;
			// 
			// groupBox_search
			// 
			this.groupBox_search.Controls.Add(this.groupBox_searchByCity);
			this.groupBox_search.Controls.Add(this.groupBox_searchByCountry);
			this.groupBox_search.Location = new System.Drawing.Point(600, 13);
			this.groupBox_search.Name = "groupBox_search";
			this.groupBox_search.Size = new System.Drawing.Size(166, 468);
			this.groupBox_search.TabIndex = 2;
			this.groupBox_search.TabStop = false;
			this.groupBox_search.Text = "Search by";
			// 
			// groupBox_searchByCity
			// 
			this.groupBox_searchByCity.Controls.Add(this.radioButton_cityPopulation);
			this.groupBox_searchByCity.Controls.Add(this.radioButton_cityRegion);
			this.groupBox_searchByCity.Controls.Add(this.radioButton_cityName);
			this.groupBox_searchByCity.Location = new System.Drawing.Point(6, 247);
			this.groupBox_searchByCity.Name = "groupBox_searchByCity";
			this.groupBox_searchByCity.Size = new System.Drawing.Size(154, 215);
			this.groupBox_searchByCity.TabIndex = 4;
			this.groupBox_searchByCity.TabStop = false;
			this.groupBox_searchByCity.Text = "City";
			// 
			// radioButton_cityPopulation
			// 
			this.radioButton_cityPopulation.AutoSize = true;
			this.radioButton_cityPopulation.Location = new System.Drawing.Point(19, 72);
			this.radioButton_cityPopulation.Name = "radioButton_cityPopulation";
			this.radioButton_cityPopulation.Size = new System.Drawing.Size(83, 19);
			this.radioButton_cityPopulation.TabIndex = 5;
			this.radioButton_cityPopulation.Text = "Population";
			this.radioButton_cityPopulation.UseVisualStyleBackColor = true;
			// 
			// radioButton_cityRegion
			// 
			this.radioButton_cityRegion.AutoSize = true;
			this.radioButton_cityRegion.Location = new System.Drawing.Point(19, 47);
			this.radioButton_cityRegion.Name = "radioButton_cityRegion";
			this.radioButton_cityRegion.Size = new System.Drawing.Size(62, 19);
			this.radioButton_cityRegion.TabIndex = 4;
			this.radioButton_cityRegion.Text = "Region";
			this.radioButton_cityRegion.UseVisualStyleBackColor = true;
			// 
			// radioButton_cityName
			// 
			this.radioButton_cityName.AutoSize = true;
			this.radioButton_cityName.Checked = true;
			this.radioButton_cityName.Location = new System.Drawing.Point(19, 22);
			this.radioButton_cityName.Name = "radioButton_cityName";
			this.radioButton_cityName.Size = new System.Drawing.Size(57, 19);
			this.radioButton_cityName.TabIndex = 3;
			this.radioButton_cityName.TabStop = true;
			this.radioButton_cityName.Text = "Name";
			this.radioButton_cityName.UseVisualStyleBackColor = true;
			// 
			// groupBox_searchByCountry
			// 
			this.groupBox_searchByCountry.Controls.Add(this.radioButton_countryContinent);
			this.groupBox_searchByCountry.Controls.Add(this.radioButton_countryName);
			this.groupBox_searchByCountry.Location = new System.Drawing.Point(6, 22);
			this.groupBox_searchByCountry.Name = "groupBox_searchByCountry";
			this.groupBox_searchByCountry.Size = new System.Drawing.Size(154, 215);
			this.groupBox_searchByCountry.TabIndex = 3;
			this.groupBox_searchByCountry.TabStop = false;
			this.groupBox_searchByCountry.Text = "Country";
			// 
			// radioButton_countryContinent
			// 
			this.radioButton_countryContinent.AutoSize = true;
			this.radioButton_countryContinent.Location = new System.Drawing.Point(19, 47);
			this.radioButton_countryContinent.Name = "radioButton_countryContinent";
			this.radioButton_countryContinent.Size = new System.Drawing.Size(78, 19);
			this.radioButton_countryContinent.TabIndex = 1;
			this.radioButton_countryContinent.Text = "Continent";
			this.radioButton_countryContinent.UseVisualStyleBackColor = true;
			// 
			// radioButton_countryName
			// 
			this.radioButton_countryName.AutoSize = true;
			this.radioButton_countryName.Checked = true;
			this.radioButton_countryName.Location = new System.Drawing.Point(19, 22);
			this.radioButton_countryName.Name = "radioButton_countryName";
			this.radioButton_countryName.Size = new System.Drawing.Size(57, 19);
			this.radioButton_countryName.TabIndex = 0;
			this.radioButton_countryName.TabStop = true;
			this.radioButton_countryName.Text = "Name";
			this.radioButton_countryName.UseVisualStyleBackColor = true;
			// 
			// groupBox_citiesTable
			// 
			this.groupBox_citiesTable.Controls.Add(this.dataGridView_cities);
			this.groupBox_citiesTable.Controls.Add(this.button_searchCities);
			this.groupBox_citiesTable.Controls.Add(this.textBox_searchCities);
			this.groupBox_citiesTable.Location = new System.Drawing.Point(306, 13);
			this.groupBox_citiesTable.Name = "groupBox_citiesTable";
			this.groupBox_citiesTable.Size = new System.Drawing.Size(288, 657);
			this.groupBox_citiesTable.TabIndex = 1;
			this.groupBox_citiesTable.TabStop = false;
			this.groupBox_citiesTable.Text = "Cities";
			// 
			// dataGridView_cities
			// 
			this.dataGridView_cities.AllowUserToAddRows = false;
			this.dataGridView_cities.AllowUserToDeleteRows = false;
			this.dataGridView_cities.AllowUserToResizeColumns = false;
			this.dataGridView_cities.AllowUserToResizeRows = false;
			this.dataGridView_cities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_cities.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_cities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_cities.Location = new System.Drawing.Point(6, 51);
			this.dataGridView_cities.Name = "dataGridView_cities";
			this.dataGridView_cities.RowHeadersVisible = false;
			this.dataGridView_cities.RowTemplate.Height = 25;
			this.dataGridView_cities.Size = new System.Drawing.Size(276, 600);
			this.dataGridView_cities.TabIndex = 3;
			// 
			// button_searchCities
			// 
			this.button_searchCities.Location = new System.Drawing.Point(216, 22);
			this.button_searchCities.Name = "button_searchCities";
			this.button_searchCities.Size = new System.Drawing.Size(66, 23);
			this.button_searchCities.TabIndex = 3;
			this.button_searchCities.Text = "Search";
			this.button_searchCities.UseVisualStyleBackColor = true;
			// 
			// textBox_searchCities
			// 
			this.textBox_searchCities.Location = new System.Drawing.Point(6, 22);
			this.textBox_searchCities.Name = "textBox_searchCities";
			this.textBox_searchCities.Size = new System.Drawing.Size(204, 23);
			this.textBox_searchCities.TabIndex = 2;
			// 
			// groupBox_editCountry
			// 
			this.groupBox_editCountry.Controls.Add(this.button_editCountry);
			this.groupBox_editCountry.Controls.Add(this.label1);
			this.groupBox_editCountry.Controls.Add(this.textBox_editCountryName);
			this.groupBox_editCountry.Controls.Add(this.textBox_editCountryContinent);
			this.groupBox_editCountry.Controls.Add(this.label2);
			this.groupBox_editCountry.Location = new System.Drawing.Point(1016, 13);
			this.groupBox_editCountry.Name = "groupBox_editCountry";
			this.groupBox_editCountry.Size = new System.Drawing.Size(236, 325);
			this.groupBox_editCountry.TabIndex = 8;
			this.groupBox_editCountry.TabStop = false;
			this.groupBox_editCountry.Text = "Edit Country";
			// 
			// button_editCountry
			// 
			this.button_editCountry.Location = new System.Drawing.Point(150, 296);
			this.button_editCountry.Name = "button_editCountry";
			this.button_editCountry.Size = new System.Drawing.Size(80, 23);
			this.button_editCountry.TabIndex = 7;
			this.button_editCountry.Text = "Edit";
			this.button_editCountry.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Continent";
			// 
			// textBox_editCountryName
			// 
			this.textBox_editCountryName.Location = new System.Drawing.Point(80, 22);
			this.textBox_editCountryName.Name = "textBox_editCountryName";
			this.textBox_editCountryName.Size = new System.Drawing.Size(150, 23);
			this.textBox_editCountryName.TabIndex = 8;
			// 
			// textBox_editCountryContinent
			// 
			this.textBox_editCountryContinent.Location = new System.Drawing.Point(80, 61);
			this.textBox_editCountryContinent.Name = "textBox_editCountryContinent";
			this.textBox_editCountryContinent.Size = new System.Drawing.Size(150, 23);
			this.textBox_editCountryContinent.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Name*";
			// 
			// groupBox_addCountry
			// 
			this.groupBox_addCountry.Controls.Add(this.button_addCountry);
			this.groupBox_addCountry.Controls.Add(this.label_addCountryContinent);
			this.groupBox_addCountry.Controls.Add(this.textBox_addCountryContinent);
			this.groupBox_addCountry.Controls.Add(this.label_addCountryName);
			this.groupBox_addCountry.Controls.Add(this.textBox_addCountryName);
			this.groupBox_addCountry.Location = new System.Drawing.Point(772, 13);
			this.groupBox_addCountry.Name = "groupBox_addCountry";
			this.groupBox_addCountry.Size = new System.Drawing.Size(236, 326);
			this.groupBox_addCountry.TabIndex = 7;
			this.groupBox_addCountry.TabStop = false;
			this.groupBox_addCountry.Text = "Add Country";
			// 
			// button_addCountry
			// 
			this.button_addCountry.Location = new System.Drawing.Point(150, 296);
			this.button_addCountry.Name = "button_addCountry";
			this.button_addCountry.Size = new System.Drawing.Size(80, 23);
			this.button_addCountry.TabIndex = 1;
			this.button_addCountry.Text = "Add";
			this.button_addCountry.UseVisualStyleBackColor = true;
			// 
			// label_addCountryContinent
			// 
			this.label_addCountryContinent.AutoSize = true;
			this.label_addCountryContinent.Location = new System.Drawing.Point(6, 65);
			this.label_addCountryContinent.Name = "label_addCountryContinent";
			this.label_addCountryContinent.Size = new System.Drawing.Size(60, 15);
			this.label_addCountryContinent.TabIndex = 6;
			this.label_addCountryContinent.Text = "Continent";
			// 
			// textBox_addCountryContinent
			// 
			this.textBox_addCountryContinent.Location = new System.Drawing.Point(80, 61);
			this.textBox_addCountryContinent.Name = "textBox_addCountryContinent";
			this.textBox_addCountryContinent.Size = new System.Drawing.Size(150, 23);
			this.textBox_addCountryContinent.TabIndex = 5;
			// 
			// label_addCountryName
			// 
			this.label_addCountryName.AutoSize = true;
			this.label_addCountryName.Location = new System.Drawing.Point(6, 26);
			this.label_addCountryName.Name = "label_addCountryName";
			this.label_addCountryName.Size = new System.Drawing.Size(44, 15);
			this.label_addCountryName.TabIndex = 4;
			this.label_addCountryName.Text = "Name*";
			// 
			// textBox_addCountryName
			// 
			this.textBox_addCountryName.Location = new System.Drawing.Point(80, 22);
			this.textBox_addCountryName.Name = "textBox_addCountryName";
			this.textBox_addCountryName.Size = new System.Drawing.Size(150, 23);
			this.textBox_addCountryName.TabIndex = 3;
			// 
			// groupBox_editCity
			// 
			this.groupBox_editCity.Controls.Add(this.checkBox_editCityHasCountry);
			this.groupBox_editCity.Controls.Add(this.comboBox_editCityCountry);
			this.groupBox_editCity.Controls.Add(this.button_editCity);
			this.groupBox_editCity.Controls.Add(this.numericUpDown_editCityPopulation);
			this.groupBox_editCity.Controls.Add(this.label5);
			this.groupBox_editCity.Controls.Add(this.label9);
			this.groupBox_editCity.Controls.Add(this.textBox_editCityRegion);
			this.groupBox_editCity.Controls.Add(this.label10);
			this.groupBox_editCity.Controls.Add(this.label6);
			this.groupBox_editCity.Controls.Add(this.textBox_editCityName);
			this.groupBox_editCity.Location = new System.Drawing.Point(1016, 345);
			this.groupBox_editCity.Name = "groupBox_editCity";
			this.groupBox_editCity.Size = new System.Drawing.Size(236, 325);
			this.groupBox_editCity.TabIndex = 10;
			this.groupBox_editCity.TabStop = false;
			this.groupBox_editCity.Text = "Edit City";
			// 
			// checkBox_editCityHasCountry
			// 
			this.checkBox_editCityHasCountry.AutoSize = true;
			this.checkBox_editCityHasCountry.Location = new System.Drawing.Point(88, 168);
			this.checkBox_editCityHasCountry.Name = "checkBox_editCityHasCountry";
			this.checkBox_editCityHasCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_editCityHasCountry.Size = new System.Drawing.Size(142, 19);
			this.checkBox_editCityHasCountry.TabIndex = 19;
			this.checkBox_editCityHasCountry.Text = "?Add city to a country";
			this.checkBox_editCityHasCountry.UseVisualStyleBackColor = true;
			// 
			// comboBox_editCityCountry
			// 
			this.comboBox_editCityCountry.FormattingEnabled = true;
			this.comboBox_editCityCountry.Location = new System.Drawing.Point(80, 139);
			this.comboBox_editCityCountry.Name = "comboBox_editCityCountry";
			this.comboBox_editCityCountry.Size = new System.Drawing.Size(150, 23);
			this.comboBox_editCityCountry.TabIndex = 21;
			// 
			// button_editCity
			// 
			this.button_editCity.Location = new System.Drawing.Point(150, 295);
			this.button_editCity.Name = "button_editCity";
			this.button_editCity.Size = new System.Drawing.Size(80, 23);
			this.button_editCity.TabIndex = 7;
			this.button_editCity.Text = "Edit";
			this.button_editCity.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_editCityPopulation
			// 
			this.numericUpDown_editCityPopulation.Location = new System.Drawing.Point(80, 100);
			this.numericUpDown_editCityPopulation.Name = "numericUpDown_editCityPopulation";
			this.numericUpDown_editCityPopulation.Size = new System.Drawing.Size(150, 23);
			this.numericUpDown_editCityPopulation.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Region";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 143);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 15);
			this.label9.TabIndex = 19;
			this.label9.Text = "Country";
			// 
			// textBox_editCityRegion
			// 
			this.textBox_editCityRegion.Location = new System.Drawing.Point(80, 60);
			this.textBox_editCityRegion.Name = "textBox_editCityRegion";
			this.textBox_editCityRegion.Size = new System.Drawing.Size(150, 23);
			this.textBox_editCityRegion.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "Region";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Name*";
			// 
			// textBox_editCityName
			// 
			this.textBox_editCityName.Location = new System.Drawing.Point(80, 21);
			this.textBox_editCityName.Name = "textBox_editCityName";
			this.textBox_editCityName.Size = new System.Drawing.Size(150, 23);
			this.textBox_editCityName.TabIndex = 8;
			// 
			// groupBox_addCity
			// 
			this.groupBox_addCity.Controls.Add(this.checkBox_addCityHasCountry);
			this.groupBox_addCity.Controls.Add(this.comboBox_addCityCountry);
			this.groupBox_addCity.Controls.Add(this.numericUpDown_addCityPopulation);
			this.groupBox_addCity.Controls.Add(this.label8);
			this.groupBox_addCity.Controls.Add(this.label7);
			this.groupBox_addCity.Controls.Add(this.button_addCity);
			this.groupBox_addCity.Controls.Add(this.label3);
			this.groupBox_addCity.Controls.Add(this.textBox_addCityName);
			this.groupBox_addCity.Controls.Add(this.textBox_addCityRegion);
			this.groupBox_addCity.Controls.Add(this.label4);
			this.groupBox_addCity.Location = new System.Drawing.Point(772, 345);
			this.groupBox_addCity.Name = "groupBox_addCity";
			this.groupBox_addCity.Size = new System.Drawing.Size(236, 325);
			this.groupBox_addCity.TabIndex = 9;
			this.groupBox_addCity.TabStop = false;
			this.groupBox_addCity.Text = "Add City";
			// 
			// checkBox_addCityHasCountry
			// 
			this.checkBox_addCityHasCountry.AutoSize = true;
			this.checkBox_addCityHasCountry.Location = new System.Drawing.Point(88, 168);
			this.checkBox_addCityHasCountry.Name = "checkBox_addCityHasCountry";
			this.checkBox_addCityHasCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_addCityHasCountry.Size = new System.Drawing.Size(142, 19);
			this.checkBox_addCityHasCountry.TabIndex = 18;
			this.checkBox_addCityHasCountry.Text = "?Add city to a country";
			this.checkBox_addCityHasCountry.UseVisualStyleBackColor = true;
			// 
			// comboBox_addCityCountry
			// 
			this.comboBox_addCityCountry.FormattingEnabled = true;
			this.comboBox_addCityCountry.Location = new System.Drawing.Point(80, 139);
			this.comboBox_addCityCountry.Name = "comboBox_addCityCountry";
			this.comboBox_addCityCountry.Size = new System.Drawing.Size(150, 23);
			this.comboBox_addCityCountry.TabIndex = 17;
			// 
			// numericUpDown_addCityPopulation
			// 
			this.numericUpDown_addCityPopulation.Location = new System.Drawing.Point(80, 100);
			this.numericUpDown_addCityPopulation.Name = "numericUpDown_addCityPopulation";
			this.numericUpDown_addCityPopulation.Size = new System.Drawing.Size(150, 23);
			this.numericUpDown_addCityPopulation.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 143);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 15);
			this.label8.TabIndex = 15;
			this.label8.Text = "Country";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "Population";
			// 
			// button_addCity
			// 
			this.button_addCity.Location = new System.Drawing.Point(150, 296);
			this.button_addCity.Name = "button_addCity";
			this.button_addCity.Size = new System.Drawing.Size(80, 23);
			this.button_addCity.TabIndex = 7;
			this.button_addCity.Text = "Add";
			this.button_addCity.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "Region";
			// 
			// textBox_addCityName
			// 
			this.textBox_addCityName.Location = new System.Drawing.Point(80, 22);
			this.textBox_addCityName.Name = "textBox_addCityName";
			this.textBox_addCityName.Size = new System.Drawing.Size(150, 23);
			this.textBox_addCityName.TabIndex = 8;
			// 
			// textBox_addCityRegion
			// 
			this.textBox_addCityRegion.Location = new System.Drawing.Point(80, 61);
			this.textBox_addCityRegion.Name = "textBox_addCityRegion";
			this.textBox_addCityRegion.Size = new System.Drawing.Size(150, 23);
			this.textBox_addCityRegion.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Name*";
			// 
			// groupBox_deleteCity
			// 
			this.groupBox_deleteCity.Controls.Add(this.button_deleteCity);
			this.groupBox_deleteCity.Location = new System.Drawing.Point(600, 613);
			this.groupBox_deleteCity.Name = "groupBox_deleteCity";
			this.groupBox_deleteCity.Size = new System.Drawing.Size(166, 57);
			this.groupBox_deleteCity.TabIndex = 3;
			this.groupBox_deleteCity.TabStop = false;
			this.groupBox_deleteCity.Text = "Delete City";
			// 
			// button_deleteCity
			// 
			this.button_deleteCity.Location = new System.Drawing.Point(25, 22);
			this.button_deleteCity.Name = "button_deleteCity";
			this.button_deleteCity.Size = new System.Drawing.Size(115, 23);
			this.button_deleteCity.TabIndex = 0;
			this.button_deleteCity.Text = "Delete";
			this.button_deleteCity.UseVisualStyleBackColor = true;
			// 
			// groupBox_deleteCountry
			// 
			this.groupBox_deleteCountry.Controls.Add(this.button_deleteCountry);
			this.groupBox_deleteCountry.Location = new System.Drawing.Point(600, 550);
			this.groupBox_deleteCountry.Name = "groupBox_deleteCountry";
			this.groupBox_deleteCountry.Size = new System.Drawing.Size(166, 57);
			this.groupBox_deleteCountry.TabIndex = 4;
			this.groupBox_deleteCountry.TabStop = false;
			this.groupBox_deleteCountry.Text = "Delete Country";
			// 
			// button_deleteCountry
			// 
			this.button_deleteCountry.Location = new System.Drawing.Point(25, 22);
			this.button_deleteCountry.Name = "button_deleteCountry";
			this.button_deleteCountry.Size = new System.Drawing.Size(115, 23);
			this.button_deleteCountry.TabIndex = 0;
			this.button_deleteCountry.Text = "Delete";
			this.button_deleteCountry.UseVisualStyleBackColor = true;
			// 
			// groupBox_reset
			// 
			this.groupBox_reset.Controls.Add(this.button_reset);
			this.groupBox_reset.Location = new System.Drawing.Point(600, 487);
			this.groupBox_reset.Name = "groupBox_reset";
			this.groupBox_reset.Size = new System.Drawing.Size(166, 57);
			this.groupBox_reset.TabIndex = 5;
			this.groupBox_reset.TabStop = false;
			this.groupBox_reset.Text = "Reset Tables";
			// 
			// button_reset
			// 
			this.button_reset.Location = new System.Drawing.Point(25, 22);
			this.button_reset.Name = "button_reset";
			this.button_reset.Size = new System.Drawing.Size(115, 23);
			this.button_reset.TabIndex = 0;
			this.button_reset.Text = "Reset";
			this.button_reset.UseVisualStyleBackColor = true;
			// 
			// LocationWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.groupBox_reset);
			this.Controls.Add(this.groupBox_deleteCountry);
			this.Controls.Add(this.groupBox_deleteCity);
			this.Controls.Add(this.groupBox_editCity);
			this.Controls.Add(this.groupBox_editCountry);
			this.Controls.Add(this.groupBox_addCity);
			this.Controls.Add(this.groupBox_addCountry);
			this.Controls.Add(this.groupBox_citiesTable);
			this.Controls.Add(this.groupBox_search);
			this.Controls.Add(this.groupBox_departmentsTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "LocationWindow";
			this.Text = "Cities and Countries Manager";
			this.groupBox_departmentsTable.ResumeLayout(false);
			this.groupBox_departmentsTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_countries)).EndInit();
			this.groupBox_search.ResumeLayout(false);
			this.groupBox_searchByCity.ResumeLayout(false);
			this.groupBox_searchByCity.PerformLayout();
			this.groupBox_searchByCountry.ResumeLayout(false);
			this.groupBox_searchByCountry.PerformLayout();
			this.groupBox_citiesTable.ResumeLayout(false);
			this.groupBox_citiesTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_cities)).EndInit();
			this.groupBox_editCountry.ResumeLayout(false);
			this.groupBox_editCountry.PerformLayout();
			this.groupBox_addCountry.ResumeLayout(false);
			this.groupBox_addCountry.PerformLayout();
			this.groupBox_editCity.ResumeLayout(false);
			this.groupBox_editCity.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_editCityPopulation)).EndInit();
			this.groupBox_addCity.ResumeLayout(false);
			this.groupBox_addCity.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addCityPopulation)).EndInit();
			this.groupBox_deleteCity.ResumeLayout(false);
			this.groupBox_deleteCountry.ResumeLayout(false);
			this.groupBox_reset.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox_departmentsTable;
		private GroupBox groupBox_search;
		private GroupBox groupBox_citiesTable;
		private GroupBox groupBox_editCountry;
		private GroupBox groupBox_addCountry;
		private GroupBox groupBox_editCity;
		private GroupBox groupBox_addCity;
		private GroupBox groupBox_deleteCity;
		private Button button_deleteCity;
		private GroupBox groupBox_deleteCountry;
		private Button button_deleteCountry;
		private GroupBox groupBox_reset;
		private Button button_reset;
		private Button button_searchDepartments;
		private TextBox textBox_searchDepartments;
		private Button button_searchCities;
		private TextBox textBox_searchCities;
		private DataGridView dataGridView_countries;
		private DataGridView dataGridView_cities;
		private GroupBox groupBox_searchByCity;
		private GroupBox groupBox_searchByCountry;
		private RadioButton radioButton_countryName;
		private RadioButton radioButton_countryContinent;
		private RadioButton radioButton_cityRegion;
		private RadioButton radioButton_cityName;
		private Button button_addCountry;
		private Label label_addCountryContinent;
		private TextBox textBox_addCountryContinent;
		private Label label_addCountryName;
		private TextBox textBox_addCountryName;
		private Button button_editCountry;
		private Label label1;
		private TextBox textBox_editCountryName;
		private TextBox textBox_editCountryContinent;
		private Label label2;
		private Button button_editCity;
		private Label label5;
		private TextBox textBox_editCityRegion;
		private Label label6;
		private TextBox textBox_editCityName;
		private Button button_addCity;
		private Label label3;
		private TextBox textBox_addCityName;
		private TextBox textBox_addCityRegion;
		private Label label4;
		private Label label8;
		private Label label7;
		private ComboBox comboBox_editCityCountry;
		private NumericUpDown numericUpDown_editCityPopulation;
		private Label label9;
		private Label label10;
		private ComboBox comboBox_addCityCountry;
		private NumericUpDown numericUpDown_addCityPopulation;
		private CheckBox checkBox_editCityHasCountry;
		private CheckBox checkBox_addCityHasCountry;
		private RadioButton radioButton_cityPopulation;
	}
}