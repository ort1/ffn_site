﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ffn_site.Models;

namespace ffn_site.Controllers
{

    [Authorize]
    public class JugeController : Controller
    {
        // GET: Juge
        public ActionResult Index()
        {
            return View();
        }
    }
}