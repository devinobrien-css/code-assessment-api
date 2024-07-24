using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class RefinementUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mable Ankunding", "Occaecati dolorum ut odit atque autem veniam sit. Perferendis id deleniti ut quo sint molestiae voluptatem provident et. Ut nam voluptate illum consequatur sit enim rerum. Officiis quasi nam sit dolorem nesciunt.", "7652e78c-6c5c-2885-0aa9-4be5b301a589", true, false, 203, "Purdy, Ortiz and Cormier", "Praesentium nesciunt nobis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jannie Konopelski", "Hic ut perferendis amet eos amet illo et. Autem laboriosam occaecati omnis unde aut qui pariatur et. Dignissimos suscipit dolores voluptatem quod. Vero quo et et harum libero.", 1, "3a8db684-e01c-65a5-cc60-3e03a2b8466f", false, true, 426, "Ryan, Corwin and Armstrong", "Placeat expedita tenetur.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Mariela Morar", "Voluptas enim esse ducimus dignissimos. Accusantium magnam ea incidunt facilis nobis quam. Ea sed earum commodi nostrum quibusdam at saepe.", 3, "7412d806-3c8f-b5ce-3271-fdc337254356", true, 275, "Kozey, Raynor and O'Hara", "Blanditiis praesentium atque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Malinda D'Amore", "Vitae voluptate illum voluptatem. Aut aut et. Ab doloremque enim. Eum id dolor odio nobis.", 1, "3110af0d-ce6b-b125-ac04-4debc8bd80f5", 331, "Paucek, Bednar and Koch", "Mollitia delectus nihil." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sabina Halvorson", "Maiores iusto porro omnis provident. Libero quas odio ea non sunt non. Natus non qui odio rerum molestiae error accusamus. Dolore eos rem ad est. Ipsa dolore voluptatem inventore delectus ad doloribus sit doloribus. Atque dolor maiores atque ea quae in asperiores quisquam reiciendis.", 2, "3c8e6479-e4e8-2667-1d05-e0a9dc591808", true, 354, "Windler, Parker and Bogisich", "Dolorem facilis dolorum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Alysa Auer", "Harum nam dolorem. Corrupti dolorum occaecati sit eum. Commodi maiores qui doloremque placeat. Fugit animi qui modi alias est ad. Necessitatibus deleniti ad molestias omnis.", 1, "ed6f9c6d-2e44-824a-3721-1f0c0a7e8cea", 300, "Marks Inc", "Ea ut dolorum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Leatha Schaden", "Quisquam occaecati facere dolores maxime vero doloribus illum. Nisi ipsum totam neque harum cupiditate odio voluptatum voluptatem aliquid. Molestiae quam repellendus qui molestias facere sit id. Labore sapiente dignissimos dolore illo.", 2, "9a8a8dab-5907-56fe-2e4d-c1b416a20809", 192, "Baumbach - Willms", "Incidunt dolorem itaque.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Evan Waelchi", "Aut perspiciatis amet est neque reprehenderit aut. Ipsa accusamus sunt reprehenderit temporibus. Sapiente non laudantium et quos ab non rerum nobis sit.", 3, "91bca149-59f9-86c2-ac8e-518105f92a0d", true, false, 263, "Hagenes Group", "Accusamus tenetur laudantium.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Nella Kozey", "Sed similique provident rem debitis impedit. Aut qui facere laboriosam nam ad vero et. Omnis ullam deserunt ipsam qui odit eveniet. Facilis blanditiis optio omnis occaecati velit omnis tempore.", 4, "26bb3ecc-4fd2-f8fe-6611-05499b8519ed", true, 309, "Kozey - Nicolas", "Quam voluptatem eligendi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elza Prosacco", "Id perspiciatis temporibus magni sed ipsa. Fuga autem occaecati ipsa ea ipsa. Consequatur impedit nisi iusto. Et consequuntur fuga consectetur provident et sed eos nobis commodi.", "9e9aa082-8dd9-f096-012d-a35a7b697c22", false, 445, "Konopelski Group", "Dolor nisi consequatur.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annabell Nikolaus", "Facilis ut consequatur fugiat qui numquam harum ut. Ut ipsum expedita eius aut. Ut delectus rerum. Autem maiores est accusantium earum.", 4, "2a80eac4-2011-a479-8ce2-963c9ef4011d", true, 368, "Carroll Group", "Consequatur ut velit.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Elias Beer", "Eius saepe velit at possimus. Alias maiores et corporis nostrum labore aut repellat. Labore deserunt molestiae fugit libero aut voluptatibus qui assumenda aspernatur.", 2, "ee97725b-d946-ed1c-caec-ab638247b1f2", true, 198, "Hayes - Stoltenberg", "Blanditiis tempore laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nannie Schamberger", "Quisquam et consequuntur necessitatibus modi quis ut qui ea nemo. Qui saepe similique nihil id sed ea. Sit quidem voluptate facere iusto fugit amet quia. Dolores incidunt voluptatem magnam cupiditate delectus dolorum. Quidem odit voluptatem voluptatem deleniti quae. Dolores laboriosam assumenda consectetur quae ut sequi et assumenda deleniti.", 4, "05dc515c-7e6e-1165-c93c-e739947ecdf3", true, 271, "Nicolas - Wisoky", "At quis accusantium.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alba Ziemann", "Tempora non aliquid ut vitae. Sed et nesciunt error amet molestias non. Voluptatem a optio id. Occaecati perspiciatis quia sapiente. Aut sed adipisci vel laboriosam error porro velit explicabo ut. Qui quo ex.", 2, "a247f4e4-e62b-49ca-5bbb-52e425e4edec", true, true, 491, "Simonis Inc", "Perferendis doloribus ut.", 2023 });

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
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bettie Boyle", "Repellendus dolores cupiditate quibusdam odio. Voluptatem est quis minus sed quo. Aut iure quidem consequatur. Odio est commodi laudantium hic voluptatem doloremque dolorum aliquid hic.", "1070fc24-bde0-e9a3-95c6-229673cbb592", false, 394, "Schumm, Gottlieb and Gusikowski", "Tenetur perspiciatis qui.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marcel Lueilwitz", "Quod dolores iste vero ad repellendus necessitatibus. Ab vel dolorem aliquid rerum sequi quidem nihil et. Vel et eum qui voluptatem et et vitae excepturi molestiae. Totam occaecati ut quod deleniti fugit aut necessitatibus quod mollitia.", "67373c3e-c422-baf4-7724-6204c4eac539", true, 224, "Zieme - Kub", "Sed porro dolorum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brenden Ziemann", "Quibusdam dicta officiis facilis omnis animi et quis quaerat blanditiis. Est modi minima quia facilis similique. Officiis quia quia odio. Delectus et velit voluptate laborum beatae. Molestiae cumque deleniti sit et vitae. Magni architecto rerum repellat.", 4, "2854621f-58dc-29ed-dee0-199ad6fea9bc", true, 216, "Brown, Lueilwitz and Gulgowski", "Deleniti sunt totam.", 2024 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "214f01d3-2c73-4ee0-975b-03e2709be093", "Pearl39@hotmail.com", "Pearl", "Kuphal", 8, "f821d599-b1d9-41aa-9c68-cb2d4087d625", "Pearl.Kuphal" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "1e337f6a-c155-4e53-b040-7293a7b010e7", "Joanna_Metz@gmail.com", "Joanna", "Metz", 27, "7cea8a00-a024-4c78-a1f4-16b20b5feefc", "Joanna_Metz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "36e144b2-5106-4a79-a2f4-ba15e18f089d", "Mamie24@yahoo.com", "Mamie", "Walker", 19, "1e3e845d-9661-40ab-872a-509eaa4a5325", "Mamie64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "8db46be3-0efa-4279-960d-e6e7a1c9bba2", "Vera52@gmail.com", "Vera", "Huel", 30, "04e6db43-d562-43b0-ba6b-478a573506d3", "Vera_Huel41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "3ebe62ce-b276-4379-96db-277c74a819b8", "Crystal_Lakin7@gmail.com", "Crystal", "Lakin", 18, "6cd2a630-5e67-4060-89a9-a1d807b0e6c6", "Crystal55" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 20, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(8890), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 5, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(9420), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 12, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(9430), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 2, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(9440), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 1, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(9450), "4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chase Ratke", "Facilis quos qui consequuntur. Provident inventore qui ut provident repellendus. Qui pariatur voluptatem expedita et et reprehenderit accusamus odit quaerat.", "4d96acdd-b52f-9de6-a817-1c5ded980bbf", false, true, 482, "Aufderhar - Stamm", "Assumenda provident consequatur.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lindsay Koch", "Placeat et ut. Iusto odit id laborum molestiae quibusdam sunt sed fuga. Est nostrum magnam magni maxime quibusdam dolores rerum consequatur. Magnam veniam reiciendis quisquam. Est odio et eum quia consequatur sed molestias molestiae sunt.", 2, "20a5b82f-6eba-fc8d-bc16-ff9f36dab455", true, false, 186, "West - Hayes", "Qui neque nulla.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaela Labadie", "Odit iusto tempore nemo omnis ea quos nisi et deleniti. Alias quia eum iure nisi illo delectus velit vel. Exercitationem quo nihil quo labore labore. Illo laboriosam officia ratione nemo natus ullam non.", 1, "bbfb9b08-f8a5-c4c2-a49e-2d931c90a33e", false, 426, "Ritchie LLC", "Et beatae qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Natasha Heaney", "Dignissimos sit qui consequatur id sapiente necessitatibus sapiente. Sapiente fugiat quam voluptas consequatur consequatur nisi. Doloremque suscipit fuga voluptates quaerat in architecto perferendis. Eos est voluptatem sit consequatur impedit error rerum voluptate.", 4, "3adb764c-6237-e90f-12c8-bc85622c63f2", 137, "Rau - Bergstrom", "Quibusdam aut non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Deven Towne", "Et quam autem rerum ut illum sit omnis et magni. Quaerat occaecati molestiae repellendus porro exercitationem voluptatem neque ipsam est. Aut repellat et sit repudiandae. Est quidem incidunt.", 4, "fb98eef5-39b6-85c8-5bfb-71c27e200808", false, false, 342, "Simonis - Mraz", "Sequi est fugiat.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Larissa Marks", "In ut deleniti laborum eaque aspernatur architecto. Culpa id expedita et. Quo necessitatibus accusantium fuga error voluptatibus voluptatem. Adipisci fuga explicabo pariatur error facere reiciendis minus voluptatibus.", 4, "b36976a5-349a-c5d4-20e5-acb82f2f88e2", false, 483, "Schultz, Rath and Hermiston", "Praesentium quis vitae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Darron Bernier", "Incidunt tempore rerum laboriosam quis earum possimus alias dignissimos deserunt. Sint sunt deserunt alias repellendus sit non harum in. Molestiae et esse. Dicta molestiae ut aut vitae molestias laudantium quis.", 3, "869c8a80-526b-cba6-7d67-77f50885edef", 355, "Wisoky, Homenick and Powlowski", "Laborum omnis odio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chad Maggio", "Est ut reprehenderit architecto facilis in sint iure sed tempora. Sequi qui amet velit. Dolorum quia qui.", 5, "25c0a792-e3ea-4eeb-3347-bbc2d14bea99", 132, "Howe, Cummings and Botsford", "Doloribus natus ipsam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Emmie Kuhic", "Fuga rerum sed odio. Inventore totam aut explicabo saepe veniam. Provident dignissimos provident.", 2, "3872ebd5-fba1-15de-cb2c-fac8994deb27", false, true, 115, "Kilback Group", "Sit et debitis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Ashton Little", "Nam est sit sequi quis est. Voluptas delectus omnis est quis enim tempora deserunt distinctio sit. Et excepturi architecto.", 2, "0ced44bc-d89a-0403-c63b-49535bd9165b", false, 494, "Kulas - Von", "Harum odio id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Braulio Kemmer", "Numquam architecto maxime quod beatae. Impedit ad qui ullam dolor ipsam sit hic perspiciatis. Aspernatur iste pariatur alias quis rem quo aut. Distinctio natus inventore est occaecati ut consequatur vel quis perferendis. Quidem maiores laudantium ducimus officia in molestias est voluptatem. Saepe aspernatur consectetur optio id et quis sint fugiat.", "5b1fede0-acc1-3fd0-6c1e-271aad1837af", true, 201, "Lueilwitz and Sons", "Quisquam perferendis nam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Melyssa Runolfsson", "Tenetur sed quibusdam minus neque recusandae non voluptates minus hic. Aut ipsa dolor dolores dolor hic ut et. Ea fugiat accusamus ipsa ipsam iure non veniam laboriosam minima.", 2, "39d2fda8-ed15-cbce-cf3f-1805bdb7fd42", false, 481, "Cartwright, Homenick and Hansen", "Rerum labore enim.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Cole Dach", "Qui ipsum quam impedit aliquam dolor dolorem velit. Veritatis sapiente quas error harum. Sint modi fuga rem sit.", 1, "a108ffcc-f259-d1f8-05fb-01c92bc90414", false, 342, "Mante - Pagac", "Numquam placeat sapiente." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jerrell Hilll", "Optio quia quia quas veniam itaque ea aut molestiae voluptas. Quaerat et a quia amet. Quisquam unde voluptate. Perferendis laboriosam eaque est quo impedit. Soluta ut rerum voluptates maxime.", 1, "a5c8da3e-3f1c-3104-1961-3e56e1a404dd", false, 203, "Daugherty, Lind and Kuhn", "Et nostrum voluptate.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jackson Farrell", "Quis doloribus voluptatem fuga itaque ipsa explicabo eius qui. Et nisi blanditiis eum. A quia reiciendis aut minima qui qui. Facilis dolorem cumque incidunt consequatur commodi maiores ut. Sit repudiandae explicabo quisquam beatae ut mollitia ut sapiente et.", 5, "ebe88e3d-093f-eb08-0f69-ecb9347e4178", false, 201, "Abernathy - Yost", "Cumque itaque consequuntur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gertrude Russel", "Quia quia magni commodi. Quia itaque vitae aliquid enim dicta. Aliquid quos debitis molestias distinctio est velit.", 4, "bc768677-ea53-fce9-e5b3-caa350e2e426", false, false, 367, "Stroman LLC", "Est tenetur laboriosam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brisa Senger", "Nam eum et. Hic excepturi at voluptatibus. Voluptatem possimus adipisci et doloremque possimus tenetur. Mollitia at in. Quis tenetur tempore eaque tempore id.", 5, "ed89564a-9483-07da-8b53-467ebe607c3d", false, false, 254, "Oberbrunner LLC", "Sit sed facere.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mauricio Funk", "Cum sequi est cumque quaerat aspernatur debitis. Enim non in natus rem dolor dolorem similique. Laudantium voluptatem voluptas harum qui et aut repudiandae sed quas. Est ea qui sed sit est aut fugiat quia. Eum magni et ut labore. In perferendis sint id eligendi non minus.", "f1afb1c0-a7cf-cf1b-6920-ec5705a65c7d", true, 189, "Schultz and Sons", "Ea cumque quod.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kenya Reinger", "Ea iste vero a quis ut et. Consequatur et officiis quod sed. Voluptates et quos. Voluptatem beatae blanditiis commodi explicabo eos et possimus rerum.", "d7568597-a115-8da8-013d-c3535fff5f01", false, 428, "Quigley, Windler and Cremin", "Voluptates quas consequatur.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "David Larkin", "Dolores omnis at quod ipsam fugiat fugiat dolores. Maiores perferendis est quidem reprehenderit et voluptate culpa. Dolores cum aperiam tempora. Ab et maxime dolorum et quae omnis praesentium. Omnis voluptatum voluptatem ad eaque et autem voluptatum molestias consequatur. Ut quis voluptatum rerum.", 3, "5457e10a-55cf-efb5-b2a8-9d745564eb2c", false, 119, "Kozey - Torp", "Dolorum dolores assumenda.", 2023 });
        }
    }
}
