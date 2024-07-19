using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCheckOutDateAgain1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 3, new DateTime(2024, 7, 13, 0, 48, 0, 625, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 7, 20, 1, 44, 26, 763, DateTimeKind.Local).AddTicks(6923) });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Laisha Mann", "Est voluptas et non voluptates error blanditiis. Omnis assumenda fuga minima officiis quia. Ea aut saepe repudiandae iusto doloribus tenetur. Aut rerum ut veritatis voluptas. Consequuntur cupiditate temporibus accusamus.", "7d9a6d1a-d519-8b77-1019-348712d56aae", 253, "Shields LLC", "Distinctio ea et.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Keara Medhurst", "Consequatur saepe ut et est repudiandae sit nihil. Blanditiis impedit officiis debitis veniam placeat. Exercitationem et et. Atque id sit laborum sequi iste qui voluptatem facilis.", 3, "f2d8680d-3648-82a4-8bee-85968b2a3aba", 434, "Orn - Kris", "Earum voluptatem est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tyson Kreiger", "Nihil ipsam doloribus accusantium. Soluta tempora quasi ipsum totam. Illum omnis repellat et eligendi. Alias temporibus et magnam. Et ab dolor. Quos eaque doloremque quisquam impedit.", "d725ec65-30bd-21c5-374f-d97c521e1a4e", 384, "Barrows Inc", "Enim aut dolore.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Valentin Legros", "Esse voluptatibus facere dolores cupiditate corporis perferendis optio fugiat. Totam ducimus et voluptatibus eligendi ut dolor. Corporis molestiae similique enim quod rerum. Nemo inventore architecto saepe magnam aut. Ipsum et fugiat sit libero ducimus cupiditate labore.", 1, "006dad92-0016-5f52-bd42-2110e5af7633", 474, "Funk - Cronin", "Consequatur eius dolor.", 2023 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Roman Doyle", "Porro illum maiores. Deleniti cumque quos id veritatis praesentium autem voluptatem minus quas. Quibusdam ut maiores.", "fab3a781-316a-4bfd-8ff6-b552dd88cddd", 304, "Sauer, O'Hara and Jast", "Eos ea est.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Tristin Feest", "Distinctio velit soluta omnis. Minima enim ipsum sint et. Tenetur qui vel eveniet ut aliquam sint. Labore quaerat dolore in sed rerum explicabo id.", 2, "9643ea16-d747-b71a-3262-761b7742fcd4", 132, "Lebsack Inc", "Doloremque praesentium ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Madelynn Davis", "Quis praesentium est est numquam. Voluptatem sapiente ut. Est sint molestiae magnam. At velit earum. Non quibusdam et necessitatibus. Quae rerum placeat voluptas mollitia.", 3, "d7e72b3d-b1ff-c08c-3bc4-58501e2cfba9", 118, "Volkman, Barrows and Stokes", "Sunt aut illum.", 2024 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maximo Quigley", "Id labore ut ut dolores dolor libero modi. Iure quia vel. Est sunt eum.", "40c40831-9bfd-fb7a-50ef-f8cc36bbb46d", 320, "Mante Group", "Eum aut nam.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brady Lockman", "Dolorem sit possimus repellendus tempora eum quia. Necessitatibus fugit adipisci quos consequatur. Soluta nam reprehenderit molestias id id aut. Similique soluta quia nulla omnis aut earum.", "113b07f5-0ebd-e3e1-4385-1b38fa503dd9", 388, "Schmeler - Crist", "Eaque repellendus amet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lurline Yundt", "In mollitia voluptatum et ullam atque itaque tempora. Quae voluptatem repellat quam quo. Exercitationem eum voluptas ut tempora nihil porro repellat rerum perspiciatis. Reiciendis quae sit id quasi quam.", 2, "e11e0fef-1561-c831-0a69-389b61d7a6a0", 161, "Hartmann - Ruecker", "Omnis exercitationem nesciunt.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Aric Yundt", "Aut non possimus cupiditate voluptatibus sed veritatis ipsa. Omnis numquam ut. Earum non sit aliquam cumque libero quia voluptatem hic id. Corporis dolorum voluptas quod tempora iusto nesciunt aut sint. Ut est quos.", "ed6d046b-6a42-35b9-50a0-73f3123b5b55", 168, "Mosciski, Feest and Sipes", "Earum saepe accusamus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Napoleon Grady", "Nihil labore pariatur. Voluptate quis in laborum quaerat dolores libero iusto est. Molestiae ipsa nesciunt quia nobis beatae quis amet quaerat. Laboriosam autem deleniti eum quia consequatur. Id est quos vero facere ea. Quia numquam commodi perspiciatis rerum accusantium minus commodi quo.", 4, "4760d6e5-17a6-5eea-cd13-4af0a8f48e5d", 151, "Dicki LLC", "Facere qui id.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Webster Kemmer", "Excepturi corrupti impedit quasi voluptas reiciendis quia nostrum placeat. Architecto accusantium fuga repellendus doloremque. Nihil est porro porro facilis consectetur officiis. Sed repudiandae dolores quibusdam amet ratione illo eaque. Deleniti est itaque dolorem dolores unde. Natus quae quas sint eaque sit ut nam.", 4, "60d6fe6c-41f8-fea3-4b25-8912f2eb13a8", 311, "Shanahan - Purdy", "Laborum sint magni.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Nico Daniel", "Est ipsam accusamus. Tempore eum nihil quas saepe dignissimos pariatur laboriosam. Saepe a omnis consequatur modi facere aliquid.", 4, "4c3ca064-cc2f-0644-d043-5fbc17ccaae9", 143, "Abshire, Wisozk and Jenkins", "Maiores dolore aliquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Wyatt Ruecker", "Illo nostrum est harum. Et quod doloremque dolore accusamus eos rerum ad sint dicta. Accusantium quisquam illo autem accusantium non ut.", "604b854a-cc29-a3ac-867f-8c8c80948ced", 122, "Dare LLC", "Exercitationem doloremque corporis." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "21518121-2791-464b-8a3a-a2688f5267d6", "Calvin.Beahan@yahoo.com", "Calvin", "Beahan", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/500.jpg", "d1c2a30d-296a-418e-a45c-f84042a30cbb", "Calvin_Beahan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "19051240-c6de-4214-b1c1-976027ee5d2b", "Lance_Erdman@yahoo.com", "Lance", "Erdman", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/65.jpg", "1968f349-9a27-4c12-b73a-e068f8199e2b", "Lance_Erdman" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "85488dfb-9ce3-497b-92e9-9a1ac6576206", "Jodi.Morissette68@yahoo.com", "Jodi", "Morissette", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/360.jpg", "89072957-7272-439d-a8ec-9ba5632be95d", "Jodi.Morissette3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "589eb1ff-3b7a-40d3-bb1e-b1abad305d6a", "Angelina60@yahoo.com", "Angelina", "Shields", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1190.jpg", "223246b4-62a6-4508-aae9-00db5a191f9a", "Angelina18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "1c5cbc32-647e-4437-a580-61364e16a88f", "Rhonda0@gmail.com", "Rhonda", "Nitzsche", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1145.jpg", "ac1e5a4b-f845-4e7c-a868-73647d398b0b", "Rhonda_Nitzsche59" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 13, 21, 19, 6, 590, DateTimeKind.Local).AddTicks(2632), new DateTime(2029, 5, 4, 22, 25, 34, 725, DateTimeKind.Local).AddTicks(6606), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 20, new DateTime(2024, 7, 15, 2, 2, 10, 884, DateTimeKind.Local).AddTicks(8327), new DateTime(2026, 3, 11, 10, 30, 47, 298, DateTimeKind.Local).AddTicks(9240), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 20, new DateTime(2024, 7, 18, 11, 7, 1, 927, DateTimeKind.Local).AddTicks(3125), new DateTime(2028, 1, 15, 3, 29, 30, 280, DateTimeKind.Local).AddTicks(8050), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 11, new DateTime(2024, 7, 13, 22, 57, 28, 280, DateTimeKind.Local).AddTicks(9353), new DateTime(2026, 1, 26, 17, 32, 12, 844, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 15, new DateTime(2024, 7, 17, 21, 5, 21, 152, DateTimeKind.Local).AddTicks(4708), new DateTime(2027, 11, 30, 15, 5, 8, 296, DateTimeKind.Local).AddTicks(1701), "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Adrien Heathcote", "Voluptatibus ipsa doloremque et ut est quis officia aliquam. Quia eos enim repellendus vitae nobis animi velit incidunt corporis. Dignissimos voluptatem quae. Amet qui non similique eum possimus tempora quis dolorum. Assumenda consequatur vero excepturi dolore dolores rem.", 4, "732801ed-67f4-9c51-e9ae-7223a5fa45d8", 255, "Breitenberg - Bashirian", "Et qui iste." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jarvis Zulauf", "Ut facere nihil suscipit. Cum aut sunt magni in eaque ut. Ipsum quia blanditiis distinctio cupiditate.", "a77f5202-e358-4f9b-b4cb-c8db44cf2765", 462, "Kris Group", "Ea qui quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kaleb Block", "Id dolores autem aut eius cum consequatur. Qui et et vero aliquid aspernatur ut dolorum. Dignissimos facilis saepe. Impedit dolor assumenda mollitia quisquam recusandae iure omnis similique corrupti. Expedita non aut ratione quas et quis. Ipsam est cupiditate et voluptas cumque sit.", 5, "155af360-6ecc-b311-63aa-a76b19f01a68", 187, "Collier Group", "Aut atque vel.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lavada Rohan", "Tempora in distinctio quaerat qui ipsa reiciendis autem ut. Nostrum et tempora laboriosam sit accusamus cumque. Maxime velit exercitationem fuga et. Labore nostrum autem ab. Ut quis architecto debitis sit omnis. Deleniti nihil inventore.", "a294c780-3291-6119-dac2-6be31be06e94", 472, "Heathcote - Gottlieb", "Numquam quos ea.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lavon Mohr", "Dolor voluptas delectus accusamus vero aperiam eum dignissimos labore optio. Ullam veniam sequi hic qui voluptas modi sit accusamus. Et qui pariatur provident ut non ut. Recusandae qui consequatur rerum non dignissimos qui. Doloremque est quia. Expedita dolorem et voluptas ut iusto.", 5, "e63338d3-30c6-1d76-0aa6-44209ad25c0f", 183, "DuBuque LLC", "Ut in qui.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Richmond Larson", "Et illo eos amet iure maxime aut. Voluptas exercitationem dolorem molestiae eum ut. Aut ea ea. Molestiae iusto facilis nostrum ea dicta. Voluptatem iste ullam dolores cum asperiores non totam. Perferendis saepe minima voluptas cupiditate est sed.", 5, "ab5ecfd7-ad51-3712-8791-56c2b0e5abc4", 375, "Veum - Strosin", "Eum occaecati doloremque.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Dean Huels", "Odit minima facilis aut quia est dolorum omnis incidunt aliquid. Veniam possimus hic ut pariatur. Sit quos eaque praesentium hic aut praesentium. Sit atque minima molestias accusamus debitis quia id voluptatum nesciunt. Beatae vero ducimus nisi atque reiciendis dolor magnam.", "45a5d04b-c0db-72be-74bb-d62c2ecbec21", 463, "Kuphal - Conn", "Quos omnis quos.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Eldridge Bednar", "Aut dicta et voluptate eaque distinctio voluptatem corporis. Dolor sit ad ducimus inventore illo qui quia a. Neque rerum vel molestiae.", 4, "b8215e6d-231c-1812-eeee-8255b2851961", 253, "Gulgowski - Kreiger", "Autem quaerat architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Madie Daniel", "Quae necessitatibus amet itaque necessitatibus ullam velit esse nemo incidunt. Suscipit pariatur adipisci eius ullam doloremque. Sint eius laborum eum reprehenderit.", 5, "267b40fd-9c7d-6cac-1e7a-2b566e0ce37c", 117, "Wintheiser - Price", "Harum ad quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Frida Leffler", "Culpa maiores in enim consequatur dignissimos aliquid. Dolorum quibusdam veniam ducimus debitis enim fugiat est ipsa. Atque aliquam aut.", 5, "983ca756-ec56-3de6-cca7-ed41ffc6a362", 352, "Greenfelder LLC", "Laborum quia cupiditate.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jeffery Schumm", "Quia esse maxime. Qui nisi autem ipsa sapiente quia soluta. Qui consequatur aut qui similique occaecati suscipit quo nemo quos. Placeat illo amet mollitia aliquid voluptatum. Consequatur voluptatem ut quaerat sit similique quos. Suscipit quia ut veritatis officiis dolor.", 4, "f707be46-25fe-96d0-6570-a115f6df2c97", 379, "Huel, Torp and Strosin", "Nisi quis voluptatum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maya Reilly", "Porro accusamus beatae dolores consequatur quis. Qui voluptatibus inventore provident hic aut. Aut nam exercitationem eos ullam et. Fugiat voluptates sunt enim id. Nostrum magnam amet. Ut ut minus aut earum ut quasi dolores.", "e9a3dffb-d0f6-c43e-55ae-5d0ffe2c1cfa", 465, "Lynch - Schmeler", "Enim enim maxime.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Isabella Kilback", "Aut delectus culpa velit. In laborum sit perspiciatis. Qui quia officia accusantium reiciendis rerum esse. Odit non voluptatem id similique animi.", "c96af60a-6982-5051-716c-fa257f996eed", 469, "Lesch - Mertz", "Qui corrupti quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brandt Muller", "Dolore doloremque sit et. Ipsum ipsam id optio officiis unde corporis. Beatae debitis deserunt repudiandae perferendis quia. Ipsum voluptatum autem aliquid alias placeat.", 1, "8fda9fe4-6338-4b66-e59e-2ba4b13fdd1c", 401, "McLaughlin - Bartoletti", "Dolorem voluptatem dolor.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Garret Murphy", "Voluptatem aut nesciunt quis voluptas eos eveniet. Quisquam tempora quo dicta nihil ducimus incidunt et. Delectus nihil facere minus placeat voluptate sit nisi perspiciatis. Unde quasi est architecto tempore atque eos nihil qui soluta.", "70bc858d-a8a7-f36f-2de4-98f422cdd16b", 410, "Kuhn Group", "Qui et itaque.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Makayla Kshlerin", "Incidunt ullam non dolores voluptas id vero inventore. Officiis recusandae aliquam beatae. Aut voluptatem quis ut perferendis non dolores. Dicta magni cupiditate aspernatur.", 2, "0360fd3b-a929-24b4-394e-994848422020", 288, "Kihn Inc", "Laboriosam asperiores vel.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chase Adams", "Nemo eum sit. Delectus reprehenderit ut. Velit eum ad sit.", 1, "9552eebe-ebcc-510f-d715-684a687b799b", 298, "Bernier LLC", "Cumque totam non.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Travon Wisoky", "Natus nihil est ipsum et laboriosam exercitationem inventore. Minus et eligendi adipisci ut aspernatur temporibus omnis. Doloremque inventore cumque voluptates voluptatum. Eum distinctio est velit sunt id incidunt. Incidunt ducimus quod quas.", 5, "1bed2ddf-7523-6767-dfc0-00ff617b98e4", 330, "Kilback, Hoeger and Lind", "Eos minima sequi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Dayne Ruecker", "Optio at dolorem asperiores deserunt. Asperiores voluptatem nihil amet harum repudiandae dolor ut. Pariatur dicta ex aut. Eum labore facere consequatur beatae soluta ut est a laudantium. Aut ut quae. Ea blanditiis excepturi alias tempore totam et corporis.", 5, "5f2d0333-bdd4-6161-166b-8dd2731f33f1", 482, "Kiehn LLC", "Alias corrupti id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Shaniya Davis", "Quo corporis aut porro necessitatibus. Quis tempora laborum itaque quidem reprehenderit neque recusandae nihil. Officia asperiores necessitatibus expedita illo perspiciatis eius. At iste quia soluta sed praesentium. Iusto perferendis voluptatibus enim. Consequatur inventore aperiam itaque tempore et.", "1b2d303c-3157-55ac-12f8-1d361a14db6a", 355, "Heaney, Gislason and Wolff", "Voluptatum occaecati sequi." });
        }
    }
}
