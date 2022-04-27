
namespace Dance
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDances = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewGroupInfo = new System.Windows.Forms.DataGridView();
            this.panelList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGS = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDanceDataSet = new Dance.SchoolDanceDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTask = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZal = new System.Windows.Forms.TextBox();
            this.comboBoxGroupForInsert = new System.Windows.Forms.ComboBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIdForDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.maskedTextBoxDateUp = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeUp = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIdForUpdate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxZalUpdate = new System.Windows.Forms.TextBox();
            this.comboBoxGroupUpdate = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxGroupDance = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGroupDance = new System.Windows.Forms.ComboBox();
            this.группыTableAdapter = new Dance.SchoolDanceDataSetTableAdapters.ГруппыTableAdapter();
            this.labelDance = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupInfo)).BeginInit();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDanceDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.panelInsert.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 34);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 491);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDances);
            this.tabPage1.Controls.Add(this.panelList);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.checkBoxAll);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxGroups);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Списки групп и учеников";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelDances
            // 
            this.panelDances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDances.Controls.Add(this.label3);
            this.panelDances.Controls.Add(this.dataGridViewGroupInfo);
            this.panelDances.Location = new System.Drawing.Point(10, 253);
            this.panelDances.Name = "panelDances";
            this.panelDances.Size = new System.Drawing.Size(440, 154);
            this.panelDances.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Виды танцев:";
            // 
            // dataGridViewGroupInfo
            // 
            this.dataGridViewGroupInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGroupInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroupInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupInfo.Location = new System.Drawing.Point(10, 34);
            this.dataGridViewGroupInfo.Name = "dataGridViewGroupInfo";
            this.dataGridViewGroupInfo.ReadOnly = true;
            this.dataGridViewGroupInfo.Size = new System.Drawing.Size(420, 111);
            this.dataGridViewGroupInfo.TabIndex = 3;
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelList.Controls.Add(this.label2);
            this.panelList.Controls.Add(this.dataGridViewGS);
            this.panelList.Location = new System.Drawing.Point(10, 6);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(448, 241);
            this.panelList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список студентов и их группа:";
            // 
            // dataGridViewGS
            // 
            this.dataGridViewGS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGS.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewGS.Name = "dataGridViewGS";
            this.dataGridViewGS.ReadOnly = true;
            this.dataGridViewGS.Size = new System.Drawing.Size(420, 182);
            this.dataGridViewGS.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Checked = true;
            this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll.Location = new System.Drawing.Point(576, 29);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(148, 27);
            this.checkBoxAll.TabIndex = 2;
            this.checkBoxAll.Text = "Выбрать всех";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(493, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа:";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DataSource = this.группыBindingSource;
            this.comboBoxGroups.DisplayMember = "Номер группы";
            this.comboBoxGroups.Enabled = false;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(576, 62);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(153, 31);
            this.comboBoxGroups.TabIndex = 0;
            this.comboBoxGroups.ValueMember = "Номер группы";
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.schoolDanceDataSet;
            // 
            // schoolDanceDataSet
            // 
            this.schoolDanceDataSet.DataSetName = "SchoolDanceDataSet";
            this.schoolDanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTask);
            this.tabPage2.Controls.Add(this.panelInsert);
            this.tabPage2.Controls.Add(this.panelDelete);
            this.tabPage2.Controls.Add(this.panelUpdate);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.checkBoxGroupDance);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBoxGroupDance);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание занятий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelTask
            // 
            this.panelTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTask.Controls.Add(this.labelError);
            this.panelTask.Controls.Add(this.label10);
            this.panelTask.Controls.Add(this.dataGridViewTask);
            this.panelTask.Location = new System.Drawing.Point(9, 6);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(512, 219);
            this.panelTask.TabIndex = 47;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(205, 10);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 19);
            this.labelError.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Расписание:";
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTask.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.ReadOnly = true;
            this.dataGridViewTask.Size = new System.Drawing.Size(487, 181);
            this.dataGridViewTask.TabIndex = 0;
            // 
            // panelInsert
            // 
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Controls.Add(this.maskedTextBoxDate);
            this.panelInsert.Controls.Add(this.maskedTextBoxTime);
            this.panelInsert.Controls.Add(this.buttonCreateTask);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label7);
            this.panelInsert.Controls.Add(this.label6);
            this.panelInsert.Controls.Add(this.label5);
            this.panelInsert.Controls.Add(this.textBoxZal);
            this.panelInsert.Controls.Add(this.comboBoxGroupForInsert);
            this.panelInsert.Location = new System.Drawing.Point(527, 61);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(234, 213);
            this.panelInsert.TabIndex = 45;
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDate.Location = new System.Drawing.Point(71, 87);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBoxDate.TabIndex = 36;
            this.maskedTextBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxTime.Location = new System.Drawing.Point(71, 117);
            this.maskedTextBoxTime.Mask = "00:00";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(137, 22);
            this.maskedTextBoxTime.TabIndex = 35;
            this.maskedTextBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxTime.ValidatingType = typeof(System.DateTime);
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTask.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTask.Location = new System.Drawing.Point(28, 164);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(194, 41);
            this.buttonCreateTask.TabIndex = 33;
            this.buttonCreateTask.Text = "Создать";
            this.buttonCreateTask.UseVisualStyleBackColor = true;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Создать занятие:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Время:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Зал:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Группа:";
            // 
            // textBoxZal
            // 
            this.textBoxZal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZal.Location = new System.Drawing.Point(71, 61);
            this.textBoxZal.Name = "textBoxZal";
            this.textBoxZal.Size = new System.Drawing.Size(138, 22);
            this.textBoxZal.TabIndex = 7;
            // 
            // comboBoxGroupForInsert
            // 
            this.comboBoxGroupForInsert.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroupForInsert.FormattingEnabled = true;
            this.comboBoxGroupForInsert.Location = new System.Drawing.Point(71, 34);
            this.comboBoxGroupForInsert.Name = "comboBoxGroupForInsert";
            this.comboBoxGroupForInsert.Size = new System.Drawing.Size(138, 23);
            this.comboBoxGroupForInsert.TabIndex = 6;
            // 
            // panelDelete
            // 
            this.panelDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Controls.Add(this.label12);
            this.panelDelete.Controls.Add(this.textBoxIdForDelete);
            this.panelDelete.Controls.Add(this.label11);
            this.panelDelete.Location = new System.Drawing.Point(479, 307);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(278, 149);
            this.panelDelete.TabIndex = 44;
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(53, 86);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(194, 46);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Номер расписания:";
            // 
            // textBoxIdForDelete
            // 
            this.textBoxIdForDelete.Location = new System.Drawing.Point(129, 48);
            this.textBoxIdForDelete.Name = "textBoxIdForDelete";
            this.textBoxIdForDelete.Size = new System.Drawing.Size(138, 20);
            this.textBoxIdForDelete.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(50, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Удалить занятие:";
            // 
            // panelUpdate
            // 
            this.panelUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Controls.Add(this.maskedTextBoxDateUp);
            this.panelUpdate.Controls.Add(this.maskedTextBoxTimeUp);
            this.panelUpdate.Controls.Add(this.label13);
            this.panelUpdate.Controls.Add(this.textBoxIdForUpdate);
            this.panelUpdate.Controls.Add(this.label15);
            this.panelUpdate.Controls.Add(this.label16);
            this.panelUpdate.Controls.Add(this.label17);
            this.panelUpdate.Controls.Add(this.label18);
            this.panelUpdate.Controls.Add(this.label19);
            this.panelUpdate.Controls.Add(this.textBoxZalUpdate);
            this.panelUpdate.Controls.Add(this.comboBoxGroupUpdate);
            this.panelUpdate.Location = new System.Drawing.Point(9, 231);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(297, 225);
            this.panelUpdate.TabIndex = 43;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(90, 185);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(194, 32);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // maskedTextBoxDateUp
            // 
            this.maskedTextBoxDateUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDateUp.Location = new System.Drawing.Point(125, 117);
            this.maskedTextBoxDateUp.Mask = "00/00/0000";
            this.maskedTextBoxDateUp.Name = "maskedTextBoxDateUp";
            this.maskedTextBoxDateUp.Size = new System.Drawing.Size(137, 22);
            this.maskedTextBoxDateUp.TabIndex = 38;
            this.maskedTextBoxDateUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDateUp.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTimeUp
            // 
            this.maskedTextBoxTimeUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxTimeUp.Location = new System.Drawing.Point(125, 143);
            this.maskedTextBoxTimeUp.Mask = "00:00";
            this.maskedTextBoxTimeUp.Name = "maskedTextBoxTimeUp";
            this.maskedTextBoxTimeUp.Size = new System.Drawing.Size(138, 22);
            this.maskedTextBoxTimeUp.TabIndex = 37;
            this.maskedTextBoxTimeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxTimeUp.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Номер расписания:";
            // 
            // textBoxIdForUpdate
            // 
            this.textBoxIdForUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdForUpdate.Location = new System.Drawing.Point(125, 39);
            this.textBoxIdForUpdate.Name = "textBoxIdForUpdate";
            this.textBoxIdForUpdate.Size = new System.Drawing.Size(138, 22);
            this.textBoxIdForUpdate.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Firebrick;
            this.label15.Location = new System.Drawing.Point(45, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Изменить занятие:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(76, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Время:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(86, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 26;
            this.label17.Text = "Дата:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(93, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Зал:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(71, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 15);
            this.label19.TabIndex = 24;
            this.label19.Text = "Группа:";
            // 
            // textBoxZalUpdate
            // 
            this.textBoxZalUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZalUpdate.Location = new System.Drawing.Point(124, 91);
            this.textBoxZalUpdate.Name = "textBoxZalUpdate";
            this.textBoxZalUpdate.Size = new System.Drawing.Size(138, 22);
            this.textBoxZalUpdate.TabIndex = 21;
            // 
            // comboBoxGroupUpdate
            // 
            this.comboBoxGroupUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroupUpdate.FormattingEnabled = true;
            this.comboBoxGroupUpdate.Location = new System.Drawing.Point(125, 65);
            this.comboBoxGroupUpdate.Name = "comboBoxGroupUpdate";
            this.comboBoxGroupUpdate.Size = new System.Drawing.Size(138, 23);
            this.comboBoxGroupUpdate.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(343, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxGroupDance
            // 
            this.checkBoxGroupDance.AutoSize = true;
            this.checkBoxGroupDance.Checked = true;
            this.checkBoxGroupDance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGroupDance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGroupDance.Location = new System.Drawing.Point(627, 8);
            this.checkBoxGroupDance.Name = "checkBoxGroupDance";
            this.checkBoxGroupDance.Size = new System.Drawing.Size(100, 19);
            this.checkBoxGroupDance.TabIndex = 4;
            this.checkBoxGroupDance.Text = "Выбрать всех";
            this.checkBoxGroupDance.UseVisualStyleBackColor = true;
            this.checkBoxGroupDance.CheckedChanged += new System.EventHandler(this.checkBoxGroupDance_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(547, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Группа:";
            // 
            // comboBoxGroupDance
            // 
            this.comboBoxGroupDance.Enabled = false;
            this.comboBoxGroupDance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroupDance.FormattingEnabled = true;
            this.comboBoxGroupDance.Location = new System.Drawing.Point(609, 33);
            this.comboBoxGroupDance.Name = "comboBoxGroupDance";
            this.comboBoxGroupDance.Size = new System.Drawing.Size(138, 23);
            this.comboBoxGroupDance.TabIndex = 2;
            this.comboBoxGroupDance.Text = "Все";
            this.comboBoxGroupDance.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupDance_SelectedIndexChanged);
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // labelDance
            // 
            this.labelDance.AutoSize = true;
            this.labelDance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDance.Location = new System.Drawing.Point(355, 19);
            this.labelDance.Name = "labelDance";
            this.labelDance.Size = new System.Drawing.Size(146, 23);
            this.labelDance.TabIndex = 3;
            this.labelDance.Text = "Ваш вид танца:";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.labelDance);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormTeacher";
            this.Text = "Школа танцев";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTeacher_FormClosed);
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelDances.ResumeLayout(false);
            this.panelDances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupInfo)).EndInit();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDanceDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.DataGridView dataGridViewGS;
        private SchoolDanceDataSet schoolDanceDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private SchoolDanceDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Label labelDance;
        private System.Windows.Forms.DataGridView dataGridViewGroupInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.ComboBox comboBoxGroupDance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxGroupDance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZal;
        private System.Windows.Forms.ComboBox comboBoxGroupForInsert;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIdForUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxZalUpdate;
        private System.Windows.Forms.ComboBox comboBoxGroupUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxIdForDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeUp;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel panelDances;
        private System.Windows.Forms.Panel panelList;
    }
}