using Microsoft.EntityFrameworkCore.Migrations;

namespace ahmad.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("INSERT INTO Makes (Name)VALUES ('Make1')" );
           migrationBuilder.Sql("INSERT INTO Makes (Name)VALUES ('Make2')" );
           migrationBuilder.Sql("INSERT INTO Makes (Name)VALUES ('Make3')" );

           migrationBuilder.Sql("INSERT INTO Model (Name, MakeId) VALUES ('make1-ModelA', (SELECT ID FROM Makes WHERE Name ='Make1'))");
           migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES ('make1-ModelB', (SELECT ID FROM Makes WHERE Name ='Make1'))");
           migrationBuilder.Sql("INSERT INTO  Model (Name,MakeId) VALUES ('make1-ModelC', (SELECT ID FROM Makes WHERE Name ='Make1'))");

           migrationBuilder.Sql("INSERT INTO Model (Name, MakeId) VALUES ('make1-ModelA', (SELECT ID FROM Makes WHERE Name ='Make2'))");
           migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES ('make1-ModelB', (SELECT ID FROM Makes WHERE Name ='Make2'))");
           migrationBuilder.Sql("INSERT INTO  Model (Name,MakeId) VALUES ('make1-ModelC', (SELECT ID FROM Makes WHERE Name ='Make2'))");
          
           migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES ('make2-ModelA', (SELECT ID FROM Makes WHERE Name ='Make3'))");
           migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES ('make2-ModelB', (SELECT ID FROM Makes WHERE Name ='Make3'))");
           migrationBuilder.Sql("INSERT INTO  Model (Name,MakeId) VALUES ('make2-ModelC',(SELECT ID FROM Makes WHERE Name ='Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("DELETE FROM MAKES");
           migrationBuilder.Sql("DELETE FROM MODEL");
        }
    }
}
