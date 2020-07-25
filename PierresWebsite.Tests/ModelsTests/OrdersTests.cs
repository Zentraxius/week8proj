using PierresWebsite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PierresWebsite.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConfirmation_DoesOrderExist_ExistYes()
    {
    Order newOrder = new Order("Test");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderDescription_DoesOrderHaveDescription_Exists()
    {
      string description = "Example String";
      Order newOrder = new Order(description);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
  }
}