using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleEmpresa.Migrations
{
    public partial class cor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Setores",
                type: "varchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Setores");
        }
    }
}
