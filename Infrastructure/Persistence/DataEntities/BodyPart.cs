using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class BodyPart {
    public Guid BodyPartId { get; set; }
    public int NeissCode { get; set;}
    public string Name { get; set; } = string.Empty;
}