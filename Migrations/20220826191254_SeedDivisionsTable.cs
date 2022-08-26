using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace srdl_repo.Migrations
{
    public partial class SeedDivisionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Name", "CreatedAt" },
                values: new object[,]
                {
                    {"Barishal", DateTime.Now},
                    {"Chittagong", DateTime.Now},
                    {"Dhaka", DateTime.Now},
                    {"Khulna", DateTime.Now},
                    {"Rajshahi", DateTime.Now},
                    {"Rangpur", DateTime.Now},
                    {"Sylhet", DateTime.Now},
                    {"Mymensingh", DateTime.Now},
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Divisions", true);
        }
    }
}
