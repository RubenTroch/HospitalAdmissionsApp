using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;

public class EmergencyVisitEnding : NeissEnumeration {
    public static EmergencyVisitEnding TreatedReleased = new(1, 1, "Treated/Examined and Released ");
    public static EmergencyVisitEnding TreatedTransferred = new(2, 2, "Treated and Transferred");
    public static EmergencyVisitEnding TreatedAdmitted = new(3, 4, "Treated and Admitted/Hospitalized ");
    public static EmergencyVisitEnding HeldForObservation = new(4, 5, "Held for Observation");
    public static EmergencyVisitEnding LeftWithoutBeingSeen = new(5, 6, "Left Without Being Seen");
    public static EmergencyVisitEnding Fatality = new(6, 8, "Fatality, Incl. DOA, Died in ER");

    public EmergencyVisitEnding(int id, int neissCode, string name) : base(id, neissCode, name)
    {
    }
}
