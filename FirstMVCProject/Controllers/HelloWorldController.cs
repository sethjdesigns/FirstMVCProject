﻿using System;
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

        public string Welcome(string name, int ID = 1) 
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }


    }
}