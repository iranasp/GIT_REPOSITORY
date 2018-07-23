using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionString
    {
        /// <summary>
        /// Get database address
        /// </summary>
        public static string Database_ConnectionString
        {
            get { return ConfigurationManager.AppSettings["GeneratorConnection"]; }
        }
    }
}
