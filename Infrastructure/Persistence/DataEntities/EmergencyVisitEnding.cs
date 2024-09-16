using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class EmergencyVisitEnding {
    public Guid EmergencyVisitEndingId { get; set; }
    public string Name { get; set;} = string.Empty;
}