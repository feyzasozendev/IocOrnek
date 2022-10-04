using DAL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IocOrnek.Controllers
{
    //Örneğimizi .NET mvc’de yaptığımız ve .NET mvc içerisinde de hali hazırda bir dependency injection
    //mekanizması bulunduğu için ekstra bir kütüphane kurmamıza gerek kalmadı.
    public class ValuesController : Controller
    {
        private readonly IConnection _connection;
        public ValuesController(IConnection connection)
        {
            _connection = connection;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var getdata= _connection.GetData();
            return View(getdata);
        }
    }

   
}