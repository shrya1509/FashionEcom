using BunaWebDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BunaWebDesign.Controllers
{
    public class LoginMasterController : Controller
    {

        public ActionResult Index()
        {
            //#region uncomment if you dont want access to home page without login.
            //if (Session["UserId"] == null)
            //{
            //    return RedirectToAction("Login");
            //}

            //#endregion
            //Sample_1Entities db = new Sample_1Entities();

            //List<EmployeeViewModel> list = db.tblEmployees.Select(x => new EmployeeViewModel { Name = x.Name, Id = x.Id, Salary = x.Salary, Gender = x.Gender, DepartmentId = x.DepartmentId, DepartmentName = x.tblDepartment.DepartmentName }).ToList();

            //ViewBag.EmployeeList = list;

            return View();
        }


        public ActionResult Login()
        {

            return View();

        }


        public JsonResult LoginUser(RegistrationViewModel model)
        {
            //Sample_1Entities db = new Sample_1Entities();
            string Result = "fail";
            //SiteUser user = db.SiteUsers.SingleOrDefault(x => x.EmailId == model.EmailId && x.Password == model.Password);
            //if (user != null)
            //{
            //    Session["UserId"] = user.UserId;
            //    Session["UserName"] = user.UserName;

            //    if (user.RoleId == 3)
            //    {
            //        Result = "GeneralUser";
            //    }

            //    else if (user.RoleId == 1)
            //    {
            //        Result = "Admin";
            //    }

            //}


            return Json(Result, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Login");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegistrationViewModel model)
        {
            //Sample_1Entities db = new Sample_1Entities();
            //SiteUser siteuser = new SiteUser();
            //siteuser.UserName = model.UserName;
            //siteuser.EmailId = model.EmailId;
            //siteuser.Password = model.Password;
            //siteuser.Address = model.Address;
            //siteuser.RoleId = 3;

            //db.SiteUsers.Add(siteuser);
            //db.SaveChanges();



            return View();










        }


       

        public ActionResult GetSearchRecord(string SearchText)
        {
            //Sample_1Entities db = new Sample_1Entities();

            //List<EmployeeViewModel> list = db.tblEmployees.Where(x => x.Name.Contains(SearchText) || x.tblDepartment.DepartmentName.Contains(SearchText)).Select(x => new EmployeeViewModel { Name = x.Name, Id = x.Id, Salary = x.Salary, Gender = x.Gender, DepartmentId = x.DepartmentId, DepartmentName = x.tblDepartment.DepartmentName }).ToList();

            //return PartialView("SearchPartial", list);

            return PartialView("SearchPartial", null);
        }



    }
}