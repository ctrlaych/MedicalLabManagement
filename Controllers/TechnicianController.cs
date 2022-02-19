using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBLP.Models;

namespace DBLP.Controllers
{
    public class TechnicianController : Controller
    {
        // GET: Technician
        public ActionResult can_ap2()
        {
            string id = (string)(Session["userid"]);
            int ret = CRUD.get_tech_id(id);
            int result = CRUD.cancel_ap(ret);
            if (result == -1)
            {
                List<tech_pend_appoint> users = new List<tech_pend_appoint>();
                ViewBag.Message = "Something went wrong while connecting with the database.";
                return View("can_ap", users);
            }
            else if (result == 0)
            {
                List<tech_pend_appoint> users = new List<tech_pend_appoint>();
                ViewBag.Message = "No Appointments to Cancel";
                return View("can_ap", users);
            }
            else
            {
                List<tech_pend_appoint> users = new List<tech_pend_appoint>();
                ViewBag.Message = "Today's Appointments Cancelled";
                return View("can_ap", users);
            }
        }
        public ActionResult can_ap()
        {
            string id2 = (string)(Session["userid"]);
            int ret2 = CRUD.get_tech_id(id2);
            List<tech_pend_appoint> users = CRUD.tech_pend_app(ret2);
            return View(users);
        }
        public ActionResult dev_rep_og()
        {
            string id4 = (string)(Session["userid"]);
            int ret4 = CRUD.get_tech_id(id4);
            int result = CRUD.Deliver_rep(ret4);
            if (result == -1)
            {
                List<tech_appp> users = CRUD.tech_pend_app5(ret4);
                ViewBag.Message = "Something went wrong while connecting with the database.";
                return View("dev_rep", users);
            }
            else if (result == 0)
            {
                List<tech_appp> users = CRUD.tech_pend_app5(ret4);
                ViewBag.Message = "No Reports to be Delivered";
                return View("dev_rep", users);
            }
            else
            {
                List<tech_appp> users = CRUD.tech_pend_app5(ret4);
                ViewBag.Message = "Reports Delivered successfully";
                return View("dev_rep", users);
            }
        }
        public ActionResult dev_rep()
        {
            string id3 = (string)(Session["userid"]);
            int ret3 = CRUD.get_tech_id(id3);
            List<tech_appp> users = CRUD.tech_pend_app5(ret3);
            return View(users);
        }
        public ActionResult tech_prev_appoint()
        {
            string id = (string)(Session["userid"]);
            int ret = CRUD.get_tech_id(id);
            List<tech_pend_appoint> users = CRUD.tech_prev_app(ret);
            return View(users);
        }
        public ActionResult tech_pend_appoint()
        {
            string id = (string)(Session["userid"]);
            int ret = CRUD.get_tech_id(id);
            List<tech_pend_appoint> users = CRUD.tech_pend_app(ret);
            return View(users);
        }
        public ActionResult tech_test()
        {
            string id = (string)(Session["userid"]);
            List<tech_test> users = CRUD.view_tect_test(id);
            return View(users);
        }
        public ActionResult viewpayments()
        {
            List<allpayments> users = CRUD.getallpayments();
            return View(users);
        }
        public ActionResult viewappointment()
        {
            List<appointments> users = CRUD.getallappointment();
            return View(users);
        }
        public ActionResult viewtest()
        {
            List<allTest> users = CRUD.getAllTest();
            return View(users);
        }
        public ActionResult viewTech()
        {
            List<allTech> users = CRUD.getAllTech();
            return View(users);
        }
        public ActionResult viewclient()
        {
            List<allClient> users = CRUD.getAllClient();
            return View(users);
        }
        public ActionResult Tsignup()
        {
            return View();
        }
        public ActionResult activetech()
        {
            return View();
        }
        public ActionResult activetest()
        {
            return View();
        }
        public ActionResult activeclient()
        {
            return View();
        }
        public ActionResult deactivetech()
        {
            return View();
        }
        public ActionResult deactivetest()
        {
            return View();
        }
        public ActionResult deactiveclient()
        {
            return View();
        }
        public ActionResult addtest()
        {
            return View();
        }
        public ActionResult Home()
        {
            if (Session["userid"] == null)
                return View("login");
            else
            {
                Tech tech = CRUD.getTech(Session["userid"].ToString());
                return View(tech);
            }
        }
        public ActionResult logout()
        {
            if (Session["userid"] != null)
            {
                Session["userid"] = null;
                return RedirectToAction("login");
            }
            else
            {
                return RedirectToAction("login");
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            if (Session["userid"] == null)
                return View();
            else
            {
                int result = CRUD.sCheck(Session["userid"].ToString());
                if (result == 2)
                    return RedirectToAction("Home");
                else
                    return RedirectToAction("homePage");
            }
        }
        public ActionResult authenticate_d_l(String techid)
        {
            int result = CRUD.deactive_tech(techid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("deactivectech", (object)data);
            }
            else if (result == 1)
            {
                String data = " Technician Deactivated Successfully ";
                return View("deactivetech", (object)data);
            }
            else if (result == 2)
            {
                String data = " Administrator cannot be deactivated or activated ";
                return View("deactivetech", (object)data);
            }
            else
            {
                String data = " Technician Not Found ";
                return View("deactivetech", (object)data);
            }
        }
        public ActionResult authenticate_d_c(String clientid)
        {
            int result = CRUD.deactive_client(clientid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("deactiveclient", (object)data);
            }
            else if (result == 1)
            {
                String data = " Client Deactivated Successfully ";
                return View("deactiveclient", (object)data);
            }
            else
            {
                String data = " Client Not Found";
                return View("deactiveclient", (object)data);
            }
        }
        public ActionResult authenticate_d_t(String testid)
        {
            int result = CRUD.deactive_test(testid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("deactivetest", (object)data);
            }
            else if (result == 1)
            {
                String data = " Test Deactivated Successfully ";
                return View("deactiveclient", (object)data);
            }
            else
            {
                String data = " Test Not Found ";
                return View("deactivetest", (object)data);
            }
        }
        public ActionResult authenticate_a_l(String techid)
        {
            int result = CRUD.active_tech(techid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("activectech", (object)data);
            }
            else if (result == 1)
            {
                String data = " Technician activated Successfully ";
                return View("activetech", (object)data);
            }
            else if (result == 2)
            {
                String data = " Administrator cannot be activated or deactivated ";
                return View("activetech", (object)data);
            }
            else if (result == 4)
            {
                String data = " There is already an active technician with the same Type ";
                return View("activetech", (object)data);
            }
            else
            {
                String data = " Technician Not Found ";
                return View("activetech", (object)data);
            }
        }
        public ActionResult authenticate_a_c(String clientid)
        {
            int result = CRUD.active_client(clientid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("activeclient", (object)data);
            }
            else if (result == 1)
            {
                String data = " Client activated Successfully ";
                return View("activeclient", (object)data);
            }
            else
            {
                String data = " Client Not Found";
                return View("activeclient", (object)data);
            }
        }
        public ActionResult authenticate_a_t(String testid)
        {
            int result = CRUD.active_test(testid);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("activetest", (object)data);
            }
            else if (result == 1)
            {
                String data = " Test activated Successfully ";
                return View("activeclient", (object)data);
            }
            else
            {
                String data = " Test Not Found ";
                return View("activetest", (object)data);
            }
        }
        public ActionResult authenticate_t(String Testtype, String TestName, String Amount)
        {
            int result = CRUD.Add_test(Testtype, TestName, Amount);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("addtest", (object)data);
            }
            else if (result == 1)
            {
                String data = " Test Added Successfully ";
                return View("addtest", (object)data);
            }
            else if (result == 2)
            {
                String data = " There is no technicain to perform this type of test ";
                return View("addtest", (object)data);
            }
            else
            {
                String data = "Test already present ";
                return View("addtest", (object)data);
            }

        }
        public ActionResult authenticate(String userid, String password)
        {
            int result = CRUD.TLogin(userid, password);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("login", (object)data);
            }
            else if (result == 0)
            {

                String data = "Incorrect Credentials";
                return View("login", (object)data);
            }
            else if (result == 2)
            {
                Session["userid"] = userid;
                return RedirectToAction("Home");
            }
            else if (result == 3)
            {
                String data = "Account Deactivate";
                return View("login", (object)data);
            }
            else
            {
                Session["userid"] = userid;
                return RedirectToAction("homePage");

            }

        }
        public ActionResult homePage()
        {
            if (Session["userid"] == null)
                return View("login");
            else
            {
                Tech tech = CRUD.getTech(Session["userid"].ToString());
                return View(tech);
            }
        }

        public ActionResult authenticate4(String userid2, String password2, String firstname2, String lastname2, String email2, String address2, String phonenumber2, String Gender2, String techtype2, int age2=-1)
        {
            if (userid2 == "" || password2 == "" || firstname2 == "" || lastname2 == "" || address2 == "" || phonenumber2 == "" || Gender2 == "" || techtype2 == "" || email2 == "" || age2 < 0)
            {
                String data = "Please enter all fields.";
                return View("Tsignup", (object)data);
            }

            int result = CRUD.TSignup(userid2, password2, firstname2, lastname2, age2, email2, address2, phonenumber2, Gender2, techtype2);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Tsignup", (object)data);
            }
            else if (result == 1)
            {
                String data = "Invalid Gender";
                return View("Tsignup", (object)data);
            }
            else if (result == 2)
            {
                String data = "Invalid Phonenumber";
                return View("Tsignup", (object)data);
            }
            else if (result == 3)
            {
                String data = "Password length is too small";
                return View("Tsignup", (object)data);
            }
            else if (result == 4)
            {
                String data = "Username Already Exist";
                return View("Tsignup", (object)data);
            }
            else if (result == 5)
            {
                String data = "Email Already Exist";
                return View("Tsignup", (object)data);
            }
            else if (result == 6)
            {
                String data = "There is an active technician with the same speciality.";
                return View("Tsignup", (object)data);
            }
            else if (result == 7)
            {
                String data = "Address Field is Empty";
                return View("Tsignup", (object)data);
            }
            else if (result == 8)
            {
                String data = "Age is not given";
                return View("Tsignup", (object)data);
            }
            else if (result == 9)
            {
                String data = "Email is not Valid";
                return View("Tsignup", (object)data);
            }
            else
            {
                return RedirectToAction("Home");
            }

        }
    }
}