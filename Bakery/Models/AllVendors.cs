using System.Collections.Generic;

namespace Bakery.Models
{
  public abstract class AllVendors
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; } = new List<Order> { };
    public static List<Vendor> VendorList { get; set; } = new List<Vendor> { };
    public static Vendor Find(int searchId)
    {
      return VendorList[searchId - 1];
    }
    public static void ClearAll()
    {
      VendorList.Clear();
    }
  }
}