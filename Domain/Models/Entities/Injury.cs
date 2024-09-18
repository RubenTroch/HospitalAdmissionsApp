using System;
using System.Collections.Generic;
using HospitalAdmissionsApp.Domain.Models.ValueObjects;

namespace HospitalAdmissionsApp.Domain.Models.Entities;

public class Injury {
    public Injury(
        string narrative,
        bool? alcoholInvolvement = null,
        bool? drugInvolvement = null,
        FireInvolvementLevel? fireInvolvementLevel = null,
        Location? location = null
    ) {
        Narrative = narrative;
        AlcoholInvolvement = alcoholInvolvement;
        DrugInvolvement = drugInvolvement;
        FireInvolvementLevel = fireInvolvementLevel;
        Location = location;
    }

    public Guid InjuryId { get; }
    public string Narrative { get; set; } = string.Empty;
    public bool? AlcoholInvolvement  {get; set;}
    public bool? DrugInvolvement  {get; set;}
    public FireInvolvementLevel? FireInvolvementLevel { get; set; }
    public Location? Location { get; set;}
}