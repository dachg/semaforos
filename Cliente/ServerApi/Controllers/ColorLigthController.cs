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
    public class ColorLigthController : ApiController
    {
        NameValueCollection appSettings;
        TrafficDb trafficDb;

        public ColorLigthController()
        {
            appSettings = ConfigurationManager.AppSettings;
            trafficDb = new TrafficDb(appSettings.Get("DbInstance"));
        }

        // GET api/traffic
        public IEnumerable<ColorLight> Get()
        {
            return trafficDb.GetColors();
        }

        // POST api/traffic
        public void Post([FromBody] ColorLight colorLight)
        {
            trafficDb.SetColor(colorLight);
        }
    }
}