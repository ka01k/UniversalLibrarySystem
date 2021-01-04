namespace TestAPPBD
{
    partial class ADMIN_CountriesManager
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
            System.Windows.Forms.Label cOUNTRYNAMELabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_CountriesManager));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNTRYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBDDataSet = new TestAPPBD.AppBDDataSet();
            this.cONTINENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOUNTRYNAMETextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cOUNTRIESTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.COUNTRIESTableAdapter();
            this.tableAdapterManager = new TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager();
            this.cONTINENTSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.CONTINENTSTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            iDLabel = new System.Windows.Forms.Label();
            cOUNTRYNAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTINENTSBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(6, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(43, 20);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "Код:";
            // 
            // cOUNTRYNAMELabel
            // 
            cOUNTRYNAMELabel.AutoSize = true;
            cOUNTRYNAMELabel.Location = new System.Drawing.Point(161, 31);
            cOUNTRYNAMELabel.Name = "cOUNTRYNAMELabel";
            cOUNTRYNAMELabel.Size = new System.Drawing.Size(146, 20);
            cOUNTRYNAMELabel.TabIndex = 2;
            cOUNTRYNAMELabel.Text = "Название страны:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(161, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "Материк:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Города";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CITYNAME,
            this.COUNTRYID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(649, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 156;
            // 
            // CITYNAME
            // 
            this.CITYNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CITYNAME.HeaderText = "Название";
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.ReadOnly = true;
            // 
            // COUNTRYID
            // 
            this.COUNTRYID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COUNTRYID.HeaderText = "Материк";
            this.COUNTRYID.Name = "COUNTRYID";
            this.COUNTRYID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(cOUNTRYNAMELabel);
            this.groupBox1.Controls.Add(this.cOUNTRYNAMETextBox);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            this.groupBox1.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TestAPPBD.Properties.Resources.table_edit;
            this.pictureBox5.Location = new System.Drawing.Point(580, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
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
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOUNTRIESBindingSource, "CONTINENT_ID", true));
            this.comboBox1.DataSource = this.cONTINENTSBindingSource;
            this.comboBox1.DisplayMember = "CONTINENTNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID";
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.appBDDataSet;
            // 
            // appBDDataSet
            // 
            this.appBDDataSet.DataSetName = "AppBDDataSet";
            this.appBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTINENTSBindingSource
            // 
            this.cONTINENTSBindingSource.DataMember = "CONTINENTS";
            this.cONTINENTSBindingSource.DataSource = this.appBDDataSet;
            // 
            // cOUNTRYNAMETextBox
            // 
            this.cOUNTRYNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOUNTRIESBindingSource, "COUNTRYNAME", true));
            this.cOUNTRYNAMETextBox.Location = new System.Drawing.Point(313, 25);
            this.cOUNTRYNAMETextBox.Name = "cOUNTRYNAMETextBox";
            this.cOUNTRYNAMETextBox.Size = new System.Drawing.Size(292, 26);
            this.cOUNTRYNAMETextBox.TabIndex = 3;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOUNTRIESBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(55, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 26);
            this.iDTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(6, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 38);
            this.panel2.TabIndex = 7;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(431, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 38);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
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
            // cOUNTRIESTableAdapter
            // 
            this.cOUNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CITIESTableAdapter = null;
            this.tableAdapterManager.CONTINENTSTableAdapter = this.cONTINENTSTableAdapter;
            this.tableAdapterManager.COUNTRIESTableAdapter = this.cOUNTRIESTableAdapter;
            this.tableAdapterManager.GENRESTableAdapter = null;
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
            // cONTINENTSTableAdapter
            // 
            this.cONTINENTSTableAdapter.ClearBeforeFill = true;
            // 
            // ADMIN_CountriesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_CountriesManager";
            this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.Text = "Таблица ~ Страны  | YourLibrary";
            this.Load += new System.EventHandler(this.ADMIN_CountriesManager_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTINENTSBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private AppBDDataSet appBDDataSet;
        private System.Windows.Forms.BindingSource cOUNTRIESBindingSource;
        private AppBDDataSetTableAdapters.COUNTRIESTableAdapter cOUNTRIESTableAdapter;
        private AppBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox cOUNTRYNAMETextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private AppBDDataSetTableAdapters.CONTINENTSTableAdapter cONTINENTSTableAdapter;
        private System.Windows.Forms.BindingSource cONTINENTSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNTRYID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}