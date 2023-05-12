using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor : AllVendors 
  {
    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>{};
      VendorList.Add(this);
      Id = VendorList.Count;
    }

  }
}