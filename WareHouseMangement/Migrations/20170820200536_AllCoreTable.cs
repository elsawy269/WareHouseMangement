using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouseMangement.Migrations
{
    public partial class AllCoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Unit",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Items",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Group",
                newName: "IsActive");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Unit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Unit",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Items",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Items",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Group",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "code",
                table: "Group");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Unit",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Items",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Group",
                newName: "IsDelete");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Unit",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "code",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
