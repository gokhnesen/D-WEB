using DüWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Controllers
{
    public class AdminStaffController : Controller
    {
        DBContext staff = new DBContext();
        public IActionResult Index()
        {
            var value = staff.Staffs.ToList();
            return View(value);
            

        }
        public ActionResult StaffUpdate(int Id)
        {
            var update = staff.Staffs.Find(Id);
            return View("StaffUpdate", update);
        }

        public ActionResult GetStaff(Staff x)
        {
            var value = staff.Staffs.Find(x.Id);
            value.Name = x.Name;
            value.Surname = x.Surname;
            value.Degree = x.Degree;
            value.Email = x.Email;
            value.Profile = x.Profile;
            value.Link = x.Link;
            staff.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(Staff p)
        {
            staff.Staffs.Add(p);
            staff.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteStaff(int Id)
        {
            var delete = staff.Staffs.Find(Id);
            staff.Staffs.Remove(delete);
            staff.SaveChanges();
            return RedirectToAction("Index");
        }

   
    }
}