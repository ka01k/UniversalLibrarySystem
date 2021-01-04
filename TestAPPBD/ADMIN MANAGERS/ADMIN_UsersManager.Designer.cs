namespace TestAPPBD
{
    partial class ADMIN_UsersManager
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
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSPORTLabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label rEG_DATALabel;
            System.Windows.Forms.Label bIRTHDAY_DATALabel;
            System.Windows.Forms.Label uSERPASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_UsersManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_REG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDAYDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uSERPASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBDDataSet = new TestAPPBD.AppBDDataSet();
            this.bIRTHDAY_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rEG_DATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.gENDERComboBox = new System.Windows.Forms.ComboBox();
            this.pASSPORTTextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
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
            this.uSERSTableAdapter = new TestAPPBD.AppBDDataSetTableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSPORTLabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            rEG_DATALabel = new System.Windows.Forms.Label();
            bIRTHDAY_DATALabel = new System.Windows.Forms.Label();
            uSERPASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).BeginInit();
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
            iDLabel.Location = new System.Drawing.Point(6, 28);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(43, 20);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "Код:";
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(161, 28);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(59, 20);
            uSERNAMELabel.TabIndex = 6;
            uSERNAMELabel.Text = "Логин:";
            // 
            // pASSPORTLabel
            // 
            pASSPORTLabel.AutoSize = true;
            pASSPORTLabel.Location = new System.Drawing.Point(371, 64);
            pASSPORTLabel.Name = "pASSPORTLabel";
            pASSPORTLabel.Size = new System.Drawing.Size(78, 20);
            pASSPORTLabel.TabIndex = 7;
            pASSPORTLabel.Text = "Паспорт:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(405, 96);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(44, 20);
            gENDERLabel.TabIndex = 8;
            gENDERLabel.Text = "Пол:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(6, 64);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(62, 20);
            eMAILLabel.TabIndex = 9;
            eMAILLabel.Text = "EMAIL:";
            // 
            // rEG_DATALabel
            // 
            rEG_DATALabel.AutoSize = true;
            rEG_DATALabel.Location = new System.Drawing.Point(9, 95);
            rEG_DATALabel.Name = "rEG_DATALabel";
            rEG_DATALabel.Size = new System.Drawing.Size(152, 20);
            rEG_DATALabel.TabIndex = 11;
            rEG_DATALabel.Text = "Дата регистрации:";
            // 
            // bIRTHDAY_DATALabel
            // 
            bIRTHDAY_DATALabel.AutoSize = true;
            bIRTHDAY_DATALabel.Location = new System.Drawing.Point(29, 126);
            bIRTHDAY_DATALabel.Name = "bIRTHDAY_DATALabel";
            bIRTHDAY_DATALabel.Size = new System.Drawing.Size(132, 20);
            bIRTHDAY_DATALabel.TabIndex = 13;
            bIRTHDAY_DATALabel.Text = "Дата рождения:";
            // 
            // uSERPASSWORDLabel
            // 
            uSERPASSWORDLabel.AutoSize = true;
            uSERPASSWORDLabel.Location = new System.Drawing.Point(371, 28);
            uSERPASSWORDLabel.Name = "uSERPASSWORDLabel";
            uSERPASSWORDLabel.Size = new System.Drawing.Size(71, 20);
            uSERPASSWORDLabel.TabIndex = 15;
            uSERPASSWORDLabel.Text = "Пароль:";
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
            this.GENDER,
            this.EMAIL,
            this.DATA_REG,
            this.BIRTHDAYDATA});
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
            this.CITYNAME.HeaderText = "Логин";
            this.CITYNAME.Name = "CITYNAME";
            this.CITYNAME.ReadOnly = true;
            // 
            // ADRESS
            // 
            this.ADRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ADRESS.HeaderText = "Пароль";
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.ReadOnly = true;
            // 
            // PASSPORT
            // 
            this.PASSPORT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PASSPORT.HeaderText = "Паспорт";
            this.PASSPORT.Name = "PASSPORT";
            this.PASSPORT.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GENDER.HeaderText = "Пол";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAIL.HeaderText = "E-MAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // DATA_REG
            // 
            this.DATA_REG.HeaderText = "Дата регистрации";
            this.DATA_REG.Name = "DATA_REG";
            this.DATA_REG.ReadOnly = true;
            // 
            // BIRTHDAYDATA
            // 
            this.BIRTHDAYDATA.HeaderText = "Дата рождения";
            this.BIRTHDAYDATA.Name = "BIRTHDAYDATA";
            this.BIRTHDAYDATA.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(uSERPASSWORDLabel);
            this.groupBox1.Controls.Add(this.uSERPASSWORDTextBox);
            this.groupBox1.Controls.Add(bIRTHDAY_DATALabel);
            this.groupBox1.Controls.Add(this.bIRTHDAY_DATADateTimePicker);
            this.groupBox1.Controls.Add(rEG_DATALabel);
            this.groupBox1.Controls.Add(this.rEG_DATADateTimePicker);
            this.groupBox1.Controls.Add(eMAILLabel);
            this.groupBox1.Controls.Add(this.eMAILTextBox);
            this.groupBox1.Controls.Add(gENDERLabel);
            this.groupBox1.Controls.Add(this.gENDERComboBox);
            this.groupBox1.Controls.Add(pASSPORTLabel);
            this.groupBox1.Controls.Add(this.pASSPORTTextBox);
            this.groupBox1.Controls.Add(uSERNAMELabel);
            this.groupBox1.Controls.Add(this.uSERNAMETextBox);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 169);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую запись";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "(0 = Женский | 1 = Мужской)";
            // 
            // uSERPASSWORDTextBox
            // 
            this.uSERPASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "USERPASSWORD", true));
            this.uSERPASSWORDTextBox.Location = new System.Drawing.Point(455, 27);
            this.uSERPASSWORDTextBox.Name = "uSERPASSWORDTextBox";
            this.uSERPASSWORDTextBox.Size = new System.Drawing.Size(167, 26);
            this.uSERPASSWORDTextBox.TabIndex = 16;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.appBDDataSet;
            // 
            // appBDDataSet
            // 
            this.appBDDataSet.DataSetName = "AppBDDataSet";
            this.appBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bIRTHDAY_DATADateTimePicker
            // 
            this.bIRTHDAY_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uSERSBindingSource, "BIRTHDAY_DATA", true));
            this.bIRTHDAY_DATADateTimePicker.Location = new System.Drawing.Point(161, 122);
            this.bIRTHDAY_DATADateTimePicker.Name = "bIRTHDAY_DATADateTimePicker";
            this.bIRTHDAY_DATADateTimePicker.Size = new System.Drawing.Size(204, 26);
            this.bIRTHDAY_DATADateTimePicker.TabIndex = 14;
            // 
            // rEG_DATADateTimePicker
            // 
            this.rEG_DATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uSERSBindingSource, "REG_DATA", true));
            this.rEG_DATADateTimePicker.Location = new System.Drawing.Point(161, 90);
            this.rEG_DATADateTimePicker.Name = "rEG_DATADateTimePicker";
            this.rEG_DATADateTimePicker.Size = new System.Drawing.Size(204, 26);
            this.rEG_DATADateTimePicker.TabIndex = 12;
            this.rEG_DATADateTimePicker.Value = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(74, 61);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(291, 26);
            this.eMAILTextBox.TabIndex = 10;
            // 
            // gENDERComboBox
            // 
            this.gENDERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "GENDER", true));
            this.gENDERComboBox.FormattingEnabled = true;
            this.gENDERComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.gENDERComboBox.Location = new System.Drawing.Point(455, 91);
            this.gENDERComboBox.Name = "gENDERComboBox";
            this.gENDERComboBox.Size = new System.Drawing.Size(167, 28);
            this.gENDERComboBox.TabIndex = 9;
            // 
            // pASSPORTTextBox
            // 
            this.pASSPORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "PASSPORT", true));
            this.pASSPORTTextBox.Location = new System.Drawing.Point(455, 61);
            this.pASSPORTTextBox.Name = "pASSPORTTextBox";
            this.pASSPORTTextBox.Size = new System.Drawing.Size(167, 26);
            this.pASSPORTTextBox.TabIndex = 8;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(226, 25);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(139, 26);
            this.uSERNAMETextBox.TabIndex = 7;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(55, 25);
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
            this.panel3.Location = new System.Drawing.Point(699, 514);
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
            this.panel2.Location = new System.Drawing.Point(15, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 38);
            this.panel2.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(914, 265);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Аккаунты";
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CITIESTableAdapter = null;
            this.tableAdapterManager.CONTINENTSTableAdapter = null;
            this.tableAdapterManager.COUNTRIESTableAdapter = null;
            this.tableAdapterManager.GENRESTableAdapter = null;
            this.tableAdapterManager.LANGUAGESTableAdapter = null;
            this.tableAdapterManager.ORDERSTableAdapter = null;
            this.tableAdapterManager.PROVIDERSTableAdapter = null;
            this.tableAdapterManager.RENTSTableAdapter = null;
            this.tableAdapterManager.SALESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestAPPBD.AppBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = this.uSERSTableAdapter;
            this.tableAdapterManager.WAREHOUSETableAdapter = null;
            this.tableAdapterManager.WORK_POSITIONSTableAdapter = null;
            this.tableAdapterManager.WORKERSTableAdapter = null;
            this.tableAdapterManager.WRITERSTableAdapter = null;
            // 
            // ADMIN_UsersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_UsersManager";
            this.Text = "Таблица ~ Аккаунты | YourLibrary";
            this.Load += new System.EventHandler(this.ADMIN_UsersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBDDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private AppBDDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private AppBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSPORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_REG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDAYDATA;
        private System.Windows.Forms.DateTimePicker rEG_DATADateTimePicker;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.ComboBox gENDERComboBox;
        private System.Windows.Forms.TextBox pASSPORTTextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker bIRTHDAY_DATADateTimePicker;
        private System.Windows.Forms.TextBox uSERPASSWORDTextBox;
        private System.Windows.Forms.Label label1;
    }
}