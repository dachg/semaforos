using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInformation
{
    public class ClientList
    {
        public List<PermissionsClients> clients;

        public ClientList()
        {
            this.clients = new List<PermissionsClients>();
            getData();
        }

        private void getData()
        {
            for (int i = 1; i <= 10; i++)
            {
                PermissionsClients client = new PermissionsClients(i + "a");
                clients.Add(client);
            }
        }
    }
}
