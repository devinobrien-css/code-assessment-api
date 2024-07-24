using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewerId",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "4d96b67f-31fd-49e0-97cf-921460b0c339", "Charlene_Cummerata@yahoo.com", "Charlene", "Cummerata", 35, "61c62d02-939e-40e5-bf67-f23c12519fc1", "Charlene.Cummerata4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "6b49708e-8726-4a80-ac6f-cf1a4759777c", "Bethany46@hotmail.com", "Bethany", "Feest", 5, "a34898ba-3cf6-41a0-a57e-48034ec763bf", "Bethany.Feest15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "cddc60c5-a0c2-4570-a0a2-d66e82686d05", "Amanda_Hammes49@gmail.com", "Amanda", "Hammes", 34, "d64e0970-9a8d-40e5-ad33-0eb538dbc0f6", "Amanda93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "a0b87fc9-f525-4306-8f7a-065f484084c0", "Rex99@yahoo.com", "Rex", "Ratke", 25, "bb4bbf6d-9aef-42fd-a9cb-9499c51ebd97", "Rex.Ratke61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "211909f2-dd83-46d8-bc2e-d47cb028af23", "Erica_Champlin94@hotmail.com", "Erica", "Champlin", 15, "14e5ecef-34aa-4168-afde-0fbadbae3bc5", "Erica.Champlin" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 14, new DateTime(2024, 7, 19, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 7, 24, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(9910), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 8, new DateTime(2024, 7, 19, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 7, 24, 23, 8, 53, 757, DateTimeKind.Local).AddTicks(410), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 8, new DateTime(2024, 7, 19, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 7, 24, 23, 8, 53, 757, DateTimeKind.Local).AddTicks(430), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 17, new DateTime(2024, 7, 19, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 7, 24, 23, 8, 53, 757, DateTimeKind.Local).AddTicks(440), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 17, new DateTime(2024, 7, 19, 23, 8, 53, 756, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 7, 24, 23, 8, 53, 757, DateTimeKind.Local).AddTicks(450), "1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Sydnee Luettgen", "Commodi soluta eveniet. Voluptatem ratione in ad atque est eum pariatur minima. Qui est at excepturi iure in velit. Quo cumque eius quia consequuntur et repellat. Aut quidem est est.", 5, "2f96bb1a-9d65-7245-a748-5ef34ab39bb3", false, 362, "Murphy, Kunze and Ledner", "Qui est eveniet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kaitlin Bosco", "Quos id ut laudantium veritatis odit et nulla distinctio voluptatibus. Esse assumenda deleniti aliquam numquam recusandae similique autem quidem vero. Molestiae et doloremque non ea laudantium corrupti. Repudiandae cumque laboriosam eaque fuga. Saepe aut ut incidunt molestias voluptatibus blanditiis reiciendis amet.", 5, "4c18f186-793f-b06d-8d6b-fe37660305b7", true, false, 450, "Wuckert - Murray", "Alias sapiente iure.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Zula Rogahn", "Dolor voluptas quis dolor rerum voluptatibus deserunt repudiandae incidunt. At architecto enim adipisci tempora molestiae accusamus eligendi aut provident. Quasi debitis iste et labore dignissimos quis molestiae consequuntur. Facere id velit sed. Odio ratione cum molestiae amet nam optio omnis odio. Excepturi quis voluptatem.", 5, "8e5aa50a-38a0-2838-86b6-22fbf7685f60", 209, "O'Connell LLC", "Minima delectus reiciendis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Keshaun Bogisich", "Voluptatem sit et qui soluta accusantium. Voluptate velit vitae eaque quia accusamus veniam incidunt. Maxime rerum voluptatem sed pariatur hic autem. Sit sequi rem voluptates dolorem unde rerum.", "39432f0f-6949-428b-404a-d05f67ab264c", true, 458, "Beer, Walker and O'Keefe", "Qui et velit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Angel Will", "Asperiores corrupti error tenetur ullam est optio. Nostrum et delectus quis sint saepe et autem voluptatem. Tenetur aliquid deserunt facilis maiores ut qui harum nihil eius. Magni a tempora magni sed. Dicta neque velit deleniti quae odio quibusdam maiores rerum. Qui eveniet reiciendis hic qui.", 4, "99c392d9-d2bd-646f-bb67-3b4491bdf408", 230, "Stanton - Weimann", "Porro illum quibusdam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kenya Purdy", "Excepturi recusandae sint unde in. Neque veniam numquam nesciunt aperiam eos ut temporibus. Odit rem sit tenetur. Ratione excepturi illo. Laudantium qui veritatis quis fugit officia aut rerum iure laborum. Facere sed nihil sit quae sunt fugit.", 1, "db429b9c-ba60-c4f2-d826-39e82711608d", 105, "Pouros - Greenholt", "Sed et omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Felicia Abshire", "Sit dicta vel voluptatem quam unde cum aut. Voluptatum dolores doloremque qui vel et minus vel eaque. Vel voluptatibus ad officiis sequi dolores debitis ex. Et dolore sit doloremque error nostrum reprehenderit asperiores dolorem quia.", 5, "a64b7635-3832-38d1-1a1c-9213cb8504d8", false, 403, "Feest - Erdman", "Dolor quam rerum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Marquis Daniel", "Quidem dolorem est harum. Molestiae voluptates tempora aliquid autem repellendus ipsum ducimus. Corrupti aut provident qui et et dolorum libero odio. Commodi numquam veritatis. Aut maiores officia tempora facilis odit. Vero maiores illo quod odit aspernatur fuga perferendis consequuntur.", 2, "bec2ceff-f790-2e60-6f58-7f7f3d027ae9", false, 309, "McLaughlin - Gleichner", "Officiis esse quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rosa Gleason", "Reiciendis consectetur dolor error. Impedit sunt deleniti quo mollitia totam est. Vel atque dolores est quod consequatur ipsa aliquid. Earum quas quasi.", 1, "92d167f0-617f-f2d1-cd32-a7410a07229c", false, 348, "Casper Inc", "Fugiat quibusdam dolores.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sibyl Little", "Nihil fugiat occaecati animi reprehenderit perspiciatis voluptatem laudantium perspiciatis. Id mollitia quaerat dolores aut quis rerum omnis error consequuntur. Dolorem expedita quibusdam accusantium quasi illo aut nesciunt sint eaque. Ut dolorem velit deleniti repellat facilis.", 4, "384e2970-fe0e-104d-e34c-9bf60d8278ed", 404, "Yundt, Deckow and Lockman", "Nihil natus et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Kayli Brakus", "Laboriosam omnis est nihil adipisci. Voluptatem inventore quia saepe saepe assumenda qui earum et. Ut perferendis corporis at alias facilis aut et.", 4, "9d35867a-9a2d-1de7-61e5-32b6a5d2a7c1", true, false, 207, "Christiansen, Lang and Brown", "Debitis eum aspernatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Easter Rohan", "Alias aut placeat optio. Itaque et est et rerum earum illo et dolorum. Quia odit cumque qui.", 2, "01f46e10-1b73-7823-564e-f89cd5b3c184", true, 265, "Larson, Kertzmann and Roberts", "Minima enim repudiandae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Camron Schmeler", "Et harum minus. Itaque velit molestiae. Dolorem velit unde sint numquam sed consequatur aut. Quaerat vel quos sunt blanditiis consequatur voluptate ut exercitationem quia. Harum laboriosam odio dolor cumque impedit quia quis.", 4, "e905bb00-b476-f809-a3fa-ae781d923e88", false, true, 205, "Weissnat - Tillman", "Quia architecto corporis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Zella D'Amore", "Illum et odio eos repellat quia eius nihil eligendi possimus. Laboriosam ut non aut debitis. Suscipit fugit molestias odit necessitatibus. Enim fuga voluptas. Nisi neque omnis vel est assumenda doloribus. Accusantium atque atque doloremque quo iusto accusamus quo eligendi corporis.", 1, "0c46b706-7241-abe6-2715-1394fa4d29c9", 280, "Satterfield, Toy and Bergnaum", "Iure distinctio voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Penelope Dooley", "Expedita id aut ut ea. Mollitia suscipit vel dolorem quia. Nemo ut labore ad. Dolorem amet necessitatibus corrupti dolorem commodi.", 4, "f1e5aff7-9b7a-9608-a00e-4950cb241de3", true, 328, "Jones - Durgan", "Vitae in quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Madisen Davis", "Modi alias explicabo commodi et expedita quaerat sed. Iste et sed consequatur explicabo. Veritatis voluptas hic sint explicabo repellat laborum officiis fuga. Unde laudantium impedit necessitatibus eligendi consequuntur consequatur error. Laudantium sequi ipsum.", 1, "fa58855c-cc8d-190a-2d0d-2abaeb9e7a97", true, 228, "Steuber - Johnson", "Est sapiente voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Laila Collier", "Ea dolorem in quibusdam soluta. Occaecati et consequatur aliquam beatae iste dolores corrupti. Quia minima in provident explicabo quidem et laudantium repudiandae iure. Reprehenderit quia aperiam dicta et rerum dolor laudantium esse nulla. Consequatur dolorem dolores aut eum non voluptas consequatur asperiores. Voluptates nam rem eos veritatis rerum quos omnis quo.", 3, "764cd694-12f7-eed5-e9be-e83a0bf1c1c1", true, 166, "Stroman - Christiansen", "Veniam et porro." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Lilliana Block", "Aliquam et corporis voluptatibus a ut culpa. Voluptas exercitationem vel illum laborum mollitia repudiandae impedit explicabo. Corrupti molestiae blanditiis molestiae. Ea ratione consequatur. Dolores qui ullam. Occaecati a sint quis magni voluptatem eum fuga quas.", 1, "13afb7b0-424e-6162-fafc-89a26393ed9b", true, true, 421, "Paucek Inc", "Deleniti sed illum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jakob Nienow", "Qui autem possimus dolor. Voluptatibus et minima natus dolorum sit magnam omnis. Libero quos eos est vel qui sapiente unde tenetur qui. Iusto harum eligendi molestiae nostrum.", 2, "cfd548a1-f696-a609-fcdf-4c16ca12b059", true, 244, "Stiedemann Inc", "Et debitis qui.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Matilda West", "Dolorum inventore itaque odio ipsam a nemo. Enim omnis et. Aspernatur iusto quis aut similique aliquid. Ratione iste saepe labore inventore eos omnis alias.", "53acca8c-6428-7df9-2963-79b497f622e6", 406, "Muller LLC", "Deleniti iusto veritatis." });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "2b2d5c5d-b2a9-46e0-bb57-50ca1b14156c", "Lynette_Labadie72@yahoo.com", "Lynette", "Labadie", 19, "a43cf263-75c6-4d3b-8f81-c1ba4c5d7fe3", "Lynette_Labadie" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "9263fbe0-c0d3-4f61-bc20-b617ab8d5085", "Danny_Gutkowski5@hotmail.com", "Danny", "Gutkowski", 28, "f812736f-ac8c-49a7-a00a-7af9154237f6", "Danny.Gutkowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "cba30aa5-331a-47ec-9a75-c59c224e2e91", "Dominic14@gmail.com", "Dominic", "Denesik", 17, "ce2362a0-d7b5-4f3d-99cc-5ad9066fe331", "Dominic.Denesik77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "afe8d174-9ae4-4b15-b8f5-582587ad6793", "George78@yahoo.com", "George", "Kassulke", 3, "a7ab3707-6af1-4a3e-bf44-0467d482ab31", "George.Kassulke13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "0cfe3504-b798-40da-8b79-e89e342aa409", "Emanuel7@gmail.com", "Emanuel", "O'Hara", 5, "dac468ce-6c7c-43c6-b717-5cb8b7ce82b0", "Emanuel_OHara9" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 8, new DateTime(2024, 7, 19, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 24, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(4350), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 24, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(4840), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 19, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 24, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(4860), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 24, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(4870), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 7, 24, 22, 38, 24, 908, DateTimeKind.Local).AddTicks(4870), "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Daisy Kling", "Fugiat saepe nesciunt molestiae dolor. Recusandae sed perferendis vel facilis officia cumque. Quo quis enim. Debitis non blanditiis unde. Eius eaque aliquam et qui accusantium modi.", 1, "53b6e128-e2e9-c95c-c1e2-a928e77dc91d", true, 238, "Borer - Bechtelar", "Omnis voluptatum quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Julien Conroy", "Modi saepe voluptas quidem vitae. Repellendus et quo ut rerum qui dolore. Sit sunt ea itaque voluptas nihil ab hic quas quisquam. Laborum autem fugit quasi cupiditate. Soluta qui voluptates quas dolorum suscipit et aspernatur non.", 3, "fad38bca-727a-a099-51e6-53dbcb9c03ea", false, true, 476, "Paucek, Prosacco and Ebert", "Maiores non quo.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kaden Koelpin", "Nulla sequi provident. Aut delectus ullam magnam molestiae facilis. Enim et molestias nobis commodi dolorem eaque et repellat ut. Minima corporis doloribus aut. Corporis modi laudantium ad excepturi culpa neque. Eaque earum consequatur iure id vero placeat.", 4, "3fd55129-ef47-935e-21c3-365e70336d1e", 303, "Sawayn, Hayes and Braun", "Assumenda et est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Howell Witting", "Cupiditate quisquam possimus et similique. Provident iusto illo sed doloremque qui provident suscipit sit animi. Quo quod maiores ab suscipit. Voluptatem tenetur aut sit suscipit qui sunt vel.", "6bfd6529-c44d-1cdc-634f-a97e06a60f6a", false, 211, "Senger Group", "Dolorem dolores nulla.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kian Wolff", "Et quaerat qui nemo distinctio nam rerum rerum. Perspiciatis officiis inventore. Assumenda omnis aliquid et omnis. Ea doloribus maiores quo dolore aliquam voluptatem doloremque magnam beatae. Nesciunt laboriosam amet et ea ut inventore sint magni non. Deserunt quos est vel.", 1, "7d08e3b1-91b9-17fd-e995-d2f3251484d2", 159, "Wintheiser LLC", "Consequuntur velit asperiores." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Marcelina O'Kon", "Quo in modi tempora qui veritatis iusto iste laudantium. Sit quo id accusantium rerum eum. Nemo in et non enim. Atque accusamus fuga est dignissimos id.", 3, "51b300b5-5370-67ec-19d1-6eb0c4a38b94", 160, "Wiegand - Wolff", "Earum culpa in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kole Brekke", "Rerum consequatur et dicta et eligendi asperiores. Sit corporis consequatur quo aliquam dolor voluptatem necessitatibus repellat consequatur. Animi nulla modi pariatur natus nam. Fuga facere dignissimos dolorem sit ipsum. Sunt quo sed sunt velit delectus.", 1, "35462f98-0262-f83c-ae69-6db1d9782bb1", true, 264, "Trantow Inc", "Voluptatibus totam repudiandae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Abdiel Bayer", "Dolores in animi. Repudiandae quo natus eos minima adipisci. Pariatur rerum beatae in ut ut ut accusamus autem. Facere officiis vel aut.", 1, "6fff2bac-6c2d-9551-f8a0-69dede240987", true, 496, "McCullough Group", "Nesciunt libero minus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Victor Prohaska", "Est ratione sint quo hic et assumenda dolor atque ex. Et vel cumque similique natus est nihil autem nesciunt ratione. Ea ipsam maxime recusandae sint ea quisquam.", 4, "81831ffa-304c-31ac-9341-53038cf7e911", true, 417, "Weissnat LLC", "Est perferendis aut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bridget Lehner", "Rem similique enim esse saepe. Beatae veniam dolor eligendi. Voluptas labore corporis.", 2, "323fc462-2437-84bd-f95b-edd275bc1fb4", 120, "Rempel - Huels", "In exercitationem dolor.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jovany Stroman", "At animi ratione voluptas quidem dolorum. Dolorem est eveniet sed fugiat architecto cupiditate aspernatur laudantium. Minima vel quas eaque nesciunt commodi. Architecto molestiae a ut et.", 2, "610eb243-a010-2139-0b86-458decb7f229", false, true, 405, "Quigley and Sons", "Maxime maiores facere." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Magnus Hand", "A et consequatur debitis nam natus porro. Quod veritatis est id deserunt qui qui quo distinctio nostrum. Minus dolor ipsa atque maxime sit aut voluptatibus iure. Perferendis officiis id reiciendis aut adipisci autem.", 5, "f748dab5-fee1-de90-efee-fc18330e0b53", false, 171, "Abshire - Ziemann", "Velit eveniet nobis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Murl Towne", "Temporibus repudiandae quia ea eum. Dolores sunt facere voluptatibus animi eum maxime. Aut sequi quia numquam. Unde est maxime enim. Voluptas sed aut hic et impedit.", 1, "460503f8-40d5-08ef-75c0-0d1b5c5e4084", true, false, 144, "Price Group", "Dolorem beatae vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Carlos Smitham", "Repudiandae ut commodi a qui dolorem in quibusdam. Non molestias officiis sed aut. Debitis dolore doloremque beatae pariatur laudantium expedita. Quis vel dolor voluptates. Debitis ut necessitatibus nihil consequatur. Corrupti dignissimos ut dolorem dignissimos non magnam minus ea eveniet.", 5, "5141eaf8-b325-73dd-4667-6c1a8bb7b974", 375, "Satterfield, Strosin and Steuber", "Placeat laborum quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Lew Lebsack", "Consequatur nihil rerum. Sed velit voluptatibus deserunt omnis quaerat. Sunt iusto et maiores. Quasi est in maxime in repellat ipsam qui. Et sed delectus quia occaecati. Qui unde et sequi quo architecto.", 3, "3f1be5de-9fdc-e527-71d8-152e919a279c", false, 208, "Hahn, Batz and Conn", "Et alias minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Arturo Pacocha", "Incidunt dolorem adipisci est in in aut molestiae odit. Reiciendis qui rerum laboriosam praesentium pariatur. Ab excepturi et neque. Voluptas dolor officia ut corporis non sint facilis laboriosam. Sit cum suscipit et qui. Ea voluptate esse qui vel qui voluptatem.", 2, "c6f543eb-a3a4-e175-8201-be284cf7eb66", false, 340, "Farrell - Mante", "Eligendi error impedit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Scot McKenzie", "Consequatur nesciunt rerum maxime. Rem numquam qui recusandae sit laudantium. Corporis similique possimus quos qui tempore ratione deserunt. Voluptas ea consectetur officia tenetur asperiores.", 5, "5ab4e91d-a1bf-cb6d-e390-c87c3079f9fc", false, 263, "Howell - Renner", "Et assumenda aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Walton Effertz", "Similique et non voluptates. Culpa dolorum suscipit et. Eligendi delectus vel aperiam amet dolorem et. Doloribus cumque et. Sunt debitis et omnis iusto unde. Nisi nemo eos perspiciatis similique.", 4, "6fdbb849-e9f1-3d1a-34ff-cfe118971adc", false, false, 413, "Frami Inc", "Reprehenderit aut sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alta Stiedemann", "Omnis et esse harum ex ratione. Culpa eos accusamus et iste. Neque at exercitationem molestias consequatur quidem quam similique magnam nesciunt.", 4, "c1a010c5-f091-1600-ce55-9dbb464205ba", false, 116, "Leannon Inc", "Rem omnis beatae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alana Kuvalis", "Porro quaerat incidunt et quisquam consequatur praesentium placeat. Alias dolores velit rerum ducimus ea quod eligendi. Ut quo eaque consectetur.", "fc512cd2-d4e0-9435-99c1-d18b45559325", 164, "Beer - Schuppe", "Dolor qui exercitationem." });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
