namespace TestAPPBD.ADMIN_MANAGERS
{
    partial class ADMIN_OrdersManager
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
            System.Windows.Forms.Label pROVIDER_IDLabel1;
            System.Windows.Forms.Label bOOK_IDLabel;
            System.Windows.Forms.Label oRDER_COUNTLabel;
            System.Windows.Forms.Label oRDER_DATALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_OrdersManager));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBDDataSet = new TestAPPBD.AppBDDataSet();
            this.pROVIDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDER_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oRDER_COUNTTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.oRDERSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.ORDERSTableAdapter();
            this.tableAdapterManager = new TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager();
            this.bOOKSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.BOOKSTableAdapter();
            this.pROVIDERSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.PROVIDERSTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            pROVIDER_IDLabel1 = new System.Windows.Forms.Label();
            bOOK_IDLabel = new System.Windows.Forms.Label();
            oRDER_COUNTLabel = new System.Windows.Forms.Label();
            oRDER_DATALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(6, 33);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(43, 20);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "Код:";
            // 
            // pROVIDER_IDLabel1
            // 
            pROVIDER_IDLabel1.AutoSize = true;
            pROVIDER_IDLabel1.Location = new System.Drawing.Point(163, 36);
            pROVIDER_IDLabel1.Name = "pROVIDER_IDLabel1";
            pROVIDER_IDLabel1.Size = new System.Drawing.Size(99, 20);
            pROVIDER_IDLabel1.TabIndex = 6;
            pROVIDER_IDLabel1.Text = "Поставщик:";
            // 
            // bOOK_IDLabel
            // 
            bOOK_IDLabel.AutoSize = true;
            bOOK_IDLabel.Location = new System.Drawing.Point(6, 74);
            bOOK_IDLabel.Name = "bOOK_IDLabel";
            bOOK_IDLabel.Size = new System.Drawing.Size(57, 20);
            bOOK_IDLabel.TabIndex = 7;
            bOOK_IDLabel.Text = "Книга:";
            // 
            // oRDER_COUNTLabel
            // 
            oRDER_COUNTLabel.AutoSize = true;
            oRDER_COUNTLabel.Location = new System.Drawing.Point(490, 36);
            oRDER_COUNTLabel.Name = "oRDER_COUNTLabel";
            oRDER_COUNTLabel.Size = new System.Drawing.Size(104, 20);
            oRDER_COUNTLabel.TabIndex = 8;
            oRDER_COUNTLabel.Text = "Количество:";
            // 
            // oRDER_DATALabel
            // 
            oRDER_DATALabel.AutoSize = true;
            oRDER_DATALabel.Location = new System.Drawing.Point(490, 71);
            oRDER_DATALabel.Name = "oRDER_DATALabel";
            oRDER_DATALabel.Size = new System.Drawing.Size(126, 20);
            oRDER_DATALabel.TabIndex = 9;
            oRDER_DATALabel.Text = "Дата поставки:";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(699, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 38);
            this.panel3.TabIndex = 24;
            this.panel3.Visible = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(15, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 38);
            this.panel2.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(914, 265);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставки:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CITYNAME,
            this.ADRESS,
            this.PASSPORT,
            this.GENDER});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(908, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CITYNAME
            // 
            this.CITYNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CITYNAME.HeaderText = "Поставщик";
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.ReadOnly = true;
            // 
            // ADRESS
            // 
            this.ADRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADRESS.HeaderText = "Книга";
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.ReadOnly = true;
            // 
            // PASSPORT
            // 
            this.PASSPORT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PASSPORT.HeaderText = "Количество";
            this.PASSPORT.Name = "PASSPORT";
            this.PASSPORT.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GENDER.HeaderText = "Дата";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(oRDER_DATALabel);
            this.groupBox1.Controls.Add(this.oRDER_DATADateTimePicker);
            this.groupBox1.Controls.Add(oRDER_COUNTLabel);
            this.groupBox1.Controls.Add(this.oRDER_COUNTTextBox);
            this.groupBox1.Controls.Add(bOOK_IDLabel);
            this.groupBox1.Controls.Add(pROVIDER_IDLabel1);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 169);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            this.groupBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oRDERSBindingSource, "PROVIDER_ID", true));
            this.comboBox2.DataSource = this.pROVIDERSBindingSource;
            this.comboBox2.DisplayMember = "PROVIDERNAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 28);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.appBDDataSet;
            // 
            // appBDDataSet
            // 
            this.appBDDataSet.DataSetName = "AppBDDataSet";
            this.appBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVIDERSBindingSource
            // 
            this.pROVIDERSBindingSource.DataMember = "PROVIDERS";
            this.pROVIDERSBindingSource.DataSource = this.appBDDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oRDERSBindingSource, "BOOK_ID", true));
            this.comboBox1.DataSource = this.bOOKSBindingSource;
            this.comboBox1.DisplayMember = "BNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.appBDDataSet;
            // 
            // oRDER_DATADateTimePicker
            // 
            this.oRDER_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oRDERSBindingSource, "ORDER_DATA", true));
            this.oRDER_DATADateTimePicker.Location = new System.Drawing.Point(622, 68);
            this.oRDER_DATADateTimePicker.Name = "oRDER_DATADateTimePicker";
            this.oRDER_DATADateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.oRDER_DATADateTimePicker.TabIndex = 10;
            // 
            // oRDER_COUNTTextBox
            // 
            this.oRDER_COUNTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "ORDER_COUNT", true));
            this.oRDER_COUNTTextBox.Location = new System.Drawing.Point(600, 33);
            this.oRDER_COUNTTextBox.Name = "oRDER_COUNTTextBox";
            this.oRDER_COUNTTextBox.Size = new System.Drawing.Size(222, 26);
            this.oRDER_COUNTTextBox.TabIndex = 9;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(55, 30);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(873, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 124);
            this.panel4.TabIndex = 5;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.CITIESTableAdapter = null;
            this.tableAdapterManager.CONTINENTSTableAdapter = null;
            this.tableAdapterManager.COUNTRIESTableAdapter = null;
            this.tableAdapterManager.GENRESTableAdapter = null;
            this.tableAdapterManager.LANGUAGESTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = this.oRDERSTableAdapter;
            this.tableAdapterManager.PROVIDERSTableAdapter = this.pROVIDERSTableAdapter;
            this.tableAdapterManager.RENTSTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.WAREHOUSETableAdapter = null;
            this.tableAdapterManager.WORK_POSITIONSTableAdapter = null;
            this.tableAdapterManager.WORKERSTableAdapter = null;
            this.tableAdapterManager.WRITERSTableAdapter = null;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // pROVIDERSTableAdapter
            // 
            this.pROVIDERSTableAdapter.ClearBeforeFill = true;
            // 
            // ADMIN_OrdersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_OrdersManager";
            this.Text = "Таблица ~ Поставки  | YourLibrary";
            this.Load += new System.EventHandler(this.ADMIN_OrdersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSPORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private AppBDDataSet appBDDataSet;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private AppBDDataSetTableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private AppBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private AppBDDataSetTableAdapters.PROVIDERSTableAdapter pROVIDERSTableAdapter;
        private System.Windows.Forms.BindingSource pROVIDERSBindingSource;
        private AppBDDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.TextBox oRDER_COUNTTextBox;
        private System.Windows.Forms.DateTimePicker oRDER_DATADateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}