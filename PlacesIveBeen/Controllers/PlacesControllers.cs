using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;
using System;
using System.Collections.Generic;

namespace PlacesIveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/Places")]
    public ActionResult Index()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }
    
    [HttpGet("/Places/New")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Places")]
    public ActionResult Create(string placeName, string travelingPartner, string journalEntry)
    {
      Places newPlaces = new Places(placeName, travelingPartner, journalEntry);
      return RedirectToAction("Index");
    }

    [HttpGet("/Places/{id}")]
    public ActionResult Show(int id)
    {
      Places foundPlace = Places.Find(id);
      return View(foundPlace);
    }
  }
}