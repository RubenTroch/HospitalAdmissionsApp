using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Location {
    public Guid LocationId { get; set;}
    public int NeissCode { get; set; }
    public string Name { get; set;} = string.Empty;
}
