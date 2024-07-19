using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserHasBooksSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "First", "Last", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0", 0, "b37fbbad-1bd7-456d-baf3-132b5242ae5e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Misty.Romaguera56@hotmail.com", false, "Misty", "Romaguera", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1156.jpg", "5edab6fe-a955-45d0-80d6-3729466977aa", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misty.Romaguera" },
                    { "1", 0, "808837fa-b7c6-4142-97c6-1c43c8b53972", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Emanuel15@hotmail.com", false, "Emanuel", "Johns", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/498.jpg", "2e28aadf-263f-439b-bf60-ce46a2696687", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emanuel.Johns" },
                    { "2", 0, "b36c5c44-b66a-453c-91e6-98e15411e425", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tom.Kemmer@yahoo.com", false, "Tom", "Kemmer", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/86.jpg", "2a39116c-4f79-4060-a2fa-26b7f866652a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom.Kemmer94" },
                    { "3", 0, "0c378bea-2f1c-4790-ac6d-6180b6675a45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "William_Adams@hotmail.com", false, "William", "Adams", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/474.jpg", "10368bef-9f97-4d78-9879-29d555df27b8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "William.Adams" },
                    { "4", 0, "26ba7f50-5803-4ce0-9a0d-101f3cec5ec8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lola_Rolfson@yahoo.com", false, "Lola", "Rolfson", false, null, null, null, null, null, false, "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/443.jpg", "21f0f3ef-edd3-45d0-ab9a-722cad55140a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lola_Rolfson" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Osborne Gleichner", "Expedita voluptatem quisquam eos quibusdam quia in distinctio corrupti omnis. Ipsam dolores aspernatur voluptatem esse reiciendis consectetur consequuntur ab ea. Provident ratione in quasi delectus.", 2, "6ac87e7e-81bb-c5d5-30d2-8c33c4ccac2b", 290, "Batz, Hyatt and Baumbach", "Amet cupiditate sed.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Reinhold Harber", "Soluta accusamus distinctio cumque aut repudiandae dolore eveniet vitae repellendus. Earum quo illum aut qui recusandae qui architecto quos delectus. Eos saepe quia culpa. Sit deleniti mollitia sed et nihil. Aut enim quam ut doloribus asperiores enim. Fuga expedita iste amet veniam tenetur et aspernatur asperiores.", 5, "1407537b-1a11-3d8b-34ad-8bf884e56898", 419, "Bosco LLC", "Et officia magni." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maritza Wuckert", "Sapiente dolor assumenda. Vel aut non magni dicta molestiae. Saepe quia nihil dolores esse aut aspernatur sed numquam.", "a6bb629b-2caf-dcd1-0b04-a3f892fa0302", 460, "Gusikowski LLC", "Reiciendis perferendis error." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Ceasar Kuhn", "Ullam eligendi sed eos nisi expedita soluta in. Ab labore tenetur ipsum aliquam mollitia expedita dolorem sint officiis. Excepturi error distinctio non quam nemo et iusto dolores. Odio cupiditate consectetur incidunt est qui autem. Consequatur cum ut quo.", 1, "8940bc68-46b7-298c-6121-7e43859f3981", 345, "Schiller and Sons", "Blanditiis similique quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Zena Mante", "Laudantium dolores necessitatibus unde consequatur itaque. Rerum laudantium qui expedita nemo commodi corrupti et. Rem sint recusandae tempora debitis similique vitae aut et.", "fea18b52-e5f7-6e3b-25b1-8737d21bd38f", 284, "Champlin Group", "Fugit nobis velit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hattie Howell", "Tenetur eum cupiditate. Eum dolor rerum beatae repellendus. Natus qui at et dolorem enim enim quibusdam. Iste vel modi autem quod. Et inventore alias ut commodi ab dignissimos est ut. Optio in officiis rerum ut id id.", "a3a10999-c8cd-9ed8-1c40-b7277ea757a0", 382, "Hintz Group", "Dolorem rerum sed.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Thelma Witting", "Neque velit ducimus sint ut quos soluta consequatur. Facilis sint impedit ut. Ipsa est consequatur debitis commodi omnis nihil natus in. Qui repudiandae qui voluptate modi.", 1, "1dc522af-acd8-e89a-a4d3-5cb2bce9975f", 223, "Rau, Schaefer and Sawayn", "Qui error voluptas.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Beulah Bruen", "Soluta id et aut odit eum a excepturi dolore odio. Dignissimos voluptas soluta et impedit quo voluptatibus rerum quibusdam. Excepturi eaque nam veritatis voluptatum. Magnam consequuntur quis molestiae consequuntur architecto suscipit laborum qui perspiciatis. Reiciendis maxime natus voluptatum aut.", 1, "8302826a-5581-b45c-3089-c7de837701af", 374, "Graham - Raynor", "Debitis incidunt recusandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gino Towne", "Vitae et nesciunt deserunt molestiae aperiam. Minima tenetur aut laboriosam soluta ea natus quidem consequatur quasi. Eum quae dolorum nam aperiam sunt voluptatibus qui eaque. Aliquid delectus illum deleniti aut vel eaque enim facere et.", 2, "8c52533e-91be-cd1e-f742-6fe064795a1c", 494, "Bergstrom, Armstrong and Cassin", "Sit quae nisi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Madilyn Parisian", "Voluptas et sed quia laborum repellat sit. Modi est consequatur reiciendis corporis aut magnam. Veritatis quasi esse quidem est expedita. Illo dolores qui est et in corrupti excepturi. Voluptas est saepe est. Ipsam provident amet laudantium praesentium voluptatem impedit.", "695237e4-9721-bbbc-3c8e-d4c96784e44e", 259, "Osinski, Block and Kling", "Officia qui modi." });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Description", "GenreId", "ISBN", "Image", "IsBestSeller", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "UpdatedAt", "UserId", "UserId1", "Year" },
                values: new object[,]
                {
                    { 11, "Bette Jenkins", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Animi non nihil aperiam. Consequatur reiciendis quas. Doloremque saepe placeat delectus corrupti tempore nulla aliquid mollitia vero.", 3, "37bc3b08-9ac9-785e-05bd-2e31394e34af", "https://drive.google.com/thumbnail?id=1dwug9Rd51uRSIR61N0de32UGuZ1Ns3WH&sz=w1000", false, false, false, false, 164, "Walter - Lemke", "Nobis error dicta.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 12, "Else Ondricka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fugiat magni ipsam distinctio excepturi necessitatibus deleniti eum doloribus odio. Perspiciatis aut cumque deleniti dolor commodi. Rerum qui et officiis molestiae non nihil tempora. Aut iusto nostrum molestiae nam nihil. Officiis aut ut itaque quae sit. Quia consequatur quis itaque aut expedita incidunt qui error.", 5, "389e6aac-2940-5fe8-427c-ef512b7f2693", "https://drive.google.com/thumbnail?id=1UCje5bgDDxlWMWdYSK8tRgwMp-LkYM27&sz=w1000", false, false, false, false, 250, "Kovacek and Sons", "Quo qui atque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 13, "Demetris Moore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Reprehenderit delectus labore tenetur voluptates illo quis. Rerum in nostrum harum aut quibusdam ducimus consequatur. Est consequuntur at. Iure sequi enim molestiae.", 3, "182eee9a-0766-810b-ed4b-4cc83219bffa", "https://drive.google.com/thumbnail?id=17pwzIwvq6pyTJyqQ9ooT7dRXMwIHVNeU&sz=w1000", false, false, false, false, 157, "Boyle, Bartell and Langworth", "Placeat neque eos.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 14, "Boris Legros", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Et tenetur soluta in quaerat in. Error dolores ullam animi quam error magni. Culpa aliquid dolore similique. Sit exercitationem ad.", 5, "d33b2688-682d-78f3-2961-a8d4f4aad752", "https://drive.google.com/thumbnail?id=1VGdbU9YQSgzTyesLYdt6xgANcWlOzVlX&sz=w1000", false, false, false, false, 139, "Turner - Kozey", "Dolorem ad assumenda.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 15, "Madison Collier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ad aut in illum alias iste sunt. Quia est rem voluptatum delectus. Non et maxime rerum id quaerat ipsam velit.", 4, "24eecdb3-0a5c-6b9b-8ca1-06e2b9b188bd", "https://drive.google.com/thumbnail?id=1-wmBdCw9y0cuT_jaYQVd8zUtQ5Y6WydG&sz=w1000", false, false, false, false, 389, "Steuber Group", "Est itaque tenetur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 16, "Trinity Bergnaum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A quibusdam fugiat suscipit laborum quam quas sed quibusdam. Dicta illo qui doloremque sit id qui nam qui. Dolor vel quos rerum maiores veniam dolor numquam. Dolorem rerum quas autem voluptas aperiam.", 4, "ed70bf75-676a-ea70-5b31-02140a1eaa58", "https://drive.google.com/thumbnail?id=17LCGXsaF8chECGxR5IXHkj5qc7UrWIqw&sz=w1000", false, false, false, false, 330, "Sauer and Sons", "Voluptas facilis voluptatem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 17, "Oren Conn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Assumenda velit quam consequatur. Ad veritatis et quo ad adipisci. Sit sunt aut.", 3, "1a408b2e-7c11-fe53-ad61-11bb897741da", "https://drive.google.com/thumbnail?id=1V5-GfhMxAUE5QhKYGDtE1XlAjl3sRZFN&sz=w1000", false, false, false, false, 193, "Schuppe, Senger and Koepp", "Aperiam repudiandae nostrum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 18, "Alanna D'Amore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quis fugiat sunt velit vel voluptatem. Error sed sunt accusantium dolorem. Temporibus delectus aperiam. Et fugiat nihil libero ullam.", 4, "dc0cab7a-57b6-4fd6-1e66-af51d4887771", "https://drive.google.com/thumbnail?id=129hAaWbWcEXubYXVEy2-a4Gbs0ulv9La&sz=w1000", false, false, false, false, 253, "Herman, Kuvalis and Goodwin", "Voluptas sapiente expedita.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 19, "Marjory Luettgen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Facilis suscipit quos nesciunt. Atque debitis quibusdam sit eum non quos. Dolores modi doloribus ipsum ut quos quibusdam quam et alias.", 2, "69f17d63-67d6-2f5e-bf20-a209c5741a10", "https://drive.google.com/thumbnail?id=1iS1vCXQNst3Cm0hkq0m9m53HlFXB2e_b&sz=w1000", false, false, false, false, 272, "O'Hara, Hyatt and MacGyver", "Dicta soluta deleniti.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2024 },
                    { 20, "Eliane Schoen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dolor saepe aspernatur accusantium quasi rerum odit quia ea fugiat. Neque voluptatum dolor et quaerat esse tempore commodi nemo at. Similique et porro ratione molestias ex consectetur dolor consequatur. Beatae quisquam aut et explicabo.", 4, "6799449a-ef3f-ed76-5f0b-2cdf39c62a8a", "https://drive.google.com/thumbnail?id=1EsQ7X9KyU57dg3N3AjHn_xtUtauiElDF&sz=w1000", false, false, false, false, 394, "Klein, Emmerich and Schimmel", "Voluptas at enim.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 21, "Fannie Wisozk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sed nemo odio doloremque quasi aliquid. Aut voluptatem reiciendis nobis commodi cumque adipisci. Ut praesentium quisquam atque iusto.", 4, "bba17553-f9cf-b447-55ca-05374686f799", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000", false, false, false, false, 421, "Rice - Langworth", "Tempore eveniet ipsam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 2024 },
                    { 22, "Kamron Walter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Maiores nulla omnis facere et deleniti modi sunt et. Deserunt id eum veritatis. Eligendi magnam optio officia explicabo in aut aut quo.", 4, "009be093-994a-ed0d-e2b0-3ae078ba6ebc", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000", false, false, false, false, 429, "Altenwerth - Kilback", "Accusantium eveniet ipsam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 23, "Merle D'Amore", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Doloremque animi magnam dolores vel voluptas harum. Rerum est aut repellendus dolores. Vitae fuga ut occaecati dolores reprehenderit. Quod maxime dolor facilis occaecati mollitia unde quod et ab. Aliquid consequatur non neque excepturi velit veritatis. Fugit ut omnis enim rem.", 3, "07e4d352-4a15-359f-33ac-1c3a3f2d9345", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000", false, false, false, false, 299, "Kessler LLC", "Ad voluptatem consectetur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2023 },
                    { 24, "Cullen Kshlerin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nam rerum natus tenetur. Cupiditate qui veritatis dolore dolorem modi. Omnis rerum quia. Consequatur et possimus consequuntur. Est fuga omnis placeat est consequuntur repudiandae laborum.", 2, "aedfecf9-4e64-9c07-94ba-2be463186d2c", "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000", false, false, false, false, 489, "Waelchi Inc", "Enim totam aperiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 2023 },
                    { 25, "Malcolm Fadel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Non nihil labore dolores enim. Eum laboriosam ex vel numquam est eveniet. Vel et et eligendi temporibus omnis aperiam perferendis non. Reprehenderit fuga et provident quae illum maxime sequi qui sint. Exercitationem voluptatem voluptas error dolorum fuga.", 1, "86bbccf2-175d-d1f4-55d9-dc076d26ee73", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000", false, false, false, false, 408, "Predovic, Klocko and Wilderman", "Aut sit quia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2024 },
                    { 26, "Lilla Willms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ut aut ut deserunt dolor. Ut velit labore impedit nostrum et voluptatem. Ipsum explicabo eveniet molestias. Aliquam facilis quia eum dolores dolor. Assumenda deserunt dolor aut. Assumenda voluptas fugit voluptatem vitae.", 2, "362a42bf-f89a-6809-d9bd-9bec3ba70841", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000", false, false, false, false, 331, "Windler, Torp and Lynch", "Itaque omnis sunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 27, "Greta Marks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Omnis sit libero sint et. Necessitatibus quis non sit officia. Error vel similique dolor beatae. Voluptas earum nemo reprehenderit mollitia est nemo autem dolores et. Sunt quia quis. Aut sint et rerum.", 2, "e626b73f-e2ab-7baa-59a3-f8fef8773947", "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000", false, false, false, false, 151, "Roberts - Gerlach", "Quia reprehenderit consequatur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2023 },
                    { 28, "Brant Paucek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Consectetur similique totam. Hic praesentium sed officia nisi ut atque. Consectetur facere ducimus magni reprehenderit repellat sapiente ea enim. Perspiciatis nisi labore hic.", 5, "7ea8bb5b-578f-f2d8-c2b1-b92aa0355bec", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000", false, false, false, false, 443, "Wiza LLC", "Dolorem at rerum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2023 },
                    { 29, "Chelsea Bogisich", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Velit quia autem rerum ut nobis ab. Ullam labore suscipit quod iste omnis. Sapiente illum quaerat enim dolorum et et numquam ea adipisci. Accusantium consequatur beatae perspiciatis. Quia quidem sit et. Doloremque est dolorem voluptatem placeat aut autem.", 5, "2b2e28c6-d1c7-f40f-05b5-fed0dd444573", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000", false, false, false, false, 451, "Sporer - Balistreri", "Distinctio exercitationem aperiam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 2023 },
                    { 30, "Cale Romaguera", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ut exercitationem nemo dolorem temporibus eligendi. Perspiciatis vel quaerat et. Eaque nulla ut ipsa qui quisquam adipisci est et facilis. Est suscipit possimus excepturi. Dicta itaque et.", 1, "de153641-57db-556a-f209-ac57f1ed2a79", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000", false, false, false, false, 458, "Cummerata LLC", "Esse molestias iusto.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 2024 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Callie Gislason", "Maiores maiores quia odio quo adipisci sapiente vel ea suscipit. Necessitatibus est quo nobis. Corrupti excepturi quasi maiores nobis rem. Incidunt ullam necessitatibus id et nesciunt harum odit. Quam totam cum.", 4, "6d063c63-dd9a-1b79-1d4b-0f8ec492c952", 471, "Lebsack, Glover and Herman", "Molestias voluptatem sunt.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Willow Gislason", "Similique neque harum debitis et voluptatem non quae maxime. Facere repellendus accusantium rerum laborum fuga harum quos dolor. Dolorem aut ut optio placeat aliquam rerum enim. Provident consequatur ratione non similique assumenda ut aut sit. Tempora sunt cumque facere blanditiis. Et sint molestiae dolores cumque.", 4, "2e1dc274-3e5f-effa-009b-784a1bc04de0", 331, "Hoppe Group", "Velit sed in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emmett Boyle", "Aperiam deleniti autem earum ut vel. Quos sint est sed facilis. Sit ex sit vel assumenda quisquam et. Et voluptatibus veniam repellat ratione accusamus et dolores.", "f773d50e-8743-2da3-702f-eff050c0db97", 137, "O'Keefe Group", "Rerum earum ea." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Selena Hackett", "Veniam dolores minima nulla eum culpa sit ut ad culpa. Consectetur magni qui rem. Sequi corrupti consectetur voluptatem dignissimos magni molestiae dolores atque sed. Vero dolorem qui.", 2, "7b401b96-7047-7097-ce16-d6ae91919b11", 296, "Schowalter, Will and Steuber", "Aut est est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Erling Hyatt", "Laboriosam non ad sed sed porro quos. Itaque enim inventore libero voluptas. Minus dolorum quod tempora. Aut non nesciunt.", "73bc00f7-783e-889e-1c23-ea8378de80ab", 259, "Reichert and Sons", "Sapiente velit nihil.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Pauline Lebsack", "Deserunt est quo quia. In dolorem voluptatem possimus consequatur excepturi. Quidem autem ut est quidem dolore et. Ut nihil culpa. Ratione aut aspernatur dolorem repellat omnis.", "c606a02b-3a6b-d633-53a8-0f4f666d7cfe", 284, "Rath Inc", "Magnam velit dolores.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Matteo Bernier", "Atque voluptatibus deserunt aliquid mollitia non autem officiis. Accusantium minus est minima libero unde. Exercitationem non reiciendis.", 2, "2a2c81ff-4140-56cd-c514-9ce6da0eaeff", 415, "Jacobi and Sons", "Alias doloribus aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Allie Reinger", "Rerum sit modi quaerat doloremque velit. Atque dolorem placeat recusandae voluptatem dolore inventore voluptas. Quia inventore est itaque ad voluptatem quia. Saepe id quo dicta ducimus nam quae. Ullam atque labore.", 3, "99707216-60d8-fecc-c718-7d16df9249c4", 353, "Howe - Boyle", "Explicabo qui est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Werner Kirlin", "Doloribus enim mollitia nesciunt explicabo quos neque deleniti vitae. Amet voluptate ipsam perspiciatis temporibus illum est consequuntur rerum in. Sed sed omnis. Quia est beatae totam ut sapiente delectus quia magnam ut. Qui consequatur delectus iure laudantium praesentium. At et id pariatur autem voluptates.", 1, "84582d43-ac64-d5bc-bc53-d77f6e9bf234", 464, "Maggio Group", "Earum et et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hugh Prosacco", "Omnis aut qui. Nostrum sequi quae iure perferendis sequi non molestiae perferendis. Accusantium incidunt veritatis sed odit ipsum aliquid possimus. Eaque error dolores consequuntur officiis doloremque est. Ea neque totam aut vero aut quis voluptatum soluta reprehenderit. Autem possimus delectus eligendi omnis ipsum dolore quas esse.", "bdaf51b3-ab80-956e-0d1a-434771ee07ee", 400, "Macejkovic Inc", "Omnis labore consequatur." });
        }
    }
}
