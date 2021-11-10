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
        public int numberLigths;
        public int numberFails;
        public eGroups groupId;

        public TrafficLight(int numberLigths, int numberFails, eGroups groupId)
        {
            this.numberLigths = numberLigths;
            this.numberFails = numberFails;
            this.groupId = groupId;
        }
    }
}
