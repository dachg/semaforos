using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInformation
{
    public class PermissionsClients
    {
        public string IdClient { get; set; }

        public PermissionsClients(string idClient)
        {
            IdClient = idClient;
        }
    }
}
