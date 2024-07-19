using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DueTime",
                table: "BookTransaction",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "BookTransaction",
                columns: new[] { "Id", "BookId", "CheckInTime", "CheckOutTime", "CheckedInById", "CheckedOutById", "DueTime", "UserId" },
                values: new object[,]
                {
                    { 1, 8, null, new DateTime(2024, 7, 15, 4, 59, 51, 983, DateTimeKind.Local).AddTicks(5945), null, "5", new DateTime(2025, 4, 13, 7, 7, 6, 253, DateTimeKind.Local).AddTicks(514), "4" },
                    { 2, 16, null, new DateTime(2024, 7, 15, 17, 27, 40, 946, DateTimeKind.Local).AddTicks(2127), null, "5", new DateTime(2025, 6, 14, 20, 17, 1, 25, DateTimeKind.Local).AddTicks(3083), "2" },
                    { 3, 5, null, new DateTime(2024, 7, 16, 8, 22, 54, 40, DateTimeKind.Local).AddTicks(5727), null, "5", new DateTime(2024, 12, 19, 3, 46, 24, 336, DateTimeKind.Local).AddTicks(9125), "2" },
                    { 4, 6, null, new DateTime(2024, 7, 14, 18, 12, 18, 523, DateTimeKind.Local).AddTicks(7458), null, "5", new DateTime(2025, 1, 9, 9, 14, 14, 330, DateTimeKind.Local).AddTicks(9198), "4" },
                    { 5, 20, null, new DateTime(2024, 7, 15, 7, 34, 50, 941, DateTimeKind.Local).AddTicks(2109), null, "5", new DateTime(2024, 8, 26, 1, 54, 19, 292, DateTimeKind.Local).AddTicks(2541), "2" }
                });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jayde Lubowitz", "Praesentium maiores repellendus et. Laudantium fugit iure quam natus fuga. Maxime tempore suscipit sed.", "21c522e4-6a9b-a3a3-69ed-8925c334c1b0", 336, "Bahringer, Pfannerstill and Mante", "Quis eum sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Mallory Dickens", "Saepe sunt est aut perspiciatis eum. Ullam ducimus culpa perspiciatis doloremque error deserunt qui. Sit sapiente accusamus autem magni voluptatem non consequuntur reiciendis.", 4, "d173bfa3-46ba-110c-8bfa-4e18cb014097", 169, "Schowalter, Kshlerin and Hand", "Soluta quia earum." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Robin Wintheiser", "Doloribus voluptatum fuga laboriosam. Accusantium maiores eligendi sunt et qui ut ad. Sed voluptatem ex.", 1, "e895b9af-f208-ac5c-a716-d4f1a39fc0aa", 107, "Heathcote Inc", "Autem eligendi in." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Syble Schneider", "Enim ut commodi accusantium aut pariatur et omnis. Autem laboriosam voluptatum natus hic recusandae possimus amet. Totam temporibus perferendis et.", 4, "27d2e211-1c3e-4d94-1676-772f10a9d38a", 157, "Swift, Feil and Senger", "Molestias deserunt accusantium.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Eino Corwin", "Ipsum dignissimos accusantium officia vel fuga qui corrupti distinctio velit. Reprehenderit voluptas nemo necessitatibus alias alias animi aut itaque velit. Non sed porro non inventore quisquam. Omnis praesentium fuga quibusdam sapiente sequi eum culpa earum. Porro autem consequatur eum saepe sint enim eos repudiandae ut. Eos consequatur et sapiente in.", 3, "8fadbf02-cc2f-79de-2877-5163d1521042", 152, "Sporer Inc", "Et deleniti modi.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Myrl Brekke", "Enim et quibusdam tenetur. Ut rerum sit autem voluptatem eos explicabo modi incidunt aspernatur. Facere veritatis ea similique nam expedita nam officia error est. Voluptas id nulla.", 1, "50cc30c3-56d1-9a19-6987-c1041e4a3ac6", 281, "Metz, Stark and Hessel", "Culpa repellendus alias.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kailey Hessel", "Quam assumenda sint libero. Harum velit quo quia quasi. Eum aperiam excepturi veritatis autem eos maxime doloremque occaecati.", 4, "eb2c7721-21a8-d6b0-591e-2bc954edf1d5", 129, "Hane, Moen and McGlynn", "Alias sit voluptatibus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lori Barrows", "Voluptatum sed et qui. Et maiores et unde et. Animi laudantium dolores cum aliquam non quis animi voluptas. Sint nisi reprehenderit.", "45ff9678-c4a9-2a33-daec-b237764fcfce", 197, "Corwin LLC", "Nemo sequi autem.", 2023 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookTransaction",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DueTime",
                table: "BookTransaction");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "80125229-08bc-4e0c-8373-18a97ecad5cb", "Otis.Kuhic@hotmail.com", "Otis", "Kuhic", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/934.jpg", "d84d9379-5d0f-4a91-88e2-d10e54bd6521", "Otis_Kuhic" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "bf8d02ba-7040-45e5-85b7-baff24683348", "Kurt_Hegmann@hotmail.com", "Kurt", "Hegmann", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1075.jpg", "b5c7c468-7305-4115-a7f4-17b39703aa43", "Kurt_Hegmann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "8d93b9a8-0367-4dff-9dd3-35aef2233536", "Anna.Stracke36@yahoo.com", "Anna", "Stracke", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/429.jpg", "f498631b-55bb-4ccd-a6e6-477d52f659bd", "Anna.Stracke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "e345b2c0-bbf9-4798-a7b1-a5dd6311f6dd", "Shannon.Wehner@hotmail.com", "Shannon", "Wehner", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/958.jpg", "85078e03-587d-4fc4-8d27-ee1004c54d3b", "Shannon.Wehner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfilePicture", "SecurityStamp", "UserName" },
                values: new object[] { "b9f2395a-c154-44fb-93bb-2d5c64275a98", "Guy_Stark@hotmail.com", "Guy", "Stark", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1074.jpg", "9e20caba-492f-4929-8230-ddee58853a79", "Guy15" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "D'angelo Berge", "Voluptatum totam fugit qui. Explicabo doloribus odit dolor quibusdam expedita deleniti assumenda sequi reiciendis. Sed quis dolores voluptatum praesentium eos eveniet dicta adipisci quo. Maxime earum voluptatem deleniti animi. Doloremque et et qui eum. Rerum iste sit quam qui adipisci temporibus nostrum odit.", 2, "aa3169ae-2a89-04b8-13e4-85489b1fda9f", 122, "Wuckert, Harris and Frami", "Eius delectus aliquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jacques Davis", "Cum minima porro. Rerum rem maiores minima consequatur ipsam maxime provident neque recusandae. Consequatur nemo esse aperiam consectetur impedit culpa qui culpa totam.", 5, "20e8b4de-baa1-1efd-8cfe-7236082935ca", 107, "Sipes, Kuhlman and Wehner", "Mollitia repellendus iusto.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hortense Bradtke", "Quia ea placeat qui nemo laborum sed esse. Culpa nesciunt qui eum et ut. Nostrum vel repellendus et in magni qui autem. Doloremque esse voluptas ex autem. Omnis iusto neque cupiditate ad aliquam.", "404dca34-2ccf-432c-5a21-be34c3d144e6", 432, "Dickinson Group", "Et nisi nam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brown Fahey", "Repellendus atque expedita. Vero quos dolorum non. Libero vero quia accusantium. Nihil labore enim nobis dignissimos possimus. Et a et aut consequatur voluptas rerum ipsam vel.", 5, "08bb83bf-5353-e3c5-8991-a48ee69136d4", 181, "Nikolaus Group", "Harum accusamus veritatis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marcos Lang", "Aspernatur porro qui error quis qui. Ad reiciendis dicta at natus voluptatem aut consequatur. Fuga et tenetur. Quidem fugit quaerat sint delectus voluptas nam quaerat beatae voluptatem. Veniam odio et tempora odit enim id. Labore error distinctio possimus praesentium quis vel consequuntur culpa.", 3, "ee4324fd-4369-4e4e-662b-81cc9c1975da", 174, "Stiedemann, Schimmel and Harris", "Blanditiis quis nobis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Geo Welch", "Velit quia sit. Iusto magnam vel nemo autem aliquam. Harum facere minima sed. Dignissimos numquam dolores dolorem similique omnis alias enim accusamus. Sunt ut dolorem sed et deserunt quod mollitia et. Aut aut vel facere alias tempore qui explicabo eius quaerat.", 4, "a3965d7e-33c1-be88-79f3-b439a3790660", 458, "Weissnat, Klein and Beer", "Omnis ut sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lorna Russel", "Enim dolorum accusantium. Tempora molestiae optio odio earum quod reiciendis praesentium. Consequuntur omnis quia laudantium et et autem et. Quasi et dolores est nihil sed aperiam animi atque voluptate. Rerum et voluptatum et quaerat earum maxime illo non earum.", 4, "156c03d0-7ba0-84ab-f45d-473f06393266", 144, "Predovic - Larson", "Et aperiam temporibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Billie O'Conner", "Aut et enim qui inventore recusandae corporis pariatur illum. Aperiam deserunt debitis et fugiat iure. Omnis aut incidunt ut quibusdam natus dolorem. Dolorem occaecati et aut.", 2, "eea8b772-683a-ab89-ae6d-5b1544ff0ace", 488, "Mertz LLC", "Et sed quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mitchell Legros", "Ut culpa aliquid nostrum distinctio repellendus. Porro modi eaque. Quia ad possimus vel. Atque incidunt consequatur accusantium excepturi.", 4, "9bcbf188-1147-5383-8038-fcf8ab7b3144", 454, "Powlowski - Walker", "Ut eligendi facere.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Wava Stanton", "Nihil officiis porro placeat soluta non. Eveniet animi est quae velit. Magni minus qui dolorem consequatur pariatur et a libero optio. Expedita ut nihil maxime. Adipisci perferendis minima dolores iste sapiente modi nihil repudiandae.", 3, "c2d4b59f-4c57-96a1-8ba1-9fe0fe786edf", 437, "O'Connell, Pouros and Zemlak", "Sit repellendus autem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nicholas Grant", "Sint voluptatum ipsa deserunt deserunt non. Recusandae veritatis sapiente quia ut facilis enim. Voluptates sunt sunt fugit sint quasi similique. Quam nemo quis quae sunt accusantium. Quia sed iure eaque consequatur architecto qui dolorem iste.", 4, "8c7c1641-55e9-ac34-f7b2-db41684d872e", 329, "Emard Inc", "Quia saepe velit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Laurie Windler", "Hic omnis eum. Assumenda esse nihil aliquid non. Quidem excepturi nostrum voluptatem assumenda harum nihil iste nam. Cupiditate neque non hic. Facilis ut aperiam consequatur velit sed doloribus sed excepturi.", "affdabe5-44c6-8ffd-2b6b-429fac6d68ae", 125, "Legros and Sons", "Quaerat sed aperiam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Daphnee Flatley", "Minima neque perferendis consequatur voluptate qui et optio iusto et. Culpa exercitationem in et quis dolorum quibusdam in a. Voluptate reprehenderit cumque optio eum velit sed. In nihil ratione facere culpa.", 1, "2084163a-9039-9610-f40e-62081f7e13b6", 392, "Rodriguez Group", "Sunt voluptates non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Helga Reynolds", "Blanditiis ea adipisci nihil. Facere iure occaecati ut est. Dolore sunt et ea saepe minus quisquam.", 2, "fb2f5a68-f3d3-be01-30bb-39bf4b0a6269", 226, "Fisher LLC", "Aliquid natus voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jackson Borer", "Voluptatem doloribus omnis sapiente. Deleniti quis quibusdam. Commodi mollitia cumque. Architecto quas maiores minus voluptatibus.", 4, "007747c5-e448-eef4-3cb2-a628c0a42221", 482, "Lebsack - Jacobson", "Velit quis sit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Wilfred Monahan", "Quaerat sit repudiandae repellendus ut eum quis qui. Doloremque beatae cupiditate aut ea vel. Minus consequatur fuga eius vero molestiae iure autem vero. Odit consequuntur ut nulla est consequatur laborum et natus exercitationem. Ut enim et. Magnam fuga et et aliquam.", 2, "4aef34f1-5bf3-8ea1-c066-752f93559d7f", 211, "Lockman Group", "Distinctio corporis eveniet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gilda Hansen", "Dolores temporibus doloribus et quia enim. Corrupti qui optio ducimus ratione. Et dolore autem aut vel assumenda maxime sapiente qui eos. Ut beatae natus est est consequatur rerum dolore. Quam nam tenetur. Nulla rerum quibusdam.", 2, "69d4d516-77b7-01a3-921f-37d7a9ef20af", 179, "Kuhic - Torp", "Sed sed qui.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Wilhelmine Hickle", "Quia velit asperiores aut ut voluptas ipsa vitae. Ea voluptate consectetur ratione sit non corporis aut tempore veritatis. Cumque nesciunt at recusandae quaerat nesciunt enim animi pariatur. Dignissimos dolores nihil architecto dignissimos. Qui sint optio quae quam. Excepturi consectetur optio illo voluptate ut ut in harum.", "f79c061d-9624-3afb-7986-fa6116d0093a", 364, "Schultz Inc", "Iusto et mollitia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Lazaro Jacobs", "Aperiam qui laudantium quae perspiciatis totam sint ut. Officiis facilis nulla similique. Aut consequatur molestiae ut. Eligendi rem et corrupti odit hic esse doloremque tenetur provident.", 2, "2eac8681-0871-a4eb-d855-d90efe3bb930", 420, "Nicolas LLC", "Ut sint consectetur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Valentina Stoltenberg", "Voluptate vel recusandae voluptas maxime est numquam omnis in. Quo ipsum et consequuntur commodi et totam cupiditate. Suscipit et expedita fugit eius alias assumenda odit. Blanditiis explicabo laudantium fugit quis aut dolore. Nam voluptas et eveniet autem magnam praesentium. Fugit laboriosam eum itaque excepturi qui aut.", 3, "b2069f5c-0ef5-4ff9-8c18-c873455022a1", 465, "Nolan - Batz", "Rerum itaque excepturi." });
        }
    }
}
