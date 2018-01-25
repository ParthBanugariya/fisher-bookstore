using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class BooksController : Controller{
        public IActionResult Index()
        {
            return Content ("hello world, this is books page");
        }

        public IActionResult New()
        {
            return Content ("hello world, this is new books page");
        }
        }
    }