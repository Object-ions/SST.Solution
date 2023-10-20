using Microsoft.AspNetCore.Mvc;
using SST.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SST.Controllers
{
  public class HomeController : Controller
  {
    private readonly SSTContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, SSTContext db)
    {
    _userManager = userManager;
    _db = db;
    }
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();

      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}