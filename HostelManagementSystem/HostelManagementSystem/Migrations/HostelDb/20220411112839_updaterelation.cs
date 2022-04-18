using Microsoft.EntityFrameworkCore.Migrations;

namespace HostelManagementSystem.Migrations.HostelDb
{
    public partial class updaterelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomAllocationNo",
                table: "Admission",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomAllocationNo",
                table: "Admission");
        }
    }
}
