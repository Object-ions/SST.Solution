using Microsoft.AspNetCore.Mvc;
using SST.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SST.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SSTContext _db;

    public TreatsController(SSTContext db)
    {
      _db = db;
    }
  }
}