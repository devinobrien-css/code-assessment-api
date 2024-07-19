using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "First", "Last", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0070abcc-bd13-b39e-f739-5863f09f9de6", 0, "b3ad2c76-8123-49b1-93dc-5865695511b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Myron.Ziemann@yahoo.com", false, "Myron", "Ziemann", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/418.jpg", "719249cd-9931-4a87-9f3a-b4850affdfd0", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myron37" },
                    { "5d496bef-4b49-e7fc-71c6-7a4937630bc7", 0, "a78f257b-0ace-4ed2-a6c2-f58e76fa5e97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Holly.Kiehn@hotmail.com", false, "Holly", "Kiehn", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/364.jpg", "aeb6ab0c-3299-4315-8313-eb4004c452e4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holly21" },
                    { "890dd9a3-0cdb-0c38-091a-f32caacd62a0", 0, "1de7d3fa-058a-4a65-b192-1161bc48ae78", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Janet17@gmail.com", false, "Janet", "Gleason", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/971.jpg", "1415ed85-0f68-4a74-aa3f-d820c672c3b5", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet_Gleason35" },
                    { "e06275fe-c8da-73eb-7046-5442841e9b3e", 0, "68910afb-a684-41df-bed0-136b88dd8bfc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Roxanne24@hotmail.com", false, "Roxanne", "Littel", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/876.jpg", "013f7f90-00e2-4a04-8713-7aea1965febb", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roxanne.Littel" },
                    { "f7fcd1d6-26dd-b2cb-d5b4-512d99ca17b4", 0, "f8835f6e-f780-49c0-b6bb-9f6b33c377c4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hazel.Abbott77@hotmail.com", false, "Hazel", "Abbott", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/678.jpg", "33269ad3-39a4-4c82-b198-88ed44ee7328", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazel.Abbott95" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Callie Gislason", "Maiores maiores quia odio quo adipisci sapiente vel ea suscipit. Necessitatibus est quo nobis. Corrupti excepturi quasi maiores nobis rem. Incidunt ullam necessitatibus id et nesciunt harum odit. Quam totam cum.", 4, "6d063c63-dd9a-1b79-1d4b-0f8ec492c952", 471, "Lebsack, Glover and Herman", "Molestias voluptatem sunt.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Willow Gislason", "Similique neque harum debitis et voluptatem non quae maxime. Facere repellendus accusantium rerum laborum fuga harum quos dolor. Dolorem aut ut optio placeat aliquam rerum enim. Provident consequatur ratione non similique assumenda ut aut sit. Tempora sunt cumque facere blanditiis. Et sint molestiae dolores cumque.", 4, "2e1dc274-3e5f-effa-009b-784a1bc04de0", 331, "Hoppe Group", "Velit sed in.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Emmett Boyle", "Aperiam deleniti autem earum ut vel. Quos sint est sed facilis. Sit ex sit vel assumenda quisquam et. Et voluptatibus veniam repellat ratione accusamus et dolores.", 5, "f773d50e-8743-2da3-702f-eff050c0db97", 137, "O'Keefe Group", "Rerum earum ea.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Selena Hackett", "Veniam dolores minima nulla eum culpa sit ut ad culpa. Consectetur magni qui rem. Sequi corrupti consectetur voluptatem dignissimos magni molestiae dolores atque sed. Vero dolorem qui.", "7b401b96-7047-7097-ce16-d6ae91919b11", 296, "Schowalter, Will and Steuber", "Aut est est.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Erling Hyatt", "Laboriosam non ad sed sed porro quos. Itaque enim inventore libero voluptas. Minus dolorum quod tempora. Aut non nesciunt.", 1, "73bc00f7-783e-889e-1c23-ea8378de80ab", 259, "Reichert and Sons", "Sapiente velit nihil.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Pauline Lebsack", "Deserunt est quo quia. In dolorem voluptatem possimus consequatur excepturi. Quidem autem ut est quidem dolore et. Ut nihil culpa. Ratione aut aspernatur dolorem repellat omnis.", 3, "c606a02b-3a6b-d633-53a8-0f4f666d7cfe", 284, "Rath Inc", "Magnam velit dolores.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Matteo Bernier", "Atque voluptatibus deserunt aliquid mollitia non autem officiis. Accusantium minus est minima libero unde. Exercitationem non reiciendis.", 2, "2a2c81ff-4140-56cd-c514-9ce6da0eaeff", 415, "Jacobi and Sons", "Alias doloribus aut.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Allie Reinger", "Rerum sit modi quaerat doloremque velit. Atque dolorem placeat recusandae voluptatem dolore inventore voluptas. Quia inventore est itaque ad voluptatem quia. Saepe id quo dicta ducimus nam quae. Ullam atque labore.", 3, "99707216-60d8-fecc-c718-7d16df9249c4", 353, "Howe - Boyle", "Explicabo qui est.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Werner Kirlin", "Doloribus enim mollitia nesciunt explicabo quos neque deleniti vitae. Amet voluptate ipsam perspiciatis temporibus illum est consequuntur rerum in. Sed sed omnis. Quia est beatae totam ut sapiente delectus quia magnam ut. Qui consequatur delectus iure laudantium praesentium. At et id pariatur autem voluptates.", 1, "84582d43-ac64-d5bc-bc53-d77f6e9bf234", 464, "Maggio Group", "Earum et et.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Hugh Prosacco", "Omnis aut qui. Nostrum sequi quae iure perferendis sequi non molestiae perferendis. Accusantium incidunt veritatis sed odit ipsum aliquid possimus. Eaque error dolores consequuntur officiis doloremque est. Ea neque totam aut vero aut quis voluptatum soluta reprehenderit. Autem possimus delectus eligendi omnis ipsum dolore quas esse.", 1, "bdaf51b3-ab80-956e-0d1a-434771ee07ee", 400, "Macejkovic Inc", "Omnis labore consequatur.", 0, null, 2023 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId1",
                table: "Books",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_UserId1",
                table: "Books",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserId1",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0070abcc-bd13-b39e-f739-5863f09f9de6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d496bef-4b49-e7fc-71c6-7a4937630bc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "890dd9a3-0cdb-0c38-091a-f32caacd62a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e06275fe-c8da-73eb-7046-5442841e9b3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7fcd1d6-26dd-b2cb-d5b4-512d99ca17b4");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hanna Jones", "Ex et in aut. Aliquam aperiam inventore magnam consequatur in. Animi pariatur odit minus autem numquam possimus itaque.", 2, "86dabeef-0749-938e-b8ca-eeb7975fadc8", 374, "Dach - Kris", "Natus molestias voluptate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Vivianne Hickle", "Quaerat aut totam est voluptate impedit omnis accusamus qui. Esse dolorem et. In ut dicta minima.", 2, "73e55795-3c39-8528-8c7f-a4a5c58d6373", 177, "Torp and Sons", "Facere ea rem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bernadine Ledner", "Voluptas non reprehenderit odit et eos nulla dignissimos. Sint ea praesentium et et. Eligendi voluptas omnis id soluta maxime libero quia nulla qui. Est tenetur perferendis ipsam quos facere dignissimos reiciendis. Error excepturi ut itaque et adipisci.", 1, "557a6d51-b5ab-55fa-1e63-b25ab6366884", 376, "Nader Group", "Aut mollitia tempora.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Oren Kulas", "Quaerat est omnis. Blanditiis distinctio eum perspiciatis beatae blanditiis soluta est non sed. Sed inventore voluptatum deserunt veniam quia ratione.", "f89c11df-9a98-a7e9-6185-a3004f9cb3c5", 346, "Corkery - Waters", "Quo non voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jeromy Gaylord", "Illum impedit ut voluptas. Eaque rerum quos tenetur distinctio modi repellendus quos. Non incidunt veniam ut libero veritatis est quidem reiciendis ea. Dolor quidem animi perspiciatis neque optio corrupti. Aliquid excepturi dignissimos.", 3, "2dda26d8-f44a-beca-9276-1da1c717c311", 217, "Runolfsdottir LLC", "Tempora sed totam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Greyson Boehm", "Rerum nemo nemo dolor rerum rerum. Quisquam provident commodi tenetur quos omnis veritatis explicabo iure harum. Quae facilis perspiciatis facere nostrum tempore eos eaque.", 1, "449c26a6-cdee-44b5-e59d-4739ff54d568", 440, "Jerde, Kertzmann and Waelchi", "Praesentium quo hic.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Una Lemke", "Tempore nulla qui voluptatem in eveniet. Facilis corrupti minus eum placeat quae voluptatum. Accusantium est repellendus in ut eveniet voluptatum ipsa dolorem. Vitae eum perspiciatis et consequatur quos impedit sint aut sunt. Maiores reprehenderit quis animi quia pariatur nostrum consequuntur eum. Ut quos quis molestiae ab et at commodi nihil.", 4, "ccd76777-b735-99b3-73b9-23b6c8533b91", 372, "Kessler - Rohan", "Delectus ipsam sunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Moriah Larson", "Officiis voluptatem ut. Eum ratione sapiente voluptas voluptatem in ut dolore rerum suscipit. Non rem maiores.", 4, "3748b3a8-98a1-2c2b-4c48-293950b11744", 183, "Buckridge - Steuber", "Voluptas cupiditate unde.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brain Hegmann", "Quo mollitia possimus ducimus sint doloribus quidem voluptas facilis. Iste dolorum laboriosam et unde. Quo libero perspiciatis repudiandae consequuntur officia et blanditiis vitae itaque. Exercitationem nostrum voluptatibus labore magnam tenetur dolores incidunt.", 2, "9bee71b2-f7f8-4502-00c4-db82587a85fa", 251, "Mante and Sons", "Quod perferendis laboriosam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Macy Auer", "Illum ipsum culpa animi omnis consequatur possimus qui sed. Aut architecto magnam. Vel error sint sit eum occaecati aut ducimus exercitationem aliquid. Mollitia voluptatem quibusdam voluptas quis in provident quisquam.", 5, "00897ead-3e70-8695-5570-4541452eacd0", 496, "Little, Rowe and Larkin", "Distinctio dignissimos incidunt.", 2024 });
        }
    }
}
