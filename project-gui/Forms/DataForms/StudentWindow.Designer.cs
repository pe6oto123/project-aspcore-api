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
			this.dataGridView_students = new System.Windows.Forms.DataGridView();
			this.button_search = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.groupBox_search = new System.Windows.Forms.GroupBox();
			this.radioButton_university = new System.Windows.Forms.RadioButton();
			this.radioButton_department = new System.Windows.Forms.RadioButton();
			this.radioButton_address = new System.Windows.Forms.RadioButton();
			this.radioButton_factultyNum = new System.Windows.Forms.RadioButton();
			this.radioButton_lastName = new System.Windows.Forms.RadioButton();
			this.radioButton_firstName = new System.Windows.Forms.RadioButton();
			this.groupBox_addStudent = new System.Windows.Forms.GroupBox();
			this.comboBox_addCity = new System.Windows.Forms.ComboBox();
			this.label_addCity = new System.Windows.Forms.Label();
			this.checkBox_addDepartment = new System.Windows.Forms.CheckBox();
			this.comboBox_addDepartment = new System.Windows.Forms.ComboBox();
			this.label_addDepartment = new System.Windows.Forms.Label();
			this.groupBox_addSubjects = new System.Windows.Forms.GroupBox();
			this.checkedListBox_addSubjects = new System.Windows.Forms.CheckedListBox();
			this.label_addAddress = new System.Windows.Forms.Label();
			this.label_addDate = new System.Windows.Forms.Label();
			this.textBox_addAddress = new System.Windows.Forms.TextBox();
			this.dateTimePicker_addDate = new System.Windows.Forms.DateTimePicker();
			this.label_addLastName = new System.Windows.Forms.Label();
			this.textBox_addLastName = new System.Windows.Forms.TextBox();
			this.checkBox_addUniversity = new System.Windows.Forms.CheckBox();
			this.comboBox_addUniversity = new System.Windows.Forms.ComboBox();
			this.button_add = new System.Windows.Forms.Button();
			this.label_addUniversity = new System.Windows.Forms.Label();
			this.label_addFirstName = new System.Windows.Forms.Label();
			this.textBox_addFirstName = new System.Windows.Forms.TextBox();
			this.groupBox_delete = new System.Windows.Forms.GroupBox();
			this.button_delete = new System.Windows.Forms.Button();
			this.groupBox_reset = new System.Windows.Forms.GroupBox();
			this.button_reset = new System.Windows.Forms.Button();
			this.groupBox_editStudent = new System.Windows.Forms.GroupBox();
			this.comboBox_editCity = new System.Windows.Forms.ComboBox();
			this.label_editCity = new System.Windows.Forms.Label();
			this.checkBox_editDepartment = new System.Windows.Forms.CheckBox();
			this.comboBox_editDepartment = new System.Windows.Forms.ComboBox();
			this.label_editDepartment = new System.Windows.Forms.Label();
			this.groupBox_editSubjects = new System.Windows.Forms.GroupBox();
			this.checkedListBox_editSubjects = new System.Windows.Forms.CheckedListBox();
			this.label_editAddress = new System.Windows.Forms.Label();
			this.label_editDate = new System.Windows.Forms.Label();
			this.textBox_editAddress = new System.Windows.Forms.TextBox();
			this.dateTimePicker_editDate = new System.Windows.Forms.DateTimePicker();
			this.label_editLastName = new System.Windows.Forms.Label();
			this.textBox_editLastName = new System.Windows.Forms.TextBox();
			this.checkBox_editUniversity = new System.Windows.Forms.CheckBox();
			this.comboBox_editUniversity = new System.Windows.Forms.ComboBox();
			this.button_edit = new System.Windows.Forms.Button();
			this.label_editUniversity = new System.Windows.Forms.Label();
			this.label_editFirstName = new System.Windows.Forms.Label();
			this.textBox_editFirstName = new System.Windows.Forms.TextBox();
			this.groupBox_table.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
			this.groupBox_search.SuspendLayout();
			this.groupBox_addStudent.SuspendLayout();
			this.groupBox_addSubjects.SuspendLayout();
			this.groupBox_delete.SuspendLayout();
			this.groupBox_reset.SuspendLayout();
			this.groupBox_editStudent.SuspendLayout();
			this.groupBox_editSubjects.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_table
			// 
			this.groupBox_table.Controls.Add(this.dataGridView_students);
			this.groupBox_table.Controls.Add(this.button_search);
			this.groupBox_table.Controls.Add(this.textBox_search);
			this.groupBox_table.Location = new System.Drawing.Point(12, 12);
			this.groupBox_table.Name = "groupBox_table";
			this.groupBox_table.Size = new System.Drawing.Size(582, 657);
			this.groupBox_table.TabIndex = 0;
			this.groupBox_table.TabStop = false;
			this.groupBox_table.Text = "Students";
			// 
			// dataGridView_students
			// 
			this.dataGridView_students.AllowUserToAddRows = false;
			this.dataGridView_students.AllowUserToDeleteRows = false;
			this.dataGridView_students.AllowUserToResizeColumns = false;
			this.dataGridView_students.AllowUserToResizeRows = false;
			this.dataGridView_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_students.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_students.Location = new System.Drawing.Point(6, 51);
			this.dataGridView_students.Name = "dataGridView_students";
			this.dataGridView_students.RowHeadersVisible = false;
			this.dataGridView_students.RowTemplate.Height = 25;
			this.dataGridView_students.Size = new System.Drawing.Size(570, 600);
			this.dataGridView_students.TabIndex = 2;
			// 
			// button_search
			// 
			this.button_search.Location = new System.Drawing.Point(510, 21);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(66, 23);
			this.button_search.TabIndex = 1;
			this.button_search.Text = "Search";
			this.button_search.UseVisualStyleBackColor = true;
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
			// groupBox_addStudent
			// 
			this.groupBox_addStudent.Controls.Add(this.comboBox_addCity);
			this.groupBox_addStudent.Controls.Add(this.label_addCity);
			this.groupBox_addStudent.Controls.Add(this.checkBox_addDepartment);
			this.groupBox_addStudent.Controls.Add(this.comboBox_addDepartment);
			this.groupBox_addStudent.Controls.Add(this.label_addDepartment);
			this.groupBox_addStudent.Controls.Add(this.groupBox_addSubjects);
			this.groupBox_addStudent.Controls.Add(this.label_addAddress);
			this.groupBox_addStudent.Controls.Add(this.label_addDate);
			this.groupBox_addStudent.Controls.Add(this.textBox_addAddress);
			this.groupBox_addStudent.Controls.Add(this.dateTimePicker_addDate);
			this.groupBox_addStudent.Controls.Add(this.label_addLastName);
			this.groupBox_addStudent.Controls.Add(this.textBox_addLastName);
			this.groupBox_addStudent.Controls.Add(this.checkBox_addUniversity);
			this.groupBox_addStudent.Controls.Add(this.comboBox_addUniversity);
			this.groupBox_addStudent.Controls.Add(this.button_add);
			this.groupBox_addStudent.Controls.Add(this.label_addUniversity);
			this.groupBox_addStudent.Controls.Add(this.label_addFirstName);
			this.groupBox_addStudent.Controls.Add(this.textBox_addFirstName);
			this.groupBox_addStudent.Location = new System.Drawing.Point(772, 12);
			this.groupBox_addStudent.Name = "groupBox_addStudent";
			this.groupBox_addStudent.Size = new System.Drawing.Size(480, 326);
			this.groupBox_addStudent.TabIndex = 7;
			this.groupBox_addStudent.TabStop = false;
			this.groupBox_addStudent.Text = "Add Student";
			// 
			// comboBox_addCity
			// 
			this.comboBox_addCity.FormattingEnabled = true;
			this.comboBox_addCity.Location = new System.Drawing.Point(80, 109);
			this.comboBox_addCity.Name = "comboBox_addCity";
			this.comboBox_addCity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_addCity.TabIndex = 37;
			// 
			// label_addCity
			// 
			this.label_addCity.AutoSize = true;
			this.label_addCity.Location = new System.Drawing.Point(6, 113);
			this.label_addCity.Name = "label_addCity";
			this.label_addCity.Size = new System.Drawing.Size(28, 15);
			this.label_addCity.TabIndex = 36;
			this.label_addCity.Text = "City";
			// 
			// checkBox_addDepartment
			// 
			this.checkBox_addDepartment.AutoSize = true;
			this.checkBox_addDepartment.Location = new System.Drawing.Point(89, 272);
			this.checkBox_addDepartment.Name = "checkBox_addDepartment";
			this.checkBox_addDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_addDepartment.Size = new System.Drawing.Size(180, 19);
			this.checkBox_addDepartment.TabIndex = 34;
			this.checkBox_addDepartment.Text = "?Is the student in department";
			this.checkBox_addDepartment.UseVisualStyleBackColor = true;
			// 
			// comboBox_addDepartment
			// 
			this.comboBox_addDepartment.FormattingEnabled = true;
			this.comboBox_addDepartment.Location = new System.Drawing.Point(80, 242);
			this.comboBox_addDepartment.Name = "comboBox_addDepartment";
			this.comboBox_addDepartment.Size = new System.Drawing.Size(189, 23);
			this.comboBox_addDepartment.TabIndex = 33;
			// 
			// label_addDepartment
			// 
			this.label_addDepartment.AutoSize = true;
			this.label_addDepartment.Location = new System.Drawing.Point(6, 245);
			this.label_addDepartment.Name = "label_addDepartment";
			this.label_addDepartment.Size = new System.Drawing.Size(70, 15);
			this.label_addDepartment.TabIndex = 32;
			this.label_addDepartment.Text = "Department";
			// 
			// groupBox_addSubjects
			// 
			this.groupBox_addSubjects.Controls.Add(this.checkedListBox_addSubjects);
			this.groupBox_addSubjects.Location = new System.Drawing.Point(280, 17);
			this.groupBox_addSubjects.Name = "groupBox_addSubjects";
			this.groupBox_addSubjects.Size = new System.Drawing.Size(194, 303);
			this.groupBox_addSubjects.TabIndex = 31;
			this.groupBox_addSubjects.TabStop = false;
			this.groupBox_addSubjects.Text = "Subjects";
			// 
			// checkedListBox_addSubjects
			// 
			this.checkedListBox_addSubjects.FormattingEnabled = true;
			this.checkedListBox_addSubjects.Location = new System.Drawing.Point(6, 22);
			this.checkedListBox_addSubjects.Name = "checkedListBox_addSubjects";
			this.checkedListBox_addSubjects.Size = new System.Drawing.Size(182, 274);
			this.checkedListBox_addSubjects.TabIndex = 20;
			// 
			// label_addAddress
			// 
			this.label_addAddress.AutoSize = true;
			this.label_addAddress.Location = new System.Drawing.Point(6, 84);
			this.label_addAddress.Name = "label_addAddress";
			this.label_addAddress.Size = new System.Drawing.Size(54, 15);
			this.label_addAddress.TabIndex = 30;
			this.label_addAddress.Text = "Address*";
			// 
			// label_addDate
			// 
			this.label_addDate.AutoSize = true;
			this.label_addDate.Location = new System.Drawing.Point(7, 207);
			this.label_addDate.Name = "label_addDate";
			this.label_addDate.Size = new System.Drawing.Size(94, 15);
			this.label_addDate.TabIndex = 29;
			this.label_addDate.Text = "Enrolment Date*";
			// 
			// textBox_addAddress
			// 
			this.textBox_addAddress.Location = new System.Drawing.Point(80, 80);
			this.textBox_addAddress.Name = "textBox_addAddress";
			this.textBox_addAddress.Size = new System.Drawing.Size(189, 23);
			this.textBox_addAddress.TabIndex = 26;
			// 
			// dateTimePicker_addDate
			// 
			this.dateTimePicker_addDate.Location = new System.Drawing.Point(107, 203);
			this.dateTimePicker_addDate.Name = "dateTimePicker_addDate";
			this.dateTimePicker_addDate.Size = new System.Drawing.Size(162, 23);
			this.dateTimePicker_addDate.TabIndex = 23;
			// 
			// label_addLastName
			// 
			this.label_addLastName.AutoSize = true;
			this.label_addLastName.Location = new System.Drawing.Point(6, 55);
			this.label_addLastName.Name = "label_addLastName";
			this.label_addLastName.Size = new System.Drawing.Size(68, 15);
			this.label_addLastName.TabIndex = 22;
			this.label_addLastName.Text = "Last Name*";
			// 
			// textBox_addLastName
			// 
			this.textBox_addLastName.Location = new System.Drawing.Point(80, 51);
			this.textBox_addLastName.Name = "textBox_addLastName";
			this.textBox_addLastName.Size = new System.Drawing.Size(189, 23);
			this.textBox_addLastName.TabIndex = 21;
			// 
			// checkBox_addUniversity
			// 
			this.checkBox_addUniversity.AutoSize = true;
			this.checkBox_addUniversity.Location = new System.Drawing.Point(144, 168);
			this.checkBox_addUniversity.Name = "checkBox_addUniversity";
			this.checkBox_addUniversity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_addUniversity.Size = new System.Drawing.Size(125, 19);
			this.checkBox_addUniversity.TabIndex = 19;
			this.checkBox_addUniversity.Text = "?Is student enroled";
			this.checkBox_addUniversity.UseVisualStyleBackColor = true;
			// 
			// comboBox_addUniversity
			// 
			this.comboBox_addUniversity.FormattingEnabled = true;
			this.comboBox_addUniversity.Location = new System.Drawing.Point(80, 139);
			this.comboBox_addUniversity.Name = "comboBox_addUniversity";
			this.comboBox_addUniversity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_addUniversity.TabIndex = 19;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(194, 297);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(80, 23);
			this.button_add.TabIndex = 1;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			// 
			// label_addUniversity
			// 
			this.label_addUniversity.AutoSize = true;
			this.label_addUniversity.Location = new System.Drawing.Point(6, 142);
			this.label_addUniversity.Name = "label_addUniversity";
			this.label_addUniversity.Size = new System.Drawing.Size(59, 15);
			this.label_addUniversity.TabIndex = 6;
			this.label_addUniversity.Text = "University";
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
			this.groupBox_delete.Text = "Delete Student";
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(25, 22);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(115, 23);
			this.button_delete.TabIndex = 0;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
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
			// 
			// groupBox_editStudent
			// 
			this.groupBox_editStudent.Controls.Add(this.comboBox_editCity);
			this.groupBox_editStudent.Controls.Add(this.label_editCity);
			this.groupBox_editStudent.Controls.Add(this.checkBox_editDepartment);
			this.groupBox_editStudent.Controls.Add(this.comboBox_editDepartment);
			this.groupBox_editStudent.Controls.Add(this.label_editDepartment);
			this.groupBox_editStudent.Controls.Add(this.groupBox_editSubjects);
			this.groupBox_editStudent.Controls.Add(this.label_editAddress);
			this.groupBox_editStudent.Controls.Add(this.label_editDate);
			this.groupBox_editStudent.Controls.Add(this.textBox_editAddress);
			this.groupBox_editStudent.Controls.Add(this.dateTimePicker_editDate);
			this.groupBox_editStudent.Controls.Add(this.label_editLastName);
			this.groupBox_editStudent.Controls.Add(this.textBox_editLastName);
			this.groupBox_editStudent.Controls.Add(this.checkBox_editUniversity);
			this.groupBox_editStudent.Controls.Add(this.comboBox_editUniversity);
			this.groupBox_editStudent.Controls.Add(this.button_edit);
			this.groupBox_editStudent.Controls.Add(this.label_editUniversity);
			this.groupBox_editStudent.Controls.Add(this.label_editFirstName);
			this.groupBox_editStudent.Controls.Add(this.textBox_editFirstName);
			this.groupBox_editStudent.Location = new System.Drawing.Point(772, 344);
			this.groupBox_editStudent.Name = "groupBox_editStudent";
			this.groupBox_editStudent.Size = new System.Drawing.Size(480, 326);
			this.groupBox_editStudent.TabIndex = 35;
			this.groupBox_editStudent.TabStop = false;
			this.groupBox_editStudent.Text = "Edit Student";
			// 
			// comboBox_editCity
			// 
			this.comboBox_editCity.FormattingEnabled = true;
			this.comboBox_editCity.Location = new System.Drawing.Point(80, 109);
			this.comboBox_editCity.Name = "comboBox_editCity";
			this.comboBox_editCity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_editCity.TabIndex = 39;
			// 
			// label_editCity
			// 
			this.label_editCity.AutoSize = true;
			this.label_editCity.Location = new System.Drawing.Point(6, 113);
			this.label_editCity.Name = "label_editCity";
			this.label_editCity.Size = new System.Drawing.Size(28, 15);
			this.label_editCity.TabIndex = 38;
			this.label_editCity.Text = "City";
			// 
			// checkBox_editDepartment
			// 
			this.checkBox_editDepartment.AutoSize = true;
			this.checkBox_editDepartment.Location = new System.Drawing.Point(89, 271);
			this.checkBox_editDepartment.Name = "checkBox_editDepartment";
			this.checkBox_editDepartment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_editDepartment.Size = new System.Drawing.Size(180, 19);
			this.checkBox_editDepartment.TabIndex = 34;
			this.checkBox_editDepartment.Text = "?Is the student in department";
			this.checkBox_editDepartment.UseVisualStyleBackColor = true;
			// 
			// comboBox_editDepartment
			// 
			this.comboBox_editDepartment.FormattingEnabled = true;
			this.comboBox_editDepartment.Location = new System.Drawing.Point(80, 242);
			this.comboBox_editDepartment.Name = "comboBox_editDepartment";
			this.comboBox_editDepartment.Size = new System.Drawing.Size(189, 23);
			this.comboBox_editDepartment.TabIndex = 33;
			// 
			// label_editDepartment
			// 
			this.label_editDepartment.AutoSize = true;
			this.label_editDepartment.Location = new System.Drawing.Point(6, 245);
			this.label_editDepartment.Name = "label_editDepartment";
			this.label_editDepartment.Size = new System.Drawing.Size(70, 15);
			this.label_editDepartment.TabIndex = 32;
			this.label_editDepartment.Text = "Department";
			// 
			// groupBox_editSubjects
			// 
			this.groupBox_editSubjects.Controls.Add(this.checkedListBox_editSubjects);
			this.groupBox_editSubjects.Location = new System.Drawing.Point(280, 17);
			this.groupBox_editSubjects.Name = "groupBox_editSubjects";
			this.groupBox_editSubjects.Size = new System.Drawing.Size(194, 303);
			this.groupBox_editSubjects.TabIndex = 31;
			this.groupBox_editSubjects.TabStop = false;
			this.groupBox_editSubjects.Text = "Subjects";
			// 
			// checkedListBox_editSubjects
			// 
			this.checkedListBox_editSubjects.FormattingEnabled = true;
			this.checkedListBox_editSubjects.Location = new System.Drawing.Point(6, 22);
			this.checkedListBox_editSubjects.Name = "checkedListBox_editSubjects";
			this.checkedListBox_editSubjects.Size = new System.Drawing.Size(182, 274);
			this.checkedListBox_editSubjects.TabIndex = 20;
			// 
			// label_editAddress
			// 
			this.label_editAddress.AutoSize = true;
			this.label_editAddress.Location = new System.Drawing.Point(6, 84);
			this.label_editAddress.Name = "label_editAddress";
			this.label_editAddress.Size = new System.Drawing.Size(54, 15);
			this.label_editAddress.TabIndex = 30;
			this.label_editAddress.Text = "Address*";
			// 
			// label_editDate
			// 
			this.label_editDate.AutoSize = true;
			this.label_editDate.Location = new System.Drawing.Point(7, 207);
			this.label_editDate.Name = "label_editDate";
			this.label_editDate.Size = new System.Drawing.Size(94, 15);
			this.label_editDate.TabIndex = 29;
			this.label_editDate.Text = "Enrolment Date*";
			// 
			// textBox_editAddress
			// 
			this.textBox_editAddress.Location = new System.Drawing.Point(80, 80);
			this.textBox_editAddress.Name = "textBox_editAddress";
			this.textBox_editAddress.Size = new System.Drawing.Size(189, 23);
			this.textBox_editAddress.TabIndex = 26;
			// 
			// dateTimePicker_editDate
			// 
			this.dateTimePicker_editDate.Location = new System.Drawing.Point(107, 203);
			this.dateTimePicker_editDate.Name = "dateTimePicker_editDate";
			this.dateTimePicker_editDate.Size = new System.Drawing.Size(162, 23);
			this.dateTimePicker_editDate.TabIndex = 23;
			// 
			// label_editLastName
			// 
			this.label_editLastName.AutoSize = true;
			this.label_editLastName.Location = new System.Drawing.Point(6, 55);
			this.label_editLastName.Name = "label_editLastName";
			this.label_editLastName.Size = new System.Drawing.Size(68, 15);
			this.label_editLastName.TabIndex = 22;
			this.label_editLastName.Text = "Last Name*";
			// 
			// textBox_editLastName
			// 
			this.textBox_editLastName.Location = new System.Drawing.Point(80, 51);
			this.textBox_editLastName.Name = "textBox_editLastName";
			this.textBox_editLastName.Size = new System.Drawing.Size(189, 23);
			this.textBox_editLastName.TabIndex = 21;
			// 
			// checkBox_editUniversity
			// 
			this.checkBox_editUniversity.AutoSize = true;
			this.checkBox_editUniversity.Location = new System.Drawing.Point(144, 168);
			this.checkBox_editUniversity.Name = "checkBox_editUniversity";
			this.checkBox_editUniversity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_editUniversity.Size = new System.Drawing.Size(125, 19);
			this.checkBox_editUniversity.TabIndex = 19;
			this.checkBox_editUniversity.Text = "?Is student enroled";
			this.checkBox_editUniversity.UseVisualStyleBackColor = true;
			// 
			// comboBox_editUniversity
			// 
			this.comboBox_editUniversity.FormattingEnabled = true;
			this.comboBox_editUniversity.Location = new System.Drawing.Point(80, 139);
			this.comboBox_editUniversity.Name = "comboBox_editUniversity";
			this.comboBox_editUniversity.Size = new System.Drawing.Size(189, 23);
			this.comboBox_editUniversity.TabIndex = 19;
			// 
			// button_edit
			// 
			this.button_edit.Location = new System.Drawing.Point(194, 297);
			this.button_edit.Name = "button_edit";
			this.button_edit.Size = new System.Drawing.Size(80, 23);
			this.button_edit.TabIndex = 1;
			this.button_edit.Text = "Edit";
			this.button_edit.UseVisualStyleBackColor = true;
			// 
			// label_editUniversity
			// 
			this.label_editUniversity.AutoSize = true;
			this.label_editUniversity.Location = new System.Drawing.Point(6, 142);
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
			this.Controls.Add(this.groupBox_editStudent);
			this.Controls.Add(this.groupBox_reset);
			this.Controls.Add(this.groupBox_delete);
			this.Controls.Add(this.groupBox_addStudent);
			this.Controls.Add(this.groupBox_search);
			this.Controls.Add(this.groupBox_table);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "TeachersWindow";
			this.Text = "Students Manager";
			this.groupBox_table.ResumeLayout(false);
			this.groupBox_table.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
			this.groupBox_search.ResumeLayout(false);
			this.groupBox_search.PerformLayout();
			this.groupBox_addStudent.ResumeLayout(false);
			this.groupBox_addStudent.PerformLayout();
			this.groupBox_addSubjects.ResumeLayout(false);
			this.groupBox_delete.ResumeLayout(false);
			this.groupBox_reset.ResumeLayout(false);
			this.groupBox_editStudent.ResumeLayout(false);
			this.groupBox_editStudent.PerformLayout();
			this.groupBox_editSubjects.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox_table;
		private GroupBox groupBox_search;
		private GroupBox groupBox_addStudent;
		private GroupBox groupBox_delete;
		private Button button_delete;
		private GroupBox groupBox_reset;
		private Button button_reset;
		private Button button_search;
		private TextBox textBox_search;
		private DataGridView dataGridView_students;
		private RadioButton radioButton_factultyNum;
		private RadioButton radioButton_lastName;
		private RadioButton radioButton_firstName;
		private CheckedListBox checkedListBox_addSubjects;
		private CheckBox checkBox_addUniversity;
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
		private DateTimePicker dateTimePicker_addDate;
		private TextBox textBox_addAddress;
		private Label label_addDate;
		private Label label_addAddress;
		private GroupBox groupBox_addSubjects;
		private CheckBox checkBox_addDepartment;
		private ComboBox comboBox_addDepartment;
		private Label label_addDepartment;
		private GroupBox groupBox_editStudent;
		private CheckBox checkBox_editDepartment;
		private ComboBox comboBox_editDepartment;
		private Label label_editDepartment;
		private GroupBox groupBox_editSubjects;
		private CheckedListBox checkedListBox_editSubjects;
		private Label label_editAddress;
		private Label label_editDate;
		private TextBox textBox_editAddress;
		private DateTimePicker dateTimePicker_editDate;
		private Label label_editLastName;
		private TextBox textBox_editLastName;
		private CheckBox checkBox_editUniversity;
		private ComboBox comboBox_editUniversity;
		private Button button_edit;
		private Label label_editUniversity;
		private Label label_editFirstName;
		private TextBox textBox_editFirstName;
		private ComboBox comboBox_addCity;
		private Label label_addCity;
		private ComboBox comboBox_editCity;
		private Label label_editCity;
	}
}