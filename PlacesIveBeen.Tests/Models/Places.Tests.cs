using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesIveBeen.Tests
{
  [TestClass]
  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }
    
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

    
    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      //Arrange
      Places newPlaces1 = new Places("test", "test", "test");
      Places newPlaces2 = new Places("test2", "test2", "test2");

      //Act
      Places result = Places.Find(2);

      //Assert
      Assert.AreEqual(newPlaces2, result);
    }
    
  }
}