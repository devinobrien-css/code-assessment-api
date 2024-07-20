using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReviewed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReviewerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Daisy Kling", "Fugiat saepe nesciunt molestiae dolor. Recusandae sed perferendis vel facilis officia cumque. Quo quis enim. Debitis non blanditiis unde. Eius eaque aliquam et qui accusantium modi.", 1, "53b6e128-e2e9-c95c-c1e2-a928e77dc91d", false, true, 238, "Borer - Bechtelar", "Omnis voluptatum quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Julien Conroy", "Modi saepe voluptas quidem vitae. Repellendus et quo ut rerum qui dolore. Sit sunt ea itaque voluptas nihil ab hic quas quisquam. Laborum autem fugit quasi cupiditate. Soluta qui voluptates quas dolorum suscipit et aspernatur non.", 3, "fad38bca-727a-a099-51e6-53dbcb9c03ea", 476, "Paucek, Prosacco and Ebert", "Maiores non quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kaden Koelpin", "Nulla sequi provident. Aut delectus ullam magnam molestiae facilis. Enim et molestias nobis commodi dolorem eaque et repellat ut. Minima corporis doloribus aut. Corporis modi laudantium ad excepturi culpa neque. Eaque earum consequatur iure id vero placeat.", 4, "3fd55129-ef47-935e-21c3-365e70336d1e", false, 303, "Sawayn, Hayes and Braun", "Assumenda et est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Howell Witting", "Cupiditate quisquam possimus et similique. Provident iusto illo sed doloremque qui provident suscipit sit animi. Quo quod maiores ab suscipit. Voluptatem tenetur aut sit suscipit qui sunt vel.", 3, "6bfd6529-c44d-1cdc-634f-a97e06a60f6a", false, 211, "Senger Group", "Dolorem dolores nulla.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kian Wolff", "Et quaerat qui nemo distinctio nam rerum rerum. Perspiciatis officiis inventore. Assumenda omnis aliquid et omnis. Ea doloribus maiores quo dolore aliquam voluptatem doloremque magnam beatae. Nesciunt laboriosam amet et ea ut inventore sint magni non. Deserunt quos est vel.", 1, "7d08e3b1-91b9-17fd-e995-d2f3251484d2", false, false, 159, "Wintheiser LLC", "Consequuntur velit asperiores.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marcelina O'Kon", "Quo in modi tempora qui veritatis iusto iste laudantium. Sit quo id accusantium rerum eum. Nemo in et non enim. Atque accusamus fuga est dignissimos id.", 3, "51b300b5-5370-67ec-19d1-6eb0c4a38b94", 160, "Wiegand - Wolff", "Earum culpa in.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kole Brekke", "Rerum consequatur et dicta et eligendi asperiores. Sit corporis consequatur quo aliquam dolor voluptatem necessitatibus repellat consequatur. Animi nulla modi pariatur natus nam. Fuga facere dignissimos dolorem sit ipsum. Sunt quo sed sunt velit delectus.", "35462f98-0262-f83c-ae69-6db1d9782bb1", 264, "Trantow Inc", "Voluptatibus totam repudiandae.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Victor Prohaska", "Est ratione sint quo hic et assumenda dolor atque ex. Et vel cumque similique natus est nihil autem nesciunt ratione. Ea ipsam maxime recusandae sint ea quisquam.", 4, "81831ffa-304c-31ac-9341-53038cf7e911", 417, "Weissnat LLC", "Est perferendis aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bridget Lehner", "Rem similique enim esse saepe. Beatae veniam dolor eligendi. Voluptas labore corporis.", 2, "323fc462-2437-84bd-f95b-edd275bc1fb4", false, false, 120, "Rempel - Huels", "In exercitationem dolor.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jovany Stroman", "At animi ratione voluptas quidem dolorum. Dolorem est eveniet sed fugiat architecto cupiditate aspernatur laudantium. Minima vel quas eaque nesciunt commodi. Architecto molestiae a ut et.", 2, "610eb243-a010-2139-0b86-458decb7f229", false, true, 405, "Quigley and Sons", "Maxime maiores facere.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Murl Towne", "Temporibus repudiandae quia ea eum. Dolores sunt facere voluptatibus animi eum maxime. Aut sequi quia numquam. Unde est maxime enim. Voluptas sed aut hic et impedit.", 1, "460503f8-40d5-08ef-75c0-0d1b5c5e4084", 144, "Price Group", "Dolorem beatae vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Carlos Smitham", "Repudiandae ut commodi a qui dolorem in quibusdam. Non molestias officiis sed aut. Debitis dolore doloremque beatae pariatur laudantium expedita. Quis vel dolor voluptates. Debitis ut necessitatibus nihil consequatur. Corrupti dignissimos ut dolorem dignissimos non magnam minus ea eveniet.", 5, "5141eaf8-b325-73dd-4667-6c1a8bb7b974", true, false, 375, "Satterfield, Strosin and Steuber", "Placeat laborum quo.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Lew Lebsack", "Consequatur nihil rerum. Sed velit voluptatibus deserunt omnis quaerat. Sunt iusto et maiores. Quasi est in maxime in repellat ipsam qui. Et sed delectus quia occaecati. Qui unde et sequi quo architecto.", 3, "3f1be5de-9fdc-e527-71d8-152e919a279c", false, 208, "Hahn, Batz and Conn", "Et alias minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Arturo Pacocha", "Incidunt dolorem adipisci est in in aut molestiae odit. Reiciendis qui rerum laboriosam praesentium pariatur. Ab excepturi et neque. Voluptas dolor officia ut corporis non sint facilis laboriosam. Sit cum suscipit et qui. Ea voluptate esse qui vel qui voluptatem.", "c6f543eb-a3a4-e175-8201-be284cf7eb66", false, 340, "Farrell - Mante", "Eligendi error impedit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Scot McKenzie", "Consequatur nesciunt rerum maxime. Rem numquam qui recusandae sit laudantium. Corporis similique possimus quos qui tempore ratione deserunt. Voluptas ea consectetur officia tenetur asperiores.", 5, "5ab4e91d-a1bf-cb6d-e390-c87c3079f9fc", false, false, 263, "Howell - Renner", "Et assumenda aut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Walton Effertz", "Similique et non voluptates. Culpa dolorum suscipit et. Eligendi delectus vel aperiam amet dolorem et. Doloribus cumque et. Sunt debitis et omnis iusto unde. Nisi nemo eos perspiciatis similique.", 4, "6fdbb849-e9f1-3d1a-34ff-cfe118971adc", false, 413, "Frami Inc", "Reprehenderit aut sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Alta Stiedemann", "Omnis et esse harum ex ratione. Culpa eos accusamus et iste. Neque at exercitationem molestias consequatur quidem quam similique magnam nesciunt.", "c1a010c5-f091-1600-ce55-9dbb464205ba", false, true, 116, "Leannon Inc", "Rem omnis beatae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alana Kuvalis", "Porro quaerat incidunt et quisquam consequatur praesentium placeat. Alias dolores velit rerum ducimus ea quod eligendi. Ut quo eaque consectetur.", "fc512cd2-d4e0-9435-99c1-d18b45559325", false, 164, "Beer - Schuppe", "Dolor qui exercitationem.", 2023 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "162615a4-ed89-4b75-b10c-79322042f803", "Constance_McLaughlin60@gmail.com", "Constance", "McLaughlin", 25, "5ac0fedf-e494-4bfb-a9eb-20df4c563195", "Constance.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "88137a4a-413c-40b0-9406-2ad47a18648b", "Ida46@gmail.com", "Ida", "Kihn", 32, "427647e6-c52b-4c3f-92ce-67297a9a01d0", "Ida_Kihn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "6e0cf2cf-01e1-46ed-bf75-048867772613", "Sheri_Zieme@yahoo.com", "Sheri", "Zieme", 29, "daf21b46-92bb-466c-8e59-f8151025db11", "Sheri7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "b87c6845-3e5a-4056-bd87-ae1d32897a5f", "Toby95@gmail.com", "Toby", "Nikolaus", 20, "10ed0c80-c6f3-4c0d-91a3-0c7cdcdf72b9", "Toby.Nikolaus44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "62b505da-d70e-4452-b1d0-cf2add3667e3", "Brandon.Ebert@yahoo.com", "Brandon", "Ebert", 23, "918f51ca-31de-4708-93f4-698af40d9728", "Brandon.Ebert" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 3, new DateTime(2024, 7, 19, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 24, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(3670), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 9, new DateTime(2024, 7, 19, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 24, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(4240), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 2, new DateTime(2024, 7, 19, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 24, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(4260), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 17, new DateTime(2024, 7, 19, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 24, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(4270), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 7, new DateTime(2024, 7, 19, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 7, 24, 19, 59, 16, 655, DateTimeKind.Local).AddTicks(4280), "1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Mable Ankunding", "Occaecati dolorum ut odit atque autem veniam sit. Perferendis id deleniti ut quo sint molestiae voluptatem provident et. Ut nam voluptate illum consequatur sit enim rerum. Officiis quasi nam sit dolorem nesciunt.", 5, "7652e78c-6c5c-2885-0aa9-4be5b301a589", true, false, 203, "Purdy, Ortiz and Cormier", "Praesentium nesciunt nobis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jannie Konopelski", "Hic ut perferendis amet eos amet illo et. Autem laboriosam occaecati omnis unde aut qui pariatur et. Dignissimos suscipit dolores voluptatem quod. Vero quo et et harum libero.", 1, "3a8db684-e01c-65a5-cc60-3e03a2b8466f", 426, "Ryan, Corwin and Armstrong", "Placeat expedita tenetur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mariela Morar", "Voluptas enim esse ducimus dignissimos. Accusantium magnam ea incidunt facilis nobis quam. Ea sed earum commodi nostrum quibusdam at saepe.", 3, "7412d806-3c8f-b5ce-3271-fdc337254356", true, 275, "Kozey, Raynor and O'Hara", "Blanditiis praesentium atque.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Malinda D'Amore", "Vitae voluptate illum voluptatem. Aut aut et. Ab doloremque enim. Eum id dolor odio nobis.", 1, "3110af0d-ce6b-b125-ac04-4debc8bd80f5", true, 331, "Paucek, Bednar and Koch", "Mollitia delectus nihil.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bonnie Thompson", "Inventore et quod laudantium deleniti quaerat quia. Eligendi sunt iure qui libero officiis nobis animi est at. Quam maxime et porro error libero quibusdam voluptas in. Cumque officiis et quia et provident recusandae. Magni qui culpa esse. Commodi dignissimos et.", 2, "541dea3c-6d4f-d6a1-8d0a-a14d9f238ee0", true, true, 315, "Kerluke Group", "Ut eveniet quae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sabina Halvorson", "Maiores iusto porro omnis provident. Libero quas odio ea non sunt non. Natus non qui odio rerum molestiae error accusamus. Dolore eos rem ad est. Ipsa dolore voluptatem inventore delectus ad doloribus sit doloribus. Atque dolor maiores atque ea quae in asperiores quisquam reiciendis.", 2, "3c8e6479-e4e8-2667-1d05-e0a9dc591808", 354, "Windler, Parker and Bogisich", "Dolorem facilis dolorum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alysa Auer", "Harum nam dolorem. Corrupti dolorum occaecati sit eum. Commodi maiores qui doloremque placeat. Fugit animi qui modi alias est ad. Necessitatibus deleniti ad molestias omnis.", "ed6f9c6d-2e44-824a-3721-1f0c0a7e8cea", 300, "Marks Inc", "Ea ut dolorum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Leatha Schaden", "Quisquam occaecati facere dolores maxime vero doloribus illum. Nisi ipsum totam neque harum cupiditate odio voluptatum voluptatem aliquid. Molestiae quam repellendus qui molestias facere sit id. Labore sapiente dignissimos dolore illo.", 2, "9a8a8dab-5907-56fe-2e4d-c1b416a20809", false, 192, "Baumbach - Willms", "Incidunt dolorem itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Evan Waelchi", "Aut perspiciatis amet est neque reprehenderit aut. Ipsa accusamus sunt reprehenderit temporibus. Sapiente non laudantium et quos ab non rerum nobis sit.", 3, "91bca149-59f9-86c2-ac8e-518105f92a0d", 263, "Hagenes Group", "Accusamus tenetur laudantium." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nella Kozey", "Sed similique provident rem debitis impedit. Aut qui facere laboriosam nam ad vero et. Omnis ullam deserunt ipsam qui odit eveniet. Facilis blanditiis optio omnis occaecati velit omnis tempore.", 4, "26bb3ecc-4fd2-f8fe-6611-05499b8519ed", true, true, 309, "Kozey - Nicolas", "Quam voluptatem eligendi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elza Prosacco", "Id perspiciatis temporibus magni sed ipsa. Fuga autem occaecati ipsa ea ipsa. Consequatur impedit nisi iusto. Et consequuntur fuga consectetur provident et sed eos nobis commodi.", 5, "9e9aa082-8dd9-f096-012d-a35a7b697c22", true, false, 445, "Konopelski Group", "Dolor nisi consequatur.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annabell Nikolaus", "Facilis ut consequatur fugiat qui numquam harum ut. Ut ipsum expedita eius aut. Ut delectus rerum. Autem maiores est accusantium earum.", 4, "2a80eac4-2011-a479-8ce2-963c9ef4011d", true, 368, "Carroll Group", "Consequatur ut velit.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Elias Beer", "Eius saepe velit at possimus. Alias maiores et corporis nostrum labore aut repellat. Labore deserunt molestiae fugit libero aut voluptatibus qui assumenda aspernatur.", 2, "ee97725b-d946-ed1c-caec-ab638247b1f2", 198, "Hayes - Stoltenberg", "Blanditiis tempore laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nannie Schamberger", "Quisquam et consequuntur necessitatibus modi quis ut qui ea nemo. Qui saepe similique nihil id sed ea. Sit quidem voluptate facere iusto fugit amet quia. Dolores incidunt voluptatem magnam cupiditate delectus dolorum. Quidem odit voluptatem voluptatem deleniti quae. Dolores laboriosam assumenda consectetur quae ut sequi et assumenda deleniti.", 4, "05dc515c-7e6e-1165-c93c-e739947ecdf3", false, true, 271, "Nicolas - Wisoky", "At quis accusantium.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Carleton Schowalter", "Quo alias vel unde. Ut aperiam aut dignissimos. Aut voluptatem voluptas praesentium modi quibusdam nam commodi iste autem. Qui officiis dolor qui.", 4, "bc21ba90-1d65-28ea-57cd-adab45abd136", true, 198, "Sporer - Predovic", "Et voluptas incidunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alba Ziemann", "Tempora non aliquid ut vitae. Sed et nesciunt error amet molestias non. Voluptatem a optio id. Occaecati perspiciatis quia sapiente. Aut sed adipisci vel laboriosam error porro velit explicabo ut. Qui quo ex.", "a247f4e4-e62b-49ca-5bbb-52e425e4edec", true, 491, "Simonis Inc", "Perferendis doloribus ut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Timmothy Windler", "Mollitia sequi aperiam sed perferendis. Qui molestias deleniti repellendus quia. Et quis aut consequatur.", 3, "17e0c3f3-4a9c-9201-7c4b-257480c7b8d4", true, true, 496, "Hodkiewicz - Feest", "Voluptas iusto quidem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Bettie Boyle", "Repellendus dolores cupiditate quibusdam odio. Voluptatem est quis minus sed quo. Aut iure quidem consequatur. Odio est commodi laudantium hic voluptatem doloremque dolorum aliquid hic.", 3, "1070fc24-bde0-e9a3-95c6-229673cbb592", true, 394, "Schumm, Gottlieb and Gusikowski", "Tenetur perspiciatis qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Marcel Lueilwitz", "Quod dolores iste vero ad repellendus necessitatibus. Ab vel dolorem aliquid rerum sequi quidem nihil et. Vel et eum qui voluptatem et et vitae excepturi molestiae. Totam occaecati ut quod deleniti fugit aut necessitatibus quod mollitia.", "67373c3e-c422-baf4-7724-6204c4eac539", true, false, 224, "Zieme - Kub", "Sed porro dolorum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brenden Ziemann", "Quibusdam dicta officiis facilis omnis animi et quis quaerat blanditiis. Est modi minima quia facilis similique. Officiis quia quia odio. Delectus et velit voluptate laborum beatae. Molestiae cumque deleniti sit et vitae. Magni architecto rerum repellat.", "2854621f-58dc-29ed-dee0-199ad6fea9bc", true, 216, "Brown, Lueilwitz and Gulgowski", "Deleniti sunt totam.", 2024 });
        }
    }
}
