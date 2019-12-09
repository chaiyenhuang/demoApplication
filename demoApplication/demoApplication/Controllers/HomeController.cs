using SkillTreeHomework.Models.ViewModels;
using SkillTreeHomework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookKeepingService bookKeeping;

        public HomeController()
        {
            bookKeeping = new BookKeepingService();
        }
        public ActionResult Index()
        {

            List<TrackViewModel> trackView = bookKeeping.GetTrackdata().ToList();

            return View(trackView);
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