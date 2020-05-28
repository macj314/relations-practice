using Microsoft.AspNetCore.Mvc;
using RelationsPractice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RelationsPractice.Controllers
{
  public class NonProfitController : Controller
  {
    private readonly RelationsPracticeContext _db;

    public NonProfitController(RelationsPracticeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<NonProfit> model = _db.NonProfits.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(NonProfit nonProfit)
    {
      _db.NonProfits.Add(nonProfit);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisNonProfit = _db.NonProfits.FirstOrDefault(nonProfit => nonProfit.NonProfitId == id);
      return View(thisNonProfit);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisNonProfit = _db.NonProfits.FirstOrDefault(nonProfit => nonProfit.NonProfitId == id);
      _db.NonProfits.Remove(thisNonProfit);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}