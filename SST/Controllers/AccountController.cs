using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SST.Models;
using System.Threading.Tasks;
using SST.ViewModels;
using Microsoft.AspNetCore.Authorization;


namespace SST.Controllers
{
  public class AccountController : Controller
  {
    private readonly SSTContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SSTContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
  }
}