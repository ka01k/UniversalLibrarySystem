using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBD;
using MaterialSkin.Controls;

namespace TestAPPBD
{
    public partial class ADMIN_UsersManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_UsersManager()
        {
            InitializeComponent();
        }

        private void ADMIN_UsersManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.appBDDataSet.USERS);
            SelectUsers();
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следущая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        public void SelectUsers()  // метод витягує дані з таблиці CITIES і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "SELECT * FROM USERS";
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();
                if (reader.HasRows) // есть ли данные
                {
                    // Выводим названия стольцов

                    while (reader.Read()) // построчно считываем данные
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = reader.GetValue(0);
                        dataGridView1.Rows[i].Cells[1].Value = reader.GetValue(1);
                        dataGridView1.Rows[i].Cells[2].Value = reader.GetValue(2);
                        dataGridView1.Rows[i].Cells[3].Value = reader.GetValue(3);
                        int check = (int) reader.GetValue(4);
                        if (check==0)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "Женский";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[4].Value = "Мужской";
                        }
                        // dataGridView1.Rows[i].Cells[4].Value = reader.GetValue(4) == "0" ? "Женский" : "Мужской";
                        dataGridView1.Rows[i].Cells[5].Value = reader.GetValue(5);
                        dataGridView1.Rows[i].Cells[6].Value = reader.GetValue(6);
                        dataGridView1.Rows[i].Cells[7].Value = reader.GetValue(7);
                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        private void button1_Click(object sender, EventArgs e)  // Кнопка "Сохранить"
        {
            flag = 1;
            panel2.Visible = false;
            uSERSBindingSource.AddNew();
            groupBox1.Visible = true;
            panel4.Visible = false;

            panel3.Visible = true;
            button5.Text = "Сохранить";
            groupBox1.Text = "Добавить новую запись";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 2;
            groupBox1.Visible = true;
            panel4.Visible = true;
            panel2.Visible = false;

            panel3.Visible = true;
            button5.Text = "Сохранить";
            groupBox1.Text = "Редактировать запись";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 3;
            groupBox1.Visible = true;
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = true;
            button5.Text = "Удалить";
            groupBox1.Text = "Удалить запись";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((flag == 1 || flag == 2) && (iDTextBox.Text == "" || eMAILTextBox.Text == "" ||
                                             pASSPORTTextBox.Text == "" || uSERNAMETextBox.Text == "" ||
                                             gENDERComboBox.Text == ""))
            {
                MessageBox.Show("Заполните ВСЕ поля, пожалуйста!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (flag == 3) uSERSBindingSource.RemoveCurrent();

            uSERSBindingNavigatorSaveItem_Click(sender, e);
            SelectUsers();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                uSERSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveLast();
        }
    }
}
