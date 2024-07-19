using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCheckOutDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 3, new DateTime(2024, 7, 19, 0, 3, 41, 974, DateTimeKind.Local).AddTicks(8878), new DateTime(2026, 8, 31, 14, 28, 1, 426, DateTimeKind.Local).AddTicks(5445), "3" });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lonzo Mohr", "Ut voluptate eum et iste fuga ut dolor corporis aut. Dolores itaque facilis neque. Ex praesentium eveniet quisquam libero. Aut quia magnam et expedita eligendi ratione voluptatem. Magnam alias accusantium reiciendis et sit dolor hic.", 4, "0528be46-f488-3f68-baf8-4a9b79c9b81b", 259, "Wilkinson, Boehm and Blick", "Nobis dolores minima.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sydney Larson", "Et consequatur cupiditate similique qui laudantium rerum. Aut odio repellat sed officia explicabo est repellat. Eos quaerat rem velit. Nulla voluptatem modi. Quisquam assumenda ut consequatur eum nihil soluta beatae voluptatum non. Animi atque ea sed.", 3, "e6f5b595-3039-0cab-1f4e-6491d2c2ef64", 159, "Effertz, Abbott and Volkman", "Enim dicta quod.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Harrison Mohr", "Consequuntur ullam perspiciatis facere unde dolor. Consectetur in qui ut eligendi. Et consequatur iste.", 3, "80f8a864-f3c4-d54a-bcff-fd0d4f54feef", 161, "Borer, Hackett and Kautzer", "Dolorum reprehenderit earum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chloe Lebsack", "Libero et quia ducimus esse exercitationem ut ex neque odit. Et eos impedit earum magnam. Voluptatum eum maxime velit eaque deleniti. Assumenda officiis debitis ut eum. Ab delectus et et dolorum.", 3, "0769647e-46fe-7c04-7d06-e1604b76b544", 236, "Rath and Sons", "Sit pariatur non.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Publisher", "Title" },
                values: new object[] { "Sydni Barrows", "Ipsam est doloribus accusamus rerum nostrum reiciendis aut eos. A voluptates quasi labore quae et et et placeat error. Ea itaque asperiores nemo nemo delectus reiciendis eaque dolores.", 3, "548275dd-84d4-0670-a932-13eb67e1cfc6", "Hintz, Lebsack and Witting", "Vitae dolorem suscipit." });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Bettye Bashirian", "Dolor voluptatem aperiam sed voluptatibus aut reiciendis. Ipsa voluptatum id deserunt pariatur eius id sit consequatur eveniet. Quidem excepturi enim magnam. Eligendi eligendi facilis odio exercitationem assumenda. Explicabo rem eligendi sequi consequuntur necessitatibus.", "782ee541-0841-6173-6649-67eda25023e1", 399, "Rippin, Wyman and Sanford", "Sit officiis sunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mikel Brakus", "Beatae ipsa assumenda consequatur nulla officiis vel eveniet ut. Necessitatibus quo eveniet nulla modi omnis a voluptates. Soluta et fugiat. Molestiae possimus laborum ipsa consequuntur quo et blanditiis praesentium. Facilis porro eum sequi dignissimos quae voluptate dolorem a. Quia quaerat rerum.", 3, "3a34c283-995f-3a9c-1229-faf788ccad00", 395, "Schumm, Greenholt and Willms", "Dicta aliquid repellat.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Maximillian Moore", "Ea id enim sit veritatis. Esse sunt et voluptatem quibusdam quia. Voluptatum reiciendis quibusdam sapiente vel eligendi fugit inventore qui. Architecto quasi placeat eum quasi ad esse quia vitae.", 5, "b0ccb0e2-149d-9cec-c1de-5eb2ed5a6fb1", 422, "Pacocha, Beier and Jacobson", "Dolore rem nostrum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Grace Rempel", "A consequatur et mollitia. Quibusdam sed assumenda. Aut alias quis consequatur omnis optio est esse ipsa voluptatem. Est placeat omnis dolore consequuntur sit est. Porro consectetur enim qui tempora et rerum voluptate.", "ee0fc940-a8d6-ec62-044f-fa410b9aea09", 405, "Kohler, Gusikowski and Ernser", "Modi labore sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alisha Jacobi", "Officia magni officiis assumenda. Quia quos rem. Aperiam assumenda reprehenderit assumenda. Minima quibusdam corporis quos quod voluptas.", "8d4ba020-f8c2-2a55-809a-5e4a991938c3", 376, "Bednar, Wunsch and Lakin", "Dolorum quia velit.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Palma Schaefer", "Consequatur doloribus quis alias voluptas animi. Quia ex aut dolorum nostrum fugiat quo voluptas aut. Provident et hic repudiandae. Quia molestiae nostrum blanditiis. Quod recusandae harum aliquid cumque ea magni.", 4, "4d30eeca-53fe-9b00-7d69-64293064c1b6", 414, "Kertzmann LLC", "Sed voluptates mollitia.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Krista Koss", "Qui quod est assumenda dolorum et quod quas. Neque tenetur qui illo quia dolores. Maiores harum aut nobis sequi iusto dolorem distinctio sint.", 1, "e2483685-b29b-0d9c-fb9d-8d809c85519e", 340, "Botsford - Metz", "Quibusdam eligendi aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Zoe Kris", "Similique tempore vitae et molestias illum et tempore. Quia vel ut. Error molestiae odit quia omnis temporibus. Id molestiae magni dolorem voluptas inventore qui omnis. Culpa provident repudiandae inventore quod quis laborum libero quia.", 1, "5ff55bf7-e75e-d5a7-020d-87c0cd75b7fc", 194, "Pouros, Anderson and Nader", "Sequi ut repellendus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Esmeralda Bednar", "Quisquam voluptate et incidunt optio perspiciatis. Ullam praesentium amet dolor rerum quia ea temporibus sint optio. Sit aspernatur nobis est illum itaque placeat odit ipsam. Quia labore quaerat quia esse cupiditate molestias dolorem laborum quas. Vel accusamus ducimus necessitatibus et ut ipsam laborum accusamus. Neque consequatur a nam consequatur sed sapiente mollitia.", 4, "528cd54b-2d22-eef1-e375-f64926d0a111", 212, "Mraz, Maggio and Schuppe", "Similique sapiente harum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Haylee Baumbach", "Veritatis rerum velit necessitatibus pariatur sint laborum cumque perspiciatis. Totam atque fuga quod sequi. Soluta nulla aut excepturi officiis distinctio aperiam voluptas est. Et voluptatem dolore qui ratione. Quasi ex doloremque ratione omnis earum a consequatur soluta.", 3, "76737be1-a907-8d2e-692e-de7e5993b8e5", 445, "Medhurst, Lockman and Hegmann", "Ut laudantium ab." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "9a37f730-1883-41f6-ac02-2a5233fbc9a8", "Perry.Dickinson78@gmail.com", "Perry", "Dickinson", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/901.jpg", "42f2237b-9997-4fe9-a06c-9cada6f09a24", "Perry_Dickinson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "8ee99337-6de0-4a44-803d-7f2c3839e6a6", "Adam60@yahoo.com", "Adam", "Bechtelar", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1076.jpg", "30b67503-863e-4d21-a54f-73df31a07c05", "Adam_Bechtelar63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "95bfe01f-7dee-4948-a9bd-acab13177361", "Jose11@gmail.com", "Jose", "Ziemann", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/138.jpg", "b3c9305d-db17-472a-bfed-d68595e02f80", "Jose18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "99d30587-ce99-4a41-8171-52a76494546f", "Kevin.Dickens48@gmail.com", "Kevin", "Dickens", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1190.jpg", "bbe6d338-0b5a-4971-9157-8d72abbe0def", "Kevin59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "1fcce4e3-1108-440b-abc3-5001b6d5a69f", "Michael_Fadel@hotmail.com", "Michael", "Fadel", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/200.jpg", "bfd87ecb-e0ab-4a5b-b46b-7cdd6e507642", "Michael.Fadel48" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 8, new DateTime(2024, 7, 15, 4, 59, 51, 983, DateTimeKind.Local).AddTicks(5945), new DateTime(2025, 4, 13, 7, 7, 6, 253, DateTimeKind.Local).AddTicks(514), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 16, new DateTime(2024, 7, 15, 17, 27, 40, 946, DateTimeKind.Local).AddTicks(2127), new DateTime(2025, 6, 14, 20, 17, 1, 25, DateTimeKind.Local).AddTicks(3083), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 5, new DateTime(2024, 7, 16, 8, 22, 54, 40, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 12, 19, 3, 46, 24, 336, DateTimeKind.Local).AddTicks(9125), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 6, new DateTime(2024, 7, 14, 18, 12, 18, 523, DateTimeKind.Local).AddTicks(7458), new DateTime(2025, 1, 9, 9, 14, 14, 330, DateTimeKind.Local).AddTicks(9198), "4" });

            migrationBuilder.UpdateData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 20, new DateTime(2024, 7, 15, 7, 34, 50, 941, DateTimeKind.Local).AddTicks(2109), new DateTime(2024, 8, 26, 1, 54, 19, 292, DateTimeKind.Local).AddTicks(2541), "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Karelle Jacobson", "Voluptatem nam voluptates ducimus. Et autem hic ipsam qui rerum. Corrupti iure consequatur similique sint fuga ut ut minima. Voluptatem unde minus iusto odit. Dolor ut perspiciatis ratione. Minus aut facere et ullam nesciunt eum et.", 1, "082e5ac3-e885-0de9-245f-eccb6f93648c", 251, "Ferry LLC", "Unde facilis et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marcelle Torp", "Porro doloribus enim ut eveniet. Omnis magni vero illum modi. Suscipit quas ipsum rerum aut quis deleniti natus.", 2, "40a63a86-28a7-4f30-fce0-c05aeaec90c1", 343, "Wolf - Nader", "Exercitationem quia velit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jayde Lubowitz", "Praesentium maiores repellendus et. Laudantium fugit iure quam natus fuga. Maxime tempore suscipit sed.", 2, "21c522e4-6a9b-a3a3-69ed-8925c334c1b0", 336, "Bahringer, Pfannerstill and Mante", "Quis eum sed.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mallory Dickens", "Saepe sunt est aut perspiciatis eum. Ullam ducimus culpa perspiciatis doloremque error deserunt qui. Sit sapiente accusamus autem magni voluptatem non consequuntur reiciendis.", 4, "d173bfa3-46ba-110c-8bfa-4e18cb014097", 169, "Schowalter, Kshlerin and Hand", "Soluta quia earum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Archibald Connelly", "Incidunt dolore est laudantium ipsa. At commodi dignissimos. Quia qui quia repellat itaque aut. Autem animi doloribus voluptas repellat velit at cum et. Quia alias sunt et quo rerum.", 2, "5d0cfa13-93f7-e8c8-3084-d27d76610d57", 304, "Gerhold, Hintz and Crona", "Vero quisquam quis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Publisher", "Title" },
                values: new object[] { "Robin Wintheiser", "Doloribus voluptatum fuga laboriosam. Accusantium maiores eligendi sunt et qui ut ad. Sed voluptatem ex.", 1, "e895b9af-f208-ac5c-a716-d4f1a39fc0aa", "Heathcote Inc", "Autem eligendi in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Rashad Anderson", "Autem consequuntur ipsum error voluptate eius aut harum. Assumenda et autem omnis doloremque. Corporis dicta similique eum quo id aliquam. Deserunt eius repellat necessitatibus illo non est et. Corporis officia dolor dolores sed sequi. Quia sed et omnis a inventore aut.", 5, "b8d49ab6-e7bc-f38d-65c5-082e4f6703bd", 287, "Tromp, Hauck and Bruen", "Tenetur voluptatem atque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Syble Schneider", "Enim ut commodi accusantium aut pariatur et omnis. Autem laboriosam voluptatum natus hic recusandae possimus amet. Totam temporibus perferendis et.", "27d2e211-1c3e-4d94-1676-772f10a9d38a", 157, "Swift, Feil and Senger", "Molestias deserunt accusantium." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Florian Hahn", "Ea rerum dolore aut. Laudantium ut voluptatem dolorum qui consectetur voluptatum et itaque aut. Deleniti impedit tempora ipsam voluptatem. Ullam molestias voluptatem aspernatur quis officiis error cum quo quisquam. Quia voluptas beatae ut.", 5, "cc72f9fd-7d87-0d87-25b5-607da90ef601", 379, "Carroll - Heathcote", "Nobis ut repellendus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Sarah Romaguera", "Et dolor aspernatur rerum aspernatur voluptatem molestiae. Et modi libero illum quos maiores occaecati quaerat. Qui occaecati deserunt cumque praesentium quia ratione dolor. Est qui est.", 1, "b64d0010-71a3-dc23-a0e3-eae48d15b96c", 357, "Jones, Boyer and Langosh", "Debitis ut itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Eino Corwin", "Ipsum dignissimos accusantium officia vel fuga qui corrupti distinctio velit. Reprehenderit voluptas nemo necessitatibus alias alias animi aut itaque velit. Non sed porro non inventore quisquam. Omnis praesentium fuga quibusdam sapiente sequi eum culpa earum. Porro autem consequatur eum saepe sint enim eos repudiandae ut. Eos consequatur et sapiente in.", "8fadbf02-cc2f-79de-2877-5163d1521042", 152, "Sporer Inc", "Et deleniti modi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Joe Thompson", "Est modi dolorum sed totam distinctio sed asperiores. Minima id aut. Molestiae ut sed magnam aliquam neque expedita suscipit. Enim facere doloribus ab provident voluptatem alias. Illum vitae repudiandae rerum. Et suscipit natus sint quam.", "e3bb3337-a374-871b-ba6e-e02420dc7f80", 216, "Kutch LLC", "Dignissimos tempore magni.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hope Stiedemann", "Aliquam et consequatur facere rerum a inventore. Saepe corrupti minus eligendi neque et modi. Quis et veniam ad nihil totam.", 3, "7380cb6e-3efb-001d-9c0c-919fe87bae01", 444, "Goldner, Glover and Ernser", "Recusandae earum sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Myrl Brekke", "Enim et quibusdam tenetur. Ut rerum sit autem voluptatem eos explicabo modi incidunt aspernatur. Facere veritatis ea similique nam expedita nam officia error est. Voluptas id nulla.", 1, "50cc30c3-56d1-9a19-6987-c1041e4a3ac6", 281, "Metz, Stark and Hessel", "Culpa repellendus alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Agustina Walter", "Iste dolores illum. Sint molestiae autem tempora ut repellendus ipsam voluptas. Consequatur quidem explicabo.", 1, "fea790ac-6886-5f5b-c5aa-7110e53a3f3a", 424, "Wisozk, Wiza and Lesch", "Dolorem libero temporibus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kamren Jacobson", "Accusantium totam enim est dolorem porro. Maxime sunt nisi quo quae. Earum impedit vero vel dignissimos illo et. Numquam eius excepturi voluptas reiciendis soluta velit voluptatibus illum.", 5, "9a6c84cc-8422-8271-0284-0f91e352c4f7", 488, "Veum - Collier", "Dolore aspernatur est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kailey Hessel", "Quam assumenda sint libero. Harum velit quo quia quasi. Eum aperiam excepturi veritatis autem eos maxime doloremque occaecati.", 4, "eb2c7721-21a8-d6b0-591e-2bc954edf1d5", 129, "Hane, Moen and McGlynn", "Alias sit voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lori Barrows", "Voluptatum sed et qui. Et maiores et unde et. Animi laudantium dolores cum aliquam non quis animi voluptas. Sint nisi reprehenderit.", 4, "45ff9678-c4a9-2a33-daec-b237764fcfce", 197, "Corwin LLC", "Nemo sequi autem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Enoch Reilly", "Reprehenderit quis repellendus quo est quos. Molestiae laudantium quo. Qui consequatur earum.", 5, "a75ff493-8a12-0c50-b7e1-a2558d06660e", 190, "Stiedemann, Padberg and Schmeler", "Quia autem quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Koby Kirlin", "Eos velit eius deserunt eos eveniet. Quia enim nostrum rerum magnam earum inventore. Tenetur ea sunt quasi velit architecto est repellendus autem.", 5, "2c3a3ee1-de67-d974-b03f-495cc9850691", 197, "Runolfsson, Sawayn and Stiedemann", "Culpa optio et." });
        }
    }
}
