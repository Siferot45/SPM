using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SPM.Storage.Migrations
{
    /// <inheritdoc />
    public partial class NameCompanyChangedGuidToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NameCompany",
                table: "Companies",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldMaxLength: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "NameCompany",
                table: "Companies",
                type: "uuid",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);
        }
    }
}
