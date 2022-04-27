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
    public partial class FormStudent : Form
    {
        FormMain fMain;
        public FormStudent(FormMain fM, string gr)
        {
            InitializeComponent();
            fMain = fM;

            labelGroup.Text += gr;

            string sql1 = "SELECT Преподаватели.ФИО, [Зал], [Дата], [Время]" +
                "FROM [Расписание занятий] inner join Группы on(Группы.[Номер группы] = [Расписание занятий].Группа) " +
                "inner join[Виды танцев] on([Виды танцев].Код = Группы.[Вид танца]) inner join" +
                " Преподаватели on (Преподаватели.Код = [Расписание занятий].Преподаватель)" +
                "where Группа = '" + gr + "'";

            FullDB(sql1, dataGridViewTask);

            string sql2 = "select ФИО from Студенты where [Учебная группа] = '" + gr + "'";

            FullDB(sql2, dataGridViewStudents);
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

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMain.Show();
        }
    }
}
