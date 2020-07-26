using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresWebsite.Models;
using System.Collections.Generic;
using System;

namespace PierresWebsite.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_TellsName_String()
    {
      string name = "Stacy's Bakery";
      Vendor newVendor = new Vendor(name); 

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorID_Int()
    {
      string name = "John's Muffins";
      Vendor newVendor = new Vendor(name);// ID 3
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Pierre's";
      string name02 = "Bakery";

      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Pierre's";
      string name02 = "Bakery";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "Behold the Yeast!";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Pierre's!";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);

    }
  }
}