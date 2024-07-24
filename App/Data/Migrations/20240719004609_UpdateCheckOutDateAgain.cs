using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCheckOutDateAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 20, new DateTime(2024, 7, 15, 2, 2, 10, 884, DateTimeKind.Local).AddTicks(8327), new DateTime(2026, 3, 11, 10, 30, 47, 298, DateTimeKind.Local).AddTicks(9240) });

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 11, new DateTime(2024, 7, 13, 22, 57, 28, 280, DateTimeKind.Local).AddTicks(9353), new DateTime(2026, 1, 26, 17, 32, 12, 844, DateTimeKind.Local).AddTicks(7937), "2" });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jarvis Zulauf", "Ut facere nihil suscipit. Cum aut sunt magni in eaque ut. Ipsum quia blanditiis distinctio cupiditate.", "a77f5202-e358-4f9b-b4cb-c8db44cf2765", 462, "Kris Group", "Ea qui quia." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lavon Mohr", "Dolor voluptas delectus accusamus vero aperiam eum dignissimos labore optio. Ullam veniam sequi hic qui voluptas modi sit accusamus. Et qui pariatur provident ut non ut. Recusandae qui consequatur rerum non dignissimos qui. Doloremque est quia. Expedita dolorem et voluptas ut iusto.", 5, "e63338d3-30c6-1d76-0aa6-44209ad25c0f", 183, "DuBuque LLC", "Ut in qui." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Frida Leffler", "Culpa maiores in enim consequatur dignissimos aliquid. Dolorum quibusdam veniam ducimus debitis enim fugiat est ipsa. Atque aliquam aut.", 5, "983ca756-ec56-3de6-cca7-ed41ffc6a362", 352, "Greenfelder LLC", "Laborum quia cupiditate." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maya Reilly", "Porro accusamus beatae dolores consequatur quis. Qui voluptatibus inventore provident hic aut. Aut nam exercitationem eos ullam et. Fugiat voluptates sunt enim id. Nostrum magnam amet. Ut ut minus aut earum ut quasi dolores.", 1, "e9a3dffb-d0f6-c43e-55ae-5d0ffe2c1cfa", 465, "Lynch - Schmeler", "Enim enim maxime." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Isabella Kilback", "Aut delectus culpa velit. In laborum sit perspiciatis. Qui quia officia accusantium reiciendis rerum esse. Odit non voluptatem id similique animi.", 1, "c96af60a-6982-5051-716c-fa257f996eed", 469, "Lesch - Mertz", "Qui corrupti quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brandt Muller", "Dolore doloremque sit et. Ipsum ipsam id optio officiis unde corporis. Beatae debitis deserunt repudiandae perferendis quia. Ipsum voluptatum autem aliquid alias placeat.", 1, "8fda9fe4-6338-4b66-e59e-2ba4b13fdd1c", 401, "McLaughlin - Bartoletti", "Dolorem voluptatem dolor." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Makayla Kshlerin", "Incidunt ullam non dolores voluptas id vero inventore. Officiis recusandae aliquam beatae. Aut voluptatem quis ut perferendis non dolores. Dicta magni cupiditate aspernatur.", 2, "0360fd3b-a929-24b4-394e-994848422020", 288, "Kihn Inc", "Laboriosam asperiores vel." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Travon Wisoky", "Natus nihil est ipsum et laboriosam exercitationem inventore. Minus et eligendi adipisci ut aspernatur temporibus omnis. Doloremque inventore cumque voluptates voluptatum. Eum distinctio est velit sunt id incidunt. Incidunt ducimus quod quas.", 5, "1bed2ddf-7523-6767-dfc0-00ff617b98e4", 330, "Kilback, Hoeger and Lind", "Eos minima sequi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Dayne Ruecker", "Optio at dolorem asperiores deserunt. Asperiores voluptatem nihil amet harum repudiandae dolor ut. Pariatur dicta ex aut. Eum labore facere consequatur beatae soluta ut est a laudantium. Aut ut quae. Ea blanditiis excepturi alias tempore totam et corporis.", 5, "5f2d0333-bdd4-6161-166b-8dd2731f33f1", 482, "Kiehn LLC", "Alias corrupti id.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Shaniya Davis", "Quo corporis aut porro necessitatibus. Quis tempora laborum itaque quidem reprehenderit neque recusandae nihil. Officia asperiores necessitatibus expedita illo perspiciatis eius. At iste quia soluta sed praesentium. Iusto perferendis voluptatibus enim. Consequatur inventore aperiam itaque tempore et.", "1b2d303c-3157-55ac-12f8-1d361a14db6a", 355, "Heaney, Gislason and Wolff", "Voluptatum occaecati sequi.", 2024 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "7a610d18-e909-4db1-a4a9-01f9756490a1", "Tammy72@hotmail.com", "Tammy", "Hartmann", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/409.jpg", "77a0028f-7b28-4694-b7fb-0f18b63a1046", "Tammy.Hartmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "7cca45b7-4ea6-4aeb-a7c1-fc98aafa11d7", "Denise88@yahoo.com", "Denise", "Beatty", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/891.jpg", "aaf88966-6fcd-4acf-acec-f896bae9652b", "Denise_Beatty" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "0bc7fbe0-7419-4f10-a2e9-0818025dc2d0", "Josh5@yahoo.com", "Josh", "Bednar", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/193.jpg", "883f96d2-38ba-438a-8034-21755ee5ebd9", "Josh_Bednar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "cb6e2b3d-caf0-4644-a6ee-ff6c2ccb421d", "Edgar.Beahan56@gmail.com", "Edgar", "Beahan", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1094.jpg", "95ee50e9-8e16-4742-9a48-184b6898f7c2", "Edgar91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "3f15d02c-dde7-4644-869e-e2f11d9ef6eb", "Wade70@yahoo.com", "Wade", "Weber", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/116.jpg", "15991c76-95f6-4247-8754-09d7959ba19a", "Wade.Weber19" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 10, new DateTime(2024, 7, 18, 21, 6, 35, 422, DateTimeKind.Local).AddTicks(2720), new DateTime(2024, 11, 16, 7, 17, 50, 961, DateTimeKind.Local).AddTicks(7508), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 18, new DateTime(2024, 7, 18, 1, 31, 47, 724, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 9, 11, 12, 41, 48, 123, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 14, 8, 8, 32, 681, DateTimeKind.Local).AddTicks(6335), new DateTime(2025, 5, 16, 9, 19, 6, 626, DateTimeKind.Local).AddTicks(9886), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 7, new DateTime(2024, 7, 15, 10, 2, 15, 577, DateTimeKind.Local).AddTicks(9118), new DateTime(2025, 3, 23, 12, 48, 33, 324, DateTimeKind.Local).AddTicks(9725), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 18, 10, 26, 33, 856, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 6, 13, 22, 44, 29, 601, DateTimeKind.Local).AddTicks(2035), "3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Van Rau", "Excepturi labore possimus et eius necessitatibus iusto dignissimos. Nobis assumenda saepe. Labore nihil numquam eos accusamus doloribus dolores rerum perferendis ullam. Illo perferendis ipsa necessitatibus consectetur. Distinctio molestiae eum eius adipisci minus id vel temporibus eum. Earum illum accusantium quas dolorum et.", 3, "e588ac9e-92b0-6f6e-7dbd-01f33cf19b48", 118, "Dibbert and Sons", "Molestiae voluptatem excepturi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Drake McCullough", "Cum vero deserunt. Cum a tempore nemo ut repellat in sit ex sunt. Aut maxime eveniet laudantium quaerat. Qui non id quod. Alias excepturi placeat saepe voluptatem nisi. Animi laudantium aperiam sed nihil consectetur est.", "a6420219-430b-da1a-d211-460d59142954", 391, "Miller - Stoltenberg", "Quia a earum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alessandra Koepp", "Atque eos autem voluptate ut sint eos eveniet. Qui possimus in quos iusto est voluptatem. Eum voluptas aut molestias dolorem dolor labore.", 2, "9dd689a1-f444-144e-004f-fefb00bd2c54", 224, "Boehm, Muller and Lesch", "Cupiditate et id.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jamil Dickens", "Et nemo iure et hic qui molestiae accusamus. Voluptatem illum itaque sunt qui ut. Eum tempora sed ut vero. Consequatur dolores ut non placeat necessitatibus occaecati quidem quia totam. Necessitatibus est et eos cum ipsam est. Et cupiditate eius adipisci assumenda perspiciatis ea commodi et assumenda.", "4558d9fe-b493-4535-490a-20c6174744dc", 477, "Rogahn LLC", "Cumque minus accusantium.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Misty Lubowitz", "Qui mollitia fugiat officia vel accusantium magnam aliquid. Et ut veniam enim natus. Quas provident a consectetur ut. Quibusdam molestiae ipsum eum adipisci quo. Ea rerum maxime aliquid non laudantium deserunt quae officiis. Vitae eos omnis natus soluta.", 4, "f03a755a-5d58-8b83-3845-a130016b8364", 233, "Barton LLC", "Rem facilis neque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harvey Kozey", "Assumenda recusandae voluptatem eveniet. Inventore blanditiis sint blanditiis. Vel impedit quidem amet accusantium doloremque quia voluptas. Libero voluptates eligendi voluptatem libero esse earum voluptatibus aliquam nobis.", 1, "393922cd-5244-6d2c-2b35-9c9e58e41827", 453, "Hauck, Breitenberg and Durgan", "Et dolorum itaque.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Vivian Schmeler", "Quam tempora dolor voluptas et possimus neque omnis. Similique neque reprehenderit. Officiis id quia in sed. Id commodi omnis. Iste magnam id.", "226a9ac0-de1d-23d9-e1b6-861dee32ed9c", 412, "Rohan, Hirthe and Mraz", "Laboriosam ullam atque.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Ethelyn Kautzer", "Quo aut molestiae accusantium eos ipsum. Expedita accusantium iusto consequatur quos consequuntur. Cum quia consequatur nostrum ad iusto est accusamus. Et quia quia sed. Aliquid minima provident voluptatum neque consequatur repellendus aut quibusdam aut. Modi natus dolorem.", 2, "cf12fd11-e81e-208d-6617-f05ed5e35206", 362, "King - Larson", "Corrupti quis eius." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Leanne Bins", "Modi vel id ullam. Dolores ipsum earum dignissimos expedita. Itaque quia corrupti rem vel aut earum ut.", 3, "3d1b661e-697c-f29d-0405-e076b9e1dd56", 109, "Kessler LLC", "Et nihil id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Ransom Rodriguez", "Accusantium aperiam ut velit repudiandae neque magni et omnis deserunt. Et dolor omnis porro sunt. Qui deserunt est delectus odio officiis et. Aut et sit cupiditate. Incidunt aut ut cumque dolore quo. Laboriosam debitis harum suscipit necessitatibus sunt dignissimos deserunt.", 1, "2d1e5b5b-2343-1661-c6b3-9fca5df9a09c", 329, "McClure - Franecki", "Necessitatibus numquam alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Agustin Lockman", "Sit nobis culpa ut nihil temporibus fugit dolor aut ut. Voluptates et ducimus qui quia omnis. Eos perspiciatis modi. Aspernatur ut ut in quia quod est natus. Quas iure odio. Quis quam quod placeat quis velit.", 5, "1f8fa9b1-4b28-7296-8378-51ddbc4fa850", 268, "Borer and Sons", "Qui et ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jolie Parker", "Ipsam eos expedita nobis. Qui dolor et. Nihil iste soluta et. Ut incidunt cumque aliquam inventore porro earum est.", 4, "3428499d-6124-efb4-4c6e-6070a7a4ede9", 371, "Dooley - Tremblay", "Vero possimus architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Guiseppe Lesch", "Recusandae minima consequuntur nostrum. Dolores dolores ratione quo libero hic. Aut in nobis quisquam eius omnis neque quas laudantium.", 3, "7da2801a-1583-4036-14ff-8ac22548fc02", 328, "Kohler and Sons", "Aut ea quia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Forrest Brown", "Odio et et quas praesentium hic voluptatem. Veniam numquam eligendi totam occaecati. Magni asperiores ipsa assumenda. Fugiat sunt velit delectus. Similique ad fuga quis reiciendis nihil ut recusandae fuga facilis. Quasi possimus voluptatum assumenda minus aperiam maiores fuga.", 5, "dbf2e3f8-5038-988d-51da-722dc3cbe3f9", 365, "Lubowitz - MacGyver", "Rerum rerum magni." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jade Stokes", "Cupiditate ut consectetur exercitationem earum similique qui in sit. Ut aut in exercitationem et. Consequatur sint ut laudantium quidem quam. Et dolore eos vero qui repudiandae dolorem nemo incidunt. Qui ab earum est dolor. Ut voluptatem non consequatur.", "9dc6e4db-ebcd-a559-c966-fc1483651dfb", 207, "Purdy - Durgan", "Hic tenetur reiciendis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Justice Bradtke", "Earum eaque non explicabo facere aperiam distinctio adipisci eligendi. Dolorem cum eveniet exercitationem sunt. Odit et error neque molestiae. Corporis quasi doloribus assumenda ipsa dignissimos et laborum fugiat est.", 5, "e54e844a-0bae-efba-9444-24bc392988e5", 336, "Thiel Inc", "Distinctio atque dolorum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Aida Jast", "Id iure consequuntur aut aut earum impedit ut. Omnis nesciunt consequatur fuga soluta eligendi qui iure placeat porro. Quod veritatis id iste neque nesciunt consequatur quasi.", 4, "be7c963c-addb-ad2d-60a9-d868ea5ccfcd", 238, "Quigley - Hills", "Ipsum aliquam et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maurine Prosacco", "Nesciunt quia et aut ad quam numquam aspernatur alias. Et aperiam enim architecto reprehenderit porro dolor quos. Quaerat aut sit modi maxime et. Ut pariatur rerum necessitatibus sunt iste. Illum eligendi debitis quaerat quia nam possimus.", 3, "18f212de-f434-bd45-dba0-f451a08cb8c1", 169, "Larkin, Upton and Lowe", "Ipsam sequi minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elenora Abernathy", "Quia quae occaecati beatae adipisci itaque. Quis sapiente eius illum. Blanditiis recusandae magni voluptatem nihil qui nihil ut. Sit et omnis impedit omnis sequi in architecto. Aut sit velit hic voluptas mollitia nobis sed.", 4, "85f7780b-90cf-2798-2744-21844354df8c", 258, "Watsica - Dibbert", "Sit nemo fuga.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elody Gibson", "Cumque quia repudiandae necessitatibus. Eius reprehenderit facere. Dignissimos facere nisi nostrum et. Dolores consequatur ducimus sint. Et ipsa non. Vitae eum enim amet nihil ipsam maxime ut.", "44301a53-807f-7b73-b8b9-dd64626fbaa1", 203, "Dibbert - Satterfield", "Facilis veritatis dolorem.", 2023 });
        }
    }
}
