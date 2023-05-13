namespace IntegrationConfigurator
{
    public partial class Main : Form
    {
        private Integration _integration { get; set; }
        private ListManager _listManager { get; set; }

        public Main()
        {
            InitializeComponent();
            _integration = new Integration();
            _listManager = new ListManager( _list, _integration );
            _integration.Deserialize();
            _listManager.Refrash();
            Refrash();
        }

        private void _save_Click( object sender, EventArgs e )
        {
            Validation.SetStrings( new List<string>
            {
                _nameIntegration.Text,
                _connectionString.Text,
                _tableNamePreview.Text,
                _tableNameCycles.Text,
                _fieldsMatching.Text,
                _cycleFormField.Text,
                _cyclesListField.Text,
                _secretKey.Text,
                _formId.Text,
                _integrationId.Text,
                _dateField.Text,
                _domain.Text,
                _orderIdField.Text,
                _periodDate.Text,
                _checkedCyclesField.Text
            } );

            if( Validation.IsEmpty() )
            {
                MessageBox.Show( "��������� �� ��� ����!" );
                return;
            }

            IntegrationModel model = new IntegrationModel();
            model.Name = _nameIntegration.Text;
            model.ConnectionString = _connectionString.Text;
            model.TableNamePreview = _tableNamePreview.Text;
            model.TableNameCycles = _tableNameCycles.Text;
            model.FieldsMatching = _integration.ParseMatchingFieldsFromString( _fieldsMatching );
            model.CycleFormField = _cycleFormField.Text;
            model.CyclesListField = _cyclesListField.Text;
            model.SecretKey = _secretKey.Text;
            model.FormId = _formId.Text;
            model.IntegrationId = _integrationId.Text;
            model.DateField = _dateField.Text;
            model.Domain = _domain.Text;
            model.OrderIdField = _orderIdField.Text;
            model.PeriodDate = _periodDate.Text;
            model.CheckedCyclesField = _checkedCyclesField.Text;
            _listManager.Save( model );
            MessageBox.Show( "������ ���������!" );
        }

        private void _add_Click( object sender, EventArgs e )
        {
            _listManager.Add();
            Refrash();
        }

        private void _delete_Click( object sender, EventArgs e )
        {
            _listManager.Remove();
            Refrash();
        }

        private void Refrash()
        {
            if( _list.Items.Count > 0 )
            {
                IntegrationModel? model = _integration.GetByName( (string) _list.Items[_list.SelectedIndex] );

                if( model == null )
                {
                    MessageBox.Show( "������ ���������� �� ����������!" );
                    return;
                }

                _nameIntegration.Text = model.Name;
                _connectionString.Text = model.ConnectionString;
                _tableNamePreview.Text = model.TableNamePreview;
                _tableNameCycles.Text = model.TableNameCycles;
                _fieldsMatching.Text = _integration.MatchingFieldsToString( model.FieldsMatching );
                _cycleFormField.Text = model.CycleFormField;
                _cyclesListField.Text = model.CyclesListField;
                _secretKey.Text = model.SecretKey;
                _formId.Text = model.FormId;
                _integrationId.Text = model.IntegrationId;
                _dateField.Text = model.DateField;
                _domain.Text = model.Domain;
                _orderIdField.Text = model.OrderIdField;
                _periodDate.Text = model.PeriodDate;
                _checkedCyclesField.Text = model.CheckedCyclesField;
            }
        }

        private void _list_SelectedIndexChanged( object sender, EventArgs e )
        {
            Refrash();
        }
    }
}