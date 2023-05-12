using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace BakeryTests
{
  [TestClass]
  public class AllVendorsTests
  {
    [TestMethod]
    public void AllVendorsConstructor_CreatesInstanceOfAllVendors_AllVendors()
    {
      Vendor jean = new Vendor();
      bool expected = true;
      Assert.AreEqual(expected, jean is AllVendors);
    }
  }
}