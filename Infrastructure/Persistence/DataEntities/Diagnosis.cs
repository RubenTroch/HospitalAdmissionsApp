using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Diagnosis {
    public Guid DiagnosisId { get; set; }
    
    [ForeignKey("BodyPart")]
    public Guid BodyPartId { get; set; }

    [ForeignKey("DiagnosisName")]
    public string DiagnosisNameId { get; set; } = string.Empty;
}