﻿namespace IntegrationConfigurator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Main ) );
            _list = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            _copy = new FontAwesome.Sharp.IconButton();
            _delete = new Button();
            _add = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            label14 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            _periodDate = new TextBox();
            _formId = new TextBox();
            _integrationId = new TextBox();
            _secretKey = new TextBox();
            _domain = new TextBox();
            _connectionString = new TextBox();
            _nameIntegration = new TextBox();
            label16 = new Label();
            _typeIntegration = new ComboBox();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            _tableNamePreview = new TextBox();
            _dateField = new TextBox();
            label9 = new Label();
            label13 = new Label();
            _orderIdField = new TextBox();
            label8 = new Label();
            _fieldsMatching = new RichTextBox();
            label17 = new Label();
            _formIdField = new TextBox();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label11 = new Label();
            _tableNameCycles = new TextBox();
            label7 = new Label();
            _cycleFormField = new TextBox();
            label12 = new Label();
            _cyclesListField = new TextBox();
            label15 = new Label();
            _checkedCyclesField = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            label18 = new Label();
            _isWorkIntegration = new CheckBox();
            _save = new FontAwesome.Sharp.IconButton();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // _list
            // 
            _list.Dock = DockStyle.Fill;
            _list.FormattingEnabled = true;
            _list.ItemHeight = 25;
            _list.Location = new Point( 0, 40 );
            _list.Name = "_list";
            _list.Size = new Size( 300, 1180 );
            _list.TabIndex = 0;
            _list.SelectedIndexChanged +=  _list_SelectedIndexChanged ;
            // 
            // panel1
            // 
            panel1.Controls.Add( _list );
            panel1.Controls.Add( panel2 );
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point( 0, 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 300, 1220 );
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add( _copy );
            panel2.Controls.Add( _delete );
            panel2.Controls.Add( _add );
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point( 0, 0 );
            panel2.Name = "panel2";
            panel2.Size = new Size( 300, 40 );
            panel2.TabIndex = 1;
            // 
            // _copy
            // 
            _copy.Dock = DockStyle.Left;
            _copy.IconChar = FontAwesome.Sharp.IconChar.Copy;
            _copy.IconColor = Color.Black;
            _copy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            _copy.IconSize = 20;
            _copy.Location = new Point( 80, 0 );
            _copy.Name = "_copy";
            _copy.Size = new Size( 40, 40 );
            _copy.TabIndex = 3;
            _copy.UseVisualStyleBackColor = true;
            _copy.Click +=  _copy_Click ;
            // 
            // _delete
            // 
            _delete.Dock = DockStyle.Left;
            _delete.Location = new Point( 40, 0 );
            _delete.Name = "_delete";
            _delete.Size = new Size( 40, 40 );
            _delete.TabIndex = 1;
            _delete.Text = "-";
            _delete.UseVisualStyleBackColor = true;
            _delete.Click +=  _delete_Click ;
            // 
            // _add
            // 
            _add.Dock = DockStyle.Left;
            _add.Location = new Point( 0, 0 );
            _add.Name = "_add";
            _add.Size = new Size( 40, 40 );
            _add.TabIndex = 0;
            _add.Text = "+";
            _add.UseVisualStyleBackColor = true;
            _add.Click +=  _add_Click ;
            // 
            // panel3
            // 
            panel3.Controls.Add( tabControl1 );
            panel3.Controls.Add( panel4 );
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point( 304, 0 );
            panel3.Name = "panel3";
            panel3.Size = new Size( 950, 1220 );
            panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add( tabPage1 );
            tabControl1.Controls.Add( tabPage2 );
            tabControl1.Controls.Add( tabPage3 );
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point( 0, 0 );
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size( 950, 1120 );
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add( tableLayoutPanel1 );
            tabPage1.Location = new Point( 4, 34 );
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding( 3 );
            tabPage1.Size = new Size( 942, 1082 );
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Основные";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 30F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70F ) );
            tableLayoutPanel1.Controls.Add( label14, 0, 7 );
            tableLayoutPanel1.Controls.Add( label6, 0, 6 );
            tableLayoutPanel1.Controls.Add( label5, 0, 5 );
            tableLayoutPanel1.Controls.Add( label4, 0, 4 );
            tableLayoutPanel1.Controls.Add( label10, 0, 3 );
            tableLayoutPanel1.Controls.Add( label2, 0, 2 );
            tableLayoutPanel1.Controls.Add( label1, 0, 1 );
            tableLayoutPanel1.Controls.Add( _periodDate, 1, 7 );
            tableLayoutPanel1.Controls.Add( _formId, 1, 6 );
            tableLayoutPanel1.Controls.Add( _integrationId, 1, 5 );
            tableLayoutPanel1.Controls.Add( _secretKey, 1, 4 );
            tableLayoutPanel1.Controls.Add( _domain, 1, 3 );
            tableLayoutPanel1.Controls.Add( _connectionString, 1, 2 );
            tableLayoutPanel1.Controls.Add( _nameIntegration, 1, 1 );
            tableLayoutPanel1.Controls.Add( label16, 0, 0 );
            tableLayoutPanel1.Controls.Add( _typeIntegration, 1, 0 );
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point( 3, 3 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            tableLayoutPanel1.Size = new Size( 936, 1076 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point( 4, 358 );
            label14.Name = "label14";
            label14.Size = new Size( 273, 50 );
            label14.TabIndex = 23;
            label14.Text = "Период выгрузки (дни)";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point( 4, 307 );
            label6.Name = "label6";
            label6.Size = new Size( 273, 50 );
            label6.TabIndex = 6;
            label6.Text = "ID формы WEB";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point( 4, 256 );
            label5.Name = "label5";
            label5.Size = new Size( 273, 50 );
            label5.TabIndex = 5;
            label5.Text = "ID интеграции WEB";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point( 4, 205 );
            label4.Name = "label4";
            label4.Size = new Size( 273, 50 );
            label4.TabIndex = 22;
            label4.Text = "Секретный ключ WEB";
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point( 4, 154 );
            label10.Name = "label10";
            label10.Size = new Size( 273, 50 );
            label10.TabIndex = 20;
            label10.Text = "Домен сайта";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point( 4, 103 );
            label2.Name = "label2";
            label2.Size = new Size( 273, 50 );
            label2.TabIndex = 1;
            label2.Text = "Строка подключения MSSQL";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point( 4, 52 );
            label1.Name = "label1";
            label1.Size = new Size( 273, 50 );
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // _periodDate
            // 
            _periodDate.Dock = DockStyle.Fill;
            _periodDate.Location = new Point( 284, 361 );
            _periodDate.Name = "_periodDate";
            _periodDate.Size = new Size( 648, 31 );
            _periodDate.TabIndex = 24;
            _periodDate.Text = "90";
            // 
            // _formId
            // 
            _formId.Dock = DockStyle.Fill;
            _formId.Location = new Point( 284, 310 );
            _formId.Name = "_formId";
            _formId.Size = new Size( 648, 31 );
            _formId.TabIndex = 14;
            // 
            // _integrationId
            // 
            _integrationId.Dock = DockStyle.Fill;
            _integrationId.Location = new Point( 284, 259 );
            _integrationId.Name = "_integrationId";
            _integrationId.Size = new Size( 648, 31 );
            _integrationId.TabIndex = 13;
            // 
            // _secretKey
            // 
            _secretKey.Dock = DockStyle.Fill;
            _secretKey.Location = new Point( 284, 208 );
            _secretKey.Name = "_secretKey";
            _secretKey.Size = new Size( 648, 31 );
            _secretKey.TabIndex = 12;
            // 
            // _domain
            // 
            _domain.Dock = DockStyle.Fill;
            _domain.Location = new Point( 284, 157 );
            _domain.Name = "_domain";
            _domain.Size = new Size( 648, 31 );
            _domain.TabIndex = 21;
            // 
            // _connectionString
            // 
            _connectionString.Dock = DockStyle.Fill;
            _connectionString.Location = new Point( 284, 106 );
            _connectionString.Name = "_connectionString";
            _connectionString.Size = new Size( 648, 31 );
            _connectionString.TabIndex = 10;
            // 
            // _nameIntegration
            // 
            _nameIntegration.Dock = DockStyle.Fill;
            _nameIntegration.Enabled = false;
            _nameIntegration.Location = new Point( 284, 55 );
            _nameIntegration.Name = "_nameIntegration";
            _nameIntegration.Size = new Size( 648, 31 );
            _nameIntegration.TabIndex = 9;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point( 4, 1 );
            label16.Name = "label16";
            label16.Size = new Size( 273, 50 );
            label16.TabIndex = 25;
            label16.Text = "Тип интеграции";
            // 
            // _typeIntegration
            // 
            _typeIntegration.Dock = DockStyle.Fill;
            _typeIntegration.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeIntegration.FormattingEnabled = true;
            _typeIntegration.Items.AddRange( new object[] { "Yandex", "Quick Form" } );
            _typeIntegration.Location = new Point( 284, 4 );
            _typeIntegration.Name = "_typeIntegration";
            _typeIntegration.Size = new Size( 648, 33 );
            _typeIntegration.TabIndex = 26;
            _typeIntegration.SelectedIndexChanged +=  _typeIntegration_SelectedIndexChanged ;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add( tableLayoutPanel2 );
            tabPage2.Location = new Point( 4, 34 );
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding( 3 );
            tabPage2.Size = new Size( 942, 1082 );
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ответы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 30F ) );
            tableLayoutPanel2.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70F ) );
            tableLayoutPanel2.Controls.Add( label3, 0, 0 );
            tableLayoutPanel2.Controls.Add( _tableNamePreview, 1, 0 );
            tableLayoutPanel2.Controls.Add( _dateField, 1, 1 );
            tableLayoutPanel2.Controls.Add( label9, 0, 1 );
            tableLayoutPanel2.Controls.Add( label13, 0, 2 );
            tableLayoutPanel2.Controls.Add( _orderIdField, 1, 2 );
            tableLayoutPanel2.Controls.Add( label8, 0, 4 );
            tableLayoutPanel2.Controls.Add( _fieldsMatching, 1, 4 );
            tableLayoutPanel2.Controls.Add( label17, 0, 3 );
            tableLayoutPanel2.Controls.Add( _formIdField, 1, 3 );
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point( 3, 3 );
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 500F ) );
            tableLayoutPanel2.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            tableLayoutPanel2.Size = new Size( 936, 1076 );
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point( 4, 1 );
            label3.Name = "label3";
            label3.Size = new Size( 273, 50 );
            label3.TabIndex = 4;
            label3.Text = "Имя таблицы MSSQL";
            // 
            // _tableNamePreview
            // 
            _tableNamePreview.Dock = DockStyle.Fill;
            _tableNamePreview.Location = new Point( 284, 4 );
            _tableNamePreview.Name = "_tableNamePreview";
            _tableNamePreview.Size = new Size( 648, 31 );
            _tableNamePreview.TabIndex = 12;
            // 
            // _dateField
            // 
            _dateField.Dock = DockStyle.Fill;
            _dateField.Location = new Point( 285, 57 );
            _dateField.Margin = new Padding( 4, 5, 4, 5 );
            _dateField.Name = "_dateField";
            _dateField.Size = new Size( 646, 31 );
            _dateField.TabIndex = 20;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point( 5, 52 );
            label9.Margin = new Padding( 4, 0, 4, 0 );
            label9.Name = "label9";
            label9.Size = new Size( 271, 50 );
            label9.TabIndex = 19;
            label9.Text = "Поле сверки даты MSSQL";
            // 
            // label13
            // 
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point( 4, 103 );
            label13.Name = "label13";
            label13.Size = new Size( 273, 50 );
            label13.TabIndex = 23;
            label13.Text = "Поле ID заявки MSSQL";
            // 
            // _orderIdField
            // 
            _orderIdField.Dock = DockStyle.Fill;
            _orderIdField.Location = new Point( 284, 106 );
            _orderIdField.Name = "_orderIdField";
            _orderIdField.Size = new Size( 648, 31 );
            _orderIdField.TabIndex = 24;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point( 4, 205 );
            label8.Name = "label8";
            label8.Size = new Size( 273, 500 );
            label8.TabIndex = 21;
            label8.Text = "Соотношение полей\r\nВведите поля через запятую сначала поле в MSSQL потом название поле интеграции формы.\r\nНапример: \r\nLastName,Фамилия\r\nFirstName,Имя";
            // 
            // _fieldsMatching
            // 
            _fieldsMatching.Dock = DockStyle.Fill;
            _fieldsMatching.Location = new Point( 284, 208 );
            _fieldsMatching.Name = "_fieldsMatching";
            _fieldsMatching.Size = new Size( 648, 494 );
            _fieldsMatching.TabIndex = 22;
            _fieldsMatching.Text = "";
            // 
            // label17
            // 
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point( 4, 154 );
            label17.Name = "label17";
            label17.Size = new Size( 273, 50 );
            label17.TabIndex = 25;
            label17.Text = "Поле ID формы MSSQL";
            // 
            // _formIdField
            // 
            _formIdField.Dock = DockStyle.Fill;
            _formIdField.Location = new Point( 284, 157 );
            _formIdField.Name = "_formIdField";
            _formIdField.Size = new Size( 648, 31 );
            _formIdField.TabIndex = 26;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add( tableLayoutPanel3 );
            tabPage3.Location = new Point( 4, 34 );
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size( 942, 1082 );
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Циклы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 30F ) );
            tableLayoutPanel3.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70F ) );
            tableLayoutPanel3.Controls.Add( label11, 0, 0 );
            tableLayoutPanel3.Controls.Add( _tableNameCycles, 1, 0 );
            tableLayoutPanel3.Controls.Add( label7, 0, 2 );
            tableLayoutPanel3.Controls.Add( _cycleFormField, 1, 2 );
            tableLayoutPanel3.Controls.Add( label12, 0, 1 );
            tableLayoutPanel3.Controls.Add( _cyclesListField, 1, 1 );
            tableLayoutPanel3.Controls.Add( label15, 0, 3 );
            tableLayoutPanel3.Controls.Add( _checkedCyclesField, 1, 3 );
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point( 0, 0 );
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel3.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel3.Size = new Size( 942, 1082 );
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point( 4, 1 );
            label11.Name = "label11";
            label11.Size = new Size( 275, 50 );
            label11.TabIndex = 0;
            label11.Text = "Имя таблицы MSSQL";
            // 
            // _tableNameCycles
            // 
            _tableNameCycles.Dock = DockStyle.Fill;
            _tableNameCycles.Location = new Point( 286, 4 );
            _tableNameCycles.Name = "_tableNameCycles";
            _tableNameCycles.Size = new Size( 652, 31 );
            _tableNameCycles.TabIndex = 1;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point( 4, 103 );
            label7.Name = "label7";
            label7.Size = new Size( 275, 50 );
            label7.TabIndex = 24;
            label7.Text = "Имя поля с циклами WEB";
            // 
            // _cycleFormField
            // 
            _cycleFormField.Dock = DockStyle.Fill;
            _cycleFormField.Location = new Point( 286, 106 );
            _cycleFormField.Name = "_cycleFormField";
            _cycleFormField.Size = new Size( 652, 31 );
            _cycleFormField.TabIndex = 25;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point( 4, 52 );
            label12.Name = "label12";
            label12.Size = new Size( 275, 50 );
            label12.TabIndex = 26;
            label12.Text = "Имя поля с циклами MSSQL";
            // 
            // _cyclesListField
            // 
            _cyclesListField.Dock = DockStyle.Fill;
            _cyclesListField.Location = new Point( 286, 55 );
            _cyclesListField.Name = "_cyclesListField";
            _cyclesListField.Size = new Size( 652, 31 );
            _cyclesListField.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point( 4, 154 );
            label15.Name = "label15";
            label15.Size = new Size( 218, 50 );
            label15.TabIndex = 28;
            label15.Text = "Имя поля выбора цикла MSSQL";
            // 
            // _checkedCyclesField
            // 
            _checkedCyclesField.Dock = DockStyle.Fill;
            _checkedCyclesField.Location = new Point( 286, 157 );
            _checkedCyclesField.Name = "_checkedCyclesField";
            _checkedCyclesField.Size = new Size( 652, 31 );
            _checkedCyclesField.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add( panel5 );
            panel4.Controls.Add( _save );
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point( 0, 1120 );
            panel4.Name = "panel4";
            panel4.Size = new Size( 950, 100 );
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add( label18 );
            panel5.Controls.Add( _isWorkIntegration );
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point( 0, 0 );
            panel5.Name = "panel5";
            panel5.Size = new Size( 950, 50 );
            panel5.TabIndex = 4;
            // 
            // label18
            // 
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point( 105, 0 );
            label18.Name = "label18";
            label18.Size = new Size( 845, 50 );
            label18.TabIndex = 4;
            label18.Text = "Использовать интеграцию";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _isWorkIntegration
            // 
            _isWorkIntegration.CheckAlign = ContentAlignment.MiddleCenter;
            _isWorkIntegration.Checked = true;
            _isWorkIntegration.CheckState = CheckState.Checked;
            _isWorkIntegration.Dock = DockStyle.Left;
            _isWorkIntegration.Location = new Point( 0, 0 );
            _isWorkIntegration.Name = "_isWorkIntegration";
            _isWorkIntegration.Size = new Size( 105, 50 );
            _isWorkIntegration.TabIndex = 3;
            _isWorkIntegration.TextAlign = ContentAlignment.MiddleCenter;
            _isWorkIntegration.UseVisualStyleBackColor = true;
            // 
            // _save
            // 
            _save.Dock = DockStyle.Bottom;
            _save.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            _save.IconColor = Color.CornflowerBlue;
            _save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            _save.IconSize = 25;
            _save.ImageAlign = ContentAlignment.MiddleLeft;
            _save.Location = new Point( 0, 50 );
            _save.Name = "_save";
            _save.Size = new Size( 950, 50 );
            _save.TabIndex = 27;
            _save.Text = "Сохранить";
            _save.UseVisualStyleBackColor = true;
            _save.Click +=  _save_Click ;
            // 
            // splitter1
            // 
            splitter1.Location = new Point( 300, 0 );
            splitter1.Name = "splitter1";
            splitter1.Size = new Size( 4, 1220 );
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF( 10F, 25F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 1254, 1220 );
            Controls.Add( panel3 );
            Controls.Add( splitter1 );
            Controls.Add( panel1 );
            Icon = (Icon) resources.GetObject( "$this.Icon" );
            Name = "Main";
            Text = "Конфигуратор интеграций";
            panel1.ResumeLayout( false );
            panel2.ResumeLayout( false );
            panel3.ResumeLayout( false );
            tabControl1.ResumeLayout( false );
            tabPage1.ResumeLayout( false );
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout( false );
            tableLayoutPanel2.ResumeLayout( false );
            tableLayoutPanel2.PerformLayout();
            tabPage3.ResumeLayout( false );
            tableLayoutPanel3.ResumeLayout( false );
            tableLayoutPanel3.PerformLayout();
            panel4.ResumeLayout( false );
            panel5.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private ListBox _list;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Splitter splitter1;
        private Button _delete;
        private Button _add;
        private Label label5;
        private Label label6;
        private TextBox _nameIntegration;
        private TextBox _connectionString;
        private TextBox _secretKey;
        private TextBox _integrationId;
        private TextBox _formId;
        private Label label10;
        private TextBox _domain;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPage3;
        private Label label3;
        private TextBox _tableNamePreview;
        private Label label4;
        private TextBox _dateField;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label11;
        private TextBox _tableNameCycles;
        private Label label8;
        private RichTextBox _fieldsMatching;
        private TextBox _cycleFormField;
        private Label label7;
        private Label label12;
        private TextBox _cyclesListField;
        private Label label13;
        private TextBox _orderIdField;
        private Label label14;
        private TextBox _periodDate;
        private Label label15;
        private TextBox _checkedCyclesField;
        private Label label16;
        private ComboBox _typeIntegration;
        private FontAwesome.Sharp.IconButton _copy;
        private Label label17;
        private TextBox _formIdField;
        private Panel panel4;
        private CheckBox _isWorkIntegration;
        private Panel panel5;
        private Label label18;
        private FontAwesome.Sharp.IconButton _save;
    }
}