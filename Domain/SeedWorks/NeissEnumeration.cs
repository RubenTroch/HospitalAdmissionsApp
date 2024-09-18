using System;

namespace HospitalAdmissionsApp.Domain.SeedWorks;

public abstract class NeissEnumeration : Enumeration
{
    public int? NeissCode { get; private set; }
    
    protected NeissEnumeration(int id, int? neissCode, string name)
        : base(id, name) {
        NeissCode = neissCode;
    }
}
