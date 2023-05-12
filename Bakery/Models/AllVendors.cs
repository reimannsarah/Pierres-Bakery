using System.Collections.Generic;

namespace Bakery.Models
{
  public abstract class AllVendors
  {
    public static List<Vendor> VendorList { get; set; } = new List<Vendor> {};
  }
}