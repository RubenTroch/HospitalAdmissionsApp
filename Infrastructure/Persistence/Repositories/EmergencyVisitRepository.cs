using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAdmissionsApp.Domain.Models.Aggregates;
using HospitalAdmissionsApp.Domain.Repositories;
using HospitalAdmissionsApp.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.Repositories;

public class EmergencyVisitRepository : IEmergencyVisitRepository {
    private readonly HospitalAdmissionsDbContext _dbContext;

    public EmergencyVisitRepository(HospitalAdmissionsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Guid> CreateAsync(EmergencyVisit aggregate)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<EmergencyVisit>> ReadAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmergencyVisit> ReadAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(EmergencyVisit aggregate)
    {
        throw new NotImplementedException();
    }
}