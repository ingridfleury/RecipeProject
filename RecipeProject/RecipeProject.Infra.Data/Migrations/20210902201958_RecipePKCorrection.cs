using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeProject.Infra.Data.Migrations
{
    public partial class RecipePKCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recipes",
                newName: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Recipes",
                newName: "Id");
        }
    }
}
