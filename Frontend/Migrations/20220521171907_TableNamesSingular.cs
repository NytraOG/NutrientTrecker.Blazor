using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend.Migrations
{
    public partial class TableNamesSingular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumed_Days_DayId",
                table: "Consumed");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_Users_UserId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_FoodStuff_FoodStuffId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntries_Days_DayId",
                table: "LogEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogEntries",
                table: "LogEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Days",
                table: "Days");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "LogEntries",
                newName: "LogEntrie");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "Ingredient");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "Dishe");

            migrationBuilder.RenameTable(
                name: "Days",
                newName: "Day");

            migrationBuilder.RenameIndex(
                name: "IX_LogEntries_DayId",
                table: "LogEntrie",
                newName: "IX_LogEntrie_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_FoodStuffId",
                table: "Ingredient",
                newName: "IX_Ingredient_FoodStuffId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_DishId",
                table: "Ingredient",
                newName: "IX_Ingredient_DishId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_UserId",
                table: "Day",
                newName: "IX_Day_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogEntrie",
                table: "LogEntrie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishe",
                table: "Dishe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Day",
                table: "Day",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumed_Day_DayId",
                table: "Consumed",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Day_User_UserId",
                table: "Day",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Dishe_DishId",
                table: "Ingredient",
                column: "DishId",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_FoodStuff_FoodStuffId",
                table: "Ingredient",
                column: "FoodStuffId",
                principalTable: "FoodStuff",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumed_Day_DayId",
                table: "Consumed");

            migrationBuilder.DropForeignKey(
                name: "FK_Day_User_UserId",
                table: "Day");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Dishe_DishId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_FoodStuff_FoodStuffId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntrie_Day_DayId",
                table: "LogEntrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogEntrie",
                table: "LogEntrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishe",
                table: "Dishe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Day",
                table: "Day");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "LogEntrie",
                newName: "LogEntries");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredients");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "Dishe",
                newName: "Dishes");

            migrationBuilder.RenameTable(
                name: "Day",
                newName: "Days");

            migrationBuilder.RenameIndex(
                name: "IX_LogEntrie_DayId",
                table: "LogEntries",
                newName: "IX_LogEntries_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredient_FoodStuffId",
                table: "Ingredients",
                newName: "IX_Ingredients_FoodStuffId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredient_DishId",
                table: "Ingredients",
                newName: "IX_Ingredients_DishId");

            migrationBuilder.RenameIndex(
                name: "IX_Day_UserId",
                table: "Days",
                newName: "IX_Days_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogEntries",
                table: "LogEntries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Days",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumed_Days_DayId",
                table: "Consumed",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Users_UserId",
                table: "Days",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Dishes_DishId",
                table: "Ingredients",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_FoodStuff_FoodStuffId",
                table: "Ingredients",
                column: "FoodStuffId",
                principalTable: "FoodStuff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntries_Days_DayId",
                table: "LogEntries",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
