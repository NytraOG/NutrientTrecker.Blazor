using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend.Migrations
{
    public partial class nochEinScheißTabellennameKekw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Dishe_DishId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntrie_Day_DayId",
                table: "LogEntrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogEntrie",
                table: "LogEntrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishe",
                table: "Dishe");

            migrationBuilder.RenameTable(
                name: "LogEntrie",
                newName: "LogEntry");

            migrationBuilder.RenameTable(
                name: "Dishe",
                newName: "Dish");

            migrationBuilder.RenameIndex(
                name: "IX_LogEntrie_DayId",
                table: "LogEntry",
                newName: "IX_LogEntry_DayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogEntry",
                table: "LogEntry",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Dish_DishId",
                table: "Ingredient",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntry_Day_DayId",
                table: "LogEntry",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Dish_DishId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntry_Day_DayId",
                table: "LogEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogEntry",
                table: "LogEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "LogEntry",
                newName: "LogEntrie");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "Dishe");

            migrationBuilder.RenameIndex(
                name: "IX_LogEntry_DayId",
                table: "LogEntrie",
                newName: "IX_LogEntrie_DayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogEntrie",
                table: "LogEntrie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishe",
                table: "Dishe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Dishe_DishId",
                table: "Ingredient",
                column: "DishId",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntrie_Day_DayId",
                table: "LogEntrie",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
