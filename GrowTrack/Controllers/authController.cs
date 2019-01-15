using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrowTrack.Controllers
{

    public class authController : Controller
    {
       

        // GET: auth/linkedin
        public ActionResult linkedin(String info)
        {
            Console.WriteLine("Hello {0}", info);
            return View();
        }

        public ActionResult token()
        {
            ViewBag.mystring = new HttpClient().PostAsync("https://www.linkedin.com/oauth/v2/accessToken",
                new JsonContent(new { grant_type = "client_credentials", client_id = "862wsoqoiz0ez9", client_secret = "MtPdae9zBUEZui1a" })).ToString();
            return View();
        }


    }
}