using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace BakeryTests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOrOrder_Order()
    {
      Order newOrder = new Order("Sourdough");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrderWithProperties_Int()
    {
      Order newOrder = new Order("Sourdough");
      string result = "0001";
      Assert.AreEqual(newOrder.OrderNumber, result);
    }
  }

}