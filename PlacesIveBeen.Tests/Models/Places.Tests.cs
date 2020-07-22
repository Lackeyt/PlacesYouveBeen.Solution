using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesIveBeen.Models;

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
  }
}