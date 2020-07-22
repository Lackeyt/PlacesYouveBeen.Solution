using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;

namespace PlacesIveBeen.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [Route("/form")]
    // public ActionResult Form() { return View(); }
  }
}