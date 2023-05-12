using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BakeryTests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendorWithProperties_String()
    {
      Vendor bakeWithMe = new Vendor("Bake With Me", "Mom and Pop shop");
      string result = "Bake With Me";
      Assert.AreEqual(bakeWithMe.Name, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_String()
    {
      string[] products = {"sourdough", "baguette", "rye"};
      int[] amounts = {2,4,5};
      Order newOrder = new Order("Sourdough", products, amounts);
      Vendor jean = new Vendor("Jean", "I am french");
      jean.AddOrder(newOrder);
      string result = jean.Orders[0].VendorName;
      Assert.AreEqual("Sourdough", result);
    }

    [TestMethod]
    public void FindMethod_FindsVendorAtGivenId_String()
    {
      Vendor jean = new Vendor("Jean", "I am french");
      AllVendors foundVendor = AllVendors.Find(1);
      string result = "jean";
      Assert.AreEqual("jean", result);
    }
  }
}