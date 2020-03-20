using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GithubProject.Controllers
{
    public class BugController : Controller
    {
        #region BugController

        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}