using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View(AllVendors.VendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Index(string[] vendorInput)
    {
      Vendor newVendor = new Vendor(vendorInput[0], vendorInput[1]);
      return View(AllVendors.VendorList);
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = AllVendors.Find(id);
      return View(selectedVendor);
    }

    // [HttpPost("/vendors/{id}")]
    // public ActionResult Show(int id, string orderInputVendorName, string[]type, int[]amount)
    // {
    //   Order newOrder = new Order(orderInputVendorName, type, amount);
    //   Vendor selectedVendor = AllVendors.Find(id);
    //   selectedVendor.AddOrder(newOrder);
    //   return View();
    // }
    
  }
}