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
    public class LoginController : ApiController
    {
        NameValueCollection appSettings;
        TrafficDb trafficDb;


        public LoginController()
        {
            appSettings = ConfigurationManager.AppSettings;
            trafficDb = new TrafficDb(appSettings.Get("DbInstance"));
        }

        // POST api/login
        public string Post([FromBody] User user)
        {
            bool isValid = trafficDb.ValidaUser(user);
            if (!isValid)
            {
                return null;
            }

            return appSettings.Get("Token");

        }
    }
}