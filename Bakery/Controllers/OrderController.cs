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

    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      return View(id);
    }
    [HttpPost("/vendors/{id}/order")]
    public ActionResult Create(int id, string orderInputVendorName, string[] type, int[] amount )
    {
      Dictionary<string,object>model = new Dictionary<string,object>();
      Order newOrder = new Order(orderInputVendorName, type, amount);
      newOrder.CalculateTotal();
      Vendor selectedVendor = AllVendors.Find(id);
      selectedVendor.AddOrder(newOrder);
      Dictionary<string,int> cart = newOrder.Cart;
      model.Add("order",newOrder);
      model.Add("cart", cart);
      return View(model);

    }
  }
}