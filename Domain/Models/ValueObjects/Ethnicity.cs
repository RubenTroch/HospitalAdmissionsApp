using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;

public class Ethnicity : NeissEnumeration {
    public static Ethnicity EuropeanNonHispanic = new(1, 1, "European Non-Hispanic");
    public static Ethnicity African = new(2, 2, "Black/African American");
    public static Ethnicity Other = new(3, 3, "Other");
    public static Ethnicity Asian = new(4, 4, "Asian");
    public static Ethnicity American = new(5, 1, "American");
    public static Ethnicity NativeAmerican = new(6, 5, "American Native/Alaska Native");
    public static Ethnicity NativePacific = new(7, 6, "Native Hawaiian/Pacific Islander");
    public static Ethnicity Hispanic = new(8, null, "Hispanic");

    public Ethnicity(int id, int? neissCode, string name) : base(id, neissCode, name)
    {
    }
}