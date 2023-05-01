using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationConfigurator
{
    [Serializable]
    public class IntegrationModel
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, string> FieldsMatching { get; set; }
        public string CycleFormField { get; set; }
        public string SecretKey { get; set; }
        public string FormId { get; set; }
        public string IntegrationId { get; set; }
        public string DateField { get; set; }
    }
}
