using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMeter.Service
{
    class Constants
    {
        // URL of REST service
        public static string RestUrl = "http://project-manhattan.azurewebsites.net/api/Movies/{0}";
        // Credentials that are hard coded into the REST service
        public static string Username = "";
        public static string Password = "";
    }
}
