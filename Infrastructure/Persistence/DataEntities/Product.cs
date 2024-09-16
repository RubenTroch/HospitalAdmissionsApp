using System;
using System.Collections.Generic;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Product {
    public Guid ProductId { get; set;}
    public int NeissCode { get; set; }
    public string Name { get; set;} = string.Empty;

    public virtual List<Injury> Injuries { get; set; } = new();
}