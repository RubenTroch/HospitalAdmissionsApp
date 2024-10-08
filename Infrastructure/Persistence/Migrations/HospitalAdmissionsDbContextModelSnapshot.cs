﻿// <auto-generated />
using System;
using HospitalAdmissionsApp.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalAdmissionsApp.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(HospitalAdmissionsDbContext))]
    partial class HospitalAdmissionsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EthnicityPerson", b =>
                {
                    b.Property<Guid>("EthnicitiesEthnicityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PeoplePersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EthnicitiesEthnicityId", "PeoplePersonId");

                    b.HasIndex("PeoplePersonId");

                    b.ToTable("EthnicityPerson");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.BodyPart", b =>
                {
                    b.Property<Guid>("BodyPartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("BodyPartId");

                    b.ToTable("BodyParts");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Diagnosis", b =>
                {
                    b.Property<Guid>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BodyPartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiagnosisNameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmergencyVisitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("BodyPartId");

                    b.HasIndex("DiagnosisNameId");

                    b.HasIndex("EmergencyVisitId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.DiagnosisName", b =>
                {
                    b.Property<Guid>("DiagnosisNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisNameId");

                    b.ToTable("DiagnosisNames");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisit", b =>
                {
                    b.Property<Guid>("EmergencyVisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPSCCaseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmergencyVisitEndingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InjuryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmergencyVisitId");

                    b.HasIndex("EmergencyVisitEndingId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("InjuryId");

                    b.ToTable("EmergencyVisits");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisitEnding", b =>
                {
                    b.Property<Guid>("EmergencyVisitEndingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmergencyVisitEndingId");

                    b.ToTable("EmergencyVisitEndings");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Ethnicity", b =>
                {
                    b.Property<Guid>("EthnicityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("EthnicityId");

                    b.ToTable("Ethnicities");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.FireInvolvementLevel", b =>
                {
                    b.Property<Guid>("FireInvolvementLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("FireInvolvementLevelId");

                    b.ToTable("FireInvolvementLevels");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Hospital", b =>
                {
                    b.Property<Guid>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HospitalStratumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalId");

                    b.HasIndex("HospitalStratumId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.HospitalAdmission", b =>
                {
                    b.Property<Guid>("HospitalAdmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalAdmissionId");

                    b.HasIndex("HospitalId");

                    b.ToTable("HospitalAdmissions");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.HospitalStratum", b =>
                {
                    b.Property<Guid>("HospitalStratumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalStratumId");

                    b.ToTable("HospitalStrata");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Injury", b =>
                {
                    b.Property<Guid>("InjuryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AlcoholInvolvement")
                        .HasColumnType("bit");

                    b.Property<bool>("DrugInvolvement")
                        .HasColumnType("bit");

                    b.Property<Guid>("EmergencyVisitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FireInvolvementLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Narrative")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TreatmentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InjuryId");

                    b.HasIndex("FireInvolvementLevelId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PersonId");

                    b.ToTable("Injuries");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeissCode")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InjuryProduct", b =>
                {
                    b.Property<Guid>("InjuriesInjuryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsInvolvedProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InjuriesInjuryId", "ProductsInvolvedProductId");

                    b.HasIndex("ProductsInvolvedProductId");

                    b.ToTable("InjuryProduct");
                });

            modelBuilder.Entity("EthnicityPerson", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Ethnicity", null)
                        .WithMany()
                        .HasForeignKey("EthnicitiesEthnicityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Person", null)
                        .WithMany()
                        .HasForeignKey("PeoplePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Diagnosis", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.BodyPart", "BodyPart")
                        .WithMany()
                        .HasForeignKey("BodyPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.DiagnosisName", "DiagnosisName")
                        .WithMany()
                        .HasForeignKey("DiagnosisNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisit", "EmergencyVisit")
                        .WithMany("Diagnoses")
                        .HasForeignKey("EmergencyVisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyPart");

                    b.Navigation("DiagnosisName");

                    b.Navigation("EmergencyVisit");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisit", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisitEnding", "EmergencyVisitEnding")
                        .WithMany()
                        .HasForeignKey("EmergencyVisitEndingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Hospital", "Hospital")
                        .WithMany("EmergencyVisits")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Injury", "Injury")
                        .WithMany()
                        .HasForeignKey("InjuryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmergencyVisitEnding");

                    b.Navigation("Hospital");

                    b.Navigation("Injury");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Hospital", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.HospitalStratum", "HospitalStratum")
                        .WithMany()
                        .HasForeignKey("HospitalStratumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HospitalStratum");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.HospitalAdmission", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Hospital", "Hospital")
                        .WithMany("HospitalAdmissions")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Injury", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.FireInvolvementLevel", "FireInvolvementLevel")
                        .WithMany()
                        .HasForeignKey("FireInvolvementLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Person", "Person")
                        .WithMany("Injuries")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FireInvolvementLevel");

                    b.Navigation("Location");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("InjuryProduct", b =>
                {
                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Injury", null)
                        .WithMany()
                        .HasForeignKey("InjuriesInjuryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsInvolvedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.EmergencyVisit", b =>
                {
                    b.Navigation("Diagnoses");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Hospital", b =>
                {
                    b.Navigation("EmergencyVisits");

                    b.Navigation("HospitalAdmissions");
                });

            modelBuilder.Entity("HospitalAdmissionsApp.Infrastructure.Persistence.DataEntities.Person", b =>
                {
                    b.Navigation("Injuries");
                });
#pragma warning restore 612, 618
        }
    }
}
