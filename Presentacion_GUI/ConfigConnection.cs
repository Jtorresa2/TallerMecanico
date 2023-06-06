using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico
{
    public static class ConfigConnection
    {
        public static string conecctionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
