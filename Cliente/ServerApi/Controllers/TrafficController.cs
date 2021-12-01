using DataInformation;
using DataInformation.DB;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ServerApi.Controllers
{
    public class TrafficController : ApiController
    {
        NameValueCollection appSettings;
        TrafficDb trafficDb;

        public TrafficController()
        {
            appSettings = ConfigurationManager.AppSettings;
            trafficDb = new TrafficDb(appSettings.Get("DbInstance"));
        }

        // GET api/traffic
        public IEnumerable<TrafficLight> Get()
        {
            return trafficDb.GetTraffics();
        }

        // POST api/traffic
        public void Post([FromBody] TrafficLight traffic)
        {
            trafficDb.SetTraffic(traffic);
        }
    }
}