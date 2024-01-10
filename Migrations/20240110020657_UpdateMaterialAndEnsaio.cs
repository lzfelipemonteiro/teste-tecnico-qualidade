using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMaterialAndEnsaio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParametrosQualidade",
                table: "Materiais");

            migrationBuilder.AddColumn<double>(
                name: "Alongamento",
                table: "Materiais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LimiteEscoamento",
                table: "Materiais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LimiteResistencia",
                table: "Materiais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MassaLinear",
                table: "Materiais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Relacao",
                table: "Materiais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Resultado",
                table: "Ensaios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "Alongamento",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Dobramento",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LimiteEscoamento",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LimiteResistencia",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MassaLinear",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Relacao",
                table: "Ensaios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alongamento",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "LimiteEscoamento",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "LimiteResistencia",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "MassaLinear",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "Relacao",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "Alongamento",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "Dobramento",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "LimiteEscoamento",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "LimiteResistencia",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "MassaLinear",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "Relacao",
                table: "Ensaios");

            migrationBuilder.AddColumn<string>(
                name: "ParametrosQualidade",
                table: "Materiais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Resultado",
                table: "Ensaios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
