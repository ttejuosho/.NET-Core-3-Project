using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppSample.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(nullable: false),
                    SchoolAddress = table.Column<string>(nullable: false),
                    SchoolCity = table.Column<string>(nullable: false),
                    SchoolState = table.Column<string>(nullable: false),
                    PrincipalName = table.Column<string>(nullable: false),
                    SchoolPhone = table.Column<string>(nullable: false),
                    SchoolPhone2 = table.Column<string>(nullable: true),
                    SchoolEmail = table.Column<string>(nullable: false),
                    SchoolWeb = table.Column<string>(nullable: true),
                    IsReligious = table.Column<bool>(nullable: false),
                    IsBoarding = table.Column<bool>(nullable: false),
                    Established = table.Column<DateTime>(nullable: false),
                    GovtApproved = table.Column<bool>(nullable: false),
                    NumberOfStudents = table.Column<int>(nullable: false),
                    NumberOfTeachers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolId);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "Established", "GovtApproved", "IsBoarding", "IsReligious", "NumberOfStudents", "NumberOfTeachers", "PrincipalName", "SchoolAddress", "SchoolCity", "SchoolEmail", "SchoolName", "SchoolPhone", "SchoolPhone2", "SchoolState", "SchoolWeb" },
                values: new object[] { 1, new DateTime(1981, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, 340, 32, "Mr O.O Obajimi", "1, Obajimi Close, Ikosi", "Ketu", "owosamsonschool@outlook.com", "Owo-Samson Memorial School", "08090322312", null, "Lagos", null });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "Established", "GovtApproved", "IsBoarding", "IsReligious", "NumberOfStudents", "NumberOfTeachers", "PrincipalName", "SchoolAddress", "SchoolCity", "SchoolEmail", "SchoolName", "SchoolPhone", "SchoolPhone2", "SchoolState", "SchoolWeb" },
                values: new object[] { 2, new DateTime(1971, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, 210, 35, "Mrs Atinuke Lawal", "10, Lawanson Avenue,", "Surulere", "yewandeschool@aol.com", "Yewande Memorial School", "08023886558", null, "Lagos", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
