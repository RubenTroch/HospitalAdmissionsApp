using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalAdmissionsApp.Domain.Models.Aggregates;

namespace HospitalAdmissionsApp.Domain.Repositories;

public interface IAggregateRepository<T> {
    public Task<Guid> CreateAsync(T aggregate);
    public Task<T> ReadAsync(Guid id);
    public Task<List<T>> ReadAllAsync();
    public Task UpdateAsync(T aggregate);
    public Task DeleteAsync(Guid id);
}