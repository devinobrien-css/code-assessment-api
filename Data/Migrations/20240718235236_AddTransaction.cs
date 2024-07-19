using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserId",
                table: "Books");

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedInById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckedOutById = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookTransaction_AspNetUsers_CheckedInById",
                        column: x => x.CheckedInById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookTransaction_AspNetUsers_CheckedOutById",
                        column: x => x.CheckedOutById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookTransaction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTransaction_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "80125229-08bc-4e0c-8373-18a97ecad5cb", "Otis.Kuhic@hotmail.com", "Otis", "Kuhic", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "d84d9379-5d0f-4a91-88e2-d10e54bd6521", "Otis_Kuhic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "bf8d02ba-7040-45e5-85b7-baff24683348", "Kurt_Hegmann@hotmail.com", "Kurt", "Hegmann", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1075.jpg", "b5c7c468-7305-4115-a7f4-17b39703aa43", "Kurt_Hegmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "8d93b9a8-0367-4dff-9dd3-35aef2233536", "Anna.Stracke36@yahoo.com", "Anna", "Stracke", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/429.jpg", "f498631b-55bb-4ccd-a6e6-477d52f659bd", "Anna.Stracke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "e345b2c0-bbf9-4798-a7b1-a5dd6311f6dd", "Shannon.Wehner@hotmail.com", "Shannon", "Wehner", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/958.jpg", "85078e03-587d-4fc4-8d27-ee1004c54d3b", "Shannon.Wehner" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "First", "Last", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { "5", 0, "b9f2395a-c154-44fb-93bb-2d5c64275a98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Guy_Stark@hotmail.com", false, "Guy", "Stark", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1074.jpg", "9e20caba-492f-4929-8230-ddee58853a79", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guy15" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "D'angelo Berge", "Voluptatum totam fugit qui. Explicabo doloribus odit dolor quibusdam expedita deleniti assumenda sequi reiciendis. Sed quis dolores voluptatum praesentium eos eveniet dicta adipisci quo. Maxime earum voluptatem deleniti animi. Doloremque et et qui eum. Rerum iste sit quam qui adipisci temporibus nostrum odit.", 2, "aa3169ae-2a89-04b8-13e4-85489b1fda9f", 122, "Wuckert, Harris and Frami", "Eius delectus aliquam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jacques Davis", "Cum minima porro. Rerum rem maiores minima consequatur ipsam maxime provident neque recusandae. Consequatur nemo esse aperiam consectetur impedit culpa qui culpa totam.", 5, "20e8b4de-baa1-1efd-8cfe-7236082935ca", 107, "Sipes, Kuhlman and Wehner", "Mollitia repellendus iusto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hortense Bradtke", "Quia ea placeat qui nemo laborum sed esse. Culpa nesciunt qui eum et ut. Nostrum vel repellendus et in magni qui autem. Doloremque esse voluptas ex autem. Omnis iusto neque cupiditate ad aliquam.", 2, "404dca34-2ccf-432c-5a21-be34c3d144e6", 432, "Dickinson Group", "Et nisi nam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brown Fahey", "Repellendus atque expedita. Vero quos dolorum non. Libero vero quia accusantium. Nihil labore enim nobis dignissimos possimus. Et a et aut consequatur voluptas rerum ipsam vel.", 5, "08bb83bf-5353-e3c5-8991-a48ee69136d4", 181, "Nikolaus Group", "Harum accusamus veritatis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marcos Lang", "Aspernatur porro qui error quis qui. Ad reiciendis dicta at natus voluptatem aut consequatur. Fuga et tenetur. Quidem fugit quaerat sint delectus voluptas nam quaerat beatae voluptatem. Veniam odio et tempora odit enim id. Labore error distinctio possimus praesentium quis vel consequuntur culpa.", 3, "ee4324fd-4369-4e4e-662b-81cc9c1975da", 174, "Stiedemann, Schimmel and Harris", "Blanditiis quis nobis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Geo Welch", "Velit quia sit. Iusto magnam vel nemo autem aliquam. Harum facere minima sed. Dignissimos numquam dolores dolorem similique omnis alias enim accusamus. Sunt ut dolorem sed et deserunt quod mollitia et. Aut aut vel facere alias tempore qui explicabo eius quaerat.", 4, "a3965d7e-33c1-be88-79f3-b439a3790660", 458, "Weissnat, Klein and Beer", "Omnis ut sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lorna Russel", "Enim dolorum accusantium. Tempora molestiae optio odio earum quod reiciendis praesentium. Consequuntur omnis quia laudantium et et autem et. Quasi et dolores est nihil sed aperiam animi atque voluptate. Rerum et voluptatum et quaerat earum maxime illo non earum.", 4, "156c03d0-7ba0-84ab-f45d-473f06393266", 144, "Predovic - Larson", "Et aperiam temporibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Billie O'Conner", "Aut et enim qui inventore recusandae corporis pariatur illum. Aperiam deserunt debitis et fugiat iure. Omnis aut incidunt ut quibusdam natus dolorem. Dolorem occaecati et aut.", 2, "eea8b772-683a-ab89-ae6d-5b1544ff0ace", 488, "Mertz LLC", "Et sed quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mitchell Legros", "Ut culpa aliquid nostrum distinctio repellendus. Porro modi eaque. Quia ad possimus vel. Atque incidunt consequatur accusantium excepturi.", 4, "9bcbf188-1147-5383-8038-fcf8ab7b3144", 454, "Powlowski - Walker", "Ut eligendi facere.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Wava Stanton", "Nihil officiis porro placeat soluta non. Eveniet animi est quae velit. Magni minus qui dolorem consequatur pariatur et a libero optio. Expedita ut nihil maxime. Adipisci perferendis minima dolores iste sapiente modi nihil repudiandae.", 3, "c2d4b59f-4c57-96a1-8ba1-9fe0fe786edf", 437, "O'Connell, Pouros and Zemlak", "Sit repellendus autem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "Publisher", "Title" },
                values: new object[] { "Nicholas Grant", "Sint voluptatum ipsa deserunt deserunt non. Recusandae veritatis sapiente quia ut facilis enim. Voluptates sunt sunt fugit sint quasi similique. Quam nemo quis quae sunt accusantium. Quia sed iure eaque consequatur architecto qui dolorem iste.", "8c7c1641-55e9-ac34-f7b2-db41684d872e", "Emard Inc", "Quia saepe velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Laurie Windler", "Hic omnis eum. Assumenda esse nihil aliquid non. Quidem excepturi nostrum voluptatem assumenda harum nihil iste nam. Cupiditate neque non hic. Facilis ut aperiam consequatur velit sed doloribus sed excepturi.", 4, "affdabe5-44c6-8ffd-2b6b-429fac6d68ae", 125, "Legros and Sons", "Quaerat sed aperiam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Daphnee Flatley", "Minima neque perferendis consequatur voluptate qui et optio iusto et. Culpa exercitationem in et quis dolorum quibusdam in a. Voluptate reprehenderit cumque optio eum velit sed. In nihil ratione facere culpa.", 1, "2084163a-9039-9610-f40e-62081f7e13b6", 392, "Rodriguez Group", "Sunt voluptates non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Helga Reynolds", "Blanditiis ea adipisci nihil. Facere iure occaecati ut est. Dolore sunt et ea saepe minus quisquam.", 2, "fb2f5a68-f3d3-be01-30bb-39bf4b0a6269", 226, "Fisher LLC", "Aliquid natus voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jackson Borer", "Voluptatem doloribus omnis sapiente. Deleniti quis quibusdam. Commodi mollitia cumque. Architecto quas maiores minus voluptatibus.", 4, "007747c5-e448-eef4-3cb2-a628c0a42221", 482, "Lebsack - Jacobson", "Velit quis sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Wilfred Monahan", "Quaerat sit repudiandae repellendus ut eum quis qui. Doloremque beatae cupiditate aut ea vel. Minus consequatur fuga eius vero molestiae iure autem vero. Odit consequuntur ut nulla est consequatur laborum et natus exercitationem. Ut enim et. Magnam fuga et et aliquam.", 2, "4aef34f1-5bf3-8ea1-c066-752f93559d7f", 211, "Lockman Group", "Distinctio corporis eveniet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Gilda Hansen", "Dolores temporibus doloribus et quia enim. Corrupti qui optio ducimus ratione. Et dolore autem aut vel assumenda maxime sapiente qui eos. Ut beatae natus est est consequatur rerum dolore. Quam nam tenetur. Nulla rerum quibusdam.", 2, "69d4d516-77b7-01a3-921f-37d7a9ef20af", 179, "Kuhic - Torp", "Sed sed qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Wilhelmine Hickle", "Quia velit asperiores aut ut voluptas ipsa vitae. Ea voluptate consectetur ratione sit non corporis aut tempore veritatis. Cumque nesciunt at recusandae quaerat nesciunt enim animi pariatur. Dignissimos dolores nihil architecto dignissimos. Qui sint optio quae quam. Excepturi consectetur optio illo voluptate ut ut in harum.", 4, "f79c061d-9624-3afb-7986-fa6116d0093a", 364, "Schultz Inc", "Iusto et mollitia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lazaro Jacobs", "Aperiam qui laudantium quae perspiciatis totam sint ut. Officiis facilis nulla similique. Aut consequatur molestiae ut. Eligendi rem et corrupti odit hic esse doloremque tenetur provident.", "2eac8681-0871-a4eb-d855-d90efe3bb930", 420, "Nicolas LLC", "Ut sint consectetur.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Valentina Stoltenberg", "Voluptate vel recusandae voluptas maxime est numquam omnis in. Quo ipsum et consequuntur commodi et totam cupiditate. Suscipit et expedita fugit eius alias assumenda odit. Blanditiis explicabo laudantium fugit quis aut dolore. Nam voluptas et eveniet autem magnam praesentium. Fugit laboriosam eum itaque excepturi qui aut.", 3, "b2069f5c-0ef5-4ff9-8c18-c873455022a1", 465, "Nolan - Batz", "Rerum itaque excepturi." });

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_BookId",
                table: "BookTransaction",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_CheckedInById",
                table: "BookTransaction",
                column: "CheckedInById");

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_CheckedOutById",
                table: "BookTransaction",
                column: "CheckedOutById");

            migrationBuilder.CreateIndex(
                name: "IX_BookTransaction_UserId",
                table: "BookTransaction",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTransaction");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "29946b5b-d98a-4ea7-862d-ef25512b1bf1", "Raul_Gutkowski37@gmail.com", "Raul", "Gutkowski", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/358.jpg", "361f9857-07f1-4876-a7eb-12a90d6aa778", "Raul_Gutkowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "1448129e-a931-4739-9c59-bcc7c878b12e", "Darrel12@hotmail.com", "Darrel", "McCullough", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/782.jpg", "f5febbf6-7835-4aa1-912b-64300de293e0", "Darrel68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "b6347606-da66-4621-b764-0e296763f4c7", "Lola95@yahoo.com", "Lola", "Swaniawski", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/648.jpg", "7d2b76ae-c4c9-4179-9cf7-d1dc3ff4042b", "Lola69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "a273e442-1e26-4900-87f4-ea868a7c1c56", "Melissa54@yahoo.com", "Melissa", "Boyle", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/57.jpg", "911f52de-28af-4560-bb45-536c754a2189", "Melissa.Boyle13" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "First", "Last", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { "0", 0, "8411863e-e69f-4ff6-9be2-0f9d336d7ff4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bobbie33@gmail.com", false, "Bobbie", "Pagac", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/150.jpg", "54148b56-79eb-4dac-9813-3d994d2d47b1", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobbie.Pagac64" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Kaleb Heathcote", "Natus facere sint accusantium distinctio ut maxime. Quia nihil voluptatem eligendi consequatur libero rerum aut qui dicta. Animi hic ut. Est eaque ad temporibus et ut quibusdam. Voluptatem eos ut pariatur et vitae non laboriosam.", 4, "c895abca-33b8-ef4e-d95f-2a728743f369", 431, "Bradtke - Haley", "Sequi magnam qui.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Kurtis Wiegand", "Officia deserunt in incidunt omnis nobis tenetur corporis repellat enim. Aut dolorem sit exercitationem rerum animi ipsa ex. Adipisci a aperiam voluptatum. Et asperiores qui corporis aut et odio. Architecto eos facilis numquam dolores doloribus similique reiciendis repudiandae.", 2, "4a0e54e7-c050-9dfe-2cbe-f58428a81c8a", 367, "Funk - Thompson", "Illo id adipisci.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Virgil Kuphal", "Ea earum reprehenderit dolorem sed vel et unde. Magni cumque ut. Optio rerum voluptatibus sit vitae impedit. Voluptate voluptatem et dolor omnis iste cum.", 1, "a4df787b-ac9f-e3f1-52b9-31f8ced8b622", 222, "Ritchie LLC", "Deleniti distinctio vitae.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Elisa Boyer", "Laudantium vitae eaque quia nihil aliquam. Aperiam expedita autem voluptas. Quis ea sunt officiis qui esse fugiat vitae. Dolor sed a dignissimos minima minus consequuntur ullam qui. Eaque id dicta aliquam saepe asperiores et.", 3, "eeab784a-60e6-6b8d-7d2e-c011d4432078", 182, "Herzog Inc", "Odit et aut.", null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Gerardo Oberbrunner", "Laudantium consectetur et deleniti qui minus. Delectus et sunt aut molestiae et dicta fuga dicta illo. Omnis autem ab eius eos et dolorem consequatur non. Minus dolores sunt nam. Consequatur autem eius modi incidunt et ad modi eligendi consequatur.", 1, "295c1daf-ef43-c9cb-46a4-1b99f7b001a8", 152, "VonRueden LLC", "Velit facilis veniam.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Marina Mraz", "Esse mollitia corrupti repellat tempora incidunt dolore error facere. Distinctio enim nostrum repellendus exercitationem dolores et qui. Eius tempore iure minima perferendis voluptatem. Nemo expedita sint dolor. Qui necessitatibus ex aut quas voluptatem mollitia ipsam corporis in. Corrupti reprehenderit error temporibus impedit ad culpa iure sit.", 1, "d5121a5d-ca63-3fe5-0788-7e3877771e36", 184, "Mitchell and Sons", "Id fugiat omnis.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Ashley Hickle", "Quidem ut incidunt unde corrupti. Praesentium fugiat eligendi nobis laborum. Recusandae consequatur est necessitatibus atque et et beatae.", 3, "6fa4f3d1-5ee9-b73a-c4bc-192286799a15", 440, "Shanahan - Klein", "Excepturi blanditiis quas.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Yolanda Brakus", "Et iste consectetur maiores. Ut eum ea. Et voluptatem ut fuga cupiditate sunt voluptates.", 4, "fb254566-4e15-e631-9678-5581da2e3cdd", 115, "Kerluke - Marvin", "Quis sit tempora.", null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Llewellyn Okuneva", "Sed perferendis sint quaerat sit aliquid quasi corrupti. Sit blanditiis laboriosam exercitationem neque odio. Dolorem ex minus omnis aut praesentium voluptates ut. Id placeat repellendus quia natus. Ut saepe natus et aut harum. Et qui et autem.", 1, "f47d735b-abba-ba73-9b0b-e90ac5ddccf7", 371, "Armstrong, Kub and Pagac", "Consequatur ut quam.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Sam Russel", "A aut dolorem soluta magni ratione debitis. Suscipit ab animi omnis ut eum occaecati pariatur eaque error. Distinctio libero ducimus quibusdam sit cumque et perspiciatis autem. Debitis officia quia eos quia dolor. Nesciunt et aut ducimus incidunt libero sed iste.", 4, "64045f11-cebb-3617-8348-ed13091adb49", 268, "Emmerich, Weimann and Abernathy", "Laudantium ex saepe.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "Publisher", "Title", "UserId" },
                values: new object[] { "Casimer Stoltenberg", "Et laborum fugiat atque quisquam quia. Dolores sed accusamus. Consectetur aut in laborum delectus aperiam esse molestias. Porro quae id iure atque. Neque doloribus illo nemo voluptatem aliquid.", "44a5a683-8da6-3104-9ef7-236d20a239ca", "Koepp Group", "Suscipit voluptas soluta.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Verla Auer", "Voluptatem porro excepturi quod enim iusto. Illo sint reprehenderit pariatur et adipisci exercitationem sed iure et. At veniam porro.", 3, "6479e193-dba2-00a1-d41a-6ee7122558f7", 469, "Zieme and Sons", "Dignissimos culpa et.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Maida Schowalter", "Quae et dolor ea eos neque libero impedit. Perferendis repudiandae iste vero perspiciatis eos laudantium rem cumque. Id aut tempore dolorum aut itaque. Velit et voluptatibus quis id cumque maxime. Laborum velit quidem doloribus quaerat ea officiis. Non voluptas in veritatis ipsum.", 3, "15843dfb-f87c-b6b8-af17-86b0b68e809a", 275, "Carter, Lesch and Collins", "Voluptas modi molestiae.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Julius Welch", "Sequi saepe voluptates nobis molestiae enim ut fugit omnis quisquam. Deserunt atque optio qui. Dolore earum et.", 4, "6f796e23-e548-1413-faf8-ef9a2f3809c0", 323, "Wolf, Yost and Terry", "Exercitationem maiores qui.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Bart Leuschke", "Nisi occaecati et animi quaerat voluptatem velit id dolorum. Magni omnis perspiciatis. Porro quae amet voluptatem voluptatem quod. Debitis magnam sit quia voluptates sint veniam.", 1, "111b3293-9caf-e250-6ac3-e57d2a2a6395", 286, "Boehm, Robel and Hessel", "Ut nihil doloribus.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Heidi Mohr", "Sit eligendi aspernatur dignissimos. Laboriosam ut voluptatem ratione iste. Qui omnis voluptatem sint omnis debitis id. Molestias sint earum modi porro non dolorum ut voluptates.", 4, "a4a6ae7c-048d-cbe0-76fd-dc286f890762", 214, "Collier - Daugherty", "Expedita atque accusamus.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Thelma Spencer", "Nam eum rem beatae ut eveniet ut. Et et modi repellendus omnis eum. Libero illo consectetur corrupti alias eum fuga dolore. Sunt vitae qui nostrum veritatis rerum. Eum doloribus asperiores laudantium molestiae voluptatum non voluptates dolores. Totam nulla quis harum pariatur qui.", 3, "9da56283-cbee-5aa4-ecb1-79e40b174963", 428, "Conn LLC", "Temporibus corporis iusto.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Emerson Gutkowski", "Et veniam ut itaque. Ut magnam molestiae officia reiciendis est dicta. Voluptas fugiat a odio maxime porro omnis architecto.", 2, "2419bcbb-4858-d317-d52a-c8e701032115", 164, "Wilderman Group", "Aperiam illum ipsa.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Lessie Lemke", "Autem aut recusandae et inventore. Ea minus voluptatem fugit aliquid sequi sint officiis itaque. Aspernatur totam et ipsam iste.", "7e8d0a0c-dc8f-945e-a6f4-3d898c289ab4", 352, "Kreiger, Becker and Boyer", "Autem doloribus voluptates.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Lavonne Mosciski", "Quasi nam placeat commodi asperiores blanditiis fuga a dolorem dolorem. Vitae ut iusto quos et accusamus ullam pariatur nisi velit. Earum autem non minus in. At autem sunt. Ea quisquam qui dolorem quis veniam beatae nihil vitae quia. Animi voluptates exercitationem.", 4, "7ed6a16c-1486-22cc-2d75-e79a34b2ae76", 122, "Corkery, Gislason and Wiegand", "Soluta deserunt repellat.", null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Description", "GenreId", "ISBN", "Image", "IsBestSeller", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "UpdatedAt", "UserId", "Year" },
                values: new object[,]
                {
                    { 21, "Harvey Schultz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quis ducimus et. Assumenda omnis nobis reiciendis labore quasi iure aut. Voluptate molestiae atque earum beatae omnis quis dignissimos nam porro.", 2, "6a6f60de-f6c6-d689-7b6a-a624940726ea", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000", false, false, false, false, 349, "Schroeder, Fisher and Von", "Expedita qui sit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2023 },
                    { 22, "Jason Mraz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Qui fuga rerum accusamus cum id. Unde maiores error pariatur expedita. Ut omnis omnis sunt error. Odio et laborum ad.", 5, "26d27b0e-c70f-a2bd-3281-63295dd4d935", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000", false, false, false, false, 413, "Hermann, Marvin and Fadel", "Consequatur qui praesentium.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2024 },
                    { 24, "Coleman Shanahan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quos sint quia iure blanditiis ea ut a dolores molestias. Dicta voluptatem velit quis ipsum consectetur aut unde amet eaque. Et laudantium vel. Cum sit incidunt voluptates id id in. Temporibus aut quasi. Soluta earum maxime modi perspiciatis.", 3, "060b6da1-2f1b-799c-ecae-19e99c02c872", "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000", false, false, false, false, 378, "Crist - Torp", "Similique voluptatem excepturi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 2023 },
                    { 25, "Rachelle Lockman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Et qui molestiae voluptates recusandae accusamus ducimus quasi fugiat. Vel nam vel. Id nemo aut tenetur asperiores laudantium ipsa dolore.", 3, "f04dca1d-bf56-cbe9-e28d-f466b3f73231", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000", false, false, false, false, 145, "Stroman, Klocko and Pfeffer", "Odit aliquam in.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", 2024 },
                    { 26, "Ima Schaden", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Est iste voluptatem consequatur nesciunt esse nostrum rerum cupiditate et. Eaque vel ratione esse. Animi voluptas ea natus iste. Dicta tenetur impedit quisquam asperiores. Et ullam aperiam dolorem nihil maiores deserunt atque animi sequi.", 3, "2356a86c-63cc-b701-2a5d-81b218dfffa1", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000", false, false, false, false, 323, "Johns LLC", "Temporibus et unde.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2024 },
                    { 27, "Cleo Thiel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nihil incidunt voluptas ullam et et et id soluta. Qui laborum eveniet asperiores labore eos voluptas maxime repellendus. Ea veniam sed dolor ratione tempore. Qui possimus eos minus omnis deserunt officia.", 5, "f97f3752-5c2c-a32e-9cc1-db9ee26c55f4", "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000", false, false, false, false, 253, "Ullrich LLC", "Recusandae sapiente quaerat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 2023 },
                    { 28, "Geovanny Harber", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quisquam et et quam deleniti nihil aut eos dolor. Qui esse minus consequuntur accusamus deserunt occaecati facilis quia reiciendis. Tempore voluptate laborum culpa non qui. Eveniet qui quo. In sapiente qui.", 5, "cb2a3037-85f9-61f9-0dba-4b2717d1d623", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000", false, false, false, false, 400, "Schiller Group", "Sit nesciunt quae.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2024 },
                    { 29, "Mae Pfeffer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolorem omnis repellat omnis doloremque. Totam sequi omnis. Dignissimos impedit dolorem et harum. Ut repellendus earum culpa pariatur aspernatur non molestiae et. Ipsum odio rerum tenetur eum ducimus molestiae odio nisi rerum. Quia omnis vel ullam error ut ut.", 3, "78786250-ef42-ad79-584b-5a42a1edabec", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000", false, false, false, false, 281, "Dietrich - Dare", "Harum explicabo quo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", 2024 },
                    { 30, "Kurtis McDermott", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eligendi rerum qui dolorem. Rerum voluptas velit eligendi quidem porro. Et ipsa molestiae. Est nemo id laboriosam. Aliquam maxime nemo voluptas neque accusamus et aut.", 4, "6177c928-fe27-ed5a-5d7e-023d53163734", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000", false, false, false, false, 213, "Jacobi LLC", "Excepturi sunt laboriosam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 2023 },
                    { 23, "Elsa Jakubowski", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aliquid non dignissimos tenetur. Ut aut velit non quos laudantium et ipsum. Voluptas possimus est quos aut provident quis at esse. Ducimus ut voluptates. Et tenetur voluptatem magnam nihil saepe praesentium fugit fugit voluptate.", 4, "3c7cd7e4-362d-a226-444c-cd6e79882f3a", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000", false, false, false, false, 274, "Keebler - Larson", "Dolores aut quia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
