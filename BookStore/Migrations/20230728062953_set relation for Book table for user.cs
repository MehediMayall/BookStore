using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class setrelationforBooktableforuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_CreatedByID",
                table: "Books",
                column: "CreatedByID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_CreatedByID",
                table: "Books",
                column: "CreatedByID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_CreatedByID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CreatedByID",
                table: "Books");
        }
    }
}
