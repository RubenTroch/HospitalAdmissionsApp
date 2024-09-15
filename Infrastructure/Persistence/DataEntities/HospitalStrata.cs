using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class HospitalStrata {
    public Guid HospitalStratumId { get; set; }
    public string Name { get; set; } = string.Empty;
}