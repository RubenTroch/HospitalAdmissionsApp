using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Injury {
    public Guid InjuryId { get; set;}
    public bool AlcoholInvolvement  {get; set;}
    public bool DrugInvolvement  {get; set;}
    public string Narrative { get; set; } = string.Empty;
    public DateTime TreatmentDate { get; set; }

    [ForeignKey("Person")]
    public Guid PersonId { get; set; }
    public virtual Person? Person { get; set; }

    [ForeignKey("FireInvolvementLevel")]
    public Guid FireInvolvementLevelId { get; set; }
    public virtual FireInvolvementLevel? FireInvolvementLevel { get; set; }

    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public virtual Location? Location { get; set;}

    [ForeignKey("EmergencyVisit")]
    public Guid EmergencyVisitId { get; set; }

    public virtual List<Product> ProductsInvolved { get; set; } = new();
}
