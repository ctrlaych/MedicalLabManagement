using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBLP.Models;

namespace DBLP.Controllers
{
    public class clientController : Controller
    {
        // GET: client
        public ActionResult delete_op2()
        {
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            int result = CRUD.delete_ap(ret);
            if (result == -1)
            {
                List<c_appointment> users = CRUD.client_today_app(ret);
                ViewBag.Message = "Something went wrong while connecting with the database.";
                return View("deleteappoint", users);
            }
            else if (result == 0)
            {
                List<c_appointment> users = CRUD.client_today_app(ret);
                ViewBag.Message = "No Appointments to Delete";
                return View("deleteappoint", users);
            }
            else
            {
                List<c_appointment> users = CRUD.client_today_app(ret);
                ViewBag.Message = "Appointments Deleted";
                return View("deleteappoint", users);
            }
        }
        public ActionResult deleteappoint()
        {
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            List<c_appointment> users = CRUD.client_today_app(ret);
            return View(users);
        }
        public ActionResult viewreports()
        {
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            List<viewreports> users = CRUD.Reports(ret);
            return View(users);
        }
        public ActionResult view_pend_appoint()
        {
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            List<c_appointment> users = CRUD.client_today_app(ret);
            return View(users);
        }
        public ActionResult viewappointments()
        {
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            List<c_appointment> users = CRUD.client_all_app(ret);
            return View(users);
        }
        public ActionResult appointback()
        {
            String data = "Appointment Added Succesfully";
            return View("appointback", (object)data);
        }
        public ActionResult addop(String testname)
        {
            //string testname = Request.Form["txtOne"];
            string id = (string)(Session["user_id"]);
            int ret = CRUD.get_client_id(id);
            int result = CRUD.Add_op(ret, testname);
            if (result == -1)
            {
                List<displaytest> users = CRUD.dispotest();
                ViewBag.Message = "Something went wrong while connecting with the database.";
                return View("displaytest", users);
            }
            else if (result == 1)
            {
                List<displaytest> users = CRUD.dispotest();
                ViewBag.Message = "Appointment Added Successfuly";
                return View("appointback", users);
            }
            else
            {
                List<displaytest> users = CRUD.dispotest();
                ViewBag.Message = "Error";
                return View("displaytest", users);
            }
        }
        public ActionResult displaytest()
        {
            List<displaytest> users = CRUD.dispotest();
            return View(users);
        }
        public ActionResult deactive()
        {
            return View();
        }
        public ActionResult login()
        {
            if (Session["user_id"] == null)
                return View();
            else
            {
                return RedirectToAction("homePage");
            }
        }
        public ActionResult logout()
        {
            if (Session["user_id"] != null)
            {
                Session["user_id"] = null;
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
        public ActionResult authenticate_d(String password3)
        {
            string id = (string)(Session["user_id"]);
            int result = CRUD.deactive(password3, id);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("deactive", (object)data);
            }
            else if (result == 1)
            {
                return RedirectToAction("logout");
            }
            else
            {
                String data = " Incorrect Password ";
                return View("deactive", (object)data);
            }
        }
        public ActionResult authenticate2(String userid, String password)
        {
            int result = CRUD.CLogin(userid, password);

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
                String data = "Account Deactivate";
                return View("login", (object)data);
            }
            else
            {
                Session["user_id"] = userid;
                return RedirectToAction("homePage");
            }

        }

        public ActionResult homePage()
        {
            if (Session["user_id"] == null)
                return View("login");
            else
            {
                Client client = CRUD.getClient(Session["user_id"].ToString());
                return View(client);
            }
        }
    }
}