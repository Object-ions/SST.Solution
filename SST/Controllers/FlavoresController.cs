using Microsoft.AspNetCore.Mvc;
using SST.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SST.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SSTContext _db;

    public FlavorsController(SSTContext db)
    {
      _db = db;
    }
  }
}