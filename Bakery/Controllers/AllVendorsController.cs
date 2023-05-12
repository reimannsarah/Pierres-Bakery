using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class AllVendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View(AllVendors.VendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult Create()
    {
      return View();
    }
  }
}