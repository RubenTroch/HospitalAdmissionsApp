using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class EmergencyVisit {
    public Guid EmergencyVisitId { get; set; }
    public string CPSCCaseNumber { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    [ForeignKey("Injury")]
    public Guid InjuryId { get; set; }
    public virtual Injury? Injury { get; set; }

    [ForeignKey("Hospital")]
    public Guid HospitalId { get; set; }
    public virtual Hospital? Hospital { get; set; }

    [ForeignKey("EmergencyVisitEnding")]
    public Guid EmergencyVisitEndingId { get; set; }
    public virtual EmergencyVisitEnding? EmergencyVisitEnding { get; set; }

    public virtual List<Diagnosis> Diagnoses { get; set; } = new();
}
