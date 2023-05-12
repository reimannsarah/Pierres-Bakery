using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Order
  {
    public string VendorName { get; set; }
    public Dictionary<string, int> Cart = new Dictionary<string, int>() {};
    public DateTime OrderDate { get; set; }
    public int OrderTracker { get; set; } = 0000;
    public string OrderNumber { get; set; }
    public Order(string vendorName, string[] products, int[] amounts)
    {
      VendorName = vendorName;
      OrderDate = DateTime.Now;
      OrderTracker++;
      OrderNumber = OrderTracker.ToString("D4");
      for (int i = 0; i < products.Length; i ++)
      {
        Cart.Add(products[i], amounts[i]);
      }
    }
  }
}