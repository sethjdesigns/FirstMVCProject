using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>Default</b> action...";
        }

        // GET: HelloWorld/Welcome/

        public string welcome() 
        {
            return "This is my <b>Welcome</b> message action method....";
        }


    }
}