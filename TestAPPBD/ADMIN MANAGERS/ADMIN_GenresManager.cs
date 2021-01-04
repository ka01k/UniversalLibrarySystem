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
    public partial class ADMIN_GenresManager : MaterialForm
    {
        public int flag = 0;
        public ADMIN_GenresManager()
        {
            InitializeComponent();
        }

        private void ADMIN_GenresManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.GENRES". При необходимости она может быть перемещена или удалена.
            this.gENRESTableAdapter.Fill(this.appBDDataSet.GENRES);

            SelectGenres();

            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следующая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        public void SelectGenres() // метод витягує дані з таблиці CONTINENTS і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "SELECT * FROM GENRES";
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
                        i++;
                    }
                }

                reader.Close();
                connection.Close();
            }
        }

        private void gENRESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gENRESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel2.Visible = false;
            gENRESBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (gNAMETextBox.Text == "" || iDTextBox.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }
            if (flag == 3) gENRESBindingSource.RemoveCurrent();

            gENRESBindingNavigatorSaveItem_Click(sender, e);
            SelectGenres();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                gENRESBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gENRESBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gENRESBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gENRESBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gENRESBindingSource.MoveLast();
        }
    }
}
