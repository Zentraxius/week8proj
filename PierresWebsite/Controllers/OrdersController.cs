using Microsoft.AspNetCore.Mvc;
using PierresWebsite.Models;
using System.Collections.Generic;

namespace PierresWebsite.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId);
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}