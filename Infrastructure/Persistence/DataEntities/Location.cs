using System;
using System.Collections.Generic;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Location {
    public Guid LocationId { get; set;}
    public int NeissCode { get; set; }
    public string Name { get; set;} = string.Empty;
}
