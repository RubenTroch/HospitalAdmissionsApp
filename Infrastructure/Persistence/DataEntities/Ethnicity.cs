using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Ethnicity {
    public Guid Id { get; set; }
    public int NeissCode { get; set; }
    public string Name { get; set; } = string.Empty;
}