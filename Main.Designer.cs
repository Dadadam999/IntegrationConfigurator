namespace IntegrationConfigurator
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
            _list= new ListBox() ;
            panel1= new Panel() ;
            panel2= new Panel() ;
            _delete= new Button() ;
            _add= new Button() ;
            panel3= new Panel() ;
            tableLayoutPanel1= new TableLayoutPanel() ;
            label1= new Label() ;
            label2= new Label() ;
            label3= new Label() ;
            label4= new Label() ;
            label5= new Label() ;
            label6= new Label() ;
            label7= new Label() ;
            _nameIntegration= new TextBox() ;
            _connectionString= new TextBox() ;
            _tableName= new TextBox() ;
            _secretKey= new TextBox() ;
            _integrationId= new TextBox() ;
            _formId= new TextBox() ;
            _cycleFormField= new TextBox() ;
            label8= new Label() ;
            _fieldsMatching= new RichTextBox() ;
            panel4= new Panel() ;
            _save= new Button() ;
            label9= new Label() ;
            _dateField= new TextBox() ;
            splitter1= new Splitter() ;
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // _list
            // 
            _list.Dock= DockStyle.Fill ;
            _list.FormattingEnabled= true ;
            _list.ItemHeight= 25 ;
            _list.Location= new Point( 0, 40 ) ;
            _list.Name= "_list" ;
            _list.Size= new Size( 300, 1067 ) ;
            _list.TabIndex= 0 ;
            _list.SelectedIndexChanged+= _list_SelectedIndexChanged ;
            // 
            // panel1
            // 
            panel1.Controls.Add( _list );
            panel1.Controls.Add( panel2 );
            panel1.Dock= DockStyle.Left ;
            panel1.Location= new Point( 0, 0 ) ;
            panel1.Name= "panel1" ;
            panel1.Size= new Size( 300, 1107 ) ;
            panel1.TabIndex= 1 ;
            // 
            // panel2
            // 
            panel2.Controls.Add( _delete );
            panel2.Controls.Add( _add );
            panel2.Dock= DockStyle.Top ;
            panel2.Location= new Point( 0, 0 ) ;
            panel2.Name= "panel2" ;
            panel2.Size= new Size( 300, 40 ) ;
            panel2.TabIndex= 1 ;
            // 
            // _delete
            // 
            _delete.Dock= DockStyle.Left ;
            _delete.Location= new Point( 40, 0 ) ;
            _delete.Name= "_delete" ;
            _delete.Size= new Size( 40, 40 ) ;
            _delete.TabIndex= 1 ;
            _delete.Text= "-" ;
            _delete.UseVisualStyleBackColor= true ;
            _delete.Click+= _delete_Click ;
            // 
            // _add
            // 
            _add.Dock= DockStyle.Left ;
            _add.Location= new Point( 0, 0 ) ;
            _add.Name= "_add" ;
            _add.Size= new Size( 40, 40 ) ;
            _add.TabIndex= 0 ;
            _add.Text= "+" ;
            _add.UseVisualStyleBackColor= true ;
            _add.Click+= _add_Click ;
            // 
            // panel3
            // 
            panel3.Controls.Add( tableLayoutPanel1 );
            panel3.Dock= DockStyle.Fill ;
            panel3.Location= new Point( 300, 0 ) ;
            panel3.Name= "panel3" ;
            panel3.Size= new Size( 954, 1107 ) ;
            panel3.TabIndex= 2 ;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle= TableLayoutPanelCellBorderStyle.Single ;
            tableLayoutPanel1.ColumnCount= 2 ;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 30F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70F ) );
            tableLayoutPanel1.Controls.Add( label1, 0, 0 );
            tableLayoutPanel1.Controls.Add( label2, 0, 1 );
            tableLayoutPanel1.Controls.Add( label3, 0, 2 );
            tableLayoutPanel1.Controls.Add( label4, 0, 3 );
            tableLayoutPanel1.Controls.Add( label5, 0, 4 );
            tableLayoutPanel1.Controls.Add( label6, 0, 5 );
            tableLayoutPanel1.Controls.Add( label7, 0, 6 );
            tableLayoutPanel1.Controls.Add( _nameIntegration, 1, 0 );
            tableLayoutPanel1.Controls.Add( _connectionString, 1, 1 );
            tableLayoutPanel1.Controls.Add( _tableName, 1, 2 );
            tableLayoutPanel1.Controls.Add( _secretKey, 1, 3 );
            tableLayoutPanel1.Controls.Add( _integrationId, 1, 4 );
            tableLayoutPanel1.Controls.Add( _formId, 1, 5 );
            tableLayoutPanel1.Controls.Add( _cycleFormField, 1, 6 );
            tableLayoutPanel1.Controls.Add( label8, 0, 8 );
            tableLayoutPanel1.Controls.Add( _fieldsMatching, 1, 8 );
            tableLayoutPanel1.Controls.Add( panel4, 1, 9 );
            tableLayoutPanel1.Controls.Add( label9, 0, 7 );
            tableLayoutPanel1.Controls.Add( _dateField, 1, 7 );
            tableLayoutPanel1.Dock= DockStyle.Fill ;
            tableLayoutPanel1.Location= new Point( 0, 0 ) ;
            tableLayoutPanel1.Name= "tableLayoutPanel1" ;
            tableLayoutPanel1.RowCount= 10 ;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 500F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Absolute, 50F ) );
            tableLayoutPanel1.Size= new Size( 954, 1107 ) ;
            tableLayoutPanel1.TabIndex= 0 ;
            // 
            // label1
            // 
            label1.Dock= DockStyle.Fill ;
            label1.Location= new Point( 4, 1 ) ;
            label1.Name= "label1" ;
            label1.Size= new Size( 279, 50 ) ;
            label1.TabIndex= 0 ;
            label1.Text= "Наименование" ;
            // 
            // label2
            // 
            label2.Dock= DockStyle.Fill ;
            label2.Location= new Point( 4, 52 ) ;
            label2.Name= "label2" ;
            label2.Size= new Size( 279, 50 ) ;
            label2.TabIndex= 1 ;
            label2.Text= "Строка подключения MSSQL" ;
            // 
            // label3
            // 
            label3.Dock= DockStyle.Fill ;
            label3.Location= new Point( 4, 103 ) ;
            label3.Name= "label3" ;
            label3.Size= new Size( 279, 50 ) ;
            label3.TabIndex= 3 ;
            label3.Text= "Имя таблицы MSSQL" ;
            // 
            // label4
            // 
            label4.Dock= DockStyle.Fill ;
            label4.Location= new Point( 4, 154 ) ;
            label4.Name= "label4" ;
            label4.Size= new Size( 279, 50 ) ;
            label4.TabIndex= 4 ;
            label4.Text= "Секретный ключ WEB" ;
            // 
            // label5
            // 
            label5.Dock= DockStyle.Fill ;
            label5.Location= new Point( 4, 205 ) ;
            label5.Name= "label5" ;
            label5.Size= new Size( 279, 50 ) ;
            label5.TabIndex= 5 ;
            label5.Text= "ID интеграции WEB" ;
            // 
            // label6
            // 
            label6.Dock= DockStyle.Fill ;
            label6.Location= new Point( 4, 256 ) ;
            label6.Name= "label6" ;
            label6.Size= new Size( 279, 50 ) ;
            label6.TabIndex= 6 ;
            label6.Text= "ID формы WEB" ;
            // 
            // label7
            // 
            label7.Dock= DockStyle.Fill ;
            label7.Location= new Point( 4, 307 ) ;
            label7.Name= "label7" ;
            label7.Size= new Size( 279, 50 ) ;
            label7.TabIndex= 7 ;
            label7.Text= "Имя поля с циклами WEB" ;
            // 
            // _nameIntegration
            // 
            _nameIntegration.Dock= DockStyle.Fill ;
            _nameIntegration.Enabled= false ;
            _nameIntegration.Location= new Point( 290, 4 ) ;
            _nameIntegration.Name= "_nameIntegration" ;
            _nameIntegration.Size= new Size( 660, 31 ) ;
            _nameIntegration.TabIndex= 9 ;
            // 
            // _connectionString
            // 
            _connectionString.Dock= DockStyle.Fill ;
            _connectionString.Location= new Point( 290, 55 ) ;
            _connectionString.Name= "_connectionString" ;
            _connectionString.Size= new Size( 660, 31 ) ;
            _connectionString.TabIndex= 10 ;
            // 
            // _tableName
            // 
            _tableName.Dock= DockStyle.Fill ;
            _tableName.Location= new Point( 290, 106 ) ;
            _tableName.Name= "_tableName" ;
            _tableName.Size= new Size( 660, 31 ) ;
            _tableName.TabIndex= 11 ;
            // 
            // _secretKey
            // 
            _secretKey.Dock= DockStyle.Fill ;
            _secretKey.Location= new Point( 290, 157 ) ;
            _secretKey.Name= "_secretKey" ;
            _secretKey.Size= new Size( 660, 31 ) ;
            _secretKey.TabIndex= 12 ;
            // 
            // _integrationId
            // 
            _integrationId.Dock= DockStyle.Fill ;
            _integrationId.Location= new Point( 290, 208 ) ;
            _integrationId.Name= "_integrationId" ;
            _integrationId.Size= new Size( 660, 31 ) ;
            _integrationId.TabIndex= 13 ;
            // 
            // _formId
            // 
            _formId.Dock= DockStyle.Fill ;
            _formId.Location= new Point( 290, 259 ) ;
            _formId.Name= "_formId" ;
            _formId.Size= new Size( 660, 31 ) ;
            _formId.TabIndex= 14 ;
            // 
            // _cycleFormField
            // 
            _cycleFormField.Dock= DockStyle.Fill ;
            _cycleFormField.Location= new Point( 290, 310 ) ;
            _cycleFormField.Name= "_cycleFormField" ;
            _cycleFormField.Size= new Size( 660, 31 ) ;
            _cycleFormField.TabIndex= 15 ;
            // 
            // label8
            // 
            label8.Location= new Point( 4, 409 ) ;
            label8.Name= "label8" ;
            label8.Size= new Size( 279, 500 ) ;
            label8.TabIndex= 8 ;
            label8.Text= "Соотношение полей\r\nВведите поля через запятую сначала поле в MSSQL потом название поле интеграции формы.\r\nНапример: \r\nLastName,Фамилия\r\nFirstName,Имя" ;
            // 
            // _fieldsMatching
            // 
            _fieldsMatching.Location= new Point( 290, 412 ) ;
            _fieldsMatching.Name= "_fieldsMatching" ;
            _fieldsMatching.Size= new Size( 658, 491 ) ;
            _fieldsMatching.TabIndex= 16 ;
            _fieldsMatching.Text= "" ;
            // 
            // panel4
            // 
            panel4.Controls.Add( _save );
            panel4.Dock= DockStyle.Fill ;
            panel4.Location= new Point( 291, 915 ) ;
            panel4.Margin= new Padding( 4, 5, 4, 5 ) ;
            panel4.Name= "panel4" ;
            panel4.Size= new Size( 658, 186 ) ;
            panel4.TabIndex= 17 ;
            // 
            // _save
            // 
            _save.Dock= DockStyle.Top ;
            _save.Location= new Point( 0, 0 ) ;
            _save.Name= "_save" ;
            _save.Size= new Size( 658, 45 ) ;
            _save.TabIndex= 2 ;
            _save.Text= "Сохранить" ;
            _save.UseVisualStyleBackColor= true ;
            _save.Click+= _save_Click ;
            // 
            // label9
            // 
            label9.Dock= DockStyle.Fill ;
            label9.Location= new Point( 5, 358 ) ;
            label9.Margin= new Padding( 4, 0, 4, 0 ) ;
            label9.Name= "label9" ;
            label9.Size= new Size( 277, 50 ) ;
            label9.TabIndex= 18 ;
            label9.Text= "Поле сверки даты MSSQL" ;
            // 
            // _dateField
            // 
            _dateField.Dock= DockStyle.Fill ;
            _dateField.Location= new Point( 291, 363 ) ;
            _dateField.Margin= new Padding( 4, 5, 4, 5 ) ;
            _dateField.Name= "_dateField" ;
            _dateField.Size= new Size( 658, 31 ) ;
            _dateField.TabIndex= 19 ;
            // 
            // splitter1
            // 
            splitter1.Location= new Point( 300, 0 ) ;
            splitter1.Name= "splitter1" ;
            splitter1.Size= new Size( 4, 1107 ) ;
            splitter1.TabIndex= 3 ;
            splitter1.TabStop= false ;
            // 
            // Main
            // 
            AutoScaleDimensions= new SizeF( 10F, 25F ) ;
            AutoScaleMode= AutoScaleMode.Font ;
            ClientSize= new Size( 1254, 1107 ) ;
            Controls.Add( splitter1 );
            Controls.Add( panel3 );
            Controls.Add( panel1 );
            Name= "Main" ;
            Text= "Конфигуратор интеграций" ;
            panel1.ResumeLayout( false );
            panel2.ResumeLayout( false );
            panel3.ResumeLayout( false );
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout( false );
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
        private Button _save;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox _nameIntegration;
        private TextBox _connectionString;
        private TextBox _tableName;
        private TextBox _secretKey;
        private TextBox _integrationId;
        private TextBox _formId;
        private TextBox _cycleFormField;
        private RichTextBox _fieldsMatching;
        private Panel panel4;
        private Label label9;
        private TextBox _dateField;
    }
}