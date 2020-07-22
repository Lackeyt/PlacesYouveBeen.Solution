using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;

namespace PlacesIveBeen.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}