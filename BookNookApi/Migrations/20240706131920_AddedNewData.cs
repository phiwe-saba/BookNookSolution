using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookNookApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "Name" },
                values: new object[,]
                {
                    { 6, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Mary Ann Shaffer and Anne Barrows" },
                    { 7, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Andrea Van Landingham" },
                    { 8, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Anderson Cooper" },
                    { 9, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Laurence Leamer" },
                    { 10, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Anne Michaud" },
                    { 11, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Tricia Levenseller" },
                    { 12, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Lynn Painter" },
                    { 13, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Ali Hazelwood" },
                    { 14, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Linda Cheng" },
                    { 15, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Gator Country" },
                    { 16, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Caroline Hardaker" },
                    { 17, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Lee Winter" },
                    { 18, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Olivia Janae" },
                    { 19, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Stephanie Shea" },
                    { 20, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Kate Quinn" },
                    { 21, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Kent Follett" },
                    { 22, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Jennifer Lyle" },
                    { 23, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Tracy K. Smith" },
                    { 24, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Sophie Cousens" },
                    { 25, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Christina Henry" },
                    { 26, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Darcy Coates" },
                    { 27, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Mark Harmon" },
                    { 28, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Kelly And Zach Weinersmith" },
                    { 29, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "John Wigger" },
                    { 30, "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo", "Mary Haverstick" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 11, 11 },
                    { 12, 12, 12 },
                    { 13, 13, 13 },
                    { 14, 14, 14 },
                    { 15, 15, 15 },
                    { 16, 16, 16 },
                    { 17, 17, 17 },
                    { 18, 18, 18 },
                    { 19, 19, 19 },
                    { 20, 20, 20 },
                    { 21, 17, 21 },
                    { 22, 22, 22 },
                    { 23, 23, 23 },
                    { 24, 24, 24 },
                    { 25, 25, 25 },
                    { 26, 26, 26 },
                    { 27, 27, 27 },
                    { 28, 28, 28 },
                    { 29, 29, 29 },
                    { 30, 30, 30 }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Genre" },
                values: new object[] { 6, "Horror" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Description", "ISBN", "ImageUrl", "Price", "Qty", "Title" },
                values: new object[,]
                {
                    { 6, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/39832183.jpg", 250m, 120, "The Guernsey" },
                    { 7, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/56359706._SX300_.jpg", 250m, 120, "Hollywood Horrors" },
                    { 8, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/56382342.jpg", 250m, 120, "Vanderbilt" },
                    { 9, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/57005206._SX300_.jpg", 250m, 120, "Capote's Women" },
                    { 10, 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/58524608._SX300_.jpg", 250m, 120, "Why They Stay" },
                    { 11, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/59656615.jpg", 250m, 120, "Vengeance Of The Pirate Queen" },
                    { 12, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/60197314.jpg", 250m, 120, "Betting On You" },
                    { 13, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/60683957.jpg", 250m, 120, "Check & Mate" },
                    { 14, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/63005207._SY475_.jpg", 250m, 120, "Gorgeous Gruesome Faces" },
                    { 15, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/65211796.jpg", 250m, 120, "Gator Country" },
                    { 16, 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/80328993.jpg", 250m, 120, "Mothtown" },
                    { 17, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/35335134.jpg", 250m, 120, "The Brutal Truth" },
                    { 18, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/36649339.jpg", 250m, 120, "Shades Of Blue" },
                    { 19, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/58443037.jpg", 250m, 120, "Chef's Kiss" },
                    { 20, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/58490567.jpg", 250m, 120, "The Diamond Eye" },
                    { 21, 4, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/58490567.jpg", 250m, 120, "The Fixer" },
                    { 22, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/81067992.jpg", 250m, 120, "The Armor Of Light" },
                    { 23, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/86033921.jpg", 250m, 120, "Swarm" },
                    { 24, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/112974900.jpg", 250m, 120, "To Free The Captives" },
                    { 25, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/112976344.jpg", 250m, 120, "The Good Part" },
                    { 26, 5, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/122658643.jpg", 250m, 120, "Good Girls Don't Die" },
                    { 27, 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/123262468._SY475_.jpg", 250m, 120, "Where He Can't Find You" },
                    { 28, 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/123266603._SY475_.jpg", 250m, 120, "Ghosts Of Honolulu" },
                    { 29, 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/125084292.jpg", 250m, 120, "A City On Mars" },
                    { 30, 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/125423142.jpg", 250m, 120, "The Hijacking Of American Flight 119" },
                    { 31, 6, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!", "978-3-16-148410-0", "images/128126768.jpg", 250m, 120, "A Woman I Know" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 5);
        }
    }
}
