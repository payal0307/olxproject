using OLXProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OLXProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        //public ActionResult Registration(RegistrationModel model)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        string message;
        //        RegistrationRepo repo = new RegistrationRepo();

        //        repo.InsertUser(model, out message);

        //        if (message == "successfully")
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "Something went wrong with the registration.");
        //            return View(model);
        //        }
        //    }
        //    else
        //    {
        //        return View(model);
        //    }

        //}
        public async Task<ActionResult> RegistrationAsync(RegistrationModel model)
        { 
            RegistrationRepo repo = new RegistrationRepo();
            var exist = await _userManager.FindByEmailAsync(model.userEmail);

            if (exist != null)
            {
                ModelState.AddModelError(string.Empty, "email is already exist");
          }
            

            return View(model);
        }
        public ActionResult Registration(RegistrationModel model)
        {
            RegistrationRepo repo = new RegistrationRepo();
            var isEmailAlreadyExists = repo.InsertUser.Any(x => x.userEmail == model.userEmail);
            if (isEmailAlreadyExists)
            {
                ModelState.AddModelError("userEmail", "this email already exists");
                
            }
            return View(model);
        }

    }
}