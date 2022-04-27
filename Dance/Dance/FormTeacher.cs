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
    public partial class FormTeacher : Form
    {
        FormMain fMain;
        string typeDance;
        string sqlTask;
        string teacherFIO;

        public FormTeacher(FormMain fM, string dance, string fIO)
        {
            InitializeComponent();
            fMain = fM;
            typeDance = dance;
            labelDance.Text += " " + typeDance;
            teacherFIO = fIO;

            sqlTask = "SELECT[Расписание занятий].Код as [Номер расписания], [Группа], Преподаватели.ФИО, [Зал], [Дата], [Время]" +
                "FROM [Расписание занятий] inner join Группы on(Группы.[Номер группы] = [Расписание занятий].Группа) " +
                "inner join[Виды танцев] on([Виды танцев].Код = Группы.[Вид танца]) inner join Преподаватели on (Преподаватели.Код = [Расписание занятий].Преподаватель)" +
                "where[Виды танцев].Название = '" + typeDance + "'";

            string sql1 = "select ФИО, Студенты.[Учебная группа], [Виды танцев].Название from " +
                 "Студенты inner join Группы on(Студенты.[Учебная группа] = Группы.[Номер группы])" +
                 "inner join[Виды танцев] on(Группы.[Вид танца] = [Виды танцев].Код) where [Виды танцев].Название = '" + typeDance + "'";

            string sql2 = "select [Виды танцев].Название, [Виды танцев].Описание from [Виды танцев]";

            string sql3 = "select [Номер группы] from " +
                "Группы inner join[Виды танцев] on(Группы.[Вид танца] = [Виды танцев].Код)" +
                "where [Виды танцев].Название = '" + typeDance + "'";

            FullDB(sql3, comboBoxGroupForInsert);
            FullDB(sql3, comboBoxGroupUpdate);

            FullDB(sql1, dataGridViewGS);
            FullDB(sql2, dataGridViewGroupInfo);
            FullDB(sql3, comboBoxGroupDance);
            FullDB(sql3, comboBoxGroups);
            FullDB(sqlTask, dataGridViewTask);
        }

        public bool CheckForEmpty(TextBox tx)
        {
            return tx.Text != "";
        }

        public void FullDB(string sql, ComboBox cb)
        {
            string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "tbl");

            cb.DataSource = ds.Tables["tbl"];
            cb.DisplayMember = "Номер группы";
            cb.ValueMember = "Номер группы";
        }

        public void FullDB(string sql, DataGridView GV)
        {
            string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                GV.DataSource = ds.Tables[0];

                connection.Close();
            }
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            this.группыTableAdapter.Fill(this.schoolDanceDataSet.Группы);
            comboBoxGroups.Text = "Все";
            comboBoxGroupDance.Text = "Все";
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxAll.Checked)
            {
                comboBoxGroups.Enabled = true;
            }
            else
            {
                comboBoxGroups.Text = "Все";
                comboBoxGroups.Enabled = false;

                string sql = "select ФИО, Студенты.[Учебная группа], [Виды танцев].Название from " +
                "Студенты inner join Группы on(Студенты.[Учебная группа] = Группы.[Номер группы])" +
                "inner join[Виды танцев] on(Группы.[Вид танца] = [Виды танцев].Код) where [Виды танцев].Название = '" + typeDance + "'";

                FullDB(sql, dataGridViewGS);
            }
                
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select ФИО, Студенты.[Учебная группа], [Виды танцев].Название from " +
                "Студенты inner join Группы on(Студенты.[Учебная группа] = Группы.[Номер группы])" +
                "inner join[Виды танцев] on(Группы.[Вид танца] = [Виды танцев].Код) " +
                "where [Виды танцев].Название = '" + typeDance + "' and Студенты.[Учебная группа] = '" + comboBoxGroups.Text +"'";

            FullDB(sql, dataGridViewGS);
        }

        private void checkBoxGroupDance_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxGroupDance.Checked)
            {
                comboBoxGroupDance.Enabled = true;
            }
            else
            {
                comboBoxGroupDance.Text = "Все";
                comboBoxGroupDance.Enabled = false;

                FullDB(sqlTask, dataGridViewTask);
            }
        }

        private void comboBoxGroupDance_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT[Расписание занятий].Код as [Номер расписания], [Группа], Преподаватели.ФИО, [Зал], [Дата], [Время]" +
                "FROM [Расписание занятий] inner join Группы on(Группы.[Номер группы] = [Расписание занятий].Группа) " +
                "inner join[Виды танцев] on([Виды танцев].Код = Группы.[Вид танца]) inner join Преподаватели on (Преподаватели.Код = [Расписание занятий].Преподаватель)" +
                "where[Виды танцев].Название = '" + typeDance + "' and [Группа] = '" + comboBoxGroupDance.Text + "'";

            FullDB(sql, dataGridViewTask);
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            if (maskedTextBoxTime.Text != "" &&
                CheckForEmpty(textBoxZal) &&
                maskedTextBoxDate.Text != "")
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);


                connect.Open();

                string cmdSelInsert = "insert into [Расписание занятий] values(@group, @te, @z, @d, @t)";
                SqlParameter prGroup = new SqlParameter("@group", comboBoxGroupForInsert.Text);
                SqlParameter prTea = new SqlParameter("@te", teacherFIO);
                SqlParameter prZ = new SqlParameter("@z", textBoxZal.Text);
                SqlParameter prD = new SqlParameter("@d", maskedTextBoxDate.Text);
                SqlParameter prT = new SqlParameter("@t", maskedTextBoxTime.Text);

                SqlCommand cmdInsertTask = new SqlCommand(cmdSelInsert, connect);
                cmdInsertTask.Parameters.Add(prGroup);
                cmdInsertTask.Parameters.Add(prTea);
                cmdInsertTask.Parameters.Add(prZ);
                cmdInsertTask.Parameters.Add(prD);
                cmdInsertTask.Parameters.Add(prT);
                try
                {
                    cmdInsertTask.ExecuteNonQuery();
                    labelError.Text = "Занятие добавлено!";
                    FullDB(sqlTask, dataGridViewTask);
                }
                catch
                {
                    labelError.Text = "Неверное значение даты или времени...";
                }

                connect.Close();

            }
            else
            {
                labelError.Text = "Неверные данные";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            if (CheckForEmpty(textBoxIdForDelete))
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);


                connect.Open();

                string cmdSelDelete = "delete from [Расписание занятий] where Код = @id";
                SqlParameter prDelId = new SqlParameter("@id", textBoxIdForDelete.Text);

                SqlCommand cmdDeleteTask = new SqlCommand(cmdSelDelete, connect);
                cmdDeleteTask.Parameters.Add(prDelId);

                cmdDeleteTask.ExecuteNonQuery();

                labelError.Text = "Занятие успешно удалено!";

                FullDB(sqlTask, dataGridViewTask);

                connect.Close();
            }
            else
            {
                labelError.Text = "Неверные данные";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            if (maskedTextBoxTimeUp.Text != "" &&
                CheckForEmpty(textBoxZalUpdate) &&
                maskedTextBoxDateUp.Text != "")
            {
                
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true"; ;

                SqlConnection connect = new SqlConnection(connectionString);


                connect.Open();

                string cmdSelInsert = "update [Расписание занятий] set Группа = @group, Зал = @z, Дата =  @d, Время = @t where Код = @id";
                SqlParameter prGroup = new SqlParameter("@group", comboBoxGroupUpdate.Text);
                SqlParameter prZ = new SqlParameter("@z", textBoxZalUpdate.Text);
                SqlParameter prD = new SqlParameter("@d", maskedTextBoxDateUp.Text);
                SqlParameter prT = new SqlParameter("@t", maskedTextBoxTimeUp.Text);
                SqlParameter prId = new SqlParameter("@id", textBoxIdForUpdate.Text);

                SqlCommand cmdInsertTask = new SqlCommand(cmdSelInsert, connect);
                cmdInsertTask.Parameters.Add(prGroup);
                cmdInsertTask.Parameters.Add(prZ);
                cmdInsertTask.Parameters.Add(prD);
                cmdInsertTask.Parameters.Add(prT);
                cmdInsertTask.Parameters.Add(prId);
                try
                {
                    cmdInsertTask.ExecuteNonQuery();
                    labelError.Text = "Занятие изменено!";

                    FullDB(sqlTask, dataGridViewTask);
                }
                catch
                {
                    labelError.Text = "Неверное значение даты или времени...";
                }
                connect.Close();
            }
            else
            {
                labelError.Text = "Неверные данные";
            }
        }

        private void FormTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMain.Show();
        }
    }
}
