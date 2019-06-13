﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            ViewBag.Title = ConfigurationManager.AppSettings["Title"];
            ViewBag.Logo = ConfigurationManager.AppSettings["Logo"];
        }
    }
}