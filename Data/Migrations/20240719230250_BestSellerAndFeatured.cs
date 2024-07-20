using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class BestSellerAndFeatured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsNewArrival",
                table: "Books");

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 2, new DateTime(2024, 7, 19, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 7, 24, 19, 2, 49, 849, DateTimeKind.Local).AddTicks(9440) });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chase Ratke", "Facilis quos qui consequuntur. Provident inventore qui ut provident repellendus. Qui pariatur voluptatem expedita et et reprehenderit accusamus odit quaerat.", 5, "4d96acdd-b52f-9de6-a817-1c5ded980bbf", true, 482, "Aufderhar - Stamm", "Assumenda provident consequatur.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Lindsay Koch", "Placeat et ut. Iusto odit id laborum molestiae quibusdam sunt sed fuga. Est nostrum magnam magni maxime quibusdam dolores rerum consequatur. Magnam veniam reiciendis quisquam. Est odio et eum quia consequatur sed molestias molestiae sunt.", 2, "20a5b82f-6eba-fc8d-bc16-ff9f36dab455", true, 186, "West - Hayes", "Qui neque nulla." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaela Labadie", "Odit iusto tempore nemo omnis ea quos nisi et deleniti. Alias quia eum iure nisi illo delectus velit vel. Exercitationem quo nihil quo labore labore. Illo laboriosam officia ratione nemo natus ullam non.", 1, "bbfb9b08-f8a5-c4c2-a49e-2d931c90a33e", true, 426, "Ritchie LLC", "Et beatae qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Natasha Heaney", "Dignissimos sit qui consequatur id sapiente necessitatibus sapiente. Sapiente fugiat quam voluptas consequatur consequatur nisi. Doloremque suscipit fuga voluptates quaerat in architecto perferendis. Eos est voluptatem sit consequatur impedit error rerum voluptate.", 4, "3adb764c-6237-e90f-12c8-bc85622c63f2", true, 137, "Rau - Bergstrom", "Quibusdam aut non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Deven Towne", "Et quam autem rerum ut illum sit omnis et magni. Quaerat occaecati molestiae repellendus porro exercitationem voluptatem neque ipsam est. Aut repellat et sit repudiandae. Est quidem incidunt.", 4, "fb98eef5-39b6-85c8-5bfb-71c27e200808", 342, "Simonis - Mraz", "Sequi est fugiat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Larissa Marks", "In ut deleniti laborum eaque aspernatur architecto. Culpa id expedita et. Quo necessitatibus accusantium fuga error voluptatibus voluptatem. Adipisci fuga explicabo pariatur error facere reiciendis minus voluptatibus.", 4, "b36976a5-349a-c5d4-20e5-acb82f2f88e2", true, 483, "Schultz, Rath and Hermiston", "Praesentium quis vitae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Darron Bernier", "Incidunt tempore rerum laboriosam quis earum possimus alias dignissimos deserunt. Sint sunt deserunt alias repellendus sit non harum in. Molestiae et esse. Dicta molestiae ut aut vitae molestias laudantium quis.", 3, "869c8a80-526b-cba6-7d67-77f50885edef", true, 355, "Wisoky, Homenick and Powlowski", "Laborum omnis odio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Chad Maggio", "Est ut reprehenderit architecto facilis in sint iure sed tempora. Sequi qui amet velit. Dolorum quia qui.", 5, "25c0a792-e3ea-4eeb-3347-bbc2d14bea99", 132, "Howe, Cummings and Botsford", "Doloribus natus ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Emmie Kuhic", "Fuga rerum sed odio. Inventore totam aut explicabo saepe veniam. Provident dignissimos provident.", "3872ebd5-fba1-15de-cb2c-fac8994deb27", true, 115, "Kilback Group", "Sit et debitis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ashton Little", "Nam est sit sequi quis est. Voluptas delectus omnis est quis enim tempora deserunt distinctio sit. Et excepturi architecto.", 2, "0ced44bc-d89a-0403-c63b-49535bd9165b", true, 494, "Kulas - Von", "Harum odio id.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Braulio Kemmer", "Numquam architecto maxime quod beatae. Impedit ad qui ullam dolor ipsam sit hic perspiciatis. Aspernatur iste pariatur alias quis rem quo aut. Distinctio natus inventore est occaecati ut consequatur vel quis perferendis. Quidem maiores laudantium ducimus officia in molestias est voluptatem. Saepe aspernatur consectetur optio id et quis sint fugiat.", 5, "5b1fede0-acc1-3fd0-6c1e-271aad1837af", true, true, 201, "Lueilwitz and Sons", "Quisquam perferendis nam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Melyssa Runolfsson", "Tenetur sed quibusdam minus neque recusandae non voluptates minus hic. Aut ipsa dolor dolores dolor hic ut et. Ea fugiat accusamus ipsa ipsam iure non veniam laboriosam minima.", 2, "39d2fda8-ed15-cbce-cf3f-1805bdb7fd42", true, 481, "Cartwright, Homenick and Hansen", "Rerum labore enim." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cole Dach", "Qui ipsum quam impedit aliquam dolor dolorem velit. Veritatis sapiente quas error harum. Sint modi fuga rem sit.", 1, "a108ffcc-f259-d1f8-05fb-01c92bc90414", 342, "Mante - Pagac", "Numquam placeat sapiente.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jerrell Hilll", "Optio quia quia quas veniam itaque ea aut molestiae voluptas. Quaerat et a quia amet. Quisquam unde voluptate. Perferendis laboriosam eaque est quo impedit. Soluta ut rerum voluptates maxime.", 1, "a5c8da3e-3f1c-3104-1961-3e56e1a404dd", 203, "Daugherty, Lind and Kuhn", "Et nostrum voluptate.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jackson Farrell", "Quis doloribus voluptatem fuga itaque ipsa explicabo eius qui. Et nisi blanditiis eum. A quia reiciendis aut minima qui qui. Facilis dolorem cumque incidunt consequatur commodi maiores ut. Sit repudiandae explicabo quisquam beatae ut mollitia ut sapiente et.", 5, "ebe88e3d-093f-eb08-0f69-ecb9347e4178", 201, "Abernathy - Yost", "Cumque itaque consequuntur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gertrude Russel", "Quia quia magni commodi. Quia itaque vitae aliquid enim dicta. Aliquid quos debitis molestias distinctio est velit.", 4, "bc768677-ea53-fce9-e5b3-caa350e2e426", 367, "Stroman LLC", "Est tenetur laboriosam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brisa Senger", "Nam eum et. Hic excepturi at voluptatibus. Voluptatem possimus adipisci et doloremque possimus tenetur. Mollitia at in. Quis tenetur tempore eaque tempore id.", 5, "ed89564a-9483-07da-8b53-467ebe607c3d", 254, "Oberbrunner LLC", "Sit sed facere.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Mauricio Funk", "Cum sequi est cumque quaerat aspernatur debitis. Enim non in natus rem dolor dolorem similique. Laudantium voluptatem voluptas harum qui et aut repudiandae sed quas. Est ea qui sed sit est aut fugiat quia. Eum magni et ut labore. In perferendis sint id eligendi non minus.", 3, "f1afb1c0-a7cf-cf1b-6920-ec5705a65c7d", true, true, 189, "Schultz and Sons", "Ea cumque quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kenya Reinger", "Ea iste vero a quis ut et. Consequatur et officiis quod sed. Voluptates et quos. Voluptatem beatae blanditiis commodi explicabo eos et possimus rerum.", "d7568597-a115-8da8-013d-c3535fff5f01", 428, "Quigley, Windler and Cremin", "Voluptates quas consequatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "David Larkin", "Dolores omnis at quod ipsam fugiat fugiat dolores. Maiores perferendis est quidem reprehenderit et voluptate culpa. Dolores cum aperiam tempora. Ab et maxime dolorum et quae omnis praesentium. Omnis voluptatum voluptatem ad eaque et autem voluptatum molestias consequatur. Ut quis voluptatum rerum.", 3, "5457e10a-55cf-efb5-b2a8-9d745564eb2c", true, 119, "Kozey - Torp", "Dolorum dolores assumenda." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewArrival",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 4, new DateTime(2024, 7, 19, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 7, 24, 11, 54, 4, 310, DateTimeKind.Local).AddTicks(2500), "3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Celine Windler", "Ut vel rerum culpa et modi iste qui nemo illo. A tempora qui fugit odio. Assumenda nulla est et.", 4, "3e6a4808-afa7-a80a-855a-e6d9c423fd54", false, false, false, 260, "Gleichner - Schaden", "Natus et voluptas.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Maiya Johnston", "Et libero quia ipsum adipisci eveniet. Quos nobis qui rerum provident. Blanditiis dolorem molestiae incidunt quibusdam est id reprehenderit voluptatibus. Fuga facilis vero consequatur.", 4, "1ab2e814-d255-862a-97ee-73ce51d8a597", false, false, false, 427, "Becker Group", "Numquam accusamus ad." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Lizeth Wiza", "Praesentium dolorem consequatur rerum sint eum accusantium. Nam quaerat qui omnis ab est quia nihil omnis. Dolor commodi incidunt.", 3, "adab8909-9740-15d0-ff14-5294401a8b24", false, false, false, 345, "Hahn LLC", "Deserunt necessitatibus error." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Emery Corkery", "Aut possimus reiciendis dolore quos et dolorem fuga laborum quisquam. Mollitia sit eaque qui temporibus similique. Aut quae ut officiis recusandae hic. Officiis officiis blanditiis iure ut. Est iure quo numquam commodi non nihil cum atque.", 1, "2e01feaa-374f-58dc-3a8c-5f5a0ca6de95", false, false, false, 302, "Runte Group", "Voluptas molestiae totam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Ettie Luettgen", "Veritatis repudiandae dolorum aperiam ullam sed ullam libero blanditiis eius. Incidunt voluptatem veritatis voluptate libero autem ex deleniti necessitatibus et. Vel rerum modi debitis tempora ea quia non dicta. Qui distinctio voluptate perferendis aliquam exercitationem reiciendis consequatur et. Cum alias asperiores nesciunt officia quis est. Dolorem molestiae voluptatem aut.", 1, "1e363a09-58aa-9e9e-3b51-556dd224b271", false, false, 419, "Casper - Gerhold", "Commodi cupiditate vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Frederic Kling", "Velit possimus et veritatis quibusdam facere sint distinctio deleniti accusamus. Rerum iure maxime animi ut ipsam corporis nam impedit. Molestias alias repellat quo.", 2, "51018be9-b0ea-6390-0c78-9dd77c69b44f", false, false, false, 400, "McDermott, D'Amore and Baumbach", "Iste provident possimus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Onie Will", "Modi perferendis eos deleniti. Ut aperiam cumque beatae ipsum sed asperiores reiciendis. Vitae ut corrupti veritatis ut perferendis. Id voluptates dignissimos vitae sit id illum perspiciatis fuga.", 2, "a8b72b83-f035-c877-7205-616f5f57f739", false, false, false, 113, "Sauer, Swaniawski and Bernhard", "Exercitationem quos et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Emanuel Nikolaus", "A et aspernatur nostrum facilis repudiandae facilis hic veniam. Quidem perspiciatis non et dicta vel et nulla. Ratione earum aut earum suscipit reiciendis fugit quidem rerum quisquam. Quidem dolorem nihil repudiandae iusto.", 4, "4c36a48e-a715-53b8-1070-ef959e8834ca", false, false, 230, "Dibbert - Block", "Dolor qui non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Wilfrid Lebsack", "Voluptatem non facilis omnis est. Veritatis et officia est velit. Accusantium ut aut ullam ratione rerum eligendi qui. Sed architecto ullam ipsum. Sit omnis quibusdam excepturi molestiae. Totam quia porro et voluptas non sequi ut earum.", "796b4f18-91af-1e1a-a0b8-1bb36b82202a", false, false, false, 117, "Berge - Moore", "Aperiam quia mollitia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Shayna Murray", "Harum sunt omnis et distinctio corporis iste nesciunt minima. Beatae earum voluptates repudiandae illo. Incidunt libero cumque odio in saepe totam sed. Nihil labore eius error eius voluptas blanditiis itaque. Amet suscipit quo. Est quae aut iste architecto quis fuga.", 3, "2ce6b5b9-2d52-2e94-ec32-7a6858d4c02e", false, false, false, 411, "Runte - Spencer", "Dicta aspernatur quod.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jett Volkman", "Dicta quod quae quibusdam nam voluptatum incidunt dolore. Nam exercitationem perferendis repellendus omnis aut distinctio corrupti fugit iste. Ut dignissimos dolorum libero sint voluptate id reiciendis deserunt ut.", 2, "6fada230-fcf7-0746-4e1c-20edcc9751af", false, false, false, false, 390, "Cronin LLC", "Temporibus illo officia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Maida Cummerata", "Magnam possimus architecto voluptatem enim sed. Similique odit sequi aut maxime deserunt suscipit. Dignissimos dicta quibusdam perferendis qui ad. Dolore aut facere tenetur voluptatum ducimus asperiores. Soluta et voluptatem laudantium exercitationem odit id dolor aspernatur minima. Optio aut non deleniti eius.", 4, "61fcac7a-aa39-c572-5e6e-267b0f9dec5f", false, false, false, 260, "Haley - Moen", "Incidunt quia minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harrison Jacobi", "Repellat expedita deleniti officiis occaecati recusandae. Delectus laudantium aut ipsum consectetur itaque. Et non rem quos odio. Exercitationem ipsum eaque omnis tempore expedita voluptatem aut sunt et. Natus et aliquam ut.", 3, "e69aa06d-bdad-0c0e-afb2-67b83be956ab", false, false, 247, "Hermann Group", "Eos eligendi ut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Einar Runte", "Repellat neque labore recusandae. Aut facere sunt aut ut. Explicabo numquam non id. Exercitationem asperiores odio ad nulla eveniet unde ducimus est vel. Delectus voluptatibus maiores.", 5, "df065812-6d5c-e205-b248-087b0c4c74af", false, false, 258, "Ankunding - Ferry", "Culpa harum impedit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Tristian Schneider", "Qui quia ex. Sapiente ab id. Beatae esse voluptatem et dolores. Aut saepe a enim quo rerum facilis veniam fuga. Possimus ut culpa veritatis sint. Dolor nihil voluptate distinctio.", 4, "7f1d6ac5-9d7c-db8b-f089-a5854c799fd3", false, false, 158, "Schultz LLC", "Eos omnis inventore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Craig Zulauf", "Asperiores rem nihil voluptate non dolores quo quas itaque et. Reprehenderit error est totam in. Itaque praesentium perferendis velit quia. Et et atque sed nesciunt facere sed modi. Rerum et ut possimus et iste. Omnis consequatur non autem aut ad.", 2, "1c81f951-143b-c5df-2eb5-2da48c66276e", false, false, 182, "O'Connell - Roob", "Necessitatibus molestias ut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harrison Mueller", "Beatae velit distinctio omnis non sed consequuntur qui. Fugit consequuntur et illum vitae ea et qui et inventore. Ea pariatur fuga nostrum cum quia voluptas reprehenderit.", 2, "e681f3fe-6b64-c421-43f5-afd7449d29e8", false, false, 188, "Funk - McDermott", "Ipsum odio porro.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Gerard Vandervort", "Recusandae praesentium nobis et officiis necessitatibus. Omnis et magni assumenda veritatis consequatur aut deleniti. Odit harum nulla voluptas doloremque.", 2, "55b6f95f-b408-64e3-b357-b2c0d1f466f6", false, false, false, false, 107, "Hartmann Group", "Fugiat suscipit est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "ISBN", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Alford Bogisich", "Laudantium qui quisquam quis ut ut. Quia sint perferendis exercitationem quia rerum illo. Praesentium et illo consequuntur. Omnis omnis et voluptas sit. Rerum iure nulla.", "14997de5-f268-687e-7397-1d95f28d0f37", false, false, 199, "Becker and Sons", "Ut voluptas ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsDeleted", "IsNewArrival", "Pages", "Publisher", "Title" },
                values: new object[] { "Leonardo Simonis", "Unde quia consequatur numquam sint beatae ut magnam saepe deserunt. Fugiat consectetur rerum dolores rerum ea. Modi omnis vel ex cum tempore ad eligendi placeat incidunt. Ea enim necessitatibus facilis magni minima qui culpa ipsam consequuntur. Deleniti ipsa aut sapiente quia tempora eligendi. Doloremque tempore non.", 2, "505a91da-f419-453f-fddb-75091ccc4cfe", false, false, false, 124, "Casper, Jerde and Von", "Recusandae laborum voluptate." });
        }
    }
}
