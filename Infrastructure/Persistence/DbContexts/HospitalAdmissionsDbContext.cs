using HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HospitalAdmissionsApp.Infrastructure.Persistence.DbContexts;

public class HospitalAdmissionsDbContext : DbContext {

    public DbSet<BodyPart> BodyParts { get; set; }
    public DbSet<Diagnosis> Diagnoses { get; set; }
    public DbSet<DiagnosisName> DiagnosisNames { get; set; }
    public DbSet<EmergencyVisit> EmergencyVisits { get; set; }
    public DbSet<EmergencyVisitEnding> EmergencyVisitEndings { get; set; }
    public DbSet<Ethnicity> Ethnicities { get; set; }
    public DbSet<FireInvolvementLevel> FireInvolvementLevels { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<HospitalAdmission> HospitalAdmissions { get; set; }
    public DbSet<HospitalStratum> HospitalStrata { get; set; }
    public DbSet<Injury> Injuries { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }

    public HospitalAdmissionsDbContext() {}

    public HospitalAdmissionsDbContext(DbContextOptions options)
        : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("HospitalAdmissionsDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}



