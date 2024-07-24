using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavorites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransaction_AspNetUsers_CheckedInById",
                table: "BookTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransaction_AspNetUsers_CheckedOutById",
                table: "BookTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransaction_AspNetUsers_UserId",
                table: "BookTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransaction_Books_BookId",
                table: "BookTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTransaction",
                table: "BookTransaction");

            migrationBuilder.RenameTable(
                name: "BookTransaction",
                newName: "BookTransactions");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransaction_UserId",
                table: "BookTransactions",
                newName: "IX_BookTransactions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransaction_CheckedOutById",
                table: "BookTransactions",
                newName: "IX_BookTransactions_CheckedOutById");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransaction_CheckedInById",
                table: "BookTransactions",
                newName: "IX_BookTransactions_CheckedInById");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransaction_BookId",
                table: "BookTransactions",
                newName: "IX_BookTransactions_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTransactions",
                table: "BookTransactions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserFavoritesbooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoritesbooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFavoritesbooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavoritesbooks_Books_BookId",
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 19, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 7, 24, 9, 45, 9, 703, DateTimeKind.Local).AddTicks(4210), "1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alec Mosciski", "In nemo corrupti. Adipisci repudiandae consequatur officia similique. Necessitatibus dolorum cumque asperiores provident ducimus aliquid amet voluptates. Rerum sit nemo reprehenderit qui est doloribus atque eos. Id aliquam nihil.", 3, "d4d8c04f-40d4-ff3b-3a5d-1499fe2d7f9c", 468, "Padberg Inc", "Incidunt et qui.", 2023 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maurine Dickinson", "Fuga sint nisi maiores voluptas. Cumque quia incidunt quidem quos eum et reiciendis. Pariatur porro sunt vero atque quia nemo est beatae non.", "b59ac04a-78bb-68f9-4040-4e3728a98954", 288, "Bogisich and Sons", "Explicabo et similique.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Cicero Bechtelar", "Et ut aut ipsa porro. Dolorum est id ut harum. Aut et voluptatem repellat dolor ipsam voluptate quod. Nobis quibusdam laborum sapiente velit suscipit quo.", "5542ce84-25ce-a7fd-5f39-443e24f12ec5", 223, "Jacobson - Schmeler", "Repellat placeat rem." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jerrold Becker", "Distinctio vero magni. Autem repellendus id est et magnam nam quisquam ut. Est aut rerum fugit voluptatem reiciendis ipsam sed quia reprehenderit. Quo nam tenetur. Quidem dolorem sit inventore necessitatibus possimus.", 2, "2d64bf7e-f800-dcf1-43a9-1a834f91ff29", 499, "Labadie - Grady", "Cupiditate doloremque illum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Ludwig Morissette", "Excepturi sed nisi placeat et consectetur odio. Id dicta voluptates. Natus eius ut necessitatibus atque architecto illo ad ipsam vero. Quo sint omnis vel optio aut alias ut ea. Omnis natus error consectetur. Et vel delectus labore perspiciatis accusantium.", "e3e89c9e-064f-a4f7-6bde-9e50e2d0d4ac", 308, "Hegmann LLC", "Recusandae est sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cali Morissette", "Ut commodi blanditiis quaerat qui beatae non veritatis. Vero laudantium laudantium velit quam consequatur. Modi in eos nobis.", 5, "57cdd10a-83f8-933b-ebd4-f2cd0c9914fb", 406, "McGlynn and Sons", "Et animi quia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jaren Jast", "Eos animi asperiores esse nobis est asperiores libero. Fugit est quia sit. Quia modi saepe id eos est earum voluptas atque. Aut ut accusantium nam consequatur iusto officia omnis sit. Id et eius vel dolorem. Fugit a impedit beatae eos ipsum quasi doloremque.", 4, "d43f2674-ef3c-cf27-52d0-e65dff85e83a", 122, "Nitzsche and Sons", "Est odit nemo." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Rickey Thiel", "Temporibus fugiat suscipit libero fugit nobis assumenda qui vitae accusamus. Ratione mollitia in. Quis dolores sed quo rerum molestiae beatae omnis tenetur rerum. Dolor et rerum et similique dolores deserunt quos. Vel voluptatum ab nihil soluta est. Architecto ratione ea.", 4, "3b1c9823-2d7e-2447-4ab9-4ed56fd15797", 247, "Brakus, Nader and Veum", "Aut magnam quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Rocky Gerhold", "Ut rerum et doloremque eligendi repellendus. Blanditiis dolorem aut ut enim nam possimus atque qui architecto. Sit eius iusto perspiciatis. Commodi in aut quis ea et beatae eligendi atque ad.", 2, "468e0d0e-bdfc-8096-62e3-286a8fd69258", 392, "Wehner - Bednar", "Voluptas autem placeat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Mackenzie Flatley", "Voluptas culpa sint culpa voluptatem beatae nihil vero sapiente. Numquam vero voluptatem vero quos voluptatem ex enim temporibus. A quia et ex labore. Tempora ea dolores id quia. Cum molestiae quas odio quidem ut.", 1, "dd2351a9-2b2c-8894-1ef3-21ef52814376", 143, "Grimes LLC", "Eaque qui voluptas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Edmund Watsica", "Earum ut vel sed. Distinctio exercitationem placeat ab tempore. Explicabo perspiciatis dolorem ipsam autem laborum suscipit inventore. Non corrupti omnis.", 1, "95c346a7-7707-48e0-2579-dbf91426451d", 330, "Stokes, Schultz and Baumbach", "Quae nesciunt mollitia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Leland Carter", "Molestiae quidem incidunt illum quidem eos. Aut aut similique numquam suscipit qui dolore. Natus et harum qui debitis.", 4, "d0e18d67-25ec-775d-a981-38a50a97c14a", 341, "Crooks - Swaniawski", "Quia libero officia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Georgianna Dicki", "Maxime excepturi quos quod illo nemo aut. Asperiores quia aut voluptate ut tenetur minima officiis est. Aut facere velit sit veniam.", 2, "d5b56cf9-0184-c723-5bdd-ebecd1b48b58", 339, "Buckridge - White", "Consectetur hic dolores.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Ewell Hansen", "Et iste magni velit nam sit quis. Eaque sapiente rerum itaque illo ut. Est at tempore dignissimos incidunt excepturi maxime. Reiciendis dicta quidem dolores eligendi est architecto. Commodi est quibusdam facere est est. Voluptatem earum qui cumque perspiciatis magni alias fugit.", 2, "af919142-673b-6751-71ab-84190ac54148", 203, "Brekke Inc", "Qui cupiditate dignissimos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hilton Gusikowski", "Quo aliquid animi molestiae ex nostrum. Similique ipsum labore ab consectetur doloribus ut et. Est non quia et pariatur iste quia ab reprehenderit iusto. Impedit quia perspiciatis maxime voluptatem nesciunt id officia explicabo veniam. Magnam velit velit laboriosam quae similique sunt odit aspernatur delectus. Itaque sed itaque temporibus.", 3, "de3318de-9872-949c-54c0-d5de02fde375", 145, "Strosin - Nitzsche", "Officiis inventore eligendi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Erick Hirthe", "Expedita atque necessitatibus inventore. Voluptate nisi nisi qui ea nulla magni iure quod iusto. Error sed rerum itaque veritatis autem. Similique illum et cumque accusantium omnis.", 4, "98c3b0a3-e3c8-7b9f-5fe1-02a1f517c107", 259, "Leuschke - Rutherford", "Sed minima qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kitty Cassin", "Error accusantium corporis fugiat officiis consequatur. Accusamus nam dolor alias quidem odit atque dolores id similique. Architecto ut saepe quaerat voluptatem nisi consequuntur quis. Modi consequuntur neque.", 1, "6a807ea4-1dc0-dbab-f448-eb4969fa6507", 478, "Runte - Bins", "Nobis sed non.", 2024 });

            migrationBuilder.InsertData(
                table: "UserFavoritesbooks",
                columns: new[] { "Id", "BookId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "1" },
                    { 2, 2, "1" },
                    { 3, 3, "1" },
                    { 4, 4, "1" },
                    { 5, 5, "1" },
                    { 6, 4, "2" },
                    { 7, 5, "2" },
                    { 8, 6, "2" },
                    { 9, 7, "2" },
                    { 10, 8, "2" },
                    { 11, 9, "2" },
                    { 12, 1, "3" },
                    { 13, 2, "3" },
                    { 14, 3, "3" },
                    { 15, 4, "3" },
                    { 16, 5, "3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoritesbooks_BookId",
                table: "UserFavoritesbooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoritesbooks_UserId",
                table: "UserFavoritesbooks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_AspNetUsers_CheckedInById",
                table: "BookTransactions",
                column: "CheckedInById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_AspNetUsers_CheckedOutById",
                table: "BookTransactions",
                column: "CheckedOutById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_AspNetUsers_UserId",
                table: "BookTransactions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_Books_BookId",
                table: "BookTransactions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_AspNetUsers_CheckedInById",
                table: "BookTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_AspNetUsers_CheckedOutById",
                table: "BookTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_AspNetUsers_UserId",
                table: "BookTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_Books_BookId",
                table: "BookTransactions");

            migrationBuilder.DropTable(
                name: "UserFavoritesbooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTransactions",
                table: "BookTransactions");

            migrationBuilder.RenameTable(
                name: "BookTransactions",
                newName: "BookTransaction");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransactions_UserId",
                table: "BookTransaction",
                newName: "IX_BookTransaction_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransactions_CheckedOutById",
                table: "BookTransaction",
                newName: "IX_BookTransaction_CheckedOutById");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransactions_CheckedInById",
                table: "BookTransaction",
                newName: "IX_BookTransaction_CheckedInById");

            migrationBuilder.RenameIndex(
                name: "IX_BookTransactions_BookId",
                table: "BookTransaction",
                newName: "IX_BookTransaction_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTransaction",
                table: "BookTransaction",
                column: "Id");

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 11, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 6, new DateTime(2024, 7, 18, 20, 51, 52, 925, DateTimeKind.Local).AddTicks(8680), new DateTime(2024, 7, 23, 20, 51, 52, 926, DateTimeKind.Local).AddTicks(1260) });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Liliana Lockman", "Rerum sed dolorem explicabo sapiente excepturi qui et qui. Dolores ducimus sed iste iste. Recusandae aperiam porro laudantium dolor. Molestiae voluptas enim magnam facere.", 5, "5f1f504d-8256-ed15-82df-11034653e4c6", 297, "Heidenreich and Sons", "Doloremque magni laudantium.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gene Doyle", "Quo sint quam. Praesentium reiciendis et omnis quaerat id autem quia hic. Tempora mollitia modi velit ut enim perspiciatis rerum dicta magni. Nulla qui eligendi officia corporis. Omnis minus velit. Sit et sed quisquam modi doloremque non.", 5, "5d09887f-3d8e-b808-b8c3-be15edde6311", 222, "Kuvalis LLC", "Maiores enim excepturi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Amely Cormier", "Est blanditiis rerum temporibus ipsam. Voluptatem eum recusandae. Libero laborum cumque minus sunt non suscipit recusandae. Praesentium nemo voluptatem cum odit.", "936a3dfd-8f23-e4ad-275c-66358a458dcc", 318, "Lockman, Bernier and Sipes", "Quo sed adipisci.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Delpha Swift", "Est illo adipisci beatae et neque omnis. In placeat vero eligendi neque qui est. Et dolorem in.", "7fda4aa0-3bed-7d82-e18a-def4e6192c5e", 431, "Schinner, Jakubowski and Ondricka", "Voluptatem aut qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annamarie Leannon", "Temporibus non unde rerum magni itaque facilis quo. Corporis possimus animi non dolores eaque quod est corporis. Voluptatem laboriosam deserunt sit aliquid ipsa. Omnis odio laborum quaerat aliquid deleniti voluptate architecto. Est dolores cumque ea. Dolorum eveniet illum quo qui.", 1, "8ec87c51-6917-ddb7-21d2-85a75eb6099a", 360, "DuBuque - Hansen", "Voluptas qui sapiente.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Robyn Bruen", "Ut neque occaecati qui ad. Possimus tempore aut earum facilis quo autem veritatis ab. Enim doloribus aut dolores accusamus eligendi aut a omnis omnis. Fugit cumque et est.", 3, "122f66d1-f199-b94b-a050-d77a8492ddf9", 156, "Cole Inc", "Repellendus ut enim.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Rafael Schuster", "Quia voluptates et blanditiis tempora suscipit tempore. Aut qui unde tenetur ab tempora facere qui magnam architecto. Optio nemo nostrum voluptatem. Quod est dignissimos.", 1, "d1b328ee-ab00-bc27-1dee-e56997ac83ea", 330, "Abernathy Group", "Enim aut voluptas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jayce Kirlin", "Cumque quod quod praesentium at reiciendis fugiat. Sequi ut rem commodi nemo sequi et. In possimus sequi.", 3, "4dcda713-3af8-2743-c200-5f5405121e31", 170, "Lesch, Graham and Fay", "Et ab quibusdam.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Freddy Boehm", "Unde omnis dolores libero est. Veniam ea cumque rem quo omnis et dolorem laboriosam aut. Veritatis voluptatem eos dolores. Quaerat iure perferendis qui qui voluptatem impedit harum aut. Nisi deserunt quam nemo doloribus molestiae quia id doloribus consequatur.", 4, "c30d1f25-6cd3-438c-a9eb-c05d69f21dfd", 250, "Ebert, McDermott and Koelpin", "Amet praesentium consequuntur.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Genevieve Smith", "Sapiente nostrum laborum dolorem error beatae qui. Nesciunt excepturi reiciendis sequi iusto veniam ipsa. Voluptatum omnis cum perferendis aut vel ut sit porro. Dolor non quas et veritatis harum magni ea consequatur non.", 5, "9dad30a6-38d5-1704-7be2-75decaf820ab", 453, "Beatty LLC", "Dolorem odit molestiae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Vivian Fay", "Earum eos possimus delectus quia provident nihil tempore quia. Consequatur recusandae et explicabo illum accusamus vel. Nihil blanditiis quia enim aperiam et quas deleniti saepe qui. Perferendis reiciendis dicta.", 3, "5f6e2d39-18a9-18e0-bb32-d13cbba19d6b", 255, "Cassin - Abshire", "Corrupti optio sit.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Everette Kassulke", "Impedit et aut et ut est id corrupti ut ad. Ut veniam quibusdam non illo atque quam. Ut et a qui. Est non quia.", 4, "5e0870d4-71a0-b054-2140-8ef833a2d0f3", 478, "Hane, Thiel and Kassulke", "Quibusdam et ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Shanie Koelpin", "Labore quibusdam id non quam id illum aut modi non. Quam est architecto est. Iusto ex sit molestias. Tempora sint fuga labore esse autem.", 4, "b05ad9de-f202-183b-e989-35b7f4de2a39", 327, "Welch Inc", "Itaque exercitationem sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jalyn Morissette", "Sequi veritatis reiciendis ut ipsa eos delectus sequi. Voluptas quos omnis dolor accusamus quod. Dolorem est adipisci autem omnis provident dignissimos. Nihil qui laudantium et ut.", 3, "5ed2ab6e-9123-a8db-13f0-1633a5c18280", 448, "Kessler, Hayes and Olson", "Ipsa eos placeat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chloe Berge", "Cum animi dignissimos vero quidem officia qui cumque. Quae officiis vitae magni voluptatibus non ut voluptas. Optio laboriosam eligendi a aut minus est minus voluptates. Sed unde provident qui soluta ipsum suscipit. Cum dolore aut.", 5, "aca6a320-2139-5e5a-2bfc-655df17133e3", 263, "Collier, Brekke and Conn", "Perspiciatis voluptas quibusdam.", 2023 });

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransaction_AspNetUsers_CheckedInById",
                table: "BookTransaction",
                column: "CheckedInById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransaction_AspNetUsers_CheckedOutById",
                table: "BookTransaction",
                column: "CheckedOutById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransaction_AspNetUsers_UserId",
                table: "BookTransaction",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransaction_Books_BookId",
                table: "BookTransaction",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
