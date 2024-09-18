using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;

public class Location : NeissEnumeration {
    public static Location Home = new(1, 1, "Home");
    public static Location FarmOrRanch = new(2, 2, "Farm/Ranch");
    public static Location Street = new(3, 4, "Street or Highway");
    public static Location OtherPublic = new(4, 5, "Other Public Property");
    public static Location MobileHome = new(5, 6, "Mobile Home");
    public static Location Industrial = new(6, 7, "Industrial");
    public static Location School = new(7, 8, "School");
    public static Location DayCare = new(8, 8, "Daycare");
    public static Location RecreationalPlace = new(9, 9, "Place of Recreation or Sports");

    public Location(int id, int? neissCode, string name) : base(id, neissCode, name)
    {
    }
}