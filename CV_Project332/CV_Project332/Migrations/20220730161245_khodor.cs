using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CV_Project332.Migrations
{
    public partial class khodor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ipath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    s1 = table.Column<bool>(type: "bit", nullable: false),
                    s2 = table.Column<bool>(type: "bit", nullable: false),
                    s3 = table.Column<bool>(type: "bit", nullable: false),
                    s4 = table.Column<bool>(type: "bit", nullable: false),
                    grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "na",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwoC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    threeC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_na", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info");

            migrationBuilder.DropTable(
                name: "na");
        }
    }
}
