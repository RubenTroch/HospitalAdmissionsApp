using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Injury {
    public Guid IncidentId { get; set;}
    public bool AlcoholInvolvement  {get; set;}
    public bool DrugInvolvement  {get; set;}
    public string Narrative { get; set; } = string.Empty;
    public DateTime TreatmentDate { get; set; }

    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    [ForeignKey("FireInvolvementLevel")]
    public Guid FireInvolvementLevelId { get; set; }

    [ForeignKey("Location")]
    public Guid LocationId { get; set; }

    public List<Product> ProductsInvolved { get; set; } = new();
}
