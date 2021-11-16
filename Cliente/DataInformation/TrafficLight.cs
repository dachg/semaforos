using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInformation
{
    [Serializable]
    public class TrafficLight
    {
        public int NumberLigths { get; set; }
        public int NumberFails { get; set; }
        public eGroups GroupId { get; set; }
        public string ClientId { get; set; }

        public TrafficLight(int numberLigths, int numberFails, eGroups groupId, string clientId)
        {
            this.NumberLigths = numberLigths;
            this.NumberFails = numberFails;
            this.GroupId = groupId;
            this.ClientId = clientId;
        }
    }
}
