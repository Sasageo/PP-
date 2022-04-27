
namespace Dance
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxGroupOrDance = new System.Windows.Forms.ComboBox();
            this.видыТанцевBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDanceDataSet = new Dance.SchoolDanceDataSet();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelGroupOrDance = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteId = new System.Windows.Forms.Button();
            this.dataGridViewTS = new System.Windows.Forms.DataGridView();
            this.кодПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студПрепBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelErrorDance = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.comboBoxDanceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCountStudent = new System.Windows.Forms.TextBox();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.виды_танцевTableAdapter = new Dance.SchoolDanceDataSetTableAdapters.Виды_танцевTableAdapter();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new Dance.SchoolDanceDataSetTableAdapters.ГруппыTableAdapter();
            this.студПрепTableAdapter = new Dance.SchoolDanceDataSetTableAdapters.СтудПрепTableAdapter();
            this.fKГруппыВидыТанцевBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыТанцевBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDanceDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студПрепBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKГруппыВидыТанцевBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(547, 276);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboBoxGroupOrDance);
            this.tabPage1.Controls.Add(this.labelError);
            this.tabPage1.Controls.Add(this.buttonInsert);
            this.tabPage1.Controls.Add(this.labelGroupOrDance);
            this.tabPage1.Controls.Add(this.textBoxPassword);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxLogin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxFIO);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxRole);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxGroupOrDance
            // 
            this.comboBoxGroupOrDance.DataSource = this.видыТанцевBindingSource;
            this.comboBoxGroupOrDance.DisplayMember = "Название";
            this.comboBoxGroupOrDance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroupOrDance.FormattingEnabled = true;
            this.comboBoxGroupOrDance.Location = new System.Drawing.Point(140, 130);
            this.comboBoxGroupOrDance.MaxLength = 10;
            this.comboBoxGroupOrDance.Name = "comboBoxGroupOrDance";
            this.comboBoxGroupOrDance.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGroupOrDance.TabIndex = 13;
            this.comboBoxGroupOrDance.ValueMember = "Код";
            // 
            // видыТанцевBindingSource
            // 
            this.видыТанцевBindingSource.DataMember = "Виды танцев";
            this.видыТанцевBindingSource.DataSource = this.schoolDanceDataSet;
            // 
            // schoolDanceDataSet
            // 
            this.schoolDanceDataSet.DataSetName = "SchoolDanceDataSet";
            this.schoolDanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(119, 167);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 12;
            // 
            // buttonInsert
            // 
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(112, 183);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(169, 43);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelGroupOrDance
            // 
            this.labelGroupOrDance.AutoSize = true;
            this.labelGroupOrDance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupOrDance.Location = new System.Drawing.Point(6, 133);
            this.labelGroupOrDance.Name = "labelGroupOrDance";
            this.labelGroupOrDance.Size = new System.Drawing.Size(100, 15);
            this.labelGroupOrDance.TabIndex = 8;
            this.labelGroupOrDance.Text = "Учебная группа:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(140, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(55, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(140, 52);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(121, 22);
            this.textBoxLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(140, 104);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(121, 22);
            this.textBoxFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Роль:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.comboBoxRole.Location = new System.Drawing.Point(140, 25);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 0;
            this.comboBoxRole.Text = "Teacher";
            this.comboBoxRole.TextChanged += new System.EventHandler(this.comboBoxRole_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.textBoxId);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonDeleteId);
            this.tabPage2.Controls.Add(this.dataGridViewTS);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удалить пользователя";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(50, 132);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id:";
            // 
            // buttonDeleteId
            // 
            this.buttonDeleteId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteId.Location = new System.Drawing.Point(31, 169);
            this.buttonDeleteId.Name = "buttonDeleteId";
            this.buttonDeleteId.Size = new System.Drawing.Size(131, 40);
            this.buttonDeleteId.TabIndex = 1;
            this.buttonDeleteId.Text = "Удалить";
            this.buttonDeleteId.UseVisualStyleBackColor = true;
            this.buttonDeleteId.Click += new System.EventHandler(this.buttonDeleteId_Click);
            // 
            // dataGridViewTS
            // 
            this.dataGridViewTS.AutoGenerateColumns = false;
            this.dataGridViewTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПользователяDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn});
            this.dataGridViewTS.DataSource = this.студПрепBindingSource;
            this.dataGridViewTS.Location = new System.Drawing.Point(186, 6);
            this.dataGridViewTS.Name = "dataGridViewTS";
            this.dataGridViewTS.ReadOnly = true;
            this.dataGridViewTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewTS.Size = new System.Drawing.Size(347, 238);
            this.dataGridViewTS.TabIndex = 0;
            // 
            // кодПользователяDataGridViewTextBoxColumn
            // 
            this.кодПользователяDataGridViewTextBoxColumn.DataPropertyName = "Код пользователя";
            this.кодПользователяDataGridViewTextBoxColumn.HeaderText = "Код пользователя";
            this.кодПользователяDataGridViewTextBoxColumn.Name = "кодПользователяDataGridViewTextBoxColumn";
            this.кодПользователяDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПользователяDataGridViewTextBoxColumn.Width = 117;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 60;
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            this.рольDataGridViewTextBoxColumn.ReadOnly = true;
            this.рольDataGridViewTextBoxColumn.Width = 58;
            // 
            // студПрепBindingSource
            // 
            this.студПрепBindingSource.DataMember = "СтудПреп";
            this.студПрепBindingSource.DataSource = this.schoolDanceDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.labelErrorDance);
            this.tabPage3.Controls.Add(this.buttonAddGroup);
            this.tabPage3.Controls.Add(this.comboBoxDanceType);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxCountStudent);
            this.tabPage3.Controls.Add(this.textBoxGroupNumber);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(539, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Добавить группу";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(322, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // labelErrorDance
            // 
            this.labelErrorDance.AutoSize = true;
            this.labelErrorDance.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDance.Location = new System.Drawing.Point(149, 23);
            this.labelErrorDance.Name = "labelErrorDance";
            this.labelErrorDance.Size = new System.Drawing.Size(0, 15);
            this.labelErrorDance.TabIndex = 16;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.Location = new System.Drawing.Point(117, 162);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(169, 43);
            this.buttonAddGroup.TabIndex = 15;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // comboBoxDanceType
            // 
            this.comboBoxDanceType.DataSource = this.видыТанцевBindingSource;
            this.comboBoxDanceType.DisplayMember = "Название";
            this.comboBoxDanceType.FormattingEnabled = true;
            this.comboBoxDanceType.Location = new System.Drawing.Point(143, 106);
            this.comboBoxDanceType.Name = "comboBoxDanceType";
            this.comboBoxDanceType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDanceType.TabIndex = 14;
            this.comboBoxDanceType.ValueMember = "Код";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во студентов:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер группы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(72, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Вид танца:";
            // 
            // textBoxCountStudent
            // 
            this.textBoxCountStudent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountStudent.Location = new System.Drawing.Point(143, 78);
            this.textBoxCountStudent.Name = "textBoxCountStudent";
            this.textBoxCountStudent.Size = new System.Drawing.Size(121, 22);
            this.textBoxCountStudent.TabIndex = 10;
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGroupNumber.Location = new System.Drawing.Point(143, 52);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(121, 22);
            this.textBoxGroupNumber.TabIndex = 9;
            // 
            // виды_танцевTableAdapter
            // 
            this.виды_танцевTableAdapter.ClearBeforeFill = true;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.schoolDanceDataSet;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // студПрепTableAdapter
            // 
            this.студПрепTableAdapter.ClearBeforeFill = true;
            // 
            // fKГруппыВидыТанцевBindingSource
            // 
            this.fKГруппыВидыТанцевBindingSource.DataMember = "FK_Группы_Виды танцев";
            this.fKГруппыВидыТанцевBindingSource.DataSource = this.видыТанцевBindingSource;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormAdmin";
            this.Text = "Школа танцев";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыТанцевBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDanceDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студПрепBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKГруппыВидыТанцевBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelGroupOrDance;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboBoxGroupOrDance;
        private System.Windows.Forms.DataGridView dataGridViewTS;
        private SchoolDanceDataSet schoolDanceDataSet;
        private System.Windows.Forms.BindingSource видыТанцевBindingSource;
        private SchoolDanceDataSetTableAdapters.Виды_танцевTableAdapter виды_танцевTableAdapter;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private SchoolDanceDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.BindingSource студПрепBindingSource;
        private SchoolDanceDataSetTableAdapters.СтудПрепTableAdapter студПрепTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDeleteId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.ComboBox comboBoxDanceType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCountStudent;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.BindingSource fKГруппыВидыТанцевBindingSource;
        private System.Windows.Forms.Label labelErrorDance;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}