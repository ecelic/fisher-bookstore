using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class AuthorsController : Controller
    {

        public IActionResult Index()
        {
            return Content("This is the Authors controller's Index action");
        }
        public IActionResult Featured()
        {
            return Content("This is the Authors controller's Featured action");
        }
        
    }
}