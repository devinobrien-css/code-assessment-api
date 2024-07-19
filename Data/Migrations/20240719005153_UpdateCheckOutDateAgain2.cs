using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCheckOutDateAgain2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "accfef27-2957-4ba7-9d5a-6e295e4e21f5", "Allison.Reinger@hotmail.com", "Allison", "Reinger", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/856.jpg", "c44d8f90-f124-455a-bca5-629c746fd675", "Allison99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "9be9435b-c869-4395-952a-84c6e6d00292", "Sonja40@hotmail.com", "Sonja", "Johnson", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1124.jpg", "11debac0-b180-46d0-86ea-d3ff861fe6d2", "Sonja.Johnson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "002ef9d4-a346-4bb9-8d1f-e814ef6c1a29", "Austin10@gmail.com", "Austin", "Stiedemann", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/95.jpg", "6f56387f-2e8a-47a5-9a79-1c7217cd948f", "Austin_Stiedemann2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "12402f73-a77a-4e5b-a839-ddc081cfcf66", "Thomas38@yahoo.com", "Thomas", "Fadel", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/259.jpg", "38c8bae0-7d52-4c56-a2ee-6aadd1b4f3ce", "Thomas.Fadel91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "cbb25514-88d3-4bf1-8c5c-2e7584e3a21a", "Wilbert81@yahoo.com", "Wilbert", "Kovacek", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/42.jpg", "2ade2ecb-16bc-4740-bc19-8df6f007950a", "Wilbert20" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 19, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(670), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 2, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1240), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 11, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1250), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 6, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1260), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 3, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1270), "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Liliana Lockman", "Rerum sed dolorem explicabo sapiente excepturi qui et qui. Dolores ducimus sed iste iste. Recusandae aperiam porro laudantium dolor. Molestiae voluptas enim magnam facere.", 5, "5f1f504d-8256-ed15-82df-11034653e4c6", 297, "Heidenreich and Sons", "Doloremque magni laudantium." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Gene Doyle", "Quo sint quam. Praesentium reiciendis et omnis quaerat id autem quia hic. Tempora mollitia modi velit ut enim perspiciatis rerum dicta magni. Nulla qui eligendi officia corporis. Omnis minus velit. Sit et sed quisquam modi doloremque non.", "5d09887f-3d8e-b808-b8c3-be15edde6311", 222, "Kuvalis LLC", "Maiores enim excepturi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Amely Cormier", "Est blanditiis rerum temporibus ipsam. Voluptatem eum recusandae. Libero laborum cumque minus sunt non suscipit recusandae. Praesentium nemo voluptatem cum odit.", 2, "936a3dfd-8f23-e4ad-275c-66358a458dcc", 318, "Lockman, Bernier and Sipes", "Quo sed adipisci." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Delpha Swift", "Est illo adipisci beatae et neque omnis. In placeat vero eligendi neque qui est. Et dolorem in.", 4, "7fda4aa0-3bed-7d82-e18a-def4e6192c5e", 431, "Schinner, Jakubowski and Ondricka", "Voluptatem aut qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annamarie Leannon", "Temporibus non unde rerum magni itaque facilis quo. Corporis possimus animi non dolores eaque quod est corporis. Voluptatem laboriosam deserunt sit aliquid ipsa. Omnis odio laborum quaerat aliquid deleniti voluptate architecto. Est dolores cumque ea. Dolorum eveniet illum quo qui.", "8ec87c51-6917-ddb7-21d2-85a75eb6099a", 360, "DuBuque - Hansen", "Voluptas qui sapiente.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cesar Stoltenberg", "Et velit minima tempora eos ex et. Temporibus harum dolore itaque sed eos sunt et. Corporis ut occaecati quia. Ad voluptatem laboriosam ut.", 3, "4ff4a79a-db54-2caf-66a1-781abef4da81", 256, "Waters and Sons", "Dolorem corporis esse.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Merle VonRueden", "Et dolorem dolor sunt. Inventore asperiores pariatur ut in dolore iste. Et id dolorem voluptates. Sequi cumque repellendus doloremque ad.", "8647a22a-b750-9e19-ae9e-9df44dde9b9a", 278, "Harris and Sons", "Neque ipsa molestias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Robyn Bruen", "Ut neque occaecati qui ad. Possimus tempore aut earum facilis quo autem veritatis ab. Enim doloribus aut dolores accusamus eligendi aut a omnis omnis. Fugit cumque et est.", 3, "122f66d1-f199-b94b-a050-d77a8492ddf9", 156, "Cole Inc", "Repellendus ut enim." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rafael Schuster", "Quia voluptates et blanditiis tempora suscipit tempore. Aut qui unde tenetur ab tempora facere qui magnam architecto. Optio nemo nostrum voluptatem. Quod est dignissimos.", 1, "d1b328ee-ab00-bc27-1dee-e56997ac83ea", 330, "Abernathy Group", "Enim aut voluptas.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jayce Kirlin", "Cumque quod quod praesentium at reiciendis fugiat. Sequi ut rem commodi nemo sequi et. In possimus sequi.", "4dcda713-3af8-2743-c200-5f5405121e31", 170, "Lesch, Graham and Fay", "Et ab quibusdam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Zander Gutkowski", "Id iusto quam dolores. Enim sint fugit. Eum doloremque aspernatur. Corporis quasi commodi corporis et sed tempore nemo consectetur totam. Reprehenderit veniam distinctio expedita.", 2, "036ded5d-453c-ee3e-c6b8-ebc64cc42e73", 472, "Reichert, Borer and Casper", "In qui voluptas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Corbin Quigley", "Quos nisi aut. Praesentium est itaque et fuga voluptatem deleniti. Eos nemo recusandae non voluptatem blanditiis.", 3, "07f14f29-59e6-a2bb-46b8-da753d4dd01b", 462, "Gerlach - Boehm", "Saepe at perferendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Sabina Kreiger", "Quas et quis consequatur dignissimos. Dicta qui animi cumque quis sunt explicabo quo in. Ratione vel voluptatem ut laboriosam. Est corporis nesciunt aspernatur. Explicabo pariatur cum. Sit ipsa eos non.", 5, "e8c9df6a-1ec2-de96-91fb-69ce7bf1ea4c", 181, "Balistreri, West and Lueilwitz", "Magnam excepturi quam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Freddy Boehm", "Unde omnis dolores libero est. Veniam ea cumque rem quo omnis et dolorem laboriosam aut. Veritatis voluptatem eos dolores. Quaerat iure perferendis qui qui voluptatem impedit harum aut. Nisi deserunt quam nemo doloribus molestiae quia id doloribus consequatur.", 4, "c30d1f25-6cd3-438c-a9eb-c05d69f21dfd", 250, "Ebert, McDermott and Koelpin", "Amet praesentium consequuntur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Genevieve Smith", "Sapiente nostrum laborum dolorem error beatae qui. Nesciunt excepturi reiciendis sequi iusto veniam ipsa. Voluptatum omnis cum perferendis aut vel ut sit porro. Dolor non quas et veritatis harum magni ea consequatur non.", 5, "9dad30a6-38d5-1704-7be2-75decaf820ab", 453, "Beatty LLC", "Dolorem odit molestiae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Vivian Fay", "Earum eos possimus delectus quia provident nihil tempore quia. Consequatur recusandae et explicabo illum accusamus vel. Nihil blanditiis quia enim aperiam et quas deleniti saepe qui. Perferendis reiciendis dicta.", 3, "5f6e2d39-18a9-18e0-bb32-d13cbba19d6b", 255, "Cassin - Abshire", "Corrupti optio sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Everette Kassulke", "Impedit et aut et ut est id corrupti ut ad. Ut veniam quibusdam non illo atque quam. Ut et a qui. Est non quia.", "5e0870d4-71a0-b054-2140-8ef833a2d0f3", 478, "Hane, Thiel and Kassulke", "Quibusdam et ut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Shanie Koelpin", "Labore quibusdam id non quam id illum aut modi non. Quam est architecto est. Iusto ex sit molestias. Tempora sint fuga labore esse autem.", 4, "b05ad9de-f202-183b-e989-35b7f4de2a39", 327, "Welch Inc", "Itaque exercitationem sit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jalyn Morissette", "Sequi veritatis reiciendis ut ipsa eos delectus sequi. Voluptas quos omnis dolor accusamus quod. Dolorem est adipisci autem omnis provident dignissimos. Nihil qui laudantium et ut.", 3, "5ed2ab6e-9123-a8db-13f0-1633a5c18280", 448, "Kessler, Hayes and Olson", "Ipsa eos placeat.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chloe Berge", "Cum animi dignissimos vero quidem officia qui cumque. Quae officiis vitae magni voluptatibus non ut voluptas. Optio laboriosam eligendi a aut minus est minus voluptates. Sed unde provident qui soluta ipsum suscipit. Cum dolore aut.", "aca6a320-2139-5e5a-2bfc-655df17133e3", 263, "Collier, Brekke and Conn", "Perspiciatis voluptas quibusdam.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "aafea138-4178-4006-9ee1-b588c249ad4e", "Elsa4@gmail.com", "Elsa", "Aufderhar", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/485.jpg", "5e798293-a509-4834-bb7b-eed942c4a866", "Elsa_Aufderhar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "6801daaf-9d89-4a6c-9fdf-8943077b8089", "Alfonso_Parker@hotmail.com", "Alfonso", "Parker", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/883.jpg", "23221965-8e23-46e7-9eb7-ae8129dbefdb", "Alfonso_Parker" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "a4f85ee6-6dfa-4e64-bd9d-a6b4c66c77e5", "Andrew24@gmail.com", "Andrew", "Jerde", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/864.jpg", "29a6c751-0321-4232-8b9f-11f139da96ed", "Andrew_Jerde4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "734d10fc-62ba-4794-8981-c4cf59254d41", "Nettie.Hilll32@yahoo.com", "Nettie", "Hilll", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/146.jpg", "777c0001-c382-4b52-b87a-b1dd1f4c243f", "Nettie_Hilll85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "9802faf3-00f4-419b-83c0-1934225ce2e9", "Myrtle.Roob@yahoo.com", "Myrtle", "Roob", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/38.jpg", "c8ce245a-3baf-48f3-9129-da03f46103bb", "Myrtle24" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 12, new DateTime(2024, 7, 13, 6, 43, 25, 61, DateTimeKind.Local).AddTicks(321), new DateTime(2025, 1, 26, 17, 1, 39, 874, DateTimeKind.Local).AddTicks(5693), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 18, new DateTime(2024, 7, 13, 15, 28, 59, 862, DateTimeKind.Local).AddTicks(4951), new DateTime(2025, 1, 24, 21, 0, 26, 826, DateTimeKind.Local).AddTicks(6592), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 12, new DateTime(2024, 7, 13, 13, 30, 3, 935, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 12, 16, 12, 33, 39, 121, DateTimeKind.Local).AddTicks(4085), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 3, new DateTime(2024, 7, 13, 0, 48, 0, 625, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 7, 20, 1, 44, 26, 763, DateTimeKind.Local).AddTicks(6923), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 20, new DateTime(2024, 7, 13, 19, 10, 44, 812, DateTimeKind.Local).AddTicks(2113), new DateTime(2025, 6, 9, 16, 2, 25, 895, DateTimeKind.Local).AddTicks(8345), "4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Thora Schaefer", "Aliquid dolorem laboriosam consequatur cumque. Perferendis earum neque tempora asperiores. Libero aut consequuntur non assumenda eligendi ut veritatis deserunt est. Quasi fugit saepe atque quaerat omnis consequuntur hic maiores. Exercitationem harum sed doloremque doloremque impedit qui omnis libero mollitia. Omnis id sit quis.", 2, "15443eea-fce8-f8a5-cea8-d0c52896e1b4", 243, "Rodriguez - Hauck", "Soluta molestiae tempore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Laisha Mann", "Est voluptas et non voluptates error blanditiis. Omnis assumenda fuga minima officiis quia. Ea aut saepe repudiandae iusto doloribus tenetur. Aut rerum ut veritatis voluptas. Consequuntur cupiditate temporibus accusamus.", "7d9a6d1a-d519-8b77-1019-348712d56aae", 253, "Shields LLC", "Distinctio ea et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Keara Medhurst", "Consequatur saepe ut et est repudiandae sit nihil. Blanditiis impedit officiis debitis veniam placeat. Exercitationem et et. Atque id sit laborum sequi iste qui voluptatem facilis.", 3, "f2d8680d-3648-82a4-8bee-85968b2a3aba", 434, "Orn - Kris", "Earum voluptatem est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Tyson Kreiger", "Nihil ipsam doloribus accusantium. Soluta tempora quasi ipsum totam. Illum omnis repellat et eligendi. Alias temporibus et magnam. Et ab dolor. Quos eaque doloremque quisquam impedit.", 1, "d725ec65-30bd-21c5-374f-d97c521e1a4e", 384, "Barrows Inc", "Enim aut dolore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Valentin Legros", "Esse voluptatibus facere dolores cupiditate corporis perferendis optio fugiat. Totam ducimus et voluptatibus eligendi ut dolor. Corporis molestiae similique enim quod rerum. Nemo inventore architecto saepe magnam aut. Ipsum et fugiat sit libero ducimus cupiditate labore.", "006dad92-0016-5f52-bd42-2110e5af7633", 474, "Funk - Cronin", "Consequatur eius dolor.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Donnie Reilly", "Id ut aut a asperiores sed distinctio sunt maxime enim. Omnis qui aut labore deleniti sit voluptatem. Sunt placeat sint aut facere id sed non dolores facilis. Delectus odio neque occaecati. Est sint dignissimos exercitationem.", 4, "bd3ec3d2-a711-63de-ba45-a155f84736cc", 215, "Runte Inc", "Nobis nam quod.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Roman Doyle", "Porro illum maiores. Deleniti cumque quos id veritatis praesentium autem voluptatem minus quas. Quibusdam ut maiores.", "fab3a781-316a-4bfd-8ff6-b552dd88cddd", 304, "Sauer, O'Hara and Jast", "Eos ea est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Marlee Boyer", "Perferendis et adipisci incidunt non. Laboriosam reiciendis qui consequatur. Voluptatibus aut cum aut distinctio sint placeat reprehenderit mollitia veritatis.", 2, "e6b4c4ee-4cc1-02c6-6e3f-58485a741577", 178, "Schneider, Schuppe and Schuppe", "Perferendis reprehenderit sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tristin Feest", "Distinctio velit soluta omnis. Minima enim ipsum sint et. Tenetur qui vel eveniet ut aliquam sint. Labore quaerat dolore in sed rerum explicabo id.", 2, "9643ea16-d747-b71a-3262-761b7742fcd4", 132, "Lebsack Inc", "Doloremque praesentium ut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Madelynn Davis", "Quis praesentium est est numquam. Voluptatem sapiente ut. Est sint molestiae magnam. At velit earum. Non quibusdam et necessitatibus. Quae rerum placeat voluptas mollitia.", "d7e72b3d-b1ff-c08c-3bc4-58501e2cfba9", 118, "Volkman, Barrows and Stokes", "Sunt aut illum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Matteo Leffler", "Atque sunt id. Nihil vitae eum molestiae. Numquam officiis qui consequatur. Velit sit ut.", 1, "5f8a0eee-7336-ba6c-cefd-009dac69353e", 214, "Durgan Group", "Ut assumenda quae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maximo Quigley", "Id labore ut ut dolores dolor libero modi. Iure quia vel. Est sunt eum.", 1, "40c40831-9bfd-fb7a-50ef-f8cc36bbb46d", 320, "Mante Group", "Eum aut nam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brady Lockman", "Dolorem sit possimus repellendus tempora eum quia. Necessitatibus fugit adipisci quos consequatur. Soluta nam reprehenderit molestias id id aut. Similique soluta quia nulla omnis aut earum.", 1, "113b07f5-0ebd-e3e1-4385-1b38fa503dd9", 388, "Schmeler - Crist", "Eaque repellendus amet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lurline Yundt", "In mollitia voluptatum et ullam atque itaque tempora. Quae voluptatem repellat quam quo. Exercitationem eum voluptas ut tempora nihil porro repellat rerum perspiciatis. Reiciendis quae sit id quasi quam.", 2, "e11e0fef-1561-c831-0a69-389b61d7a6a0", 161, "Hartmann - Ruecker", "Omnis exercitationem nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Aric Yundt", "Aut non possimus cupiditate voluptatibus sed veritatis ipsa. Omnis numquam ut. Earum non sit aliquam cumque libero quia voluptatem hic id. Corporis dolorum voluptas quod tempora iusto nesciunt aut sint. Ut est quos.", 2, "ed6d046b-6a42-35b9-50a0-73f3123b5b55", 168, "Mosciski, Feest and Sipes", "Earum saepe accusamus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Napoleon Grady", "Nihil labore pariatur. Voluptate quis in laborum quaerat dolores libero iusto est. Molestiae ipsa nesciunt quia nobis beatae quis amet quaerat. Laboriosam autem deleniti eum quia consequatur. Id est quos vero facere ea. Quia numquam commodi perspiciatis rerum accusantium minus commodi quo.", 4, "4760d6e5-17a6-5eea-cd13-4af0a8f48e5d", 151, "Dicki LLC", "Facere qui id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Webster Kemmer", "Excepturi corrupti impedit quasi voluptas reiciendis quia nostrum placeat. Architecto accusantium fuga repellendus doloremque. Nihil est porro porro facilis consectetur officiis. Sed repudiandae dolores quibusdam amet ratione illo eaque. Deleniti est itaque dolorem dolores unde. Natus quae quas sint eaque sit ut nam.", "60d6fe6c-41f8-fea3-4b25-8912f2eb13a8", 311, "Shanahan - Purdy", "Laborum sint magni.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annie Reichel", "Doloribus eum commodi. Distinctio dolore inventore. Dignissimos optio saepe et velit.", 2, "4b0bfa29-0ebb-af70-72fa-3ae550d93a87", 246, "Ullrich, Smith and Skiles", "Exercitationem qui ab.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nico Daniel", "Est ipsam accusamus. Tempore eum nihil quas saepe dignissimos pariatur laboriosam. Saepe a omnis consequatur modi facere aliquid.", 4, "4c3ca064-cc2f-0644-d043-5fbc17ccaae9", 143, "Abshire, Wisozk and Jenkins", "Maiores dolore aliquam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Wyatt Ruecker", "Illo nostrum est harum. Et quod doloremque dolore accusamus eos rerum ad sint dicta. Accusantium quisquam illo autem accusantium non ut.", "604b854a-cc29-a3ac-867f-8c8c80948ced", 122, "Dare LLC", "Exercitationem doloremque corporis.", 2024 });
        }
    }
}
