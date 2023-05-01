using System.Collections.Generic;
using System.Reflection;

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
                _tableName.Text,
                _fieldsMatching.Text,
                _cycleFormField.Text,
                _secretKey.Text,
                _formId.Text,
                _integrationId.Text,
                _dateField.Text,
                _domain.Text
            } );

            if( Validation.IsEmpty() )
            {
                MessageBox.Show( "Заполнены не все поля!" );
                return;
            }

            IntegrationModel model = new IntegrationModel();
            model.Name = _nameIntegration.Text;
            model.ConnectionString = _connectionString.Text;
            model.TableName = _tableName.Text;
            model.FieldsMatching = _integration.ParseMatchingFieldsFromString( _fieldsMatching );
            model.CycleFormField = _cycleFormField.Text;
            model.SecretKey = _secretKey.Text;
            model.FormId = _formId.Text;
            model.IntegrationId = _integrationId.Text;
            model.DateField = _dateField.Text;
            model.Domain = _domain.Text;
            _listManager.Save( model );
            MessageBox.Show( "Данный сохранены!" );
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
                    MessageBox.Show( "Данные интеграции не обновленны!" );
                    return;
                }

                _nameIntegration.Text = model.Name;
                _connectionString.Text = model.ConnectionString;
                _tableName.Text = model.TableName;
                _fieldsMatching.Text = _integration.MatchingFieldsToString( model.FieldsMatching );
                _cycleFormField.Text = model.CycleFormField;
                _secretKey.Text = model.SecretKey;
                _formId.Text = model.FormId;
                _integrationId.Text = model.IntegrationId;
                _dateField.Text = model.DateField;
                _domain.Text = model.Domain;
            }
        }

        private void _list_SelectedIndexChanged( object sender, EventArgs e )
        {
            Refrash();
        }
    }
}