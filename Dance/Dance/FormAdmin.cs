using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dance
{
    public partial class FormAdmin : Form
    {
        FormMain fMain;
        public FormAdmin(FormMain fM)
        {
            InitializeComponent();
            fMain = fM;
        }
        public bool CheckForEmpty(TextBox tx)
        {
            return tx.Text != "";
        }

        public void RefreshDB()
        {
            this.студПрепTableAdapter.Fill(this.schoolDanceDataSet.СтудПреп);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            RefreshDB();
            this.группыTableAdapter.Fill(this.schoolDanceDataSet.Группы);
            this.виды_танцевTableAdapter.Fill(this.schoolDanceDataSet.Виды_танцев);

            labelGroupOrDance.Text = "Специализация танца: ";
            comboBoxGroupOrDance.DataSource = видыТанцевBindingSource;
            comboBoxGroupOrDance.DisplayMember = "Название";
            comboBoxGroupOrDance.ValueMember = "Код";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //labelGroupOrDance.Text = comboBoxGroupOrDance.SelectedValue.ToString();

            labelError.Text = "";

            if (CheckForEmpty(textBoxLogin) && CheckForEmpty(textBoxPassword) && CheckForEmpty(textBoxFIO))
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);

                string cmdSelLogin = "Select Логин from Пользователи where Логин = @login";

                SqlParameter prLogin = new SqlParameter("@login", textBoxLogin.Text);
                SqlCommand cmd = new SqlCommand(cmdSelLogin, connect);
                cmd.Parameters.Add(prLogin);

                connect.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                string readerLogin = "";

                while (reader.Read())
                {
                    readerLogin = reader[0].ToString();
                }
                if (readerLogin == "")
                {
                    string cmdSelInsertUser = "insert into Пользователи values(@login, HASHBYTES('SHA2_256', Convert(varchar(max), @password)), @role)";
                    
                    SqlParameter prLogin2 = new SqlParameter("@login", textBoxLogin.Text);
                    SqlParameter prRole = new SqlParameter("@role", comboBoxRole.Text);
                    SqlParameter prPass = new SqlParameter("@password", textBoxPassword.Text);

                    SqlCommand cmdInsertUser = new SqlCommand(cmdSelInsertUser, connect);
                    cmdInsertUser.Parameters.Add(prLogin2);
                    cmdInsertUser.Parameters.Add(prRole);
                    cmdInsertUser.Parameters.Add(prPass);

                    cmdInsertUser.ExecuteNonQuery();

                    string table = "";

                    if(comboBoxRole.Text == "Teacher")
                    {
                        table = "Преподаватели";
                    }
                    else
                    {
                        table = "Студенты";
                    }
                    string cmdSelInsert = "insert into "+ table + " values(@fio, @gd, (select Код from Пользователи where Логин = @login))";
                    SqlParameter prFIO = new SqlParameter("@fio",textBoxFIO.Text);
                    SqlParameter prGD = new SqlParameter("@gd", comboBoxGroupOrDance.SelectedValue);
                    SqlParameter prPass2 = new SqlParameter("@password", textBoxPassword.Text);
                    SqlParameter prLogin3 = new SqlParameter("@login", textBoxLogin.Text);

                    SqlCommand cmdInsertPeople = new SqlCommand(cmdSelInsert, connect);
                    cmdInsertPeople.Parameters.Add(prLogin3);
                    cmdInsertPeople.Parameters.Add(prFIO);
                    cmdInsertPeople.Parameters.Add(prGD);
                    cmdInsertPeople.Parameters.Add(prPass2);

                    cmdInsertPeople.ExecuteNonQuery();


                    labelError.Text = "Пользователь успешно создан";
                    RefreshDB();
                }
                else
                {
                    labelError.Text = "Логин уже занят";
                }
                connect.Close();
            }
            else
            {
                labelError.Text = "Неверные данные";
            }
        }

        private void comboBoxRole_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "Teacher")
            {
                labelGroupOrDance.Text = "Специализация танца: ";
                this.виды_танцевTableAdapter.Fill(this.schoolDanceDataSet.Виды_танцев);
                comboBoxGroupOrDance.DataSource = видыТанцевBindingSource;
                comboBoxGroupOrDance.DisplayMember = "Название";
                comboBoxGroupOrDance.ValueMember = "Код";
            }
            else if (comboBoxRole.Text == "Student")
            {
                labelGroupOrDance.Text = "Учебная группа: ";
                this.группыTableAdapter.Fill(this.schoolDanceDataSet.Группы);
                comboBoxGroupOrDance.DataSource = группыBindingSource;
                comboBoxGroupOrDance.DisplayMember = "Номер группы";
                comboBoxGroupOrDance.ValueMember = "Номер группы";
            }

            labelError.Text = "";
        }

        private void buttonDeleteId_Click(object sender, EventArgs e)
        {
            if(CheckForEmpty(textBoxId))
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);

                string cmdSelDelId = "delete from Пользователи where Код = @id";

                SqlParameter prId = new SqlParameter("@id", textBoxId.Text);
                SqlCommand cmd = new SqlCommand(cmdSelDelId, connect);
                cmd.Parameters.Add(prId);

                connect.Open();

                cmd.ExecuteNonQuery();

                connect.Close();

                this.студПрепTableAdapter.Fill(this.schoolDanceDataSet.СтудПреп);
            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMain.Show();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            labelErrorDance.Text = "";

            if (CheckForEmpty(textBoxGroupNumber) && CheckForEmpty(textBoxCountStudent))
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);

                string cmdSelLogin = "Select [Номер группы] from Группы where [Номер группы] = @group";

                SqlParameter prGroups = new SqlParameter("@group", textBoxGroupNumber.Text);
                SqlCommand cmd = new SqlCommand(cmdSelLogin, connect);
                cmd.Parameters.Add(prGroups);

                connect.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                string readerLogin = "";

                while (reader.Read())
                {
                    readerLogin = reader[0].ToString();
                }
                if (readerLogin == "")
                {

                    string cmdSelInsert = "insert into Группы values(@name, @count, @dance)";
                    SqlParameter prName = new SqlParameter("@name", textBoxGroupNumber.Text);
                    SqlParameter prCount = new SqlParameter("@count", textBoxCountStudent.Text);
                    SqlParameter prDance = new SqlParameter("@dance", comboBoxDanceType.SelectedValue);

                    SqlCommand cmdInsertGroup = new SqlCommand(cmdSelInsert, connect);
                    cmdInsertGroup.Parameters.Add(prName);
                    cmdInsertGroup.Parameters.Add(prCount);
                    cmdInsertGroup.Parameters.Add(prDance);

                    cmdInsertGroup.ExecuteNonQuery();

                    labelErrorDance.Text = "Группа добавлена";
                    RefreshDB();
                }
                else
                {
                    labelErrorDance.Text = "Такая группа уже есть";
                }
                connect.Close();
            }
            else
            {
                labelErrorDance.Text = "Неверные данные";
            }
        }
    }
}
