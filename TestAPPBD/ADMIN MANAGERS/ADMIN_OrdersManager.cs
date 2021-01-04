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
    public partial class ADMIN_OrdersManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_OrdersManager()
        {
            InitializeComponent();
        }

        private void ADMIN_OrdersManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.BOOKS". При необходимости она может быть перемещена или удалена.
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.PROVIDERS". При необходимости она может быть перемещена или удалена.
            this.pROVIDERSTableAdapter.Fill(this.appBDDataSet.PROVIDERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.ORDERS". При необходимости она может быть перемещена или удалена.
            this.oRDERSTableAdapter.Fill(this.appBDDataSet.ORDERS);

            SelectOrders();
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следующая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        private void oRDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        public void SelectOrders()  // метод витягує дані з таблиці CITIES і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "select ORDERS.ID, PROVIDERS.PROVIDERNAME, BOOKS.BNAME, ORDERS.ORDER_COUNT, ORDERS.ORDER_DATA  FROM ORDERS INNER JOIN PROVIDERS ON ORDERS.PROVIDER_ID = PROVIDERS.ID INNER JOIN BOOKS ON ORDERS.BOOK_ID=BOOKS.ID";
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
            oRDERSBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) &&
                (iDTextBox.Text == "" || oRDER_COUNTTextBox.Text == "" || comboBox1.Text ==
                    "" || comboBox2.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }

            if (flag == 3) oRDERSBindingSource.RemoveCurrent();

            oRDERSBindingNavigatorSaveItem_Click(sender, e);
            SelectOrders();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                oRDERSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.MoveLast();
        }

        private void bOOK_IDComboBox_Click(object sender, EventArgs e)
        {
            
        }

        private void pROVIDER_IDComboBox_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.pROVIDERSTableAdapter.Fill(this.appBDDataSet.PROVIDERS);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);
        }
    }
}
