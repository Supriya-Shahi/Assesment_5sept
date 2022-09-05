using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult InsertData()
        {

            return View();
        }


        [HttpPost]
        public ActionResult InsertData(Registration r)
        {
            if (ModelState.IsValid)
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44307/InsertData", JsonConvert.SerializeObject(r));
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View();
            }
        }
    }
}