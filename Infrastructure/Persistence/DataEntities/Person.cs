using System;
using System.Collections.Generic;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Person {
    public Guid PersonId { get; set;}
    public string Name { get; set;} = string.Empty;
    public int Age { get; set;}
    public int Sex { get; set;}
    public float Weight { get; set;}

    public List<Ethnicity> Ethnicities { get; set; } = new();
}