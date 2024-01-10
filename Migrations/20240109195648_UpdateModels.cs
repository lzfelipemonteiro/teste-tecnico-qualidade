using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotes_Ensaios_EnsaioId",
                table: "Lotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Materiais_Lotes_LoteId",
                table: "Materiais");

            migrationBuilder.DropIndex(
                name: "IX_Materiais_LoteId",
                table: "Materiais");

            migrationBuilder.DropIndex(
                name: "IX_Lotes_EnsaioId",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "LoteId",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "EnsaioId",
                table: "Lotes");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Lotes",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Materiais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Materiais",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Lotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Identificador",
                table: "Lotes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Lotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Lotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Lotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ensaios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LoteId",
                table: "Ensaios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Ensaios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_MaterialId",
                table: "Lotes",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Ensaios_LoteId",
                table: "Ensaios",
                column: "LoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ensaios_Lotes_LoteId",
                table: "Ensaios",
                column: "LoteId",
                principalTable: "Lotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lotes_Materiais_MaterialId",
                table: "Lotes",
                column: "MaterialId",
                principalTable: "Materiais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ensaios_Lotes_LoteId",
                table: "Ensaios");

            migrationBuilder.DropForeignKey(
                name: "FK_Lotes_Materiais_MaterialId",
                table: "Lotes");

            migrationBuilder.DropIndex(
                name: "IX_Lotes_MaterialId",
                table: "Lotes");

            migrationBuilder.DropIndex(
                name: "IX_Ensaios_LoteId",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Materiais");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "Identificador",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "LoteId",
                table: "Ensaios");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Ensaios");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Lotes",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "LoteId",
                table: "Materiais",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnsaioId",
                table: "Lotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materiais_LoteId",
                table: "Materiais",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_EnsaioId",
                table: "Lotes",
                column: "EnsaioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotes_Ensaios_EnsaioId",
                table: "Lotes",
                column: "EnsaioId",
                principalTable: "Ensaios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiais_Lotes_LoteId",
                table: "Materiais",
                column: "LoteId",
                principalTable: "Lotes",
                principalColumn: "Id");
        }
    }
}
