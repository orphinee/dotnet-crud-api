using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_crud_api.Migrations
{
    /// <inheritdoc />
    public partial class SetProdukIdAsIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kategorild",
                table: "Produk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kategorild",
                table: "Produk",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
