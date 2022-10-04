using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    //IConnection interface’ini kullandığımız için ConnectionHelper’ın Oracle ve MsSQL sınıfları hakkında bilgi sahibi olmasını engellemiş olduk.
    
    public class ConnectionHelper
    {
        private IConnection _connection;
        public ConnectionHelper(IConnection connection)
        {
            _connection = connection;
        }
        public string GetData()
        {
            return _connection.GetData();
        }
    }
}
