using System;

namespace Bakery.Models
{
  public class Order
  {
    public string Description { get; set; }
    public DateTime OrderDate { get; set; }
    public int OrderTracker { get; set; } = 0000;
    public string OrderNumber { get; set; }
    public Order(string description)
    {
      Description = description;
      OrderDate = DateTime.Now;
      OrderTracker++;
      OrderNumber = OrderTracker.ToString("D4");
    }
  }
}