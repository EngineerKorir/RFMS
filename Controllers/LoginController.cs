using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ron_Financial_Management_System.Models;

namespace Ron_Financial_Management_System.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(Ron_Financial_Management_System.Models.systemuser usermodel)
        {
            using (LoginDataModel db =new LoginDataModel())
            {
                var userDetails = db.systemusers.Where(x => x.UserName == usermodel.UserName &&
                x.Password == usermodel.Password).FirstOrDefault();
                if (userDetails == null)
                    {
                    usermodel.LoginErrorMessage = "The User Name or password is not valid";
                    return View("Index", usermodel);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["userName"] = userDetails.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
           
        }
        public ActionResult logOut()
        {
            //int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}