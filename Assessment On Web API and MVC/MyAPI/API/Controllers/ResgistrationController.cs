using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Models;

namespace API.Controllers
{
    public class ResgistrationController : ApiController
    {
        AssementAPIEntities1 db = new AssementAPIEntities1();

        [HttpPost]
        [Route("InsertData")]
        public string InsertData(Registration r)
        {
            db.Registrations.Add(r);
            db.SaveChanges();
            int i = db.SaveChanges();
            if (i > 0)
                return "sucess";
            else return "not sucess";
        }
    }
}
