using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInformation
{
    [Serializable]
    public class ColorLight
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string ClientId { get; set; }

        public eGroups GroupId { get; set; }

        public eColor Color { get; set; }
    }
}
