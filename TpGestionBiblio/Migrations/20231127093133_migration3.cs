﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpGestionBiblio.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_AbonneId",
                table: "Emprunts",
                column: "AbonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_LivreId",
                table: "Emprunts",
                column: "LivreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprunts_Abonnes_AbonneId",
                table: "Emprunts",
                column: "AbonneId",
                principalTable: "Abonnes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprunts_Livres_LivreId",
                table: "Emprunts",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprunts_Abonnes_AbonneId",
                table: "Emprunts");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprunts_Livres_LivreId",
                table: "Emprunts");

            migrationBuilder.DropIndex(
                name: "IX_Emprunts_AbonneId",
                table: "Emprunts");

            migrationBuilder.DropIndex(
                name: "IX_Emprunts_LivreId",
                table: "Emprunts");
        }
    }
}
