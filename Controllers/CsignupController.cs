using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBLP.Models;

namespace DBLP.Controllers
{
    public class CsignupController : Controller
    {
        // GET: Csignup
        public ActionResult signup()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult authenticate3(String userid, String password, String firstname, String lastname, String email, String address, String phonenumber, String Gender, String Bloodgroup, int age=-1)
        {
            if (userid == "" || password == "" || firstname == "" || lastname == "" || address == "" || phonenumber == "" || Gender == "" || Bloodgroup == "" || email == "" || age < 0)
            {
                String data = "Please enter all fields.";
                return View("signup", (object)data);
            }
            int result = CRUD.CSignup(userid, password, firstname, lastname, age, email, address, phonenumber, Gender, Bloodgroup);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("signup", (object)data);
            }
            else if (result == 1)
            {
                String data = "Invalid Gender";
                return View("signup", (object)data);
            }
            else if (result == 2)
            {
                String data = "Invalid Phonenumber";
                return View("signup", (object)data);
            }
            else if (result == 3)
            {
                String data = "Password length is too small";
                return View("signup", (object)data);
            }
            else if (result == 4)
            {
                String data = "Username Already Exist";
                return View("signup", (object)data);
            }
            else if (result == 5)
            {
                String data = "Email Already Exist";
                return View("signup", (object)data);
            }
            else if (result == 6)
            {
                String data = "Address field is empty";
                return View("signup", (object)data);
            }
            else if (result == 7)
            {
                String data = "Age is not specified";
                return View("signup", (object)data);
            }
            else if (result == 8)
            {
                String data = "Email is invalid";
                return View("signup", (object)data);
            }
            else
            {
                int result2 = CRUD.CLogin(userid, password);

                if (result == -1)
                {
                    return View("login", "client");
                }
                else
                {
                    Session["user_id"] = userid;
                    return RedirectToAction("homePage", "client");
                }
            }

        }
    }
}