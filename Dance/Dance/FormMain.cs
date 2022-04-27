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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public bool CheckForEmpty(TextBox tx)
        {
            return tx.Text != "";
        }

        public string CmdSelect(string query, SqlConnection connect)
        {
            string str = "";

            SqlParameter prPass = new SqlParameter("@password", textBoxPassword.Text);
            SqlParameter prLogin = new SqlParameter("@login", textBoxLogin.Text);
            SqlCommand cmd = new SqlCommand(query, connect);

            cmd.Parameters.Add(prPass);
            cmd.Parameters.Add(prLogin);
            try
            {
                str = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                str = "";
            }

            return str;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelError.Text = "";

            if (CheckForEmpty(textBoxLogin) && CheckForEmpty(textBoxPassword))
            {
                string connectionString = @"Data Source = АЛЁНА-ПК; Initial catalog = SchoolDance; Integrated Security = True; MultipleActiveResultSets = true";

                SqlConnection connect = new SqlConnection(connectionString);
                
                connect.Open();

                string cmdSelLogin = "Select Пароль from Пользователи where Логин = @login";

                SqlParameter prLogin = new SqlParameter("@login", textBoxLogin.Text);
                SqlCommand cmd = new SqlCommand(cmdSelLogin, connect);
                cmd.Parameters.Add(prLogin);

                SqlDataReader reader = cmd.ExecuteReader();

                string readerPass = "";

                while (reader.Read())
                {
                    readerPass = reader[0].ToString();
                }
                if (readerPass != "")
                {
                    string role = "";

                    string cmdSelPass = "Select Роль from Пользователи where Пароль = HASHBYTES('SHA2_256', Convert(varchar(MAX), @password)) and Логин = @login";

                    role = CmdSelect(cmdSelPass, connect);

                    if (role == "")
                    {
                        labelError.Text = "Неверный пароль";
                    }
                    else if (role == "Teacher")
                    {
                        string cmdSelDance = "Select Название from [Виды танцев] where Код = (Select [Специализация танца] from Преподаватели where [Код пользователя] = (select Код from Пользователи where Пароль = HASHBYTES('SHA2_256', Convert(varchar(MAX), @password)) and Логин = @login))";
                        string cmdSelFIO= "Select Код from Преподаватели where [Код пользователя] = (select Код from Пользователи where Пароль = HASHBYTES('SHA2_256', Convert(varchar(MAX), @password)) and Логин = @login)";

                        FormTeacher fTeacher = new FormTeacher(this, CmdSelect(cmdSelDance, connect), CmdSelect(cmdSelFIO, connect));
                        fTeacher.Show();
                        Hide();
                    }
                    else if (role == "Student")
                    {

                        string cmdSelGroup = "Select [Учебная группа] from Студенты where [Код пользователя] = (select Код from Пользователи where Пароль = HASHBYTES('SHA2_256', Convert(varchar(MAX), @password)) and Логин = @login)";
                        
                        FormStudent fStudent = new FormStudent(this, CmdSelect(cmdSelGroup, connect));
                        Hide();
                        fStudent.Show();
                    }
                    else if (role == "Admin")
                    {
                        FormAdmin fA = new FormAdmin(this);
                        Hide();
                        fA.Show();
                    }

                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";

                }
                else
                {
                    labelError.Text = "Неверный логин";
                }
                connect.Close();
            }
            else
            {
                labelError.Text = "Неверный данные";
            }
        }
    }
}
