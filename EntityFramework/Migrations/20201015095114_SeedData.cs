using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Grades(GradeName, Section) values('A', 'Final')");
            migrationBuilder.Sql("Insert into Students(StudentName, GradeID) values('B', '1')");
            migrationBuilder.Sql("Insert into Students(StudentName, GradeID) values('Test1', '1')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
