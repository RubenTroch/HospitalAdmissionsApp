using HospitalAdmissionsApp.Domain.Models.ValueObjects;

using System;

namespace HospitalAdmissionsApp.Domain.Models.Aggregates;

public class Diagnosis {
    public Diagnosis(BodyPart bodyPart, DiagnosisName diagnosisName) {
        BodyPart = bodyPart;
        DiagnosisName = diagnosisName;
    }

    public Guid DiagnosisId { get; }
    public BodyPart BodyPart { get; set; }
    public DiagnosisName DiagnosisName { get; set; }
    public Guid EmergencyVisitId { get; set; }
}