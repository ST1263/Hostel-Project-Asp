using Microsoft.EntityFrameworkCore.Migrations;

namespace HostelManagementSystem.Migrations.HostelDb
{
    public partial class updateadmissionroomallocate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomAllocationNo",
                table: "Admission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomAllocationNo",
                table: "Admission",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
