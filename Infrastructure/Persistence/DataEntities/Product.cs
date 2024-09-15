using System;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;

public class Product {
    public Guid ProductId { get; set;}
    public int NeissCode { get; set; }
    public string Name { get; set;} = string.Empty;
}