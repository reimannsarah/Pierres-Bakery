using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace BakeryTests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOrOrder_Order()
    {
      string[] products = {"sourdough", "baguette", "rye"};
      int[] amounts = {2,4,5};
      Order newOrder = new Order("Sourdough", products, amounts);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrderWithProperties_Int()
    {
      string[] products = {"sourdough", "baguette", "rye"};
      int[] amounts = {2,4,5};
      Order newOrder = new Order("Sourdough", products, amounts);
      string result = "0001";
      Assert.AreEqual(newOrder.OrderNumber, result);
    }
    
    [TestMethod]
    public void OrderConstructor_CreatesDictionaryWithOrderDetails_Int()
    {
      string[] products = {"sourdough", "baguette", "rye"};
      int[] amounts = {2,4,5};
      Order newOrder = new Order("Sarah's Bakery", products, amounts);
      int result = newOrder.Cart["sourdough"];
      Assert.AreEqual(2, result);
    }
    
    [TestMethod]
    public void CalculateTotalMethod_CalculatesTotalOfItemsInCart_Int()
    {
      string[] products = {"super sourdough rainbow swirl", "le baguette", "rye guy"};
      int[] amounts = {2,4,5};
      Order newOrder = new Order("Sarah's Bakery", products, amounts);
      newOrder.CalculateTotal();
      int result = newOrder.OrderTotal;
      Assert.AreEqual(41, result);
    }
  }

}