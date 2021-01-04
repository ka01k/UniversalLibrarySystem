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
    public partial class ADMIN_SalesManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_SalesManager()
        {
            InitializeComponent();
        }

        private void ADMIN_SalesManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.BOOKS". При необходимости она может быть перемещена или удалена.
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WORKERS". При необходимости она может быть перемещена или удалена.
            this.wORKERSTableAdapter.Fill(this.appBDDataSet.WORKERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.appBDDataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.SALES". При необходимости она может быть перемещена или удалена.
            this.sALESTableAdapter.Fill(this.appBDDataSet.SALES);

            SelectSales();
        }

        private void sALESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        public void SelectSales()  // метод витягує дані з таблиці CITIES і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "select SALES.ID, USERS.USERNAME, BOOKS.BNAME, WORKERS.USERNUM, SALES.SELL_DATA FROM SALES INNER JOIN USERS ON SALES.USERNUM=USERS.ID INNER JOIN BOOKS ON SALES.BOOK_ID=BOOKS.ID INNER JOIN WORKERS ON SALES.WORKER_ID=WORKERS.ID";
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
                        dataGridView1.Rows[i].Cells[4].Value = reader.GetValue(4);
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
            sALESBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (iDTextBox.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" ||
                                             comboBox3.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }

            if (flag == 3) sALESBindingSource.RemoveCurrent();

            sALESBindingNavigatorSaveItem_Click(sender, e);
            SelectSales();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                sALESBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sALESBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sALESBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sALESBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sALESBindingSource.MoveLast();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.wORKERSTableAdapter.Fill(this.appBDDataSet.WORKERS);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.uSERSTableAdapter.Fill(this.appBDDataSet.USERS);
        }
    }
}
