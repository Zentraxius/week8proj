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
    public void OrderTest1_DoesOrderExist_ExistYes()
    {
    Order newOrder = new Order("Test");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}