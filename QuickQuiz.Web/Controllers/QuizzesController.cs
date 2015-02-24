using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace QuickQuiz.Web.Controllers
{
    public class QuizzesController : Controller
    {
        // GET: Quizzes
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();

            return View();
        }
    }
}