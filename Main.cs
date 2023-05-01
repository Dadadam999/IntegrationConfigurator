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
            IntegrationModel model = new IntegrationModel();
            _listManager.Save( model );
            Refrash();
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
                _





            }
        }
    }
}