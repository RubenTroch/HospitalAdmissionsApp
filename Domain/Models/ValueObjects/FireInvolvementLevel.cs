using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;

public class FireInvolvementLevel : NeissEnumeration {
    public static FireInvolvementLevel NoFireInvolved = new(1, 0, "No Fire Involved or Fire Involvement Not Recorded");
    public static FireInvolvementLevel FireWithFireDepartment= new(2, 1, "Fire Involved and Fire Department Attended");
    public static FireInvolvementLevel FireNoFireDepartment = new(3, 2, "Fire Involved and Fire Department Did Not Attend");
    public static FireInvolvementLevel FireWithUnknownFireDepartment = new(4, 3, "Fire Involved and Unknown Fire Department Attendance ");

    public FireInvolvementLevel(int id, int? neissCode, string name) : base(id, neissCode, name)
    {
    }
}