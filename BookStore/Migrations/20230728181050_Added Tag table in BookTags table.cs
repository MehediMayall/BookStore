using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddedTagtableinBookTagstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTags",
                table: "BookTags");

            migrationBuilder.RenameColumn(
                name: "TagID",
                table: "BookTags",
                newName: "TagId");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "BookTags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");


            migrationBuilder.CreateIndex(
                name: "IX_BookTags_TagID",
                table: "BookTags",
                column: "TagID");


            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_TagID",
                table: "BookTags");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTags",
                table: "BookTags");

            migrationBuilder.DropIndex(
                name: "IX_BookTags_TagId",
                table: "BookTags");

            migrationBuilder.DropIndex(
                name: "IX_BookTags_TagID",
                table: "BookTags");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "BookTags");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "BookTags",
                newName: "TagID");

            migrationBuilder.AlterColumn<int>(
                name: "TagID",
                table: "BookTags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTags",
                table: "BookTags",
                columns: new[] { "BookID", "TagID" });
        }
    }
}
