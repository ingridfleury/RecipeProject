using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeProject.Infra.Data.Migrations
{
    public partial class RecipeIngredientsTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_MeasureUnit_MeasureUnitId",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_MeasureUnitId",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "MeasureUnitId",
                table: "RecipeIngredients");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RecipeIngredients");

            migrationBuilder.AddColumn<int>(
                name: "MeasureUnitId",
                table: "Ingredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "Ingredient",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_MeasureUnitId",
                table: "Ingredient",
                column: "MeasureUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_MeasureUnit_MeasureUnitId",
                table: "Ingredient",
                column: "MeasureUnitId",
                principalTable: "MeasureUnit",
                principalColumn: "MeasureUnitId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_MeasureUnit_MeasureUnitId",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_MeasureUnitId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "MeasureUnitId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Ingredient");

            migrationBuilder.AddColumn<int>(
                name: "MeasureUnitId",
                table: "RecipeIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "RecipeIngredients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_MeasureUnitId",
                table: "RecipeIngredients",
                column: "MeasureUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_MeasureUnit_MeasureUnitId",
                table: "RecipeIngredients",
                column: "MeasureUnitId",
                principalTable: "MeasureUnit",
                principalColumn: "MeasureUnitId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
