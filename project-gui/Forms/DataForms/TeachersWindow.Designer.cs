namespace project_gui.Forms.DataForms
{
	partial class TeachersWindow
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
			this.groupBox_table = new System.Windows.Forms.GroupBox();
			this.dataGridView_teachers = new System.Windows.Forms.DataGridView();
			this.button_search = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.groupBox_search = new System.Windows.Forms.GroupBox();
			this.radioButton_university = new System.Windows.Forms.RadioButton();
			this.radioButton_department = new System.Windows.Forms.RadioButton();
			this.radioButton_address = new System.Windows.Forms.RadioButton();
			this.radioButton_factultyNum = new System.Windows.Forms.RadioButton();
			this.radioButton_lastName = new System.Windows.Forms.RadioButton();
			this.radioButton_firstName = new System.Windows.Forms.RadioButton();
			this.groupBox_add = new System.Windows.Forms.GroupBox();
			this.label_addPostition = new System.Windows.Forms.Label();
			this.textBox_addPosition = new System.Windows.Forms.TextBox();
			this.checkBox_addCity = new System.Windows.Forms.CheckBox();
			this.comboBox_addCity = new System.Windows.Forms.ComboBox();
			this.label_addCity = new System.Windows.Forms.Label();
			this.groupBox_addDepartment = new System.Windows.Forms.GroupBox();
			this.checkedListBox_addDepartments = new System.Windows.Forms.CheckedListBox();
			this.label_addAddress = new System.Windows.Forms.Label();
			this.textBox_addAddress = new System.Windows.Forms.TextBox();
			this.label_addLastName = new System.Windows.Forms.Label();
			this.textBox_addLastName = new System.Windows.Forms.TextBox();
			this.comboBox_addUniversity = new System.Windows.Forms.ComboBox();
			this.button_add = new System.Windows.Forms.Button();
			this.label_addUniversity = new System.Windows.Forms.Label();
			this.label_addFirstName = new System.Windows.Forms.Label();
			this.textBox_addFirstName = new System.Windows.Forms.TextBox();
			this.groupBox_delete = new System.Windows.Forms.GroupBox();
			this.button_delete = new System.Windows.Forms.Button();
			this.groupBox_reset = new System.Windows.Forms.GroupBox();
			this.button_reset = new System.Windows.Forms.Button();
			this.groupBox_edit = new System.Windows.Forms.GroupBox();
			this.label_editPostition = new System.Windows.Forms.Label();
			this.checkBox_editCity = new System.Windows.Forms.CheckBox();
			this.textBox_editPosition = new System.Windows.Forms.TextBox();
			this.comboBox_editCity = new System.Windows.Forms.ComboBox();
			this.label_editCity = new System.Windows.Forms.Label();
			this.groupBox_editDepartment = new System.Windows.Forms.GroupBox();
			this.checkedListBox_editDepartments = new System.Windows.Forms.CheckedListBox();
			this.label_editAddress = new System.Windows.Forms.Label();
			this.textBox_editAddress = new System.Windows.Forms.TextBox();
			this.label_editLastName = new System.Windows.Forms.Label();
			this.textBox_editLastName = new System.Windows.Forms.TextBox();
			this.comboBox_editUniversity = new System.Windows.Forms.ComboBox();
			this.button_edit = new System.Windows.Forms.Button();
			this.label_editUniversity = new System.Windows.Forms.Label();
			this.label_editFirstName = new System.Windows.Forms.Label();
			this.textBox_editFirstName = new System.Windows.Forms.TextBox();
			this.groupBox_table.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).BeginInit();
			this.groupBox_search.SuspendLayout();
			this.groupBox_add.SuspendLayout();
			this.groupBox_addDepartment.SuspendLayout();
			this.groupBox_delete.SuspendLayout();
			this.groupBox_reset.SuspendLayout();
			this.groupBox_edit.SuspendLayout();
			this.groupBox_editDepartment.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_table
			// 
			this.groupBox_table.Controls.Add(this.dataGridView_teachers);
			this.groupBox_table.Controls.Add(this.button_search);
			this.groupBox_table.Controls.Add(this.textBox_search);
			this.groupBox_table.Location = new System.Drawing.Point(12, 12);
			this.groupBox_table.Name = "groupBox_table";
			this.groupBox_table.Size = new System.Drawing.Size(582, 657);
			this.groupBox_table.TabIndex = 0;
			this.groupBox_table.TabStop = false;
			this.groupBox_table.Text = "Teachers";
			// 
			// dataGridView_teachers
			// 
			this.dataGridView_teachers.AllowUserToAddRows = false;
			this.dataGridView_teachers.AllowUserToDeleteRows = false;
			this.dataGridView_teachers.AllowUserToResizeColumns = false;
			this.dataGridView_teachers.AllowUserToResizeRows = false;
			this.dataGridView_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_teachers.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_teachers.Location = new System.Drawing.Point(6, 51);
			this.dataGridView_teachers.MultiSelect = false;
			this.dataGridView_teachers.Name = "dataGridView_teachers";
			this.dataGridView_teachers.ReadOnly = true;
			this.dataGridView_teachers.RowHeadersVisible = false;
			this.dataGridView_teachers.RowTemplate.Height = 25;
			this.dataGridView_teachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_teachers.Size = new System.Drawing.Size(570, 600);
			this.dataGridView_teachers.TabIndex = 2;
			this.dataGridView_teachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_teachers_CellClick);
			this.dataGridView_teachers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_teachers_ColumnHeaderMouseClick);
			// 
			// button_search
			// 
			this.button_search.Location = new System.Drawing.Point(510, 21);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(66, 23);
			this.button_search.TabIndex = 1;
			this.button_search.Text = "Search";
			this.button_search.UseVisualStyleBackColor = true;
			this.button_search.Click += new System.EventHandler(this.Button_search_Click);
			// 
			// textBox_search
			// 
			this.textBox_search.Location = new System.Drawing.Point(6, 22);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(498, 23);
			this.textBox_search.TabIndex = 0;
			// 
			// groupBox_search
			// 
			this.groupBox_search.Controls.Add(this.radioButton_university);
			this.groupBox_search.Controls.Add(this.radioButton_department);
			this.groupBox_search.Controls.Add(this.radioButton_address);
			this.groupBox_search.Controls.Add(this.radioButton_factultyNum);
			this.groupBox_search.Controls.Add(this.radioButton_lastName);
			this.groupBox_search.Controls.Add(this.radioButton_firstName);
			this.groupBox_search.Location = new System.Drawing.Point(600, 13);
			this.groupBox_search.Name = "groupBox_search";
			this.groupBox_search.Size = new System.Drawing.Size(166, 531);
			this.groupBox_search.TabIndex = 2;
			this.groupBox_search.TabStop = false;
			this.groupBox_search.Text = "Search by";
			// 
			// radioButton_university
			// 
			this.radioButton_university.AutoSize = true;
			this.radioButton_university.Location = new System.Drawing.Point(6, 147);
			this.radioButton_university.Name = "radioButton_university";
			this.radioButton_university.Size = new System.Drawing.Size(77, 19);
			this.radioButton_university.TabIndex = 6;
			this.radioButton_university.Text = "University";
			this.radioButton_university.UseVisualStyleBackColor = true;
			// 
			// radioButton_department
			// 
			this.radioButton_department.AutoSize = true;
			this.radioButton_department.Location = new System.Drawing.Point(6, 122);
			this.radioButton_department.Name = "radioButton_department";
			this.radioButton_department.Size = new System.Drawing.Size(88, 19);
			this.radioButton_department.TabIndex = 5;
			this.radioButton_department.Text = "Department";
			this.radioButton_department.UseVisualStyleBackColor = true;
			// 
			// radioButton_address
			// 
			this.radioButton_address.AutoSize = true;
			this.radioButton_address.Location = new System.Drawing.Point(6, 97);
			this.radioButton_address.Name = "radioButton_address";
			this.radioButton_address.Size = new System.Drawing.Size(67, 19);
			this.radioButton_address.TabIndex = 4;
			this.radioButton_address.Text = "Address";
			this.radioButton_address.UseVisualStyleBackColor = true;
			// 
			// radioButton_factultyNum
			// 
			this.radioButton_factultyNum.AutoSize = true;
			this.radioButton_factultyNum.Location = new System.Drawing.Point(6, 72);
			this.radioButton_factultyNum.Name = "radioButton_factultyNum";
			this.radioButton_factultyNum.Size = new System.Drawing.Size(110, 19);
			this.radioButton_factultyNum.TabIndex = 3;
			this.radioButton_factultyNum.Text = "Faculty Number";
			this.radioButton_factultyNum.UseVisualStyleBackColor = true;
			// 
			// radioButton_lastName
			// 
			this.radioButton_lastName.AutoSize = true;
			this.radioButton_lastName.Location = new System.Drawing.Point(6, 47);
			this.radioButton_lastName.Name = "radioButton_lastName";
			this.radioButton_lastName.Size = new System.Drawing.Size(81, 19);
			this.radioButton_lastName.TabIndex = 2;
			this.radioButton_lastName.Text = "Last Name";
			this.radioButton_lastName.UseVisualStyleBackColor = true;
			// 
			// radioButton_firstName
			// 
			this.radioButton_firstName.AutoSize = true;
			this.radioButton_firstName.Checked = true;
			this.radioButton_firstName.Location = new System.Drawing.Point(6, 22);
			this.radioButton_firstName.Name = "radioButton_firstName";
			this.radioButton_firstName.Size = new System.Drawing.Size(82, 19);
			this.radioButton_firstName.TabIndex = 0;
			this.radioButton_firstName.TabStop = true;
			this.radioButton_firstName.Text = "First Name";
			this.radioButton_firstName.UseVisualStyleBackColor = true;
			// 
			// groupBox_add
			// 
			this.groupBox_add.Controls.Add(this.label_addPostition);
			this.groupBox_add.Controls.Add(this.textBox_addPosition);
			this.groupBox_add.Controls.Add(this.checkBox_addCity);
			this.groupBox_add.Controls.Add(this.comboBox_addCity);
			this.groupBox_add.Controls.Add(this.label_addCity);
			this.groupBox_add.Controls.Add(this.groupBox_addDepartment);
			this.groupBox_add.Controls.Add(this.label_addAddress);
			this.groupBox_add.Controls.Add(this.textBox_addAddress);
			this.groupBox_add.Controls.Add(this.label_addLastName);
			this.groupBox_add.Controls.Add(this.textBox_addLastName);
			this.groupBox_add.Controls.Add(this.comboBox_addUniversity);
			this.groupBox_add.Controls.Add(this.button_add);
			this.groupBox_add.Controls.Add(this.label_addUniversity);
			this.groupBox_add.Controls.Add(this.label_addFirstName);
			this.groupBox_add.Controls.Add(this.textBox_addFirstName);
			this.groupBox_add.Location = new System.Drawing.Point(772, 12);
			this.groupBox_add.Name = "groupBox_add";
			this.groupBox_add.Size = new System.Drawing.Size(480, 326);
			this.groupBox_add.TabIndex = 7;
			this.groupBox_add.TabStop = false;
			this.groupBox_add.Text = "Add Teacher";
			// 
			// label_addPostition
			// 
			this.label_addPostition.AutoSize = true;
			this.label_addPostition.Location = new System.Drawing.Point(6, 104);
			this.label_addPostition.Name = "label_addPostition";
			this.label_addPostition.Size = new System.Drawing.Size(55, 15);
			this.label_addPostition.TabIndex = 40;
			this.label_addPostition.Text = "Position*";
			// 
			// textBox_addPosition
			// 
			this.textBox_addPosition.Location = new System.Drawing.Point(80, 100);
			this.textBox_addPosition.Name = "textBox_addPosition";
			this.textBox_addPosition.Size = new System.Drawing.Size(189, 23);
			this.textBox_addPosition.TabIndex = 39;
			// 
			// checkBox_addCity
			// 
			this.checkBox_addCity.AutoSize = true;
			this.checkBox_addCity.Location = new System.Drawing.Point(194, 207);
			this.checkBox_addCity.Name = "checkBox_addCity";
			this.checkBox_addCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_addCity.Size = new System.Drawing.Size(75, 19);
			this.checkBox_addCity.TabIndex = 38;
			this.checkBox_addCity.Tag = "comboBox_addCity";
			this.checkBox_addCity.Text = "?Add city";
			this.checkBox_addCity.UseVisualStyleBackColor = true;
			this.checkBox_addCity.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
			// 
			// comboBox_addCity
			// 
			this.comboBox_addCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_addCity.Enabled = false;
			this.comboBox_addCity.FormattingEnabled = true;
			this.comboBox_addCity.Location = new System.Drawing.Point(80, 178);
			this.comboBox_addCity.Name = "comboBox_addCity";
			this.comboBox_addCity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_addCity.TabIndex = 37;
			// 
			// label_addCity
			// 
			this.label_addCity.AutoSize = true;
			this.label_addCity.Location = new System.Drawing.Point(6, 182);
			this.label_addCity.Name = "label_addCity";
			this.label_addCity.Size = new System.Drawing.Size(28, 15);
			this.label_addCity.TabIndex = 36;
			this.label_addCity.Text = "City";
			// 
			// groupBox_addDepartment
			// 
			this.groupBox_addDepartment.Controls.Add(this.checkedListBox_addDepartments);
			this.groupBox_addDepartment.Location = new System.Drawing.Point(280, 17);
			this.groupBox_addDepartment.Name = "groupBox_addDepartment";
			this.groupBox_addDepartment.Size = new System.Drawing.Size(194, 303);
			this.groupBox_addDepartment.TabIndex = 31;
			this.groupBox_addDepartment.TabStop = false;
			this.groupBox_addDepartment.Text = "Departments";
			// 
			// checkedListBox_addDepartments
			// 
			this.checkedListBox_addDepartments.CheckOnClick = true;
			this.checkedListBox_addDepartments.FormattingEnabled = true;
			this.checkedListBox_addDepartments.Location = new System.Drawing.Point(6, 22);
			this.checkedListBox_addDepartments.Name = "checkedListBox_addDepartments";
			this.checkedListBox_addDepartments.Size = new System.Drawing.Size(182, 274);
			this.checkedListBox_addDepartments.TabIndex = 20;
			// 
			// label_addAddress
			// 
			this.label_addAddress.AutoSize = true;
			this.label_addAddress.Location = new System.Drawing.Point(6, 143);
			this.label_addAddress.Name = "label_addAddress";
			this.label_addAddress.Size = new System.Drawing.Size(54, 15);
			this.label_addAddress.TabIndex = 30;
			this.label_addAddress.Text = "Address*";
			// 
			// textBox_addAddress
			// 
			this.textBox_addAddress.Location = new System.Drawing.Point(80, 139);
			this.textBox_addAddress.Name = "textBox_addAddress";
			this.textBox_addAddress.Size = new System.Drawing.Size(189, 23);
			this.textBox_addAddress.TabIndex = 26;
			// 
			// label_addLastName
			// 
			this.label_addLastName.AutoSize = true;
			this.label_addLastName.Location = new System.Drawing.Point(6, 65);
			this.label_addLastName.Name = "label_addLastName";
			this.label_addLastName.Size = new System.Drawing.Size(68, 15);
			this.label_addLastName.TabIndex = 22;
			this.label_addLastName.Text = "Last Name*";
			// 
			// textBox_addLastName
			// 
			this.textBox_addLastName.Location = new System.Drawing.Point(80, 61);
			this.textBox_addLastName.Name = "textBox_addLastName";
			this.textBox_addLastName.Size = new System.Drawing.Size(189, 23);
			this.textBox_addLastName.TabIndex = 21;
			// 
			// comboBox_addUniversity
			// 
			this.comboBox_addUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_addUniversity.FormattingEnabled = true;
			this.comboBox_addUniversity.Location = new System.Drawing.Point(80, 242);
			this.comboBox_addUniversity.Name = "comboBox_addUniversity";
			this.comboBox_addUniversity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_addUniversity.TabIndex = 19;
			this.comboBox_addUniversity.SelectedIndexChanged += new System.EventHandler(this.ComboBox_addUniversity_SelectedIndexChanged);
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(194, 297);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(80, 23);
			this.button_add.TabIndex = 1;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.Button_add_Click);
			// 
			// label_addUniversity
			// 
			this.label_addUniversity.AutoSize = true;
			this.label_addUniversity.Location = new System.Drawing.Point(6, 246);
			this.label_addUniversity.Name = "label_addUniversity";
			this.label_addUniversity.Size = new System.Drawing.Size(64, 15);
			this.label_addUniversity.TabIndex = 6;
			this.label_addUniversity.Text = "University*";
			// 
			// label_addFirstName
			// 
			this.label_addFirstName.AutoSize = true;
			this.label_addFirstName.Location = new System.Drawing.Point(6, 26);
			this.label_addFirstName.Name = "label_addFirstName";
			this.label_addFirstName.Size = new System.Drawing.Size(69, 15);
			this.label_addFirstName.TabIndex = 4;
			this.label_addFirstName.Text = "First Name*";
			// 
			// textBox_addFirstName
			// 
			this.textBox_addFirstName.Location = new System.Drawing.Point(80, 22);
			this.textBox_addFirstName.Name = "textBox_addFirstName";
			this.textBox_addFirstName.Size = new System.Drawing.Size(189, 23);
			this.textBox_addFirstName.TabIndex = 3;
			// 
			// groupBox_delete
			// 
			this.groupBox_delete.Controls.Add(this.button_delete);
			this.groupBox_delete.Location = new System.Drawing.Point(600, 613);
			this.groupBox_delete.Name = "groupBox_delete";
			this.groupBox_delete.Size = new System.Drawing.Size(166, 57);
			this.groupBox_delete.TabIndex = 3;
			this.groupBox_delete.TabStop = false;
			this.groupBox_delete.Text = "Delete Teacher";
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(25, 22);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(115, 23);
			this.button_delete.TabIndex = 0;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
			// 
			// groupBox_reset
			// 
			this.groupBox_reset.Controls.Add(this.button_reset);
			this.groupBox_reset.Location = new System.Drawing.Point(600, 550);
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
			this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
			// 
			// groupBox_edit
			// 
			this.groupBox_edit.Controls.Add(this.label_editPostition);
			this.groupBox_edit.Controls.Add(this.checkBox_editCity);
			this.groupBox_edit.Controls.Add(this.textBox_editPosition);
			this.groupBox_edit.Controls.Add(this.comboBox_editCity);
			this.groupBox_edit.Controls.Add(this.label_editCity);
			this.groupBox_edit.Controls.Add(this.groupBox_editDepartment);
			this.groupBox_edit.Controls.Add(this.label_editAddress);
			this.groupBox_edit.Controls.Add(this.textBox_editAddress);
			this.groupBox_edit.Controls.Add(this.label_editLastName);
			this.groupBox_edit.Controls.Add(this.textBox_editLastName);
			this.groupBox_edit.Controls.Add(this.comboBox_editUniversity);
			this.groupBox_edit.Controls.Add(this.button_edit);
			this.groupBox_edit.Controls.Add(this.label_editUniversity);
			this.groupBox_edit.Controls.Add(this.label_editFirstName);
			this.groupBox_edit.Controls.Add(this.textBox_editFirstName);
			this.groupBox_edit.Location = new System.Drawing.Point(772, 344);
			this.groupBox_edit.Name = "groupBox_edit";
			this.groupBox_edit.Size = new System.Drawing.Size(480, 326);
			this.groupBox_edit.TabIndex = 38;
			this.groupBox_edit.TabStop = false;
			this.groupBox_edit.Text = "Edit Teacher";
			// 
			// label_editPostition
			// 
			this.label_editPostition.AutoSize = true;
			this.label_editPostition.Location = new System.Drawing.Point(6, 104);
			this.label_editPostition.Name = "label_editPostition";
			this.label_editPostition.Size = new System.Drawing.Size(55, 15);
			this.label_editPostition.TabIndex = 42;
			this.label_editPostition.Text = "Position*";
			// 
			// checkBox_editCity
			// 
			this.checkBox_editCity.AutoSize = true;
			this.checkBox_editCity.Location = new System.Drawing.Point(194, 207);
			this.checkBox_editCity.Name = "checkBox_editCity";
			this.checkBox_editCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_editCity.Size = new System.Drawing.Size(75, 19);
			this.checkBox_editCity.TabIndex = 38;
			this.checkBox_editCity.Tag = "comboBox_editCity";
			this.checkBox_editCity.Text = "?Add city";
			this.checkBox_editCity.UseVisualStyleBackColor = true;
			this.checkBox_editCity.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
			// 
			// textBox_editPosition
			// 
			this.textBox_editPosition.Location = new System.Drawing.Point(80, 100);
			this.textBox_editPosition.Name = "textBox_editPosition";
			this.textBox_editPosition.Size = new System.Drawing.Size(189, 23);
			this.textBox_editPosition.TabIndex = 41;
			// 
			// comboBox_editCity
			// 
			this.comboBox_editCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_editCity.Enabled = false;
			this.comboBox_editCity.FormattingEnabled = true;
			this.comboBox_editCity.Location = new System.Drawing.Point(80, 178);
			this.comboBox_editCity.Name = "comboBox_editCity";
			this.comboBox_editCity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_editCity.TabIndex = 37;
			// 
			// label_editCity
			// 
			this.label_editCity.AutoSize = true;
			this.label_editCity.Location = new System.Drawing.Point(6, 182);
			this.label_editCity.Name = "label_editCity";
			this.label_editCity.Size = new System.Drawing.Size(28, 15);
			this.label_editCity.TabIndex = 36;
			this.label_editCity.Text = "City";
			// 
			// groupBox_editDepartment
			// 
			this.groupBox_editDepartment.Controls.Add(this.checkedListBox_editDepartments);
			this.groupBox_editDepartment.Location = new System.Drawing.Point(280, 17);
			this.groupBox_editDepartment.Name = "groupBox_editDepartment";
			this.groupBox_editDepartment.Size = new System.Drawing.Size(194, 303);
			this.groupBox_editDepartment.TabIndex = 31;
			this.groupBox_editDepartment.TabStop = false;
			this.groupBox_editDepartment.Text = "Departments";
			// 
			// checkedListBox_editDepartments
			// 
			this.checkedListBox_editDepartments.CheckOnClick = true;
			this.checkedListBox_editDepartments.FormattingEnabled = true;
			this.checkedListBox_editDepartments.Location = new System.Drawing.Point(6, 23);
			this.checkedListBox_editDepartments.Name = "checkedListBox_editDepartments";
			this.checkedListBox_editDepartments.Size = new System.Drawing.Size(182, 274);
			this.checkedListBox_editDepartments.TabIndex = 20;
			// 
			// label_editAddress
			// 
			this.label_editAddress.AutoSize = true;
			this.label_editAddress.Location = new System.Drawing.Point(6, 143);
			this.label_editAddress.Name = "label_editAddress";
			this.label_editAddress.Size = new System.Drawing.Size(54, 15);
			this.label_editAddress.TabIndex = 30;
			this.label_editAddress.Text = "Address*";
			// 
			// textBox_editAddress
			// 
			this.textBox_editAddress.Location = new System.Drawing.Point(80, 139);
			this.textBox_editAddress.Name = "textBox_editAddress";
			this.textBox_editAddress.Size = new System.Drawing.Size(189, 23);
			this.textBox_editAddress.TabIndex = 26;
			// 
			// label_editLastName
			// 
			this.label_editLastName.AutoSize = true;
			this.label_editLastName.Location = new System.Drawing.Point(6, 65);
			this.label_editLastName.Name = "label_editLastName";
			this.label_editLastName.Size = new System.Drawing.Size(68, 15);
			this.label_editLastName.TabIndex = 22;
			this.label_editLastName.Text = "Last Name*";
			// 
			// textBox_editLastName
			// 
			this.textBox_editLastName.Location = new System.Drawing.Point(80, 61);
			this.textBox_editLastName.Name = "textBox_editLastName";
			this.textBox_editLastName.Size = new System.Drawing.Size(189, 23);
			this.textBox_editLastName.TabIndex = 21;
			// 
			// comboBox_editUniversity
			// 
			this.comboBox_editUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_editUniversity.FormattingEnabled = true;
			this.comboBox_editUniversity.Location = new System.Drawing.Point(80, 242);
			this.comboBox_editUniversity.Name = "comboBox_editUniversity";
			this.comboBox_editUniversity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_editUniversity.TabIndex = 19;
			this.comboBox_editUniversity.SelectedIndexChanged += new System.EventHandler(this.ComboBox_editUniversity_SelectedIndexChanged);
			// 
			// button_edit
			// 
			this.button_edit.Location = new System.Drawing.Point(194, 297);
			this.button_edit.Name = "button_edit";
			this.button_edit.Size = new System.Drawing.Size(80, 23);
			this.button_edit.TabIndex = 1;
			this.button_edit.Text = "Edit";
			this.button_edit.UseVisualStyleBackColor = true;
			this.button_edit.Click += new System.EventHandler(this.Button_edit_Click);
			// 
			// label_editUniversity
			// 
			this.label_editUniversity.AutoSize = true;
			this.label_editUniversity.Location = new System.Drawing.Point(6, 246);
			this.label_editUniversity.Name = "label_editUniversity";
			this.label_editUniversity.Size = new System.Drawing.Size(59, 15);
			this.label_editUniversity.TabIndex = 6;
			this.label_editUniversity.Text = "University";
			// 
			// label_editFirstName
			// 
			this.label_editFirstName.AutoSize = true;
			this.label_editFirstName.Location = new System.Drawing.Point(6, 26);
			this.label_editFirstName.Name = "label_editFirstName";
			this.label_editFirstName.Size = new System.Drawing.Size(69, 15);
			this.label_editFirstName.TabIndex = 4;
			this.label_editFirstName.Text = "First Name*";
			// 
			// textBox_editFirstName
			// 
			this.textBox_editFirstName.Location = new System.Drawing.Point(80, 22);
			this.textBox_editFirstName.Name = "textBox_editFirstName";
			this.textBox_editFirstName.Size = new System.Drawing.Size(189, 23);
			this.textBox_editFirstName.TabIndex = 3;
			// 
			// TeachersWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.groupBox_edit);
			this.Controls.Add(this.groupBox_reset);
			this.Controls.Add(this.groupBox_delete);
			this.Controls.Add(this.groupBox_add);
			this.Controls.Add(this.groupBox_search);
			this.Controls.Add(this.groupBox_table);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "TeachersWindow";
			this.Text = "Teachers Manager";
			this.groupBox_table.ResumeLayout(false);
			this.groupBox_table.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_teachers)).EndInit();
			this.groupBox_search.ResumeLayout(false);
			this.groupBox_search.PerformLayout();
			this.groupBox_add.ResumeLayout(false);
			this.groupBox_add.PerformLayout();
			this.groupBox_addDepartment.ResumeLayout(false);
			this.groupBox_delete.ResumeLayout(false);
			this.groupBox_reset.ResumeLayout(false);
			this.groupBox_edit.ResumeLayout(false);
			this.groupBox_edit.PerformLayout();
			this.groupBox_editDepartment.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox_table;
		private GroupBox groupBox_search;
		private GroupBox groupBox_add;
		private GroupBox groupBox_delete;
		private Button button_delete;
		private GroupBox groupBox_reset;
		private Button button_reset;
		private Button button_search;
		private TextBox textBox_search;
		private DataGridView dataGridView_teachers;
		private RadioButton radioButton_factultyNum;
		private RadioButton radioButton_lastName;
		private RadioButton radioButton_firstName;
		private CheckedListBox checkedListBox_addDepartments;
		private ComboBox comboBox_addUniversity;
		private Button button_add;
		private Label label_addUniversity;
		private Label label_addFirstName;
		private TextBox textBox_addFirstName;
		private RadioButton radioButton_department;
		private RadioButton radioButton_address;
		private RadioButton radioButton_university;
		private Label label_addLastName;
		private TextBox textBox_addLastName;
		private TextBox textBox_addAddress;
		private Label label_addAddress;
		private GroupBox groupBox_addDepartment;
		private ComboBox comboBox_addCity;
		private Label label_addCity;
		private GroupBox groupBox_edit;
		private ComboBox comboBox_editCity;
		private Label label_editCity;
		private GroupBox groupBox_editDepartment;
		private CheckedListBox checkedListBox_editDepartments;
		private Label label_editAddress;
		private TextBox textBox_editAddress;
		private Label label_editLastName;
		private TextBox textBox_editLastName;
		private ComboBox comboBox_editUniversity;
		private Button button_edit;
		private Label label_editUniversity;
		private Label label_editFirstName;
		private TextBox textBox_editFirstName;
		private CheckBox checkBox_addCity;
		private CheckBox checkBox_editCity;
		private Label label_addPostition;
		private TextBox textBox_addPosition;
		private Label label_editPostition;
		private TextBox textBox_editPosition;
	}
}