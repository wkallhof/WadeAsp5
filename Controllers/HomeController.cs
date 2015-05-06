using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;

namespace WadeAsp5.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<AppSettings> settings)
        {
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}