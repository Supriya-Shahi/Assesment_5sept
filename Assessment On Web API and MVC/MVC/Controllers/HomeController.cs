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
        public string InsertData(Registration r)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44393/InsertData", JsonConvert.SerializeObject(r));

                }
            }
            catch (Exception)
            {

            }
            return "Registered Successfully";
        }
    }
}