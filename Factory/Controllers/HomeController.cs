using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;


namespace Factory.Controllers
{
    public class HomeController : Controller
    {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Engineer> engineerList = _db.Engineers.ToList();
      List<Machine> machineList = _db.Machines.ToList();
      ViewBag.Engineers = engineerList;
      ViewBag.Machines = machineList;
      return View();
    }
      

    }
}