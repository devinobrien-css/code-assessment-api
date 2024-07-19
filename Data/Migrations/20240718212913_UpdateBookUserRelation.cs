using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserId1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "8411863e-e69f-4ff6-9be2-0f9d336d7ff4", "Bobbie33@gmail.com", "Bobbie", "Pagac", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/150.jpg", "54148b56-79eb-4dac-9813-3d994d2d47b1", "Bobbie.Pagac64" });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Kurtis Wiegand", "Officia deserunt in incidunt omnis nobis tenetur corporis repellat enim. Aut dolorem sit exercitationem rerum animi ipsa ex. Adipisci a aperiam voluptatum. Et asperiores qui corporis aut et odio. Architecto eos facilis numquam dolores doloribus similique reiciendis repudiandae.", 2, "4a0e54e7-c050-9dfe-2cbe-f58428a81c8a", 367, "Funk - Thompson", "Illo id adipisci.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Virgil Kuphal", "Ea earum reprehenderit dolorem sed vel et unde. Magni cumque ut. Optio rerum voluptatibus sit vitae impedit. Voluptate voluptatem et dolor omnis iste cum.", 1, "a4df787b-ac9f-e3f1-52b9-31f8ced8b622", 222, "Ritchie LLC", "Deleniti distinctio vitae.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Elisa Boyer", "Laudantium vitae eaque quia nihil aliquam. Aperiam expedita autem voluptas. Quis ea sunt officiis qui esse fugiat vitae. Dolor sed a dignissimos minima minus consequuntur ullam qui. Eaque id dicta aliquam saepe asperiores et.", 3, "eeab784a-60e6-6b8d-7d2e-c011d4432078", 182, "Herzog Inc", "Odit et aut.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Gerardo Oberbrunner", "Laudantium consectetur et deleniti qui minus. Delectus et sunt aut molestiae et dicta fuga dicta illo. Omnis autem ab eius eos et dolorem consequatur non. Minus dolores sunt nam. Consequatur autem eius modi incidunt et ad modi eligendi consequatur.", "295c1daf-ef43-c9cb-46a4-1b99f7b001a8", 152, "VonRueden LLC", "Velit facilis veniam.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Marina Mraz", "Esse mollitia corrupti repellat tempora incidunt dolore error facere. Distinctio enim nostrum repellendus exercitationem dolores et qui. Eius tempore iure minima perferendis voluptatem. Nemo expedita sint dolor. Qui necessitatibus ex aut quas voluptatem mollitia ipsam corporis in. Corrupti reprehenderit error temporibus impedit ad culpa iure sit.", 1, "d5121a5d-ca63-3fe5-0788-7e3877771e36", 184, "Mitchell and Sons", "Id fugiat omnis.", null, 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Yolanda Brakus", "Et iste consectetur maiores. Ut eum ea. Et voluptatem ut fuga cupiditate sunt voluptates.", 4, "fb254566-4e15-e631-9678-5581da2e3cdd", 115, "Kerluke - Marvin", "Quis sit tempora.", null });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Sam Russel", "A aut dolorem soluta magni ratione debitis. Suscipit ab animi omnis ut eum occaecati pariatur eaque error. Distinctio libero ducimus quibusdam sit cumque et perspiciatis autem. Debitis officia quia eos quia dolor. Nesciunt et aut ducimus incidunt libero sed iste.", 4, "64045f11-cebb-3617-8348-ed13091adb49", 268, "Emmerich, Weimann and Abernathy", "Laudantium ex saepe.", null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Casimer Stoltenberg", "Et laborum fugiat atque quisquam quia. Dolores sed accusamus. Consectetur aut in laborum delectus aperiam esse molestias. Porro quae id iure atque. Neque doloribus illo nemo voluptatem aliquid.", 4, "44a5a683-8da6-3104-9ef7-236d20a239ca", 329, "Koepp Group", "Suscipit voluptas soluta.", null });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Maida Schowalter", "Quae et dolor ea eos neque libero impedit. Perferendis repudiandae iste vero perspiciatis eos laudantium rem cumque. Id aut tempore dolorum aut itaque. Velit et voluptatibus quis id cumque maxime. Laborum velit quidem doloribus quaerat ea officiis. Non voluptas in veritatis ipsum.", "15843dfb-f87c-b6b8-af17-86b0b68e809a", 275, "Carter, Lesch and Collins", "Voluptas modi molestiae.", null, 2024 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Heidi Mohr", "Sit eligendi aspernatur dignissimos. Laboriosam ut voluptatem ratione iste. Qui omnis voluptatem sint omnis debitis id. Molestias sint earum modi porro non dolorum ut voluptates.", "a4a6ae7c-048d-cbe0-76fd-dc286f890762", 214, "Collier - Daugherty", "Expedita atque accusamus.", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Thelma Spencer", "Nam eum rem beatae ut eveniet ut. Et et modi repellendus omnis eum. Libero illo consectetur corrupti alias eum fuga dolore. Sunt vitae qui nostrum veritatis rerum. Eum doloribus asperiores laudantium molestiae voluptatum non voluptates dolores. Totam nulla quis harum pariatur qui.", "9da56283-cbee-5aa4-ecb1-79e40b174963", 428, "Conn LLC", "Temporibus corporis iusto.", null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Emerson Gutkowski", "Et veniam ut itaque. Ut magnam molestiae officia reiciendis est dicta. Voluptas fugiat a odio maxime porro omnis architecto.", 2, "2419bcbb-4858-d317-d52a-c8e701032115", 164, "Wilderman Group", "Aperiam illum ipsa.", null });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Lavonne Mosciski", "Quasi nam placeat commodi asperiores blanditiis fuga a dolorem dolorem. Vitae ut iusto quos et accusamus ullam pariatur nisi velit. Earum autem non minus in. At autem sunt. Ea quisquam qui dolorem quis veniam beatae nihil vitae quia. Animi voluptates exercitationem.", "7ed6a16c-1486-22cc-2d75-e79a34b2ae76", 122, "Corkery, Gislason and Wiegand", "Soluta deserunt repellat.", null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Harvey Schultz", "Quis ducimus et. Assumenda omnis nobis reiciendis labore quasi iure aut. Voluptate molestiae atque earum beatae omnis quis dignissimos nam porro.", 2, "6a6f60de-f6c6-d689-7b6a-a624940726ea", 349, "Schroeder, Fisher and Von", "Expedita qui sit.", "3", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Jason Mraz", "Qui fuga rerum accusamus cum id. Unde maiores error pariatur expedita. Ut omnis omnis sunt error. Odio et laborum ad.", 5, "26d27b0e-c70f-a2bd-3281-63295dd4d935", 413, "Hermann, Marvin and Fadel", "Consequatur qui praesentium.", "4", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Elsa Jakubowski", "Aliquid non dignissimos tenetur. Ut aut velit non quos laudantium et ipsum. Voluptas possimus est quos aut provident quis at esse. Ducimus ut voluptates. Et tenetur voluptatem magnam nihil saepe praesentium fugit fugit voluptate.", 4, "3c7cd7e4-362d-a226-444c-cd6e79882f3a", 274, "Keebler - Larson", "Dolores aut quia.", "0", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Coleman Shanahan", "Quos sint quia iure blanditiis ea ut a dolores molestias. Dicta voluptatem velit quis ipsum consectetur aut unde amet eaque. Et laudantium vel. Cum sit incidunt voluptates id id in. Temporibus aut quasi. Soluta earum maxime modi perspiciatis.", 3, "060b6da1-2f1b-799c-ecae-19e99c02c872", 378, "Crist - Torp", "Similique voluptatem excepturi.", "1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Rachelle Lockman", "Et qui molestiae voluptates recusandae accusamus ducimus quasi fugiat. Vel nam vel. Id nemo aut tenetur asperiores laudantium ipsa dolore.", 3, "f04dca1d-bf56-cbe9-e28d-f466b3f73231", 145, "Stroman, Klocko and Pfeffer", "Odit aliquam in.", "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Ima Schaden", "Est iste voluptatem consequatur nesciunt esse nostrum rerum cupiditate et. Eaque vel ratione esse. Animi voluptas ea natus iste. Dicta tenetur impedit quisquam asperiores. Et ullam aperiam dolorem nihil maiores deserunt atque animi sequi.", 3, "2356a86c-63cc-b701-2a5d-81b218dfffa1", 323, "Johns LLC", "Temporibus et unde.", "4", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId" },
                values: new object[] { "Cleo Thiel", "Nihil incidunt voluptas ullam et et et id soluta. Qui laborum eveniet asperiores labore eos voluptas maxime repellendus. Ea veniam sed dolor ratione tempore. Qui possimus eos minus omnis deserunt officia.", 5, "f97f3752-5c2c-a32e-9cc1-db9ee26c55f4", 253, "Ullrich LLC", "Recusandae sapiente quaerat.", "3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Geovanny Harber", "Quisquam et et quam deleniti nihil aut eos dolor. Qui esse minus consequuntur accusamus deserunt occaecati facilis quia reiciendis. Tempore voluptate laborum culpa non qui. Eveniet qui quo. In sapiente qui.", "cb2a3037-85f9-61f9-0dba-4b2717d1d623", 400, "Schiller Group", "Sit nesciunt quae.", "4", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Mae Pfeffer", "Dolorem omnis repellat omnis doloremque. Totam sequi omnis. Dignissimos impedit dolorem et harum. Ut repellendus earum culpa pariatur aspernatur non molestiae et. Ipsum odio rerum tenetur eum ducimus molestiae odio nisi rerum. Quia omnis vel ullam error ut ut.", 3, "78786250-ef42-ad79-584b-5a42a1edabec", 281, "Dietrich - Dare", "Harum explicabo quo.", "1", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "Year" },
                values: new object[] { "Kurtis McDermott", "Eligendi rerum qui dolorem. Rerum voluptas velit eligendi quidem porro. Et ipsa molestiae. Est nemo id laboriosam. Aliquam maxime nemo voluptas neque accusamus et aut.", 4, "6177c928-fe27-ed5a-5d7e-023d53163734", 213, "Jacobi LLC", "Excepturi sunt laboriosam.", "4", 2023 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "b37fbbad-1bd7-456d-baf3-132b5242ae5e", "Misty.Romaguera56@hotmail.com", "Misty", "Romaguera", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1156.jpg", "5edab6fe-a955-45d0-80d6-3729466977aa", "Misty.Romaguera" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "808837fa-b7c6-4142-97c6-1c43c8b53972", "Emanuel15@hotmail.com", "Emanuel", "Johns", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/498.jpg", "2e28aadf-263f-439b-bf60-ce46a2696687", "Emanuel.Johns" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "b36c5c44-b66a-453c-91e6-98e15411e425", "Tom.Kemmer@yahoo.com", "Tom", "Kemmer", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/86.jpg", "2a39116c-4f79-4060-a2fa-26b7f866652a", "Tom.Kemmer94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "0c378bea-2f1c-4790-ac6d-6180b6675a45", "William_Adams@hotmail.com", "William", "Adams", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/474.jpg", "10368bef-9f97-4d78-9879-29d555df27b8", "William.Adams" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "26ba7f50-5803-4ce0-9a0d-101f3cec5ec8", "Lola_Rolfson@yahoo.com", "Lola", "Rolfson", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/443.jpg", "21f0f3ef-edd3-45d0-ab9a-722cad55140a", "Lola_Rolfson" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Osborne Gleichner", "Expedita voluptatem quisquam eos quibusdam quia in distinctio corrupti omnis. Ipsam dolores aspernatur voluptatem esse reiciendis consectetur consequuntur ab ea. Provident ratione in quasi delectus.", 2, "6ac87e7e-81bb-c5d5-30d2-8c33c4ccac2b", 290, "Batz, Hyatt and Baumbach", "Amet cupiditate sed.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Reinhold Harber", "Soluta accusamus distinctio cumque aut repudiandae dolore eveniet vitae repellendus. Earum quo illum aut qui recusandae qui architecto quos delectus. Eos saepe quia culpa. Sit deleniti mollitia sed et nihil. Aut enim quam ut doloribus asperiores enim. Fuga expedita iste amet veniam tenetur et aspernatur asperiores.", 5, "1407537b-1a11-3d8b-34ad-8bf884e56898", 419, "Bosco LLC", "Et officia magni.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Maritza Wuckert", "Sapiente dolor assumenda. Vel aut non magni dicta molestiae. Saepe quia nihil dolores esse aut aspernatur sed numquam.", 5, "a6bb629b-2caf-dcd1-0b04-a3f892fa0302", 460, "Gusikowski LLC", "Reiciendis perferendis error.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Ceasar Kuhn", "Ullam eligendi sed eos nisi expedita soluta in. Ab labore tenetur ipsum aliquam mollitia expedita dolorem sint officiis. Excepturi error distinctio non quam nemo et iusto dolores. Odio cupiditate consectetur incidunt est qui autem. Consequatur cum ut quo.", 1, "8940bc68-46b7-298c-6121-7e43859f3981", 345, "Schiller and Sons", "Blanditiis similique quis.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Zena Mante", "Laudantium dolores necessitatibus unde consequatur itaque. Rerum laudantium qui expedita nemo commodi corrupti et. Rem sint recusandae tempora debitis similique vitae aut et.", "fea18b52-e5f7-6e3b-25b1-8737d21bd38f", 284, "Champlin Group", "Fugit nobis velit.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Hattie Howell", "Tenetur eum cupiditate. Eum dolor rerum beatae repellendus. Natus qui at et dolorem enim enim quibusdam. Iste vel modi autem quod. Et inventore alias ut commodi ab dignissimos est ut. Optio in officiis rerum ut id id.", 3, "a3a10999-c8cd-9ed8-1c40-b7277ea757a0", 382, "Hintz Group", "Dolorem rerum sed.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Thelma Witting", "Neque velit ducimus sint ut quos soluta consequatur. Facilis sint impedit ut. Ipsa est consequatur debitis commodi omnis nihil natus in. Qui repudiandae qui voluptate modi.", 1, "1dc522af-acd8-e89a-a4d3-5cb2bce9975f", 223, "Rau, Schaefer and Sawayn", "Qui error voluptas.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Beulah Bruen", "Soluta id et aut odit eum a excepturi dolore odio. Dignissimos voluptas soluta et impedit quo voluptatibus rerum quibusdam. Excepturi eaque nam veritatis voluptatum. Magnam consequuntur quis molestiae consequuntur architecto suscipit laborum qui perspiciatis. Reiciendis maxime natus voluptatum aut.", 1, "8302826a-5581-b45c-3089-c7de837701af", 374, "Graham - Raynor", "Debitis incidunt recusandae.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Gino Towne", "Vitae et nesciunt deserunt molestiae aperiam. Minima tenetur aut laboriosam soluta ea natus quidem consequatur quasi. Eum quae dolorum nam aperiam sunt voluptatibus qui eaque. Aliquid delectus illum deleniti aut vel eaque enim facere et.", 2, "8c52533e-91be-cd1e-f742-6fe064795a1c", 494, "Bergstrom, Armstrong and Cassin", "Sit quae nisi.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Madilyn Parisian", "Voluptas et sed quia laborum repellat sit. Modi est consequatur reiciendis corporis aut magnam. Veritatis quasi esse quidem est expedita. Illo dolores qui est et in corrupti excepturi. Voluptas est saepe est. Ipsam provident amet laudantium praesentium voluptatem impedit.", 1, "695237e4-9721-bbbc-3c8e-d4c96784e44e", 259, "Osinski, Block and Kling", "Officia qui modi.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Bette Jenkins", "Animi non nihil aperiam. Consequatur reiciendis quas. Doloremque saepe placeat delectus corrupti tempore nulla aliquid mollitia vero.", 3, "37bc3b08-9ac9-785e-05bd-2e31394e34af", 164, "Walter - Lemke", "Nobis error dicta.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Else Ondricka", "Fugiat magni ipsam distinctio excepturi necessitatibus deleniti eum doloribus odio. Perspiciatis aut cumque deleniti dolor commodi. Rerum qui et officiis molestiae non nihil tempora. Aut iusto nostrum molestiae nam nihil. Officiis aut ut itaque quae sit. Quia consequatur quis itaque aut expedita incidunt qui error.", 5, "389e6aac-2940-5fe8-427c-ef512b7f2693", 250, "Kovacek and Sons", "Quo qui atque.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Demetris Moore", "Reprehenderit delectus labore tenetur voluptates illo quis. Rerum in nostrum harum aut quibusdam ducimus consequatur. Est consequuntur at. Iure sequi enim molestiae.", "182eee9a-0766-810b-ed4b-4cc83219bffa", 157, "Boyle, Bartell and Langworth", "Placeat neque eos.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Boris Legros", "Et tenetur soluta in quaerat in. Error dolores ullam animi quam error magni. Culpa aliquid dolore similique. Sit exercitationem ad.", 5, "d33b2688-682d-78f3-2961-a8d4f4aad752", 139, "Turner - Kozey", "Dolorem ad assumenda.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Madison Collier", "Ad aut in illum alias iste sunt. Quia est rem voluptatum delectus. Non et maxime rerum id quaerat ipsam velit.", 4, "24eecdb3-0a5c-6b9b-8ca1-06e2b9b188bd", 389, "Steuber Group", "Est itaque tenetur.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Trinity Bergnaum", "A quibusdam fugiat suscipit laborum quam quas sed quibusdam. Dicta illo qui doloremque sit id qui nam qui. Dolor vel quos rerum maiores veniam dolor numquam. Dolorem rerum quas autem voluptas aperiam.", "ed70bf75-676a-ea70-5b31-02140a1eaa58", 330, "Sauer and Sons", "Voluptas facilis voluptatem.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Oren Conn", "Assumenda velit quam consequatur. Ad veritatis et quo ad adipisci. Sit sunt aut.", "1a408b2e-7c11-fe53-ad61-11bb897741da", 193, "Schuppe, Senger and Koepp", "Aperiam repudiandae nostrum.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Alanna D'Amore", "Quis fugiat sunt velit vel voluptatem. Error sed sunt accusantium dolorem. Temporibus delectus aperiam. Et fugiat nihil libero ullam.", 4, "dc0cab7a-57b6-4fd6-1e66-af51d4887771", 253, "Herman, Kuvalis and Goodwin", "Voluptas sapiente expedita.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Marjory Luettgen", "Facilis suscipit quos nesciunt. Atque debitis quibusdam sit eum non quos. Dolores modi doloribus ipsum ut quos quibusdam quam et alias.", "69f17d63-67d6-2f5e-bf20-a209c5741a10", 272, "O'Hara, Hyatt and MacGyver", "Dicta soluta deleniti.", 0, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Eliane Schoen", "Dolor saepe aspernatur accusantium quasi rerum odit quia ea fugiat. Neque voluptatum dolor et quaerat esse tempore commodi nemo at. Similique et porro ratione molestias ex consectetur dolor consequatur. Beatae quisquam aut et explicabo.", "6799449a-ef3f-ed76-5f0b-2cdf39c62a8a", 394, "Klein, Emmerich and Schimmel", "Voluptas at enim.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Fannie Wisozk", "Sed nemo odio doloremque quasi aliquid. Aut voluptatem reiciendis nobis commodi cumque adipisci. Ut praesentium quisquam atque iusto.", 4, "bba17553-f9cf-b447-55ca-05374686f799", 421, "Rice - Langworth", "Tempore eveniet ipsam.", 4, null, 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Kamron Walter", "Maiores nulla omnis facere et deleniti modi sunt et. Deserunt id eum veritatis. Eligendi magnam optio officia explicabo in aut aut quo.", 4, "009be093-994a-ed0d-e2b0-3ae078ba6ebc", 429, "Altenwerth - Kilback", "Accusantium eveniet ipsam.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Merle D'Amore", "Doloremque animi magnam dolores vel voluptas harum. Rerum est aut repellendus dolores. Vitae fuga ut occaecati dolores reprehenderit. Quod maxime dolor facilis occaecati mollitia unde quod et ab. Aliquid consequatur non neque excepturi velit veritatis. Fugit ut omnis enim rem.", 3, "07e4d352-4a15-359f-33ac-1c3a3f2d9345", 299, "Kessler LLC", "Ad voluptatem consectetur.", 1, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Cullen Kshlerin", "Nam rerum natus tenetur. Cupiditate qui veritatis dolore dolorem modi. Omnis rerum quia. Consequatur et possimus consequuntur. Est fuga omnis placeat est consequuntur repudiandae laborum.", 2, "aedfecf9-4e64-9c07-94ba-2be463186d2c", 489, "Waelchi Inc", "Enim totam aperiam.", 4, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Malcolm Fadel", "Non nihil labore dolores enim. Eum laboriosam ex vel numquam est eveniet. Vel et et eligendi temporibus omnis aperiam perferendis non. Reprehenderit fuga et provident quae illum maxime sequi qui sint. Exercitationem voluptatem voluptas error dolorum fuga.", 1, "86bbccf2-175d-d1f4-55d9-dc076d26ee73", 408, "Predovic, Klocko and Wilderman", "Aut sit quia.", 1, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Lilla Willms", "Ut aut ut deserunt dolor. Ut velit labore impedit nostrum et voluptatem. Ipsum explicabo eveniet molestias. Aliquam facilis quia eum dolores dolor. Assumenda deserunt dolor aut. Assumenda voluptas fugit voluptatem vitae.", 2, "362a42bf-f89a-6809-d9bd-9bec3ba70841", 331, "Windler, Torp and Lynch", "Itaque omnis sunt.", 0, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1" },
                values: new object[] { "Greta Marks", "Omnis sit libero sint et. Necessitatibus quis non sit officia. Error vel similique dolor beatae. Voluptas earum nemo reprehenderit mollitia est nemo autem dolores et. Sunt quia quis. Aut sint et rerum.", 2, "e626b73f-e2ab-7baa-59a3-f8fef8773947", 151, "Roberts - Gerlach", "Quia reprehenderit consequatur.", 0, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Brant Paucek", "Consectetur similique totam. Hic praesentium sed officia nisi ut atque. Consectetur facere ducimus magni reprehenderit repellat sapiente ea enim. Perspiciatis nisi labore hic.", "7ea8bb5b-578f-f2d8-c2b1-b92aa0355bec", 443, "Wiza LLC", "Dolorem at rerum.", 1, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Chelsea Bogisich", "Velit quia autem rerum ut nobis ab. Ullam labore suscipit quod iste omnis. Sapiente illum quaerat enim dolorum et et numquam ea adipisci. Accusantium consequatur beatae perspiciatis. Quia quidem sit et. Doloremque est dolorem voluptatem placeat aut autem.", 5, "2b2e28c6-d1c7-f40f-05b5-fed0dd444573", 451, "Sporer - Balistreri", "Distinctio exercitationem aperiam.", 3, null, 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "UserId", "UserId1", "Year" },
                values: new object[] { "Cale Romaguera", "Ut exercitationem nemo dolorem temporibus eligendi. Perspiciatis vel quaerat et. Eaque nulla ut ipsa qui quisquam adipisci est et facilis. Est suscipit possimus excepturi. Dicta itaque et.", 1, "de153641-57db-556a-f209-ac57f1ed2a79", 458, "Cummerata LLC", "Esse molestias iusto.", 4, null, 2024 });

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
    }
}
