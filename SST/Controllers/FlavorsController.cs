using Microsoft.AspNetCore.Mvc;
using SST.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SST.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SSTContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> userManager, SSTContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> flavors = _db.Flavors.ToList();
      return View(flavors);
    }

    [Authorize]
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [Authorize]
    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View(flavor);
      }
      else
      {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Flavor thisFlavor = _db.Flavors
                                .Include(flavor => flavor.JoinEntities)
                                .ThenInclude(join => join.Treat)
                                .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [Authorize]
    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [Authorize]
    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Flavors.Update(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize]
    public ActionResult Delete(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [Authorize]
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }

    [Authorize]
    public ActionResult AddTreat(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(p => p.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View(thisFlavor);
    }

    [Authorize]
    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int treatId)
    {
      #nullable enable
      FlavorTreat? joinEntity = _db.FlavorTreats.FirstOrDefault(join => (join.TreatId == treatId && join.FlavorId == flavor.FlavorId));
      #nullable disable
      if (joinEntity == null && treatId != 0)
      {
          _db.FlavorTreats.Add(new FlavorTreat() { 
              TreatId = treatId, FlavorId = flavor.FlavorId
          });
          _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = flavor.FlavorId });
    }

    [Authorize]
    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      FlavorTreat joinEntity = _db.FlavorTreats.FirstOrDefault(joinEntity => joinEntity.FlavorTreatId == joinId);
      _db.FlavorTreats.Remove(joinEntity);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = joinEntity.FlavorId});
    }
  }
}