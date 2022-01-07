using DüWEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DüWEB.Controllers
{
    public class AdminManagementController : Controller
    {
        DBContext senate = new DBContext();

      
        public IActionResult Index()
        {
            var value = senate.Senates.ToList();
            return View(value);
        }

        public ActionResult SenateUpdate(int Id)
        {
            var update = senate.Senates.Find(Id);
            return View("SenateUpdate",update);
        }

        public ActionResult GetSenate(Senate  x)
        {
            var value = senate.Senates.Find(x.Id);
            value.Name = x.Name;
            value.Surname = x.Surname;
            value.Title = x.Title;
            value.Degree = x.Degree;
            senate.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSenate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSenate(Senate p)
        {
            senate.Senates.Add(p);
            senate.SaveChanges();
            return RedirectToAction("Index");
        }
     
        public ActionResult DeleteSenate(int Id)
        {
            var delete = senate.Senates.Find(Id);
            senate.Senates.Remove(delete);
            senate.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

    