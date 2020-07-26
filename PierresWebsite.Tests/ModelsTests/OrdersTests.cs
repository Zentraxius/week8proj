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
      string description = "Wash the Sesame Seeds";
      Order newOrder = new Order(description);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void CheckDescription_SetDescription_String()
    {
      string description = "Check the flour";
      Order newOrder = new Order(description);

      string updatedDescription = "Stock the yeast";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisOrder.Description);
      }
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      
      string description01 = "Knead the dough";
      string description02 = "Preheat the oven";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

     
      List<Order> result = Order.GetAll();

      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisOrder.Description);
      }

     
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_GetIdForOrder_Int()
    {
      string description = "Add a pinch of salt";
      Order newOrder = new Order(description);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "Wash your hands";
      string description02 = "Preserve the sourdough starter";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);

      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}