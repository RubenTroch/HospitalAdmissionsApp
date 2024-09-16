using System;
using System.Collections.Generic;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Ethnicity {
    public Guid EthnicityId { get; set; }
    public int NeissCode { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual List<Person> People { get; set; } = new();
}