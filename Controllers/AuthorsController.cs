using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class AuthorsController : Controller{
        public IActionResult Index()
        {
            return Content ("hello world, this is controller page");
        }

        public IActionResult Featured()
        {
            return Content ("hello world, this is Featured page");
        }

        }
    }