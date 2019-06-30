using Microsoft.EntityFrameworkCore.Migrations;

namespace Mini.Migrations.Migrations
{
    public partial class update_basedata_isdefault_to_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsDefault",
                table: "Mini_BaseData",
                nullable: true,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "IsDefault",
                table: "Mini_BaseData",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
