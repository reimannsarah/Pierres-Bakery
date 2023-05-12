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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }

}