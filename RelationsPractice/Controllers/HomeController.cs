using Microsoft.AspNetCore.Mvc;

namespace RelationsPractice.Controllers
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