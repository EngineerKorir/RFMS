﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ron_Financial_Management_System.Controllers
{
    public class CompanyProfileController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
       
    }
}