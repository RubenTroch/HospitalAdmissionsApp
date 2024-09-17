using HospitalAdmissionsApp.Domain.Models.Aggregates;

namespace HospitalAdmissionsApp.Domain.Repositories;

public interface IDiagnosis : IAggregateRepository<Diagnosis> {}
