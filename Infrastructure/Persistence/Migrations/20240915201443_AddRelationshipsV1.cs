using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAdmissionsApp.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmergencyVisitId",
                table: "Injuries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HospitalId",
                table: "HospitalStrata",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AlterColumn<Guid>(
                name: "DiagnosisNameId",
                table: "Diagnoses",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "EmergencyVisitId",
                table: "Diagnoses",
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
                name: "IX_Injuries_PersonId",
                table: "Injuries",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Injuries_People_PersonId",
                table: "Injuries",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Injuries_People_PersonId",
                table: "Injuries");

            migrationBuilder.DropIndex(
                name: "IX_Injuries_PersonId",
                table: "Injuries");

            migrationBuilder.DropColumn(
                name: "EmergencyVisitId",
                table: "Injuries");

            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "HospitalStrata");

            migrationBuilder.DropColumn(
                name: "EmergencyVisitId",
                table: "EmergencyVisitEndings");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "DiagnosisNames");

            migrationBuilder.DropColumn(
                name: "EmergencyVisitId",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "BodyParts");

            migrationBuilder.AlterColumn<string>(
                name: "DiagnosisNameId",
                table: "Diagnoses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
