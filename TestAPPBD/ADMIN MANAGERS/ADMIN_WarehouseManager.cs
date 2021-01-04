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
    public partial class ADMIN_WarehouseManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_WarehouseManager()
        {
            InitializeComponent();
        }

        public void SelectBooksWareHouse()
        {
            int i = 0;
            string sqlExpression =
                "SELECT WAREHOUSE.ID, BOOKS.BNAME, WAREHOUSE.BOOK_COUNT FROM WAREHOUSE INNER JOIN BOOKS ON WAREHOUSE.BOOK_ID = BOOKS.ID";

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
        private void wAREHOUSEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wAREHOUSEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);

        }

        private void ADMIN_WarehouseManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.BOOKS". При необходимости она может быть перемещена или удалена.
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WAREHOUSE". При необходимости она может быть перемещена или удалена.
            this.wAREHOUSETableAdapter.Fill(this.appBDDataSet.WAREHOUSE);

            SelectBooksWareHouse();
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следущая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        private void button1_Click(object sender, EventArgs e)  // Кнопка "Сохранить"
        {
            flag = 1;
            panel2.Visible = false;
            wAREHOUSEBindingSource.AddNew();
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
                (comboBox1.Text == "" || bOOK_COUNTTextBox.Text == "" || iDTextBox.Text == ""))
            {
                MessageBox.Show("Заполните ВСЕ поля, пожалуйста!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (flag == 3) wAREHOUSEBindingSource.RemoveCurrent();

            wAREHOUSEBindingNavigatorSaveItem_Click(sender, e);
            SelectBooksWareHouse();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                wAREHOUSEBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wAREHOUSEBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wAREHOUSEBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wAREHOUSEBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wAREHOUSEBindingSource.MoveLast();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);   // Заполнить comboBox1 - данными из таблицы COUNTRIES
        }
    }
}
