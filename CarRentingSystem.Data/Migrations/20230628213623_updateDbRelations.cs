using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentingSystem.Web.Data.Migrations
{
    public partial class updateDbRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProtectionPlanId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProtectionPlanId",
                table: "Cargos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ProtectionPlanId",
                table: "Cars",
                column: "ProtectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_ProtectionPlanId",
                table: "Cargos",
                column: "ProtectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_ProtectionPlans_ProtectionPlanId",
                table: "Cargos",
                column: "ProtectionPlanId",
                principalTable: "ProtectionPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_ProtectionPlans_ProtectionPlanId",
                table: "Cars",
                column: "ProtectionPlanId",
                principalTable: "ProtectionPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_ProtectionPlans_ProtectionPlanId",
                table: "Cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_ProtectionPlans_ProtectionPlanId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ProtectionPlanId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_ProtectionPlanId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "ProtectionPlanId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ProtectionPlanId",
                table: "Cargos");
        }
    }
}
