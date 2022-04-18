using Microsoft.EntityFrameworkCore.Migrations;

namespace HostelManagementSystem.Migrations.HostelDb
{
    public partial class AddRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdmissionId",
                table: "RoomAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RoomAllocation_AdmissionId",
                table: "RoomAllocation",
                column: "AdmissionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomAllocation_Admission_AdmissionId",
                table: "RoomAllocation",
                column: "AdmissionId",
                principalTable: "Admission",
                principalColumn: "AdmissionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomAllocation_Admission_AdmissionId",
                table: "RoomAllocation");

            migrationBuilder.DropIndex(
                name: "IX_RoomAllocation_AdmissionId",
                table: "RoomAllocation");

            migrationBuilder.DropColumn(
                name: "AdmissionId",
                table: "RoomAllocation");
        }
    }
}
