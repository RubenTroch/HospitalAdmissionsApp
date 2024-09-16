using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAdmissionsApp.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ethnicities_People_PersonId",
                table: "Ethnicities");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Injuries_InjuryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_InjuryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Ethnicities_PersonId",
                table: "Ethnicities");

            migrationBuilder.DropColumn(
                name: "InjuryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "HospitalStrata");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Ethnicities");

            migrationBuilder.DropColumn(
                name: "EmergencyVisitId",
                table: "EmergencyVisitEndings");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "DiagnosisNames");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "BodyParts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ethnicities",
                newName: "EthnicityId");

            migrationBuilder.CreateTable(
                name: "PeopleEthnicities",
                columns: table => new
                {
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleEthnicities", x => new { x.EthnicityId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_PeopleEthnicities_Ethnicities_EthnicityId",
                        column: x => x.EthnicityId,
                        principalTable: "Ethnicities",
                        principalColumn: "EthnicityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleEthnicities_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjuryInvolvedProducts",
                columns: table => new
                {
                    InjuryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryInvolvedProducts", x => new { x.InjuryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_InjuryInvolvedProducts_Injuries_InjuryId",
                        column: x => x.InjuryId,
                        principalTable: "Injuries",
                        principalColumn: "InjuryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryInvolvedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Injuries_FireInvolvementLevelId",
                table: "Injuries",
                column: "FireInvolvementLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Injuries_LocationId",
                table: "Injuries",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_HospitalStratumId",
                table: "Hospitals",
                column: "HospitalStratumId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalAdmissions_HospitalId",
                table: "HospitalAdmissions",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyVisits_EmergencyVisitEndingId",
                table: "EmergencyVisits",
                column: "EmergencyVisitEndingId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyVisits_HospitalId",
                table: "EmergencyVisits",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyVisits_InjuryId",
                table: "EmergencyVisits",
                column: "InjuryId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_BodyPartId",
                table: "Diagnoses",
                column: "BodyPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_DiagnosisNameId",
                table: "Diagnoses",
                column: "DiagnosisNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_EmergencyVisitId",
                table: "Diagnoses",
                column: "EmergencyVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleEthnicities_PersonId",
                table: "PeopleEthnicities",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuryInvolvedProducts_ProductId",
                table: "InjuryInvolvedProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_BodyParts_BodyPartId",
                table: "Diagnoses",
                column: "BodyPartId",
                principalTable: "BodyParts",
                principalColumn: "BodyPartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_DiagnosisNames_DiagnosisNameId",
                table: "Diagnoses",
                column: "DiagnosisNameId",
                principalTable: "DiagnosisNames",
                principalColumn: "DiagnosisNameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_EmergencyVisits_EmergencyVisitId",
                table: "Diagnoses",
                column: "EmergencyVisitId",
                principalTable: "EmergencyVisits",
                principalColumn: "EmergencyVisitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyVisits_EmergencyVisitEndings_EmergencyVisitEndingId",
                table: "EmergencyVisits",
                column: "EmergencyVisitEndingId",
                principalTable: "EmergencyVisitEndings",
                principalColumn: "EmergencyVisitEndingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyVisits_Hospitals_HospitalId",
                table: "EmergencyVisits",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyVisits_Injuries_InjuryId",
                table: "EmergencyVisits",
                column: "InjuryId",
                principalTable: "Injuries",
                principalColumn: "InjuryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalAdmissions_Hospitals_HospitalId",
                table: "HospitalAdmissions",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_HospitalStrata_HospitalStratumId",
                table: "Hospitals",
                column: "HospitalStratumId",
                principalTable: "HospitalStrata",
                principalColumn: "HospitalStratumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Injuries_FireInvolvementLevels_FireInvolvementLevelId",
                table: "Injuries",
                column: "FireInvolvementLevelId",
                principalTable: "FireInvolvementLevels",
                principalColumn: "FireInvolvementLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Injuries_Locations_LocationId",
                table: "Injuries",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_BodyParts_BodyPartId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_DiagnosisNames_DiagnosisNameId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_EmergencyVisits_EmergencyVisitId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyVisits_EmergencyVisitEndings_EmergencyVisitEndingId",
                table: "EmergencyVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyVisits_Hospitals_HospitalId",
                table: "EmergencyVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyVisits_Injuries_InjuryId",
                table: "EmergencyVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_HospitalAdmissions_Hospitals_HospitalId",
                table: "HospitalAdmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_HospitalStrata_HospitalStratumId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Injuries_FireInvolvementLevels_FireInvolvementLevelId",
                table: "Injuries");

            migrationBuilder.DropForeignKey(
                name: "FK_Injuries_Locations_LocationId",
                table: "Injuries");

            migrationBuilder.DropTable(
                name: "EthnicityPerson");

            migrationBuilder.DropTable(
                name: "InjuryProduct");

            migrationBuilder.DropIndex(
                name: "IX_Injuries_FireInvolvementLevelId",
                table: "Injuries");

            migrationBuilder.DropIndex(
                name: "IX_Injuries_LocationId",
                table: "Injuries");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_HospitalStratumId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_HospitalAdmissions_HospitalId",
                table: "HospitalAdmissions");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyVisits_EmergencyVisitEndingId",
                table: "EmergencyVisits");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyVisits_HospitalId",
                table: "EmergencyVisits");

            migrationBuilder.DropIndex(
                name: "IX_EmergencyVisits_InjuryId",
                table: "EmergencyVisits");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_BodyPartId",
                table: "Diagnoses");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_DiagnosisNameId",
                table: "Diagnoses");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_EmergencyVisitId",
                table: "Diagnoses");

            migrationBuilder.RenameColumn(
                name: "EthnicityId",
                table: "Ethnicities",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "InjuryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HospitalId",
                table: "HospitalStrata",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Ethnicities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmergencyVisitId",
                table: "EmergencyVisitEndings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DiagnosisId",
                table: "DiagnosisNames",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DiagnosisId",
                table: "BodyParts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Products_InjuryId",
                table: "Products",
                column: "InjuryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ethnicities_PersonId",
                table: "Ethnicities",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ethnicities_People_PersonId",
                table: "Ethnicities",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Injuries_InjuryId",
                table: "Products",
                column: "InjuryId",
                principalTable: "Injuries",
                principalColumn: "InjuryId");
        }
    }
}
