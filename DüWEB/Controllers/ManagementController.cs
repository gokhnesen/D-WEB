using DüWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Controllers
{
    public class ManagementController : Controller
    {

        DBContext senate = new DBContext();
        public IActionResult Index()
        {
            var value = senate.Senates.ToList();
            return View(value);
        }
    }
}
