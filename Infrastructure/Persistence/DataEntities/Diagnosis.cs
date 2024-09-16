using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Diagnosis {
    public Guid DiagnosisId { get; set; }
    
    [ForeignKey("BodyPart")]
    public Guid BodyPartId { get; set; }
    public virtual BodyPart? BodyPart { get; set; }


    [ForeignKey("DiagnosisName")]
    public Guid DiagnosisNameId { get; set; }
    public virtual DiagnosisName? DiagnosisName { get; set; }


    [ForeignKey("EmergencyVisit")]
    public Guid EmergencyVisitId { get; set; }
    public virtual EmergencyVisit? EmergencyVisit { get; set; }
}