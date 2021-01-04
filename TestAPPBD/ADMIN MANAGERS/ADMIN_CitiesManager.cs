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
    public partial class ADMIN_CitiesManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_CitiesManager()
        {
            InitializeComponent();
        }

        private void ADMIN_CitiesManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.COUNTRIES". При необходимости она может быть перемещена или удалена.
            this.cOUNTRIESTableAdapter.Fill(this.appBDDataSet.COUNTRIES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.CITIES". При необходимости она может быть перемещена или удалена.
            this.cITIESTableAdapter.Fill(this.appBDDataSet.CITIES);

            SelectCities(); // Выводим данные в dataGriedView1

            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следущая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        private void cITIESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cITIESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        private void button1_Click(object sender, EventArgs e)  // Кнопка "Сохранить"
        {
            flag = 1;
            panel2.Visible = false;
            cITIESBindingSource.AddNew();
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

        public void SelectCities()
        {
            int i = 0;
            string sqlExpression =
                "SELECT CITIES.ID, CITIES.CITYNAME, COUNTRIES.COUNTRYNAME FROM CITIES INNER JOIN COUNTRIES ON CITIES.COUNTRYID = COUNTRIES.ID ORDER BY CITIES.CITYNAME";

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
                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((flag == 1 || flag == 2) && (cITYNAMETextBox.Text == "" || comboBox1.Text == ""))
            {
                MessageBox.Show("Заполните ВСЕ поля, пожалуйста!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (flag == 3) cITIESBindingSource.RemoveCurrent();

            cITIESBindingNavigatorSaveItem_Click(sender, e);
            SelectCities();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                cITIESBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cITIESBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cITIESBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cITIESBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cITIESBindingSource.MoveLast();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // ДОБАВИТЬ КОД
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.cOUNTRIESTableAdapter.Fill(this.appBDDataSet.COUNTRIES);   // Заполнить comboBox1 - данными из таблицы COUNTRIES
        }
    }
}
