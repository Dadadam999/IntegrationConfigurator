using System.Runtime.Serialization.Formatters.Binary;

namespace IntegrationConfigurator
{
    [Serializable]
    public class Integration
    {
        private BinaryFormatter _formatter;
        public List<IntegrationModel> Integrations { get; set; } = new List<IntegrationModel>();

        public IntegrationModel? GetByName( string name )
        {
            IntegrationModel? model = Integrations.Find( x => x.Name == name );

            if( model == null )
                return null;

            return model;
        }

        public void Serialize()
        {
            _formatter = new BinaryFormatter();

            try
            {
                using FileStream stream = new FileStream( "config.integration", FileMode.Create );
                _formatter.Serialize( stream, Integrations );
            }
            catch( Exception ex )
            {
                MessageBox.Show( $"Ошибка при сохранении данных: {ex.Message}" );
            }
        }

        public void Deserialize()
        {
            if( !File.Exists( "config.integration" ) )
                return;

            _formatter= new BinaryFormatter();

            try
            {
                using FileStream stream = new FileStream( "config.integration", FileMode.Open );
                Integrations = ( List<IntegrationModel> ) _formatter.Deserialize( stream );
            }
            catch( Exception ex )
            {

                MessageBox.Show( $"Ошибка при загрузке данных: {ex.Message}" );
            }
        }

        public Dictionary<string,string> ParseMatchingFieldsFromString( RichTextBox text )
        {
            Dictionary<string, string> result = new();

            try
            {

                foreach( string line in text.Lines )
                {
                    string[] fields = line.Split( ',' );
                    result.Add( fields[0], fields[1] );
                }

            }
            catch( Exception ex )
            {
                MessageBox.Show( $"Данные поля соответсвия полей введены не вверном формате!\nОшибка:{ex.Message}" );
            }
            return result;
        }

        public string MatchingFieldsToString( Dictionary<string, string> fields )
        {
            if( fields == null || fields.Count == 0 )
                return string.Empty;

            string result = string.Empty;

            foreach( KeyValuePair<string, string> field in fields )
                result += $"{field.Key},{field.Value}\n";

            return result;
        }
    }
}

