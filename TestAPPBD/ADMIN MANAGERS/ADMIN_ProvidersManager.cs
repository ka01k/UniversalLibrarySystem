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

namespace TestAPPBD.ADMIN_MANAGERS
{
    public partial class ADMIN_ProvidersManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_ProvidersManager()
        {
            InitializeComponent();
        }

        private void ADMIN_ProvidersManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.PROVIDERS". При необходимости она может быть перемещена или удалена.
            this.pROVIDERSTableAdapter.Fill(this.appBDDataSet.PROVIDERS);

            SelectProviders();
            
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следующая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        private void pROVIDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROVIDERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        public void SelectProviders() // метод витягує дані з таблиці CONTINENTS і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "SELECT * FROM PROVIDERS";
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
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel2.Visible = false;
            pROVIDERSBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (pROVIDERNAMETextBox.Text == "" || iDTextBox.Text == "" ||
                                             pROVIDERADRESSTextBox.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }

            if (flag == 3) pROVIDERSBindingSource.RemoveCurrent();

            pROVIDERSBindingNavigatorSaveItem_Click(sender, e);
            SelectProviders();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                pROVIDERSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pROVIDERSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pROVIDERSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pROVIDERSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pROVIDERSBindingSource.MoveLast();
        }
    }
}