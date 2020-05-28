using Microsoft.EntityFrameworkCore.Migrations;

namespace ahmad.Migrations
{
    public partial class addingseedfeaturestothemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          //this help us to insert default values into the table
          migrationBuilder.Sql("INSERT  INTO Features (Name)  VALUES ('Feature1')");
          migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Features2')");
          migrationBuilder.Sql("INSERT INTO  Features (Name)  VALUES ('Features3')");
          migrationBuilder.Sql("INSERT INTO Features (Name)  VALUES ('Features4')" );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
