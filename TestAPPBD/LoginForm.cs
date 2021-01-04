using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBD;
using MaterialSkin.Controls;

namespace TestAPPBD
{
    public partial class LoginForm : MaterialForm
    {
        MainMenu toMainMenu = new MainMenu();  // Новая переменная для открытия главного меню

        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlquery = new SqlCommand();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            sqlConnect.ConnectionString = DB.connectionString;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var login = bunifuMaterialTextbox1.Text.Trim();
            var password = bunifuMaterialTextbox2.Text.Trim();

            sqlConnect.Open();     // Подключаемся к базе данных

            sqlquery.Connection = sqlConnect;
            sqlquery.CommandText = "SELECT * FROM USERS";   // Выборка из таблицы USERS

            SqlDataReader DR = sqlquery.ExecuteReader();

            if (DR.Read())
            {
                if (bunifuMaterialTextbox1.Text.Equals(DR["USERNAME"].ToString()) &&
                    bunifuMaterialTextbox2.Text.Equals(DR["USERPASSWORD"].ToString()))
                {
                    toMainMenu.Show();              // Открываем главное меню
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(@"Проверьте правильность ввода данных.", @"Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            sqlConnect.Close();     // Отключаемся от базы данных
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = Convert.ToString(e.KeyChar);
            if (!Regex.IsMatch(c, "[a-zA-Z0-9._@]"))
            {
                e.Handled = true;
            }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = Convert.ToString(e.KeyChar);
            if (!Regex.IsMatch(c, "[a-zA-Z0-9._@]"))
            {
                e.Handled = true;
            }
        }
    }
}
