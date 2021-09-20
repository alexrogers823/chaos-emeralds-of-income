using Microsoft.EntityFrameworkCore.Migrations;

namespace ChaosEmeraldsOfIncome.Migrations
{
    public partial class RemovedUserForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
