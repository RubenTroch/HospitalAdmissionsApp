using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Hospital {
    public Guid HospitalId { get; set; }
    public string Name { get; set;} = string.Empty;
    
    [ForeignKey("HospitalStrata")]
    public Guid HospitalStratumId { get; set; }
}