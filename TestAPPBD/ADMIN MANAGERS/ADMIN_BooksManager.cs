﻿using System;
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
    public partial class ADMIN_BooksManager : MaterialForm
    {
        private int flag = 0;
        public ADMIN_BooksManager()
        {
            InitializeComponent();
        }

        private void ADMIN_BooksManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.GENRES". При необходимости она может быть перемещена или удалена.
            this.gENRESTableAdapter.Fill(this.appBDDataSet.GENRES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.WRITERS". При необходимости она может быть перемещена или удалена.
            this.wRITERSTableAdapter.Fill(this.appBDDataSet.WRITERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.LANGUAGES". При необходимости она может быть перемещена или удалена.
            this.lANGUAGESTableAdapter.Fill(this.appBDDataSet.LANGUAGES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appBDDataSet.BOOKS". При необходимости она может быть перемещена или удалена.
            this.bOOKSTableAdapter.Fill(this.appBDDataSet.BOOKS);

            SelectBooks();
            
            // Подсказки для навигации
            toolTip1.SetToolTip(this.pictureBox1, "Первая запись");
            toolTip2.SetToolTip(this.pictureBox2, "Предыдущая запись");
            toolTip3.SetToolTip(this.pictureBox3, "Следующая запись");
            toolTip4.SetToolTip(this.pictureBox4, "Последняя запись");
        }

        public void SelectBooks()  // метод витягує дані з таблиці CITIES і розміщує в dataGridView1
        {
            int i = 0;
            string sqlExpression =
                "SELECT BOOKS.ID, BOOKS.BNAME, BOOKS.BDESCRIPTION, LANGUAGES.LNAME, WRITERS.WSURNAME, GENRES.GNAME, BOOKS.CREATEDATE, BOOKS.BUY_PRICE, BOOKS.RENT_PRICE FROM BOOKS INNER JOIN LANGUAGES ON BOOKS.LANGUAGE_ID=LANGUAGES.ID INNER JOIN WRITERS ON BOOKS.WRITER_ID=WRITERS.ID INNER JOIN GENRES ON BOOKS.GENRE_ID=GENRES.ID";
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
                        dataGridView1.Rows[i].Cells[5].Value = reader.GetValue(5);
                        dataGridView1.Rows[i].Cells[6].Value = reader.GetValue(6);
                        dataGridView1.Rows[i].Cells[7].Value = reader.GetValue(7);
                        dataGridView1.Rows[i].Cells[8].Value = reader.GetValue(8);
                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void bOOKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appBDDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel2.Visible = false;
            bOOKSBindingSource.AddNew();
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
            if ((flag == 1 || flag == 2) && (bNAMETextBox.Text == "" || bDESCRIPTIONTextBox.Text == "" ||
                                             bUY_PRICETextBox.Text == "" || rENT_PRICETextBox.Text == "" ||
                                             comboBox1.Text == "" || comboBox2.Text == "" | comboBox3.Text == "" ||
                                             iDTextBox.Text == ""))
            {
                MessageBox.Show("ЗАДАНО НЕ ВСЕ ПОЛЯ", "НЕЗАПОЛНЕННЫЕ ПОЛЯ!");
                return;
            }

            if (flag == 3) bOOKSBindingSource.RemoveCurrent();

            bOOKSBindingNavigatorSaveItem_Click(sender, e);
            SelectBooks();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
                bOOKSBindingSource.CancelEdit();

            panel2.Visible = true;
            panel3.Visible = false;
            groupBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bOOKSBindingSource.MoveFirst();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bOOKSBindingSource.MovePrevious();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bOOKSBindingSource.MoveNext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bOOKSBindingSource.MoveLast();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            this.lANGUAGESTableAdapter.Fill(this.appBDDataSet.LANGUAGES);
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.wRITERSTableAdapter.Fill(this.appBDDataSet.WRITERS);
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            this.gENRESTableAdapter.Fill(this.appBDDataSet.GENRES);
        }
    }
}
