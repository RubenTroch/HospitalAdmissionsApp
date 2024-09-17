using System;
using HospitalAdmissionsApp.Domain.Models.ValueObjects;

namespace HospitalAdmissionsApp.Domain.Models.Aggregates;

public class Hospital {
    public Hospital(string name, HospitalStratum hospitalStratum) {
        Name = name;
        HospitalStratum = hospitalStratum;
    }

    public Guid? HospitalId { get; }
    public string Name { get; set;} = string.Empty;
    public HospitalStratum HospitalStratum { get; set; }
}