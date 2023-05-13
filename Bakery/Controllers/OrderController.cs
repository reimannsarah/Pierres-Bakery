using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Index(int id)
    {
      Dictionary<string,object> model = new Dictionary<string,object>();
      Vendor selectedVendor = AllVendors.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
  }
}