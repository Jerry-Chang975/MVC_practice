using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_practice.Models;

namespace MVC_practice.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //DateTime dt = DateTime.Now;
            //Student data = new Student();
            //List<Student> st_list = new List<Student>();
            //st_list.Add(new Student("1", "jerry", 90));
            //st_list.Add(new Student("2", "Miigun", 80));
            //st_list.Add(new Student("3", "Miibo", 99));

            //ViewBag.Date = dt;
            //ViewBag.Student = data;
            //ViewBag.List = st_list;

            //return View();

            //--------------------------
            DateTime date = DateTime.Now;
            ViewBag.Date = date;

            Student data = new Student("1", "jerry", 90);
            return View(data);
        }
        public ActionResult Transcripts(string id, string name, int score)
        {
            Student data = new Student(id, name, score);
            return View(data);
        }

    }   
}