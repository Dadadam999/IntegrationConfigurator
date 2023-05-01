using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Save( IntegrationModel model )
        {

        }
    }
}
