using DüWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Controllers
{
    public class StaffController : Controller
    {
        DBContext staff = new DBContext();
        public IActionResult Index()
        {
            var value = staff.Staffs.ToList();
            return View(value);
        }
    }
}
