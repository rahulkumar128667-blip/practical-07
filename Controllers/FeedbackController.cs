using System.Web.Mvc;
using practical_07.Models;

namespace practical_07.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: /Feedback/Index  -> form dikhata hai
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Feedback/Index  -> form submit hone par
        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Submitted", feedback);
            }
            return View(feedback);
        }

        // GET: /Feedback/Submitted  -> URL direct khole to form par bhej do
        [HttpGet]
        public ActionResult Submitted()
        {
            return RedirectToAction("Index");
        }

        // POST: /Feedback/Submitted  -> agar form kahin se yahan post ho jaye
        [HttpPost]
        public ActionResult Submitted(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Submitted", feedback);
            }
            return View("Index", feedback);
        }
    }
}