using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class HospitalStratum {
    public Guid HospitalStratumId { get; set; }
    public string Name { get; set; } = string.Empty;
}