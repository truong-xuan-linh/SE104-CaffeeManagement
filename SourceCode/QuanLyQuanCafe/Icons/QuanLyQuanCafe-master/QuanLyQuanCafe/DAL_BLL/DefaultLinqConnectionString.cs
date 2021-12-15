using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public static class DefaultLinqConnectionString
    {
        public static String UDF_DefaultLinqConnectionString()
        {
            return Properties.Settings.Default.dbQLQCFConn.ToString().Trim();
        }
    }
}
