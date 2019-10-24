using Microsoft.EntityFrameworkCore.Migrations;

namespace TweetBook.Migrations
{
    public partial class refreshtoken_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JwtId",
                table: "RefreshToken",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JwtId",
                table: "RefreshToken",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
