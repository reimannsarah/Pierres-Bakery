using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

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
    [HttpPost("/vendors")]
    public ActionResult Index(string[] vendorInput)
    {
      Vendor newVendor = new Vendor(vendorInput[0], vendorInput[1]);
      return View(AllVendors.VendorList);
    }
  }
}