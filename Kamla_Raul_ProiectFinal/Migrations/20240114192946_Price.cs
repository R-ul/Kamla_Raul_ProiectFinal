using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kamla_Raul_ProiectFinal.Migrations
{
    public partial class Price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Provider_ProviderId",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Game",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Provider_ProviderId",
                table: "Game",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Provider_ProviderId",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Provider_ProviderId",
                table: "Game",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
