﻿namespace TestAPPBD.ADMIN_MANAGERS
{
    partial class ADMIN_GenresManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label gNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_GenresManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CITYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gNAMETextBox = new System.Windows.Forms.TextBox();
            this.gENRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBDDataSet = new TestAPPBD.AppBDDataSet();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.gENRESTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.GENRESTableAdapter();
            this.tableAdapterManager = new TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            gNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(9, 28);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(43, 20);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "Код:";
            // 
            // gNAMELabel
            // 
            gNAMELabel.AutoSize = true;
            gNAMELabel.Location = new System.Drawing.Point(164, 25);
            gNAMELabel.Name = "gNAMELabel";
            gNAMELabel.Size = new System.Drawing.Size(87, 20);
            gNAMELabel.TabIndex = 6;
            gNAMELabel.Text = "Название:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestAPPBD.Properties.Resources.first_arrow__VERTICAL;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TestAPPBD.Properties.Resources.last_arrow_VERTICAL;
            this.pictureBox4.Location = new System.Drawing.Point(3, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TestAPPBD.Properties.Resources.next_arrow_VERTICAL;
            this.pictureBox3.Location = new System.Drawing.Point(3, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // CITYNAME
            // 
            this.CITYNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CITYNAME.HeaderText = "Название";
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 156;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CITYNAME});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 265);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Жанры";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestAPPBD.Properties.Resources.prev_arrow_VERTICAL;
            this.pictureBox2.Location = new System.Drawing.Point(3, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(611, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 124);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(15, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 38);
            this.panel2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(111, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(268, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(118, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(440, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 38);
            this.panel3.TabIndex = 12;
            this.panel3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gNAMELabel);
            this.groupBox1.Controls.Add(this.gNAMETextBox);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            this.groupBox1.Visible = false;
            // 
            // gNAMETextBox
            // 
            this.gNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gENRESBindingSource, "GNAME", true));
            this.gNAMETextBox.Location = new System.Drawing.Point(257, 22);
            this.gNAMETextBox.Name = "gNAMETextBox";
            this.gNAMETextBox.Size = new System.Drawing.Size(244, 26);
            this.gNAMETextBox.TabIndex = 7;
            // 
            // gENRESBindingSource
            // 
            this.gENRESBindingSource.DataMember = "GENRES";
            this.gENRESBindingSource.DataSource = this.appBDDataSet;
            // 
            // appBDDataSet
            // 
            this.appBDDataSet.DataSetName = "AppBDDataSet";
            this.appBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gENRESBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(58, 25);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 6;
            // 
            // gENRESTableAdapter
            // 
            this.gENRESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CITIESTableAdapter = null;
            this.tableAdapterManager.CONTINENTSTableAdapter = null;
            this.tableAdapterManager.COUNTRIESTableAdapter = null;
            this.tableAdapterManager.GENRESTableAdapter = this.gENRESTableAdapter;
            this.tableAdapterManager.LANGUAGESTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PROVIDERSTableAdapter = null;
            this.tableAdapterManager.RENTSTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.WAREHOUSETableAdapter = null;
            this.tableAdapterManager.WORK_POSITIONSTableAdapter = null;
            this.tableAdapterManager.WORKERSTableAdapter = null;
            this.tableAdapterManager.WRITERSTableAdapter = null;
            // 
            // ADMIN_GenresManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_GenresManager";
            this.Text = "Таблица ~ Жанры  | YourLibrary";
            this.Load += new System.EventHandler(this.ADMIN_GenresManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.GroupBox groupBox1;
        private AppBDDataSet appBDDataSet;
        private System.Windows.Forms.BindingSource gENRESBindingSource;
        private AppBDDataSetTableAdapters.GENRESTableAdapter gENRESTableAdapter;
        private AppBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox gNAMETextBox;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}