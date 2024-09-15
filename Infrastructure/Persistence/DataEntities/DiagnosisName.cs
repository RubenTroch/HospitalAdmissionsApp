using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class DiagnosisName {
    public Guid DiagnosisDescriptionId { get; set; }
    public int NeissCode { get; set; }
    public string Name { get; set; } = string.Empty;
}