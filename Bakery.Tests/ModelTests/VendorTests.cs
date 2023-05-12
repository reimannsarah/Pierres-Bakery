using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BakeryTests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendorWithProperties_String()
    {
      Vendor bakeWithMe = new Vendor("Bake With Me", "Mom and Pop shop");
      string result = "Bake With Me";
      Assert.AreEqual(bakeWithMe.Name, result);
    }
  }
}