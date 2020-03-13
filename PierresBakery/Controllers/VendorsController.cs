using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet ("/vendors")]
    public ActionResult Index ()
    {
      List<Vendor> allVendors = Vendor.GetAll ();
      return View (allVendors);
    }

    [HttpGet ("/vendors/new")]
    public ActionResult New ()
    {
      return View ();
    }

    [HttpPost ("/vendors")]
    public ActionResult Create (string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor (vendorName, vendorDescription);
      return RedirectToAction ("Index");
    }

    // This one creates new Orders within a given Vendor, not new Vendors:

    [HttpPost ("/vendors/{vendorId}/orders")]
    public ActionResult Create (int vendorId, string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor foundVendor = Vendor.Find (vendorId);
      Order newOrder = new Order (orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddItem (newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add ("orders", vendorOrders);
      model.Add ("vendor", foundVendor);
      return View ("Show", model);
    }

    [HttpGet ("/vendors/{id}")]

    public ActionResult Show (int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor selectedVendor = Vendor.Find (id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add ("vendor", selectedVendor);
      model.Add ("orders", vendorOrders);
      return View (model);
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
  }
}