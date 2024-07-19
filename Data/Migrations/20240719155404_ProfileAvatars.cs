using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfileAvatars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Last",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileAvatarId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProfileAvatars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileAvatars", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "0a4ed2b9-da9b-4341-a40b-84a6c5703d0e", "Angie_Howell1@yahoo.com", "Angie", "Howell", 9, "7cc8926f-3064-4d2f-8e25-102335ba990f", "Angie_Howell" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "26c0642f-9722-4cf7-9692-a492cfbda9ae", "Annie78@gmail.com", "Annie", "Gerhold", 15, "16240b5c-5169-49cc-9020-e3a972a25cb3", "Annie_Gerhold50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "719a88ee-8436-4124-a5ba-26b0b7f7f885", "Frances_Pfeffer@gmail.com", "Frances", "Pfeffer", 15, "1a3d4ab3-b76b-4cf2-927c-e0b11b4b9727", "Frances.Pfeffer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "13fe45d2-aa6c-46b3-86f7-7285e2ef9e55", "Melanie60@yahoo.com", "Melanie", "Witting", 18, "4aa294ee-45fb-4be8-9429-88653e4ee07b", "Melanie92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "792b532c-4364-4b54-b2ac-2b3056652261", "Theresa.Prosacco@yahoo.com", "Theresa", "Prosacco", 31, "02382c2b-9376-417d-bc97-8092a1c09680", "Theresa_Prosacco" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 19, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(1950), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 14, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2470), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2480), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2500), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2500), "3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Celine Windler", "Ut vel rerum culpa et modi iste qui nemo illo. A tempora qui fugit odio. Assumenda nulla est et.", 4, "3e6a4808-afa7-a80a-855a-e6d9c423fd54", 260, "Gleichner - Schaden", "Natus et voluptas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maiya Johnston", "Et libero quia ipsum adipisci eveniet. Quos nobis qui rerum provident. Blanditiis dolorem molestiae incidunt quibusdam est id reprehenderit voluptatibus. Fuga facilis vero consequatur.", 4, "1ab2e814-d255-862a-97ee-73ce51d8a597", 427, "Becker Group", "Numquam accusamus ad.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lizeth Wiza", "Praesentium dolorem consequatur rerum sint eum accusantium. Nam quaerat qui omnis ab est quia nihil omnis. Dolor commodi incidunt.", 3, "adab8909-9740-15d0-ff14-5294401a8b24", 345, "Hahn LLC", "Deserunt necessitatibus error." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emery Corkery", "Aut possimus reiciendis dolore quos et dolorem fuga laborum quisquam. Mollitia sit eaque qui temporibus similique. Aut quae ut officiis recusandae hic. Officiis officiis blanditiis iure ut. Est iure quo numquam commodi non nihil cum atque.", 1, "2e01feaa-374f-58dc-3a8c-5f5a0ca6de95", 302, "Runte Group", "Voluptas molestiae totam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ettie Luettgen", "Veritatis repudiandae dolorum aperiam ullam sed ullam libero blanditiis eius. Incidunt voluptatem veritatis voluptate libero autem ex deleniti necessitatibus et. Vel rerum modi debitis tempora ea quia non dicta. Qui distinctio voluptate perferendis aliquam exercitationem reiciendis consequatur et. Cum alias asperiores nesciunt officia quis est. Dolorem molestiae voluptatem aut.", 1, "1e363a09-58aa-9e9e-3b51-556dd224b271", 419, "Casper - Gerhold", "Commodi cupiditate vel.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Frederic Kling", "Velit possimus et veritatis quibusdam facere sint distinctio deleniti accusamus. Rerum iure maxime animi ut ipsam corporis nam impedit. Molestias alias repellat quo.", "51018be9-b0ea-6390-0c78-9dd77c69b44f", 400, "McDermott, D'Amore and Baumbach", "Iste provident possimus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Onie Will", "Modi perferendis eos deleniti. Ut aperiam cumque beatae ipsum sed asperiores reiciendis. Vitae ut corrupti veritatis ut perferendis. Id voluptates dignissimos vitae sit id illum perspiciatis fuga.", 2, "a8b72b83-f035-c877-7205-616f5f57f739", 113, "Sauer, Swaniawski and Bernhard", "Exercitationem quos et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emanuel Nikolaus", "A et aspernatur nostrum facilis repudiandae facilis hic veniam. Quidem perspiciatis non et dicta vel et nulla. Ratione earum aut earum suscipit reiciendis fugit quidem rerum quisquam. Quidem dolorem nihil repudiandae iusto.", 4, "4c36a48e-a715-53b8-1070-ef959e8834ca", 230, "Dibbert - Block", "Dolor qui non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Wilfrid Lebsack", "Voluptatem non facilis omnis est. Veritatis et officia est velit. Accusantium ut aut ullam ratione rerum eligendi qui. Sed architecto ullam ipsum. Sit omnis quibusdam excepturi molestiae. Totam quia porro et voluptas non sequi ut earum.", 2, "796b4f18-91af-1e1a-a0b8-1bb36b82202a", 117, "Berge - Moore", "Aperiam quia mollitia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Shayna Murray", "Harum sunt omnis et distinctio corporis iste nesciunt minima. Beatae earum voluptates repudiandae illo. Incidunt libero cumque odio in saepe totam sed. Nihil labore eius error eius voluptas blanditiis itaque. Amet suscipit quo. Est quae aut iste architecto quis fuga.", 3, "2ce6b5b9-2d52-2e94-ec32-7a6858d4c02e", 411, "Runte - Spencer", "Dicta aspernatur quod.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jett Volkman", "Dicta quod quae quibusdam nam voluptatum incidunt dolore. Nam exercitationem perferendis repellendus omnis aut distinctio corrupti fugit iste. Ut dignissimos dolorum libero sint voluptate id reiciendis deserunt ut.", 2, "6fada230-fcf7-0746-4e1c-20edcc9751af", 390, "Cronin LLC", "Temporibus illo officia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maida Cummerata", "Magnam possimus architecto voluptatem enim sed. Similique odit sequi aut maxime deserunt suscipit. Dignissimos dicta quibusdam perferendis qui ad. Dolore aut facere tenetur voluptatum ducimus asperiores. Soluta et voluptatem laudantium exercitationem odit id dolor aspernatur minima. Optio aut non deleniti eius.", 4, "61fcac7a-aa39-c572-5e6e-267b0f9dec5f", 260, "Haley - Moen", "Incidunt quia minima.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harrison Jacobi", "Repellat expedita deleniti officiis occaecati recusandae. Delectus laudantium aut ipsum consectetur itaque. Et non rem quos odio. Exercitationem ipsum eaque omnis tempore expedita voluptatem aut sunt et. Natus et aliquam ut.", 3, "e69aa06d-bdad-0c0e-afb2-67b83be956ab", 247, "Hermann Group", "Eos eligendi ut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Einar Runte", "Repellat neque labore recusandae. Aut facere sunt aut ut. Explicabo numquam non id. Exercitationem asperiores odio ad nulla eveniet unde ducimus est vel. Delectus voluptatibus maiores.", 5, "df065812-6d5c-e205-b248-087b0c4c74af", 258, "Ankunding - Ferry", "Culpa harum impedit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tristian Schneider", "Qui quia ex. Sapiente ab id. Beatae esse voluptatem et dolores. Aut saepe a enim quo rerum facilis veniam fuga. Possimus ut culpa veritatis sint. Dolor nihil voluptate distinctio.", "7f1d6ac5-9d7c-db8b-f089-a5854c799fd3", 158, "Schultz LLC", "Eos omnis inventore.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Craig Zulauf", "Asperiores rem nihil voluptate non dolores quo quas itaque et. Reprehenderit error est totam in. Itaque praesentium perferendis velit quia. Et et atque sed nesciunt facere sed modi. Rerum et ut possimus et iste. Omnis consequatur non autem aut ad.", "1c81f951-143b-c5df-2eb5-2da48c66276e", 182, "O'Connell - Roob", "Necessitatibus molestias ut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harrison Mueller", "Beatae velit distinctio omnis non sed consequuntur qui. Fugit consequuntur et illum vitae ea et qui et inventore. Ea pariatur fuga nostrum cum quia voluptas reprehenderit.", "e681f3fe-6b64-c421-43f5-afd7449d29e8", 188, "Funk - McDermott", "Ipsum odio porro.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gerard Vandervort", "Recusandae praesentium nobis et officiis necessitatibus. Omnis et magni assumenda veritatis consequatur aut deleniti. Odit harum nulla voluptas doloremque.", 2, "55b6f95f-b408-64e3-b357-b2c0d1f466f6", 107, "Hartmann Group", "Fugiat suscipit est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alford Bogisich", "Laudantium qui quisquam quis ut ut. Quia sint perferendis exercitationem quia rerum illo. Praesentium et illo consequuntur. Omnis omnis et voluptas sit. Rerum iure nulla.", "14997de5-f268-687e-7397-1d95f28d0f37", 199, "Becker and Sons", "Ut voluptas ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Leonardo Simonis", "Unde quia consequatur numquam sint beatae ut magnam saepe deserunt. Fugiat consectetur rerum dolores rerum ea. Modi omnis vel ex cum tempore ad eligendi placeat incidunt. Ea enim necessitatibus facilis magni minima qui culpa ipsam consequuntur. Deleniti ipsa aut sapiente quia tempora eligendi. Doloremque tempore non.", 2, "505a91da-f419-453f-fddb-75091ccc4cfe", 124, "Casper, Jerde and Von", "Recusandae laborum voluptate.", 2023 });

            migrationBuilder.InsertData(
                table: "ProfileAvatars",
                columns: new[] { "Id", "Url" },
                values: new object[,]
                {
                    { 1, "https://robohash.org/1" },
                    { 2, "https://robohash.org/2" },
                    { 3, "https://robohash.org/3" },
                    { 4, "https://robohash.org/4" },
                    { 5, "https://robohash.org/5" },
                    { 6, "https://robohash.org/6" },
                    { 7, "https://robohash.org/7" },
                    { 8, "https://robohash.org/8" },
                    { 9, "https://robohash.org/9" },
                    { 10, "https://robohash.org/10" },
                    { 11, "https://robohash.org/11" },
                    { 12, "https://robohash.org/12" },
                    { 13, "https://robohash.org/13" },
                    { 14, "https://robohash.org/14" },
                    { 15, "https://robohash.org/15" },
                    { 16, "https://robohash.org/16" },
                    { 17, "https://robohash.org/17" },
                    { 18, "https://robohash.org/18" },
                    { 19, "https://robohash.org/19" },
                    { 20, "https://robohash.org/20" },
                    { 21, "https://robohash.org/21" },
                    { 22, "https://robohash.org/22" },
                    { 23, "https://robohash.org/23" },
                    { 24, "https://robohash.org/24" },
                    { 25, "https://robohash.org/25" },
                    { 26, "https://robohash.org/26" },
                    { 27, "https://robohash.org/27" },
                    { 28, "https://robohash.org/28" },
                    { 29, "https://robohash.org/29" },
                    { 30, "https://robohash.org/30" },
                    { 31, "https://robohash.org/31" },
                    { 32, "https://robohash.org/32" },
                    { 33, "https://robohash.org/33" },
                    { 34, "https://robohash.org/34" },
                    { 35, "https://robohash.org/35" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfileAvatarId",
                table: "AspNetUsers",
                column: "ProfileAvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProfileAvatars_ProfileAvatarId",
                table: "AspNetUsers",
                column: "ProfileAvatarId",
                principalTable: "ProfileAvatars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProfileAvatars_ProfileAvatarId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProfileAvatars");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfileAvatarId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileAvatarId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Last",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "First",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "f6efaba8-3d4c-4edf-b114-09e56e6f3971", "Cornelius18@hotmail.com", "Cornelius", "Cummings", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/526.jpg", "5b381ff3-22d4-4bc3-ae78-5d5de45b2a42", "Cornelius_Cummings46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "c49eda4e-1701-4e7f-8339-2dd0de4ecdf3", "Lester75@hotmail.com", "Lester", "Pacocha", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/673.jpg", "e179f811-8ca0-4ccc-a4c0-404706fbb3c7", "Lester_Pacocha29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "dd5280d8-74ab-4901-a27a-d34a7102a2f7", "Ramiro46@yahoo.com", "Ramiro", "Lueilwitz", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/987.jpg", "728d4db1-ab0a-46e8-ba65-1477189c9f8f", "Ramiro_Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "df643fde-ae2c-493e-8ac6-641f1c3cbd3c", "Guadalupe.Koelpin14@gmail.com", "Guadalupe", "Koelpin", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/413.jpg", "b42fb376-18c4-4160-bdb9-afa5b8ebd137", "Guadalupe.Koelpin94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "8b76134b-537e-47da-bd41-bd13bd79645c", "Joann_Mraz@gmail.com", "Joann", "Mraz", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/823.jpg", "bdab2ab2-0e65-48be-b3fd-0935c767b155", "Joann50" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(3640), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4170), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4190), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4200), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4210), "1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alec Mosciski", "In nemo corrupti. Adipisci repudiandae consequatur officia similique. Necessitatibus dolorum cumque asperiores provident ducimus aliquid amet voluptates. Rerum sit nemo reprehenderit qui est doloribus atque eos. Id aliquam nihil.", 3, "d4d8c04f-40d4-ff3b-3a5d-1499fe2d7f9c", 468, "Padberg Inc", "Incidunt et qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rosendo Runolfsdottir", "Ut laborum nulla. Aut ut ex. Et illum nesciunt aut est accusantium ut. Officia nihil quis earum.", 1, "f157f6cb-aac0-9680-1f8b-158f7bde06f2", 245, "Rau LLC", "Sint nulla sed.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maurine Dickinson", "Fuga sint nisi maiores voluptas. Cumque quia incidunt quidem quos eum et reiciendis. Pariatur porro sunt vero atque quia nemo est beatae non.", 2, "b59ac04a-78bb-68f9-4040-4e3728a98954", 288, "Bogisich and Sons", "Explicabo et similique." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Cicero Bechtelar", "Et ut aut ipsa porro. Dolorum est id ut harum. Aut et voluptatem repellat dolor ipsam voluptate quod. Nobis quibusdam laborum sapiente velit suscipit quo.", 4, "5542ce84-25ce-a7fd-5f39-443e24f12ec5", 223, "Jacobson - Schmeler", "Repellat placeat rem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hellen Pagac", "Laboriosam assumenda accusamus nihil optio dolorum ipsa quidem vel. Tempora harum ea. Autem dolores ut tenetur unde ut praesentium et. Facere temporibus ratione dolorem. Perferendis repellendus quae animi voluptatem porro praesentium sapiente tempore illum.", 4, "026e3a03-35cd-f092-4afb-d59ebe0643a6", 326, "Rutherford, Spinka and Sipes", "Distinctio eum aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jerrold Becker", "Distinctio vero magni. Autem repellendus id est et magnam nam quisquam ut. Est aut rerum fugit voluptatem reiciendis ipsam sed quia reprehenderit. Quo nam tenetur. Quidem dolorem sit inventore necessitatibus possimus.", "2d64bf7e-f800-dcf1-43a9-1a834f91ff29", 499, "Labadie - Grady", "Cupiditate doloremque illum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ludwig Morissette", "Excepturi sed nisi placeat et consectetur odio. Id dicta voluptates. Natus eius ut necessitatibus atque architecto illo ad ipsam vero. Quo sint omnis vel optio aut alias ut ea. Omnis natus error consectetur. Et vel delectus labore perspiciatis accusantium.", 5, "e3e89c9e-064f-a4f7-6bde-9e50e2d0d4ac", 308, "Hegmann LLC", "Recusandae est sit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Cali Morissette", "Ut commodi blanditiis quaerat qui beatae non veritatis. Vero laudantium laudantium velit quam consequatur. Modi in eos nobis.", 5, "57cdd10a-83f8-933b-ebd4-f2cd0c9914fb", 406, "McGlynn and Sons", "Et animi quia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jaren Jast", "Eos animi asperiores esse nobis est asperiores libero. Fugit est quia sit. Quia modi saepe id eos est earum voluptas atque. Aut ut accusantium nam consequatur iusto officia omnis sit. Id et eius vel dolorem. Fugit a impedit beatae eos ipsum quasi doloremque.", 4, "d43f2674-ef3c-cf27-52d0-e65dff85e83a", 122, "Nitzsche and Sons", "Est odit nemo.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Pearline Botsford", "Eos at a quas sit odit vitae. Qui at et id sit nihil consequatur aperiam ratione voluptates. Qui soluta eligendi pariatur quia nisi dolor facere aliquid nam. Porro minus repellendus cupiditate. Inventore et debitis rem a rerum quaerat. Sunt qui unde sed atque quia quis id autem.", 4, "65cb2961-5f79-50e2-0497-3b1d629f9100", 381, "Effertz, Strosin and Friesen", "Sequi voluptatem aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rickey Thiel", "Temporibus fugiat suscipit libero fugit nobis assumenda qui vitae accusamus. Ratione mollitia in. Quis dolores sed quo rerum molestiae beatae omnis tenetur rerum. Dolor et rerum et similique dolores deserunt quos. Vel voluptatum ab nihil soluta est. Architecto ratione ea.", 4, "3b1c9823-2d7e-2447-4ab9-4ed56fd15797", 247, "Brakus, Nader and Veum", "Aut magnam quo.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rocky Gerhold", "Ut rerum et doloremque eligendi repellendus. Blanditiis dolorem aut ut enim nam possimus atque qui architecto. Sit eius iusto perspiciatis. Commodi in aut quis ea et beatae eligendi atque ad.", 2, "468e0d0e-bdfc-8096-62e3-286a8fd69258", 392, "Wehner - Bednar", "Voluptas autem placeat.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mackenzie Flatley", "Voluptas culpa sint culpa voluptatem beatae nihil vero sapiente. Numquam vero voluptatem vero quos voluptatem ex enim temporibus. A quia et ex labore. Tempora ea dolores id quia. Cum molestiae quas odio quidem ut.", 1, "dd2351a9-2b2c-8894-1ef3-21ef52814376", 143, "Grimes LLC", "Eaque qui voluptas.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Edmund Watsica", "Earum ut vel sed. Distinctio exercitationem placeat ab tempore. Explicabo perspiciatis dolorem ipsam autem laborum suscipit inventore. Non corrupti omnis.", 1, "95c346a7-7707-48e0-2579-dbf91426451d", 330, "Stokes, Schultz and Baumbach", "Quae nesciunt mollitia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Leland Carter", "Molestiae quidem incidunt illum quidem eos. Aut aut similique numquam suscipit qui dolore. Natus et harum qui debitis.", "d0e18d67-25ec-775d-a981-38a50a97c14a", 341, "Crooks - Swaniawski", "Quia libero officia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Georgianna Dicki", "Maxime excepturi quos quod illo nemo aut. Asperiores quia aut voluptate ut tenetur minima officiis est. Aut facere velit sit veniam.", "d5b56cf9-0184-c723-5bdd-ebecd1b48b58", 339, "Buckridge - White", "Consectetur hic dolores.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ewell Hansen", "Et iste magni velit nam sit quis. Eaque sapiente rerum itaque illo ut. Est at tempore dignissimos incidunt excepturi maxime. Reiciendis dicta quidem dolores eligendi est architecto. Commodi est quibusdam facere est est. Voluptatem earum qui cumque perspiciatis magni alias fugit.", "af919142-673b-6751-71ab-84190ac54148", 203, "Brekke Inc", "Qui cupiditate dignissimos.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hilton Gusikowski", "Quo aliquid animi molestiae ex nostrum. Similique ipsum labore ab consectetur doloribus ut et. Est non quia et pariatur iste quia ab reprehenderit iusto. Impedit quia perspiciatis maxime voluptatem nesciunt id officia explicabo veniam. Magnam velit velit laboriosam quae similique sunt odit aspernatur delectus. Itaque sed itaque temporibus.", 3, "de3318de-9872-949c-54c0-d5de02fde375", 145, "Strosin - Nitzsche", "Officiis inventore eligendi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Erick Hirthe", "Expedita atque necessitatibus inventore. Voluptate nisi nisi qui ea nulla magni iure quod iusto. Error sed rerum itaque veritatis autem. Similique illum et cumque accusantium omnis.", "98c3b0a3-e3c8-7b9f-5fe1-02a1f517c107", 259, "Leuschke - Rutherford", "Sed minima qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kitty Cassin", "Error accusantium corporis fugiat officiis consequatur. Accusamus nam dolor alias quidem odit atque dolores id similique. Architecto ut saepe quaerat voluptatem nisi consequuntur quis. Modi consequuntur neque.", 1, "6a807ea4-1dc0-dbab-f448-eb4969fa6507", 478, "Runte - Bins", "Nobis sed non.", 2024 });
        }
    }
}
