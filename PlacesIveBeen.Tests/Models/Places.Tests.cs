using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;
using System.Collections.Generic;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlacesTests
  {
    [TestMethod]
    public void PlacesConstructor_CreatesInstanceOfPlaces_Places()
    {
      Places newPlace = new Places("test", "test", "test");
      Assert.AreEqual(typeof(Places), newPlace.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfPlaces_PlacesList()
    {
      Places newPlace = new Places("test", "test", "test");
      List<Places> newList = Places.GetAll();
      Assert.AreEqual(newList, Places.GetAll());
    }
    
  }
}