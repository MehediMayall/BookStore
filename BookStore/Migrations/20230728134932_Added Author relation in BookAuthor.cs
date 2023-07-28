using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddedAuthorrelationinBookAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorID",
                table: "BookAuthor",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Authors_AuthorID",
                table: "BookAuthor",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Authors_AuthorID",
                table: "BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthor_AuthorID",
                table: "BookAuthor");
        }
    }
}
