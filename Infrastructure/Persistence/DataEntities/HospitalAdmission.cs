using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class HospitalAdmission {
    public Guid HospitalAdmissionId { get; set; }
    public string Name { get; set; } = string.Empty;

    [ForeignKey("Hospital")]
    public Guid HospitalId { get; set; }
}
