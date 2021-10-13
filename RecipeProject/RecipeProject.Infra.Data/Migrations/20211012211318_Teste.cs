using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeProject.Infra.Data.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Category_CategoryId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId1",
                table: "Recipes",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Category_CategoryId1",
                table: "Recipes",
                column: "CategoryId1",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Category_CategoryId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Category_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
