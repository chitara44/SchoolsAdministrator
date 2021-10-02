using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolsAdministrator.Infrastructure.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
               .Sql("INSERT INTO Schools(Name, Address) VALUES('School 1', '9768 E. Johnson Lane');");
            migrationBuilder
               .Sql("INSERT INTO Schools(Name, Address) VALUES('School 2', '2 Forest Court');");
            migrationBuilder
               .Sql("INSERT INTO Schools(Name, Address) VALUES('School 3', '688 East Ocean Ave.');");
            migrationBuilder
               .Sql("INSERT INTO Schools(Name, Address) VALUES('School 4', '593 North Overlook St.');");

            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 1', 20, (SELECT Id FROM Schools WHERE Name = 'School 1'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 2', 25, (SELECT Id FROM Schools WHERE Name = 'School 1'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 3', 30, (SELECT Id FROM Schools WHERE Name = 'School 1'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 1', 20, (SELECT Id FROM Schools WHERE Name = 'School 2'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 2', 25, (SELECT Id FROM Schools WHERE Name = 'School 2'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 3', 30, (SELECT Id FROM Schools WHERE Name = 'School 2'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 1', 20, (SELECT Id FROM Schools WHERE Name = 'School 3'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 2', 25, (SELECT Id FROM Schools WHERE Name = 'School 3'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 3', 30, (SELECT Id FROM Schools WHERE Name = 'School 3'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 1', 20, (SELECT Id FROM Schools WHERE Name = 'School 4'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 2', 25, (SELECT Id FROM Schools WHERE Name = 'School 4'));");
            migrationBuilder
             .Sql("INSERT INTO Classrooms(Name, Capacity, SchoolId) VALUES('Classroom 3', 30, (SELECT Id FROM Schools WHERE Name = 'School 4'));");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
