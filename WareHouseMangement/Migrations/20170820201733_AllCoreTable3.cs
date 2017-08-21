using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouseMangement.Migrations
{
    public partial class AllCoreTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceMasters_DocumentTypes_DocumentTypeId1",
                table: "InvoiceMasters");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceMasters_DocumentTypeId1",
                table: "InvoiceMasters");

            migrationBuilder.DropColumn(
                name: "DocumentTypeId1",
                table: "InvoiceMasters");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentTypeId",
                table: "InvoiceMasters",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceMasters_DocumentTypeId",
                table: "InvoiceMasters",
                column: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceMasters_DocumentTypes_DocumentTypeId",
                table: "InvoiceMasters",
                column: "DocumentTypeId",
                principalTable: "DocumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceMasters_DocumentTypes_DocumentTypeId",
                table: "InvoiceMasters");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceMasters_DocumentTypeId",
                table: "InvoiceMasters");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTypeId",
                table: "InvoiceMasters",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "DocumentTypeId1",
                table: "InvoiceMasters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceMasters_DocumentTypeId1",
                table: "InvoiceMasters",
                column: "DocumentTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceMasters_DocumentTypes_DocumentTypeId1",
                table: "InvoiceMasters",
                column: "DocumentTypeId1",
                principalTable: "DocumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
