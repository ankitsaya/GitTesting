﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GithubProject.Controllers
{
    public class UserController : Controller
    {
        #region Constuctor

        #endregion
        
        public IActionResult Index()
        {
            return View();
        }
    }
}