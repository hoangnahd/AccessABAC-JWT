﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ABAC_Fe.Models;
using System.Text;

namespace ABAC_Fe.Controllers
{
    public class HomeController : Controller
    {
        


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

       
    }
}