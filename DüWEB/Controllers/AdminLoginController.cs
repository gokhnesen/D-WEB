using DüWEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace DüWEB.Controllers
{
   
    public class AdminLoginController : Controller
    {
        DBContext login = new DBContext();

     
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var info = login.Admins.FirstOrDefault(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == admin.Sifre);
            if(info !=null)
            {
                
                return RedirectToAction("Index", "AdminManagement");
            }
            else
            {
               
            }
            return View();
        }
       
    }
}
