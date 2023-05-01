using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationConfigurator
{
    [Serializable]
    public class Integration
    {
        public List<IntegrationModel> Integrations { get; set; } = new List<IntegrationModel>();

        public Integration() { }

        public IntegrationModel? GetByName( string name )
        {
            IntegrationModel? model = Integrations.Find( x => x.Name == name );
            
            if ( model == null ) 
                return null;
           
            return model;
        }

        public void Serialize() 
        { 
        
        }

        public void Deserialize()
        {

        }
    }
}
