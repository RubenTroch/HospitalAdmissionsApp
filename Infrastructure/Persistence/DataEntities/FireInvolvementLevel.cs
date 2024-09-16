using System;
using System.Collections.Generic;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class FireInvolvementLevel {
    public Guid FireInvolvementLevelId { get; set; }
    public int NeissCode { get; set; }
    public string Name { get; set; } = string.Empty;
}