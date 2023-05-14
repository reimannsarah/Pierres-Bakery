using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Order : Menu
  {
    public string VendorName { get; set; }
    public Dictionary<string, int> Cart = new Dictionary<string, int>() {};
    public int OrderTotal { get; set; }
    public DateTime OrderDate { get; set; }
    public static int OrderTracker { get; set; } = 0000;
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
    public static void ResetTracker()
    {
      OrderTracker = 0000;
    }
    public void CalculateTotal()
    {
      foreach (KeyValuePair<string,int> item in Cart)
      {
        foreach (KeyValuePair<string,int> menuItem in MenuItems)
        {
          if(item.Key == menuItem.Key)
          {
            OrderTotal+=(item.Value * menuItem.Value);
          }
        }
      }
    }
  }
}