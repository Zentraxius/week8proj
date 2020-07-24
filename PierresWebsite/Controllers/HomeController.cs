using Microsoft.AspNetCore.Mvc;

namespace PierresWebsite.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}