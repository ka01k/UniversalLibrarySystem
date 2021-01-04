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
    public partial class ADMIN_WorkersManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_WorkersManager()
        {
            InitializeComponent();
        }

        private void ADMIN_WorkersManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WORK_POSITIONS". При необходимости она может быть перемещена или удалена.
            this.wORK_POSITIONSTableAdapter.Fill(this.appBDDataSet.WORK_POSITIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.appBDDataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WORKERS". При необходимости она может быть перемещена или удалена.
            this.wORKERSTableAdapter.Fill(this.appBDDataSet.WORKERS);

            SelectWorkers();
        }

        private void wORKERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wORKERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);
        }
        public void SelectWorkers()  // метод витягує дані з таблиці CITIES і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "select WORKERS.ID, USERS.USERNAME, WORK_POSITIONS.PNAME, WORKERS.START_DATA, WORKERS.END_DATA FROM WORKERS INNER JOIN USERS ON WORKERS.USERNUM=USERS.ID INNER JOIN WORK_POSITIONS ON WORKERS.POSITION_ID=WORK_POSITIONS.ID";
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
            wORKERSBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (iDTextBox.Text == "" || comboBox1.Text == "" || comboBox2.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }

            if (flag == 3) wORKERSBindingSource.RemoveCurrent();

            wORKERSBindingNavigatorSaveItem_Click(sender, e);
            SelectWorkers();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                wORKERSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wORKERSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wORKERSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wORKERSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wORKERSBindingSource.MoveLast();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.uSERSTableAdapter.Fill(this.appBDDataSet.USERS);
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.wORK_POSITIONSTableAdapter.Fill(this.appBDDataSet.WORK_POSITIONS);
        }
    }
}
