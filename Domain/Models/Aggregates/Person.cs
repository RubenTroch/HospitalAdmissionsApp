using System;
using System.Collections.Generic;
using HospitalAdmissionsApp.Domain.Models.ValueObjects;

namespace HospitalAdmissionsApp.Domain.Models.Aggregates;

public class Person {
    public Person (string name, int age, int sex, float weight) {
        Name = name;
        Age = age;
        Sex = sex;
        Weight = weight;
    }

    public Guid PersonId { get; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Sex { get; set; }
    public float Weight { get; set; }

    public List<Ethnicity> Ethnicities { get; set; } = new();
}