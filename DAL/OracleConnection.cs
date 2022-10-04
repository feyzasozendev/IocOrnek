using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OracleConnection : IConnection
    {
        public string GetData()
        {
            return "Oracle";
        }
    }
}
