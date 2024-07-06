using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookNookApi.Migrations
{
    /// <inheritdoc />
    public partial class FixedAnImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "images/75434345.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "images/58490567.jpg");
        }
    }
}
