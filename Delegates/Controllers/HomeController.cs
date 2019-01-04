using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delegates.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyDelegate del = new MyDelegate(myMethod1);
            del += new MyDelegate(myMethod2);
            return Content("<h1>" + del("value: ") + "</h1>");
        } // end ActionResult Index GET

        delegate string MyDelegate(string argument);

        private string myMethod1(string msg)
        {
            return msg + "I am in myMethod1";
        } // end method myMethod1

        private string myMethod2(string msg)
        {
            return msg + "I am in myMethod2";
        } // end method myMethod2

    } // end class HomeController : Controller

} // end class HomeController : Controller