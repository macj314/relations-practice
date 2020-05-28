using Microsoft.AspNetCore.Mvc;
using RelationsPractice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RelationsPractice.Controllers
{
  public class BoardMemberController : Controller
  {
    private readonly RelationsPracticeContext _db;

    public BoardMemberController(RelationsPracticeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<BoardMember> model = _db.BoardMembers.Include(boardMembers => boardMembers.NonProfit).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.NonProfitId = new SelectList(_db.NonProfits, "NonProfitId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(BoardMember boardMember)
    {
      _db.BoardMembers.Add(boardMember);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      BoardMember thisBoardMember = _db.BoardMembers.FirstOrDefault(boardMembers => boardMembers.BoardMemberId == id);
      return View(thisBoardMember);
    }

    public ActionResult Edit(int id)
    {
      var thisBoardMember = _db.BoardMembers.FirstOrDefault(boardMembers => boardMembers.BoardMemberId == id);
      ViewBag.NonProfitId = new SelectList(_db.NonProfits, "NonProfitId", "Name");
      return View(thisBoardMember);
    }

    [HttpPost]
    public ActionResult Edit(BoardMember boardMember)
    {
      _db.Entry(boardMember).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisBoardMember = _db.BoardMembers.FirstOrDefault(boardMembers => boardMembers.BoardMemberId == id);
      return View(thisBoardMember);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBoardMember = _db.BoardMembers.FirstOrDefault(boardMembers => boardMembers.BoardMemberId == id);
      _db.BoardMembers.Remove(thisBoardMember);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}