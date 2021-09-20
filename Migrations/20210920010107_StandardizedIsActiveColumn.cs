using Microsoft.EntityFrameworkCore.Migrations;

namespace ChaosEmeraldsOfIncome.Migrations
{
    public partial class StandardizedIsActiveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCurrent",
                table: "EarnedIncome",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsCurrent",
                table: "BusinessIncome",
                newName: "IsActive");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RoyaltyIncome",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RentalIncome",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InterestIncome",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "IncomeTitle",
                table: "EarnedIncome",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "DividendIncome",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_InterestIncome_UserId",
                table: "InterestIncome",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EarnedIncome_UserId",
                table: "EarnedIncome",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EarnedIncome_Users_UserId",
                table: "EarnedIncome",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InterestIncome_Users_UserId",
                table: "InterestIncome",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EarnedIncome_Users_UserId",
                table: "EarnedIncome");

            migrationBuilder.DropForeignKey(
                name: "FK_InterestIncome_Users_UserId",
                table: "InterestIncome");

            migrationBuilder.DropIndex(
                name: "IX_InterestIncome_UserId",
                table: "InterestIncome");

            migrationBuilder.DropIndex(
                name: "IX_EarnedIncome_UserId",
                table: "EarnedIncome");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RoyaltyIncome");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RentalIncome");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "DividendIncome");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "EarnedIncome",
                newName: "IsCurrent");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "BusinessIncome",
                newName: "IsCurrent");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "InterestIncome",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "IncomeTitle",
                table: "EarnedIncome",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);
        }
    }
}
