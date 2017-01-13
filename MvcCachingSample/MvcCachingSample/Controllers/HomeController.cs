using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCachingSample.Controllers
{
    public class HomeController : Controller
    {
        private static Dictionary<string, int> _textboxNumberByProcess = null;
        public HomeController()
        {
            _textboxNumberByProcess = new Dictionary<string, int>();
            _textboxNumberByProcess.Add("idc", 3);
            _textboxNumberByProcess.Add("progen", 6);
            _textboxNumberByProcess.Add("timesheet", 8);
        }
        public ActionResult Index()
        {
            return View();
        }

        //[OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, Duration = 1800, VaryByParam = "process")]
        public ActionResult Dashboard(string process)
        {
            if (_textboxNumberByProcess.ContainsKey(process.ToLower()))
            {
                ViewBag.ProcessName = process;
                ViewBag.TextBoxCount = _textboxNumberByProcess[process.ToLower()];
                return View();
            }
            else
            {
                return this.RedirectToAction("Error404", "Error");
            }
        }

        public ActionResult MyJobs(string process)
        {
            if (_textboxNumberByProcess.ContainsKey(process.ToLower()))
            {
                ViewBag.ProcessName = process;
                ViewBag.TextBoxCount = _textboxNumberByProcess[process.ToLower()];
                return View();
            }
            else
            {
                return this.RedirectToAction("Error404", "Error");
            }
        }

        public ActionResult Admin(string process)
        {
            if (_textboxNumberByProcess.ContainsKey(process.ToLower()))
            {
                ViewBag.ProcessName = process;
                ViewBag.TextBoxCount = _textboxNumberByProcess[process.ToLower()];
                return View();
            }
            else
            {
                return this.RedirectToAction("Error404", "Error");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}