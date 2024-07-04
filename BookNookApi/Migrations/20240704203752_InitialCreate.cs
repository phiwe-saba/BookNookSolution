using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookNookApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "Name" },
                values: new object[,]
                {
                    { 1, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Harper Lee" },
                    { 2, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Sara Gruen" },
                    { 3, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Kathryn Stockett" },
                    { 4, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Lovely Bones" },
                    { 5, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Liza Mundy" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Genre" },
                values: new object[,]
                {
                    { 1, "Narrative" },
                    { 2, "Fiction" },
                    { 3, "Non-Fiction" },
                    { 4, "Romance" },
                    { 5, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Description", "ISBN", "ImageUrl", "Price", "Qty", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/2657._SX300_.jpg", 150m, 100, "To Kill A Mockingbird" },
                    { 2, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/43641._SX300_.jpg", 125m, 100, "Water for Elephants" },
                    { 3, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/4667024.jpg", 100m, 100, "The Help" },
                    { 4, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/12232938._SX300_.jpg", 150m, 100, "Lovely Bones" },
                    { 5, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/34184307._SX300_.jpg", 150m, 100, "Code Girls" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Phiwe" },
                    { 2, "Saba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
