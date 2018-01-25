using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    public class BooksController : Controller
    {

        public IActionResult Index()
        {
            return Content("This is the Books controller's Index action");
        }
        public IActionResult New()
        {
            return Content("This is the Books controller's New action");
    }
  }
}