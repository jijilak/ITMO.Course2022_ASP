using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        //////////////////////////////////////Lab1Ex0/////////////////////////////////
        //GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //////////////////////////////////////Lab1Ex1/////////////////////////////////
        //public string Start()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
        //    return Greeting;
        //}
        //////////////////////////////////////Lab1Ex2/////////////////////////////////
        //public string Start(string hel)
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
        //    return Greeting;
        //}
        //////////////////////////////////////Lab1Ex3/////////////////////////////////
        public string Index(string hel)
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}