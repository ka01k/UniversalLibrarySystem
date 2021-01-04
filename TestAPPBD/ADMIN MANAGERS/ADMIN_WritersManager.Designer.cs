namespace TestAPPBD
{
    partial class ADMIN_WritersManager
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
            System.Windows.Forms.Label wNAMELabel;
            System.Windows.Forms.Label wSURNAMELabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label bIRTHDAY_DATALabel;
            System.Windows.Forms.Label dEATH_DATALabel;
            System.Windows.Forms.Label cITY_BIRTHDAYLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_WritersManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_BIRTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DEATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY_BIRTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY_DEATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.wRITERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBDDataSet = new TestAPPBD.AppBDDataSet();
            this.cITIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dEATH_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bIRTHDAY_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gENDERComboBox = new System.Windows.Forms.ComboBox();
            this.wSURNAMETextBox = new System.Windows.Forms.TextBox();
            this.wNAMETextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.wRITERSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.WRITERSTableAdapter();
            this.tableAdapterManager = new TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager();
            this.cITIESTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.CITIESTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            wNAMELabel = new System.Windows.Forms.Label();
            wSURNAMELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            bIRTHDAY_DATALabel = new System.Windows.Forms.Label();
            dEATH_DATALabel = new System.Windows.Forms.Label();
            cITY_BIRTHDAYLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRITERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(6, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(43, 20);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "Код:";
            // 
            // wNAMELabel
            // 
            wNAMELabel.AutoSize = true;
            wNAMELabel.Location = new System.Drawing.Point(131, 25);
            wNAMELabel.Name = "wNAMELabel";
            wNAMELabel.Size = new System.Drawing.Size(44, 20);
            wNAMELabel.TabIndex = 6;
            wNAMELabel.Text = "Имя:";
            // 
            // wSURNAMELabel
            // 
            wSURNAMELabel.AutoSize = true;
            wSURNAMELabel.Location = new System.Drawing.Point(343, 25);
            wSURNAMELabel.Name = "wSURNAMELabel";
            wSURNAMELabel.Size = new System.Drawing.Size(85, 20);
            wSURNAMELabel.TabIndex = 7;
            wSURNAMELabel.Text = "Фамилия:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(343, 58);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(44, 20);
            gENDERLabel.TabIndex = 8;
            gENDERLabel.Text = "Пол:";
            // 
            // bIRTHDAY_DATALabel
            // 
            bIRTHDAY_DATALabel.AutoSize = true;
            bIRTHDAY_DATALabel.Location = new System.Drawing.Point(10, 86);
            bIRTHDAY_DATALabel.Name = "bIRTHDAY_DATALabel";
            bIRTHDAY_DATALabel.Size = new System.Drawing.Size(132, 20);
            bIRTHDAY_DATALabel.TabIndex = 9;
            bIRTHDAY_DATALabel.Text = "Дата рождения:";
            // 
            // dEATH_DATALabel
            // 
            dEATH_DATALabel.AutoSize = true;
            dEATH_DATALabel.Location = new System.Drawing.Point(6, 58);
            dEATH_DATALabel.Name = "dEATH_DATALabel";
            dEATH_DATALabel.Size = new System.Drawing.Size(111, 20);
            dEATH_DATALabel.TabIndex = 11;
            dEATH_DATALabel.Text = "Дата смерти:";
            // 
            // cITY_BIRTHDAYLabel
            // 
            cITY_BIRTHDAYLabel.AutoSize = true;
            cITY_BIRTHDAYLabel.Location = new System.Drawing.Point(11, 118);
            cITY_BIRTHDAYLabel.Name = "cITY_BIRTHDAYLabel";
            cITY_BIRTHDAYLabel.Size = new System.Drawing.Size(164, 20);
            cITY_BIRTHDAYLabel.TabIndex = 13;
            cITY_BIRTHDAYLabel.Text = "Город, где родился:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 20);
            label1.TabIndex = 14;
            label1.Text = "Город, где умер:";
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
            this.GENDER,
            this.DATA_BIRTH,
            this.DATA_DEATH,
            this.CITY_BIRTH,
            this.CITY_DEATH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // CITYNAME
            // 
            this.CITYNAME.HeaderText = "Имя";
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.ReadOnly = true;
            // 
            // ADRESS
            // 
            this.ADRESS.HeaderText = "Фамилия";
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.HeaderText = "Пол";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // DATA_BIRTH
            // 
            this.DATA_BIRTH.HeaderText = "Дата рождения";
            this.DATA_BIRTH.Name = "DATA_BIRTH";
            this.DATA_BIRTH.ReadOnly = true;
            // 
            // DATA_DEATH
            // 
            this.DATA_DEATH.HeaderText = "Дата смерти";
            this.DATA_DEATH.Name = "DATA_DEATH";
            this.DATA_DEATH.ReadOnly = true;
            // 
            // CITY_BIRTH
            // 
            this.CITY_BIRTH.HeaderText = "Город рождения";
            this.CITY_BIRTH.Name = "CITY_BIRTH";
            this.CITY_BIRTH.ReadOnly = true;
            // 
            // CITY_DEATH
            // 
            this.CITY_DEATH.HeaderText = "Город, где умер";
            this.CITY_DEATH.Name = "CITY_DEATH";
            this.CITY_DEATH.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(cITY_BIRTHDAYLabel);
            this.groupBox1.Controls.Add(dEATH_DATALabel);
            this.groupBox1.Controls.Add(this.dEATH_DATADateTimePicker);
            this.groupBox1.Controls.Add(bIRTHDAY_DATALabel);
            this.groupBox1.Controls.Add(this.bIRTHDAY_DATADateTimePicker);
            this.groupBox1.Controls.Add(gENDERLabel);
            this.groupBox1.Controls.Add(this.gENDERComboBox);
            this.groupBox1.Controls.Add(wSURNAMELabel);
            this.groupBox1.Controls.Add(this.wSURNAMETextBox);
            this.groupBox1.Controls.Add(wNAMELabel);
            this.groupBox1.Controls.Add(this.wNAMETextBox);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "(0 = Женский | 1 = Мужской)";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wRITERSBindingSource, "CITY_DEATH", true));
            this.comboBox2.DataSource = this.cITIESBindingSource;
            this.comboBox2.DisplayMember = "CITYNAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(318, 28);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // wRITERSBindingSource
            // 
            this.wRITERSBindingSource.DataMember = "WRITERS";
            this.wRITERSBindingSource.DataSource = this.appBDDataSet;
            // 
            // appBDDataSet
            // 
            this.appBDDataSet.DataSetName = "AppBDDataSet";
            this.appBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cITIESBindingSource
            // 
            this.cITIESBindingSource.DataMember = "CITIES";
            this.cITIESBindingSource.DataSource = this.appBDDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wRITERSBindingSource, "CITY_BIRTHDAY", true));
            this.comboBox1.DataSource = this.cITIESBindingSource;
            this.comboBox1.DisplayMember = "CITYNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // dEATH_DATADateTimePicker
            // 
            this.dEATH_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.wRITERSBindingSource, "DEATH_DATA", true));
            this.dEATH_DATADateTimePicker.Location = new System.Drawing.Point(123, 57);
            this.dEATH_DATADateTimePicker.Name = "dEATH_DATADateTimePicker";
            this.dEATH_DATADateTimePicker.Size = new System.Drawing.Size(214, 26);
            this.dEATH_DATADateTimePicker.TabIndex = 12;
            // 
            // bIRTHDAY_DATADateTimePicker
            // 
            this.bIRTHDAY_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.wRITERSBindingSource, "BIRTHDAY_DATA", true));
            this.bIRTHDAY_DATADateTimePicker.Location = new System.Drawing.Point(148, 86);
            this.bIRTHDAY_DATADateTimePicker.Name = "bIRTHDAY_DATADateTimePicker";
            this.bIRTHDAY_DATADateTimePicker.Size = new System.Drawing.Size(189, 26);
            this.bIRTHDAY_DATADateTimePicker.TabIndex = 10;
            // 
            // gENDERComboBox
            // 
            this.gENDERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wRITERSBindingSource, "GENDER", true));
            this.gENDERComboBox.FormattingEnabled = true;
            this.gENDERComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.gENDERComboBox.Location = new System.Drawing.Point(392, 55);
            this.gENDERComboBox.Name = "gENDERComboBox";
            this.gENDERComboBox.Size = new System.Drawing.Size(213, 28);
            this.gENDERComboBox.TabIndex = 9;
            // 
            // wSURNAMETextBox
            // 
            this.wSURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wRITERSBindingSource, "WSURNAME", true));
            this.wSURNAMETextBox.Location = new System.Drawing.Point(434, 22);
            this.wSURNAMETextBox.Name = "wSURNAMETextBox";
            this.wSURNAMETextBox.Size = new System.Drawing.Size(171, 26);
            this.wSURNAMETextBox.TabIndex = 8;
            // 
            // wNAMETextBox
            // 
            this.wNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wRITERSBindingSource, "WNAME", true));
            this.wNAMETextBox.Location = new System.Drawing.Point(181, 22);
            this.wNAMETextBox.Name = "wNAMETextBox";
            this.wNAMETextBox.Size = new System.Drawing.Size(156, 26);
            this.wNAMETextBox.TabIndex = 7;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wRITERSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(55, 22);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(70, 26);
            this.iDTextBox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(756, 25);
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
            this.panel3.Location = new System.Drawing.Point(582, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 38);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(15, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 38);
            this.panel2.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 265);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Авторы";
            // 
            // wRITERSTableAdapter
            // 
            this.wRITERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CITIESTableAdapter = this.cITIESTableAdapter;
            this.tableAdapterManager.CONTINENTSTableAdapter = null;
            this.tableAdapterManager.COUNTRIESTableAdapter = null;
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
            this.tableAdapterManager.WRITERSTableAdapter = this.wRITERSTableAdapter;
            // 
            // cITIESTableAdapter
            // 
            this.cITIESTableAdapter.ClearBeforeFill = true;
            // 
            // ADMIN_WritersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_WritersManager";
            this.Text = "Таблица ~ Авторы | YourLibrary";
            this.Load += new System.EventHandler(this.ADMIN_WritersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wRITERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip3;
        private AppBDDataSet appBDDataSet;
        private System.Windows.Forms.BindingSource wRITERSBindingSource;
        private AppBDDataSetTableAdapters.WRITERSTableAdapter wRITERSTableAdapter;
        private AppBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox wNAMETextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox wSURNAMETextBox;
        private System.Windows.Forms.ComboBox gENDERComboBox;
        private System.Windows.Forms.DateTimePicker bIRTHDAY_DATADateTimePicker;
        private System.Windows.Forms.DateTimePicker dEATH_DATADateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private AppBDDataSetTableAdapters.CITIESTableAdapter cITIESTableAdapter;
        private System.Windows.Forms.BindingSource cITIESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_BIRTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DEATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY_BIRTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY_DEATH;
        private System.Windows.Forms.Label label2;
    }
}