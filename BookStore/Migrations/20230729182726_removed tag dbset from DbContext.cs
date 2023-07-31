using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class removedtagdbsetfromDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");


            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagID",
                table: "BookTags",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTags_Tags_TagId",
                table: "BookTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }
    }
}
