﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GithubProject.Controllers
{
    public class DemoController : Controller
    {
        #region Constructor

        public DemoController()
        {

        }

        #endregion
        public IActionResult Index()
        {
            return View();
        }
    }
}