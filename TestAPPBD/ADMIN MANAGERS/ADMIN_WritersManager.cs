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
    public partial class ADMIN_WritersManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_WritersManager()
        {
            InitializeComponent();
        }

        private void ADMIN_WritersManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.CITIES". При необходимости она может быть перемещена или удалена.
            this.cITIESTableAdapter.Fill(this.appBDDataSet.CITIES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WRITERS". При необходимости она может быть перемещена или удалена.
            this.wRITERSTableAdapter.Fill(this.appBDDataSet.WRITERS);

            SelectWriters();
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следущая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        private void wRITERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wRITERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        public void SelectWriters()
        {
            int i = 0;
            string sqlExpression =
                "SELECT WRITERS.ID, WRITERS.WNAME, WRITERS.WSURNAME, WRITERS.GENDER, WRITERS.BIRTHDAY_DATA, writers.DEATH_DATA, t1.CITYNAME, t2.CITYNAME FROM WRITERS LEFT JOIN CITIES AS t1 ON t1.ID=WRITERS.CITY_BIRTHDAY LEFT JOIN CITIES AS t2 ON t2.ID=WRITERS.CITY_DEATH";

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
                        int check = (int)reader.GetValue(3);
                        if (check == 0)
                        {
                            dataGridView1.Rows[i].Cells[3].Value = "Женский";
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[3].Value = "Мужской";
                        }
                        dataGridView1.Rows[i].Cells[4].Value = reader.GetValue(4);
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
        private void button1_Click(object sender, EventArgs e)  // Кнопка "Сохранить"
        {
            flag = 1;
            panel2.Visible = false;
            wRITERSBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (iDTextBox.Text == "" || wNAMETextBox.Text == "" ||
                                             wSURNAMETextBox.Text == "" || comboBox1.Text == "" ||
                                             comboBox2.Text == ""))
            {
                MessageBox.Show("Заполните ВСЕ поля, пожалуйста!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (flag == 3) wRITERSBindingSource.RemoveCurrent();

            wRITERSBindingNavigatorSaveItem_Click(sender, e);
            SelectWriters();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                wRITERSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wRITERSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wRITERSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wRITERSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wRITERSBindingSource.MoveLast();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.cITIESTableAdapter.Fill(this.appBDDataSet.CITIES);   // Заполнить comboBox1 - данными из таблицы CITIES
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.cITIESTableAdapter.Fill(this.appBDDataSet.CITIES);   // Заполнить comboBox2 - данными из таблицы CITIES
        }
    }
}
