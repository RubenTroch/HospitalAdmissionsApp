using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalAdmissionsApp.Domain.Repositories;

public interface IAggregateRepository<TEntity> {
    public Task<Guid> CreateAsync(TEntity aggregate);
    public Task<TEntity> ReadAsync(Guid id);
    public Task<List<TEntity>> ReadAllAsync();
    public Task UpdateAsync(TEntity aggregate);
    public Task DeleteAsync(Guid id);
}