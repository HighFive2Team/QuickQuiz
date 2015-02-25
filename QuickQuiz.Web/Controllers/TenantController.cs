using Newtonsoft.Json;
using QuickQuiz.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace QuickQuiz.Web.Controllers
{
    public class TenantController : Controller
    {
        // GET: Tenant
        public ActionResult Index()
        {
            WebClient client = new WebClient();
            string response = client.DownloadString("http://quizwebapi.azurewebsites.net/api/Tenant");
            var model = JsonConvert.DeserializeObject<List<TenantModel>>(response);

            return View(model);
        }
    }
}