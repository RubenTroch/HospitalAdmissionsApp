using System;
using System.Collections.Generic;
using HospitalAdmissionsApp.Domain.Models.Entities;
using HospitalAdmissionsApp.Domain.Models.ValueObjects;

namespace HospitalAdmissionsApp.Domain.Models.Aggregates;

public class EmergencyVisit{
    public EmergencyVisit(
        Guid personId,
        Guid hospitalId        
    ) {
        Date = DateTime.Now;
        PersonId = personId;
        HospitalId = hospitalId;
    }

    public Guid? EmergencyVisitId { get; }
    public DateTime Date { get; set; }

    public Injury? Injury { get; set; }
    public EmergencyVisitEnding? EmergencyVisitEnding { get; set; }

    public Guid PersonId { get; set; }
    public Guid HospitalId { get; set; }
    public List<Guid> DiagnosisIds = new();
}