using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Hospital {
    public Guid HospitalId { get; set; }
    public string Name { get; set;} = string.Empty;
    
    [ForeignKey("HospitalStrata")]
    public Guid HospitalStratumId { get; set; }
    public virtual HospitalStratum? HospitalStratum { get; set; }

    public virtual List<EmergencyVisit> EmergencyVisits { get; set; } = new();
    public virtual List<HospitalAdmission> HospitalAdmissions { get; set; } = new();
}