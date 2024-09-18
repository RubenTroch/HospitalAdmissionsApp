using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;
    public class DiagnosisName : NeissEnumeration {
    public static DiagnosisName Ingestion = new(1, 41, "Ingestion");
    public static DiagnosisName Aspiration = new(2, 42, "Aspiration");
    public static DiagnosisName BurnsElectrical = new(3, 46, "Burns - Electrical");
    public static DiagnosisName BurnsNotSpecified = new(4, 47, "Burns - Not Specified");
    public static DiagnosisName BurnsScald = new(5, 48, "Burns - Scald");
    public static DiagnosisName BurnsChemical = new(6, 49, "Burns - Chemical");
    public static DiagnosisName Amputation = new(7, 50, "Amputation");
    public static DiagnosisName BurnsThermal = new(8, 51, "Burns - Thermal");
    public static DiagnosisName Concussions = new(9, 52, "Concussions");
    public static DiagnosisName Abrasions = new(10, 53, "Abrasions");
    public static DiagnosisName Crushing = new(11, 54, "Crushing");
    public static DiagnosisName Dislocation = new(12, 55, "Dislocation");
    public static DiagnosisName ForeignBody = new(13, 56, "Foreign Body");
    public static DiagnosisName Fracture = new(14, 57, "Fracture");
    public static DiagnosisName Hematome = new(15, 58, "Hematoma");
    public static DiagnosisName Laceration = new(16, 59, "Laceration");
    public static DiagnosisName DentalInjury = new(17, 60, "Dental Injury");
    public static DiagnosisName NerveDamage = new(18, 61, "Nerve Damage");
    public static DiagnosisName InternalOrganInjury = new(19, 62, "Internal Organ Injury");
    public static DiagnosisName Puncture = new(20, 63, "Puncture");
    public static DiagnosisName Strain = new(21, 64, "Strain");
    public static DiagnosisName Anoxia = new(22, 65, "Anoxia");
    public static DiagnosisName Hemorrhage = new(23, 66, "Hemorrhage");
    public static DiagnosisName ElectricShock = new(24, 67, "Electric Shock");
    public static DiagnosisName Poisoning = new(25, 68, "Poisoning");
    public static DiagnosisName Submersion = new(26, 69, "Submersion");
    public static DiagnosisName Other = new(27, 71, "Other - Not Stated");
    public static DiagnosisName Avulsion = new(28, 72, "Avulsion");
    public static DiagnosisName BurnsRadiation = new(29, 73, "Burns - Radiation");
    public static DiagnosisName Dermatitis = new(30, 74, "Dermatitis");
    public static DiagnosisName Conjunctivitis = new(31, 74, "Conjunctivitis");

    public DiagnosisName(int id, int neissCode, string name) : base(id, neissCode, name)
    {
    }
}