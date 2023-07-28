using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddedPriceOffertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffer_Books_BookId",
                table: "PriceOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer");

            migrationBuilder.RenameTable(
                name: "PriceOffer",
                newName: "PriceOffers");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffer_BookId",
                table: "PriceOffers",
                newName: "IX_PriceOffers_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionalText",
                table: "PriceOffers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PriceOffers",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PriceOffers",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffers_Books_BookId",
                table: "PriceOffers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffers_Books_BookId",
                table: "PriceOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers");

            migrationBuilder.RenameTable(
                name: "PriceOffers",
                newName: "PriceOffer");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffer",
                newName: "IX_PriceOffer_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionalText",
                table: "PriceOffer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "PriceOffer",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PriceOffer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffer_Books_BookId",
                table: "PriceOffer",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
