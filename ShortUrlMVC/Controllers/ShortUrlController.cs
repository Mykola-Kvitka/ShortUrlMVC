using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlMVC.PL.Controllers
{
    public class ShortUrlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
