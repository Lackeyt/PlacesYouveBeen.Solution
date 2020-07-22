using System.Collections.Generic;

namespace PlacesIveBeen.Models
{
  public class Places
  {
    public string PlaceName { get; set; }
    //public img Image { get; set; }
    public string TravelingPartner { get; set; }
    public string JournalEntry { get; set; }
    public int Id { get; }
    private static List<Places> _instances = new List<Places> {};
    
    public Places(string placeName, string travelingPartner, string journalEntry)
    {
      PlaceName = placeName;
      // Image = Image;
      TravelingPartner = travelingPartner;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Places> GetAll()
    {
      return _instances;
    }
  }
}