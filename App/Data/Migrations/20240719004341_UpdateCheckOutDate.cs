using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCheckOutDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 18, new DateTime(2024, 7, 18, 1, 31, 47, 724, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 9, 11, 12, 41, 48, 123, DateTimeKind.Local).AddTicks(8151), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 4, new DateTime(2024, 7, 14, 8, 8, 32, 681, DateTimeKind.Local).AddTicks(6335), new DateTime(2025, 5, 16, 9, 19, 6, 626, DateTimeKind.Local).AddTicks(9886) });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Drake McCullough", "Cum vero deserunt. Cum a tempore nemo ut repellat in sit ex sunt. Aut maxime eveniet laudantium quaerat. Qui non id quod. Alias excepturi placeat saepe voluptatem nisi. Animi laudantium aperiam sed nihil consectetur est.", 5, "a6420219-430b-da1a-d211-460d59142954", 391, "Miller - Stoltenberg", "Quia a earum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alessandra Koepp", "Atque eos autem voluptate ut sint eos eveniet. Qui possimus in quos iusto est voluptatem. Eum voluptas aut molestias dolorem dolor labore.", 2, "9dd689a1-f444-144e-004f-fefb00bd2c54", 224, "Boehm, Muller and Lesch", "Cupiditate et id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jamil Dickens", "Et nemo iure et hic qui molestiae accusamus. Voluptatem illum itaque sunt qui ut. Eum tempora sed ut vero. Consequatur dolores ut non placeat necessitatibus occaecati quidem quia totam. Necessitatibus est et eos cum ipsam est. Et cupiditate eius adipisci assumenda perspiciatis ea commodi et assumenda.", 1, "4558d9fe-b493-4535-490a-20c6174744dc", 477, "Rogahn LLC", "Cumque minus accusantium." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Harvey Kozey", "Assumenda recusandae voluptatem eveniet. Inventore blanditiis sint blanditiis. Vel impedit quidem amet accusantium doloremque quia voluptas. Libero voluptates eligendi voluptatem libero esse earum voluptatibus aliquam nobis.", 1, "393922cd-5244-6d2c-2b35-9c9e58e41827", 453, "Hauck, Breitenberg and Durgan", "Et dolorum itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Vivian Schmeler", "Quam tempora dolor voluptas et possimus neque omnis. Similique neque reprehenderit. Officiis id quia in sed. Id commodi omnis. Iste magnam id.", 5, "226a9ac0-de1d-23d9-e1b6-861dee32ed9c", 412, "Rohan, Hirthe and Mraz", "Laboriosam ullam atque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ethelyn Kautzer", "Quo aut molestiae accusantium eos ipsum. Expedita accusantium iusto consequatur quos consequuntur. Cum quia consequatur nostrum ad iusto est accusamus. Et quia quia sed. Aliquid minima provident voluptatum neque consequatur repellendus aut quibusdam aut. Modi natus dolorem.", 2, "cf12fd11-e81e-208d-6617-f05ed5e35206", 362, "King - Larson", "Corrupti quis eius.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Leanne Bins", "Modi vel id ullam. Dolores ipsum earum dignissimos expedita. Itaque quia corrupti rem vel aut earum ut.", "3d1b661e-697c-f29d-0405-e076b9e1dd56", 109, "Kessler LLC", "Et nihil id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ransom Rodriguez", "Accusantium aperiam ut velit repudiandae neque magni et omnis deserunt. Et dolor omnis porro sunt. Qui deserunt est delectus odio officiis et. Aut et sit cupiditate. Incidunt aut ut cumque dolore quo. Laboriosam debitis harum suscipit necessitatibus sunt dignissimos deserunt.", 1, "2d1e5b5b-2343-1661-c6b3-9fca5df9a09c", 329, "McClure - Franecki", "Necessitatibus numquam alias.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Agustin Lockman", "Sit nobis culpa ut nihil temporibus fugit dolor aut ut. Voluptates et ducimus qui quia omnis. Eos perspiciatis modi. Aspernatur ut ut in quia quod est natus. Quas iure odio. Quis quam quod placeat quis velit.", 5, "1f8fa9b1-4b28-7296-8378-51ddbc4fa850", 268, "Borer and Sons", "Qui et ut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jolie Parker", "Ipsam eos expedita nobis. Qui dolor et. Nihil iste soluta et. Ut incidunt cumque aliquam inventore porro earum est.", "3428499d-6124-efb4-4c6e-6070a7a4ede9", 371, "Dooley - Tremblay", "Vero possimus architecto." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jade Stokes", "Cupiditate ut consectetur exercitationem earum similique qui in sit. Ut aut in exercitationem et. Consequatur sint ut laudantium quidem quam. Et dolore eos vero qui repudiandae dolorem nemo incidunt. Qui ab earum est dolor. Ut voluptatem non consequatur.", 2, "9dc6e4db-ebcd-a559-c966-fc1483651dfb", 207, "Purdy - Durgan", "Hic tenetur reiciendis." });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elenora Abernathy", "Quia quae occaecati beatae adipisci itaque. Quis sapiente eius illum. Blanditiis recusandae magni voluptatem nihil qui nihil ut. Sit et omnis impedit omnis sequi in architecto. Aut sit velit hic voluptas mollitia nobis sed.", "85f7780b-90cf-2798-2744-21844354df8c", 258, "Watsica - Dibbert", "Sit nemo fuga.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elody Gibson", "Cumque quia repudiandae necessitatibus. Eius reprehenderit facere. Dignissimos facere nisi nostrum et. Dolores consequatur ducimus sint. Et ipsa non. Vitae eum enim amet nihil ipsam maxime ut.", 5, "44301a53-807f-7b73-b8b9-dd64626fbaa1", 203, "Dibbert - Satterfield", "Facilis veritatis dolorem.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "3ec2cb53-3f70-4322-bba8-55e97a90aabc", "Lynda.Lesch61@hotmail.com", "Lynda", "Lesch", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/766.jpg", "ae8faa7c-6a36-4205-b399-e359d074dceb", "Lynda_Lesch" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "544bb51f-22d8-4ed7-aa61-eca07caebfac", "Dustin95@hotmail.com", "Dustin", "Schmeler", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/0.jpg", "460c0d62-cc85-4890-b608-7f17eb508fe7", "Dustin.Schmeler48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "3f403eeb-4e9e-4850-82c9-6bbf0a2e7242", "Tabitha77@gmail.com", "Tabitha", "Ebert", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/502.jpg", "761147ce-85cf-4731-921d-5b00ce3b5a38", "Tabitha13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "bf1db8d4-b3f6-42e9-8c8a-5d1d2164098f", "Paulette50@gmail.com", "Paulette", "O'Kon", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/562.jpg", "d5eebd2b-4fde-46da-bc18-9e117f9e81ba", "Paulette.OKon" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "33812bd9-e503-4737-b14d-e985fe52f507", "Margaret46@gmail.com", "Margaret", "Cronin", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/100.jpg", "82ced047-f56c-4d2e-b1fe-0097c1ff5aa7", "Margaret_Cronin" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 18, 18, 59, 49, 612, DateTimeKind.Local).AddTicks(559), new DateTime(2026, 10, 26, 0, 1, 50, 404, DateTimeKind.Local).AddTicks(4382), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 15, new DateTime(2024, 7, 17, 21, 7, 21, 488, DateTimeKind.Local).AddTicks(5705), new DateTime(2028, 4, 10, 3, 46, 21, 382, DateTimeKind.Local).AddTicks(1141), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 3, new DateTime(2024, 7, 19, 0, 3, 41, 974, DateTimeKind.Local).AddTicks(8878), new DateTime(2026, 8, 31, 14, 28, 1, 426, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 14, new DateTime(2024, 7, 16, 3, 53, 3, 562, DateTimeKind.Local).AddTicks(9398), new DateTime(2024, 7, 25, 2, 48, 58, 359, DateTimeKind.Local).AddTicks(6670), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 14, new DateTime(2024, 7, 19, 0, 0, 32, 659, DateTimeKind.Local).AddTicks(2462), new DateTime(2029, 1, 6, 17, 12, 20, 957, DateTimeKind.Local).AddTicks(6637), "4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Sherwood Thiel", "Tempore magnam et quia earum. Cumque consequuntur asperiores saepe eum debitis. Debitis similique vitae numquam. Totam delectus consequatur molestiae incidunt magnam qui quia suscipit rerum. Culpa ipsa ullam voluptatem sed reprehenderit sed. Similique sunt repellat officiis accusantium possimus commodi et.", 2, "ec9af4a9-0a74-0f9b-9e79-4665c4a69ff7", 490, "Ullrich - Sauer", "Architecto magnam est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lonzo Mohr", "Ut voluptate eum et iste fuga ut dolor corporis aut. Dolores itaque facilis neque. Ex praesentium eveniet quisquam libero. Aut quia magnam et expedita eligendi ratione voluptatem. Magnam alias accusantium reiciendis et sit dolor hic.", 4, "0528be46-f488-3f68-baf8-4a9b79c9b81b", 259, "Wilkinson, Boehm and Blick", "Nobis dolores minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Sydney Larson", "Et consequatur cupiditate similique qui laudantium rerum. Aut odio repellat sed officia explicabo est repellat. Eos quaerat rem velit. Nulla voluptatem modi. Quisquam assumenda ut consequatur eum nihil soluta beatae voluptatum non. Animi atque ea sed.", 3, "e6f5b595-3039-0cab-1f4e-6491d2c2ef64", 159, "Effertz, Abbott and Volkman", "Enim dicta quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Harrison Mohr", "Consequuntur ullam perspiciatis facere unde dolor. Consectetur in qui ut eligendi. Et consequatur iste.", 3, "80f8a864-f3c4-d54a-bcff-fd0d4f54feef", 161, "Borer, Hackett and Kautzer", "Dolorum reprehenderit earum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Chloe Lebsack", "Libero et quia ducimus esse exercitationem ut ex neque odit. Et eos impedit earum magnam. Voluptatum eum maxime velit eaque deleniti. Assumenda officiis debitis ut eum. Ab delectus et et dolorum.", 3, "0769647e-46fe-7c04-7d06-e1604b76b544", 236, "Rath and Sons", "Sit pariatur non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Sydni Barrows", "Ipsam est doloribus accusamus rerum nostrum reiciendis aut eos. A voluptates quasi labore quae et et et placeat error. Ea itaque asperiores nemo nemo delectus reiciendis eaque dolores.", 3, "548275dd-84d4-0670-a932-13eb67e1cfc6", 107, "Hintz, Lebsack and Witting", "Vitae dolorem suscipit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Charlotte Pfeffer", "Quas quas corrupti ut atque blanditiis earum aut. Veniam necessitatibus modi aut quaerat dolore dignissimos et. Delectus id rerum doloribus ullam aperiam. Qui aut consequatur sed saepe autem.", 3, "db0f1967-5e2d-007a-0295-f8e387bea4fc", 474, "Fritsch, McLaughlin and Kris", "Vitae temporibus sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bettye Bashirian", "Dolor voluptatem aperiam sed voluptatibus aut reiciendis. Ipsa voluptatum id deserunt pariatur eius id sit consequatur eveniet. Quidem excepturi enim magnam. Eligendi eligendi facilis odio exercitationem assumenda. Explicabo rem eligendi sequi consequuntur necessitatibus.", 4, "782ee541-0841-6173-6649-67eda25023e1", 399, "Rippin, Wyman and Sanford", "Sit officiis sunt.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Mikel Brakus", "Beatae ipsa assumenda consequatur nulla officiis vel eveniet ut. Necessitatibus quo eveniet nulla modi omnis a voluptates. Soluta et fugiat. Molestiae possimus laborum ipsa consequuntur quo et blanditiis praesentium. Facilis porro eum sequi dignissimos quae voluptate dolorem a. Quia quaerat rerum.", "3a34c283-995f-3a9c-1229-faf788ccad00", 395, "Schumm, Greenholt and Willms", "Dicta aliquid repellat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maximillian Moore", "Ea id enim sit veritatis. Esse sunt et voluptatem quibusdam quia. Voluptatum reiciendis quibusdam sapiente vel eligendi fugit inventore qui. Architecto quasi placeat eum quasi ad esse quia vitae.", 5, "b0ccb0e2-149d-9cec-c1de-5eb2ed5a6fb1", 422, "Pacocha, Beier and Jacobson", "Dolore rem nostrum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Grace Rempel", "A consequatur et mollitia. Quibusdam sed assumenda. Aut alias quis consequatur omnis optio est esse ipsa voluptatem. Est placeat omnis dolore consequuntur sit est. Porro consectetur enim qui tempora et rerum voluptate.", 3, "ee0fc940-a8d6-ec62-044f-fa410b9aea09", 405, "Kohler, Gusikowski and Ernser", "Modi labore sit.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alisha Jacobi", "Officia magni officiis assumenda. Quia quos rem. Aperiam assumenda reprehenderit assumenda. Minima quibusdam corporis quos quod voluptas.", "8d4ba020-f8c2-2a55-809a-5e4a991938c3", 376, "Bednar, Wunsch and Lakin", "Dolorum quia velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Herta Lebsack", "Quidem praesentium aut ex fugit sapiente at consequatur enim blanditiis. Expedita commodi exercitationem voluptate odio et atque aspernatur eveniet. Illum et perspiciatis deserunt ut magnam reprehenderit et.", 4, "968f286e-b929-4374-bc54-fa6364439ad3", 412, "Marvin, Hansen and Braun", "Impedit quis voluptas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Riley Ziemann", "Voluptas aut unde soluta et aspernatur iste in. Voluptates ad delectus id. Et veritatis et nisi rerum reprehenderit officia rerum consequatur. Tempora assumenda iure. Alias hic aliquam molestiae alias voluptatum distinctio.", 3, "6ec7b325-e32f-8c4d-1ec7-d8c3ddc42bfc", 195, "Von, Stracke and Brekke", "Voluptatibus odit est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Palma Schaefer", "Consequatur doloribus quis alias voluptas animi. Quia ex aut dolorum nostrum fugiat quo voluptas aut. Provident et hic repudiandae. Quia molestiae nostrum blanditiis. Quod recusandae harum aliquid cumque ea magni.", 4, "4d30eeca-53fe-9b00-7d69-64293064c1b6", 414, "Kertzmann LLC", "Sed voluptates mollitia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Gerhard Bailey", "Corporis in harum in rem quidem et. Dolores et ipsum quae ullam esse expedita ipsa. Facere in nam reprehenderit rerum.", 2, "e6ba9ea9-2339-471b-83df-6e8fc631752c", 199, "Morar, Carroll and Zboncak", "Sed eligendi mollitia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Krista Koss", "Qui quod est assumenda dolorum et quod quas. Neque tenetur qui illo quia dolores. Maiores harum aut nobis sequi iusto dolorem distinctio sint.", 1, "e2483685-b29b-0d9c-fb9d-8d809c85519e", 340, "Botsford - Metz", "Quibusdam eligendi aut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Zoe Kris", "Similique tempore vitae et molestias illum et tempore. Quia vel ut. Error molestiae odit quia omnis temporibus. Id molestiae magni dolorem voluptas inventore qui omnis. Culpa provident repudiandae inventore quod quis laborum libero quia.", 1, "5ff55bf7-e75e-d5a7-020d-87c0cd75b7fc", 194, "Pouros, Anderson and Nader", "Sequi ut repellendus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Esmeralda Bednar", "Quisquam voluptate et incidunt optio perspiciatis. Ullam praesentium amet dolor rerum quia ea temporibus sint optio. Sit aspernatur nobis est illum itaque placeat odit ipsam. Quia labore quaerat quia esse cupiditate molestias dolorem laborum quas. Vel accusamus ducimus necessitatibus et ut ipsam laborum accusamus. Neque consequatur a nam consequatur sed sapiente mollitia.", "528cd54b-2d22-eef1-e375-f64926d0a111", 212, "Mraz, Maggio and Schuppe", "Similique sapiente harum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Haylee Baumbach", "Veritatis rerum velit necessitatibus pariatur sint laborum cumque perspiciatis. Totam atque fuga quod sequi. Soluta nulla aut excepturi officiis distinctio aperiam voluptas est. Et voluptatem dolore qui ratione. Quasi ex doloremque ratione omnis earum a consequatur soluta.", 3, "76737be1-a907-8d2e-692e-de7e5993b8e5", 445, "Medhurst, Lockman and Hegmann", "Ut laudantium ab.", 2024 });
        }
    }
}
