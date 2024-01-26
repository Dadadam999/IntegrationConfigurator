namespace IntegrationConfigurator
{
    internal class ListManager
    {
        private ListBox _list;
        private Integration _integration;
        public ListManager( ListBox list, Integration integration )
        {
            _list = list;
            _integration = integration;
        }

        public void Add()
        {
            IntegrationModel model = new();
            model.Name = "Интеграция " + ( _list.Items.Count + 1 );
            _integration.Integrations.Add( model );
            Refrash();
        }

        public void Remove()
        {
            if( _list.SelectedIndex >= 0 )
            {
                IntegrationModel? model = _integration.GetByName( (string) _list.Items[_list.SelectedIndex] );

                if( model == null )
                {
                    MessageBox.Show( "Такой интеграции нет!" );
                    return;
                }

                _integration.Integrations.Remove( model );
                Refrash();
            }
        }

        public void Refrash()
        {
            if( _integration.Integrations.Count > 0 )
            {
                _list.Items.Clear();

                _integration.Integrations.ForEach( integration =>
                {
                    _list.Items.Add( integration.Name );
                } );

                _list.SelectedIndex = 0;
            }
        }

        public void Copy()
        {
            if( _integration.Integrations.Count <= 0 )
            {
                MessageBox.Show( "Список пуст!" );
                return;
            }

            IntegrationModel? originalModel = _integration.GetByName( (string) _list.Items[_list.SelectedIndex] );

            if( originalModel == null )
            {
                MessageBox.Show( "Выберите сохранённую интеграцию для копирования!" );
                return;
            }

            IntegrationModel model = new();
            model.ConnectionString = originalModel.ConnectionString;
            model.TableNamePreview = originalModel.TableNamePreview;
            model.TableNameCycles = originalModel.TableNameCycles;
            model.FieldsMatching = originalModel.FieldsMatching;
            model.CycleFormField = originalModel.CycleFormField;
            model.CyclesListField = originalModel.CyclesListField;
            model.SecretKey = originalModel.SecretKey;
            model.FormId = originalModel.FormId;
            model.IntegrationId = originalModel.IntegrationId;
            model.DateField = originalModel.DateField;
            model.Domain = originalModel.Domain;
            model.OrderIdField = originalModel.OrderIdField;
            model.PeriodDate = originalModel.PeriodDate;
            model.CheckedCyclesField = originalModel.CheckedCyclesField;
            model.TypeIntegration = originalModel.TypeIntegration;
            model.Name = "Интеграция " + ( _list.Items.Count + 1 );
            _integration.Integrations.Add( model );
            Refrash();
            _list.SelectedIndex = _list.Items.Count - 1;
        }

        public void Save( IntegrationModel model )
        {
            IntegrationModel? existingModel = _integration.GetByName( model.Name );
            
            if( existingModel == null )
            {
                MessageBox.Show( "Ошибка при сохранении интеграции!" );
                return;
            }

            existingModel.ConnectionString = model.ConnectionString;
            existingModel.TableNamePreview = model.TableNamePreview;
            existingModel.TableNameCycles = model.TableNameCycles;
            existingModel.FieldsMatching = model.FieldsMatching;
            existingModel.CycleFormField = model.CycleFormField;
            existingModel.CyclesListField = model.CyclesListField;
            existingModel.SecretKey = model.SecretKey;
            existingModel.FormId = model.FormId;
            existingModel.IntegrationId = model.IntegrationId;
            existingModel.DateField = model.DateField;
            existingModel.Domain = model.Domain;
            existingModel.OrderIdField = model.OrderIdField;
            existingModel.PeriodDate = model.PeriodDate;
            existingModel.CheckedCyclesField = model.CheckedCyclesField;
            existingModel.TypeIntegration = model.TypeIntegration;
            _integration.Serialize();
        }

    }
}
