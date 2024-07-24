using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Data.Migrations
{
    /// <inheritdoc />
    public partial class CondenseMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "e23ace36-bac2-4eb9-8b34-0d6cfa1d0133", "Tomas37@hotmail.com", "Tomas", "Roob", 35, "f606942e-0bad-4175-b631-f325d3a043a8", "Tomas.Roob32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "cefb4cd1-15cf-4113-84b1-107d15af650d", "John12@hotmail.com", "John", 22, "605c1a90-2cb9-4419-bb7a-ab2e51bdb9bc", "John_Dach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "a9f671b9-1ea5-4870-9991-2b7167249d05", "Velma5@hotmail.com", "Velma", "Schultz", 20, "9fa1e91f-66ec-458f-bf32-02d6b7283045", "Velma59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "08687605-42a0-46ec-b514-2e1ad1a45d05", "Marcos_Pagac91@hotmail.com", "Marcos", "Pagac", 26, "90b22a40-af4d-4a1e-ae9e-bb7613f9bb8c", "Marcos.Pagac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "0278ee30-7539-4134-891f-92c6f2a5c59d", "Josh_Heaney85@gmail.com", "Josh", "Heaney", 28, "ec655c1c-3139-41a0-a60a-4000b32c029f", "Josh98" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 10, new DateTime(2024, 7, 23, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 7, 28, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 15, new DateTime(2024, 7, 23, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 7, 28, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(2710), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 20, new DateTime(2024, 7, 23, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 7, 28, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 15, new DateTime(2024, 7, 23, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 7, 28, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(2730), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 10, new DateTime(2024, 7, 23, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 7, 28, 21, 33, 11, 349, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kaya Kulas", "Quidem quis soluta quod ea non eos omnis. Consequatur voluptates voluptas a quam sit sequi tempore sint soluta. Iusto aliquam voluptatibus sint explicabo. Voluptatem aut quis magnam eum qui voluptate sunt.", 5, "0f1245ed-82a8-1ac0-e85c-e0219c0a48c0", true, true, 400, "Fritsch LLC", "Distinctio doloremque amet.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Claudie Davis", "Qui nobis est nam. Quas ducimus reprehenderit suscipit quo harum sed sed. Qui architecto aut est beatae est ut sequi nemo. Sed illum maiores qui delectus blanditiis voluptatibus pariatur voluptas accusamus. Et ea animi temporibus nesciunt ipsa.", 4, "903bffbe-1f9a-a718-94b9-13d8768fe9fe", true, 112, "Hudson and Sons", "Magnam quas aliquam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Elenora Pollich", "Ducimus aut eos. Porro distinctio corporis quas. Consequatur quisquam inventore. Accusantium cumque alias architecto. Earum quas at corporis distinctio ut accusamus. Perferendis qui laboriosam consequuntur dolor voluptatibus perspiciatis qui esse natus.", 5, "dbcccf0f-a71e-280b-7da0-fbdf7386cf24", true, 325, "Sawayn, Kuhlman and Bergstrom", "Culpa aut maxime." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Dameon Brown", "Non ipsam quia ea est voluptatem. Tenetur nihil similique. Ad perspiciatis et et et suscipit. Suscipit repudiandae omnis quaerat fugit. Rerum qui non rerum aliquam omnis placeat odit. Totam odit sequi autem sit ipsum atque sed molestiae aut.", 1, "774f5c2d-4e48-95ab-9b33-1043c63c4b2e", 407, "Klocko, Lakin and Block", "Possimus tempora molestiae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Elizabeth Pfannerstill", "Dignissimos minima dignissimos. Labore modi ad doloremque aut dolorem voluptatibus eum consequuntur deleniti. Rem maiores eum ut sint incidunt fugiat illo. Suscipit asperiores rerum voluptatem occaecati maiores temporibus sed mollitia.", 5, "a29c048d-f969-2315-aa1e-d0ed29d64c89", false, 360, "Jaskolski, Strosin and Rodriguez", "Vel officia nihil." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Brooke Dietrich", "Enim ab iste eaque fuga. Itaque consectetur deleniti omnis sequi numquam. Est unde deserunt excepturi. Asperiores est reiciendis voluptatem quo nemo. Est accusantium id rerum dignissimos reprehenderit vitae quibusdam. Exercitationem ea dolorem quod quis et qui.", 4, "af9523db-0324-7486-b78d-fa4784dd6618", false, 381, "Stoltenberg Inc", "Aut et hic." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Delphine Goldner", "Quibusdam hic laudantium qui corporis. Consequuntur non rerum eaque fugiat aut ducimus. Quo ea qui inventore. Quo id sint repellat modi debitis dolor expedita eveniet. Nisi minus exercitationem. Praesentium nam et quisquam eligendi et modi iste iusto.", 5, "9cd38d83-855b-5c0e-c1bc-09c05fa4df26", true, true, 232, "Reilly, Morissette and Rolfson", "Ducimus eveniet fugit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Theron Nienow", "Labore adipisci qui est porro praesentium. Accusantium quis dolor adipisci dolor sunt qui laudantium aut quis. Sit id maiores neque doloremque distinctio. Eos ratione sit ipsam optio omnis natus qui omnis. Fuga porro iste.", 5, "4d27ffdd-7a58-7032-23e3-d515fdea249a", true, 201, "Paucek and Sons", "Molestias et voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gail Schumm", "Illum praesentium doloribus quia nulla sed. Corporis sapiente magnam occaecati quibusdam ut pariatur iusto. Nobis ipsa neque voluptate quasi vero nihil. Eligendi et omnis qui nisi. Voluptates molestiae nulla.", 1, "34284c67-39e0-3efd-104f-fb43c7452045", 298, "Feil, Weimann and Ziemann", "Quia officiis et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Raegan Watsica", "Accusamus est et quae quia quasi laboriosam placeat. Sint consequatur blanditiis eaque repellendus cumque dolorum voluptatem quos. Dolore quisquam cupiditate minus animi suscipit pariatur. Reprehenderit tempora pariatur quo omnis et minus. Aperiam omnis vel laboriosam atque. Rerum maxime quia nemo officia nostrum ut voluptatem molestias.", 3, "a24973cc-16c6-7495-20e6-1b7e99126b27", true, true, 420, "Wuckert LLC", "Illum maxime quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Zula Gusikowski", "Eius impedit est temporibus veritatis. Perspiciatis nobis sit sit molestiae deserunt dolor. Quae aut atque qui quas. Voluptatem et molestiae officia harum beatae. Suscipit error expedita quod dignissimos alias ut aut animi. Consectetur mollitia consequatur ullam rerum doloribus sint nemo.", "0ca28cf8-fde0-be1d-8a93-204b1666790c", false, 296, "Murazik - Miller", "Qui tempora voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Trudie McClure", "Accusantium culpa dicta sapiente quo neque distinctio eum. Non natus quis rem ipsam quia sint expedita. Quo velit aperiam enim mollitia quia atque aut nemo ab.", 4, "7a1dc91d-cca6-e9ab-0729-0985eb435653", true, false, 347, "Barton Group", "Consequatur saepe et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Geo Mante", "Consectetur provident cupiditate omnis. Ipsa tempore recusandae. Vel ex odit repellat temporibus numquam sit. Nesciunt animi numquam rerum et quisquam ut et quo. Dolor explicabo numquam quod aut maiores voluptatum aspernatur. Magni repellendus error odio est.", 5, "f82e27c8-f321-2d15-d0b3-eb23c115a3d4", true, 151, "Kerluke - Wiegand", "Fugit quidem officiis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Augusta Hamill", "Et aliquam nobis iste quae autem. Alias et quo. Pariatur esse omnis. Non consequatur eveniet quo deleniti neque sed. Numquam delectus beatae illo ex eaque provident.", 1, "18f83a54-327b-7f21-1526-b7498ee09fdf", false, 450, "Marks LLC", "Non esse aliquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jacques Mitchell", "Velit eos atque quia cupiditate magnam fuga. Nihil sunt quis vero veritatis asperiores. Quisquam recusandae et aut accusamus doloremque. Quisquam officiis vel.", "c28ee1a4-4a83-fe23-eb55-42912f686535", true, 497, "Nienow Inc", "Voluptas qui earum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Calista Smith", "Doloribus culpa est non reiciendis ut maxime molestiae. Ullam fugiat voluptatem exercitationem. Magnam quis delectus enim laborum sint odit. Quo voluptatem dolores est voluptatibus. Quibusdam consequatur ex ipsa impedit cumque enim tempore eius.", 3, "732e79f7-be8f-cd41-6f42-6f03e52357b0", 225, "Goodwin - Thiel", "Consequatur ut quisquam.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Loy Rempel", "Dolorem voluptatem vel voluptate soluta fuga dolore. Magnam asperiores dolores magnam. Et sit nesciunt.", 4, "20fedc9f-21f7-8fe5-748c-ce959c8db161", true, 282, "Auer Group", "Recusandae totam iusto.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Parker Adams", "Ut quod consequatur in et quidem et amet et. Quis dignissimos culpa quis numquam maxime voluptatibus veniam. Quisquam laudantium et.", 2, "afa2c9a1-65a5-b8d8-03f7-5fce737ca0d5", true, 177, "Erdman, Leuschke and Runolfsdottir", "Repudiandae illum ab." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jannie Howell", "Ipsa voluptates hic ut vitae earum sunt ratione facilis. Iure cupiditate esse officiis reprehenderit id omnis perferendis. Occaecati deleniti dolor similique. Modi nemo voluptates illum aut quibusdam. Aut voluptatibus hic similique quo quia nemo voluptatem recusandae. Nihil rem eum delectus.", 5, "ef757aba-eaeb-40a4-d506-3756895c4d33", false, false, 409, "Dooley, Kohler and Erdman", "Accusantium quis inventore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Shanon Yost", "Optio tempore sint placeat debitis ab. Accusantium libero praesentium et. Fuga quia animi deserunt ipsam labore quidem tenetur et. In suscipit reprehenderit omnis dolor sequi velit praesentium qui impedit.", 2, "55745c4b-0a8c-6943-f1b5-05687073b2c0", false, 311, "Runolfsdottir, Marvin and White", "Eum voluptate id." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 1, "2023-10-12", "Et consequatur sint. Quis voluptas vitae rerum id. Libero nihil distinctio voluptatum soluta consequatur esse saepe. Et aliquam aut dolor porro.", 4, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 5, "2024-07-23", "Mollitia hic et. Illum eum ex temporibus autem ea beatae est et. Distinctio harum quam. Aliquam maiores voluptate. Qui corrupti unde at. Sit qui sunt sed sit possimus asperiores animi fuga.", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 7, "2024-01-28", "Quos enim vel perspiciatis earum cupiditate. Eos harum eveniet dolor. Ab aut eos dolor itaque voluptate ipsum necessitatibus.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { "2024-01-07", "Dicta eligendi aspernatur nemo aut quis ut est sapiente. Ut cumque ut consectetur optio quidem non. Est ut odit culpa. Aut quos assumenda fugiat consequuntur.", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 2, "2023-09-27", "Aut est beatae assumenda corrupti ut consequatur. Fugit minima officiis qui labore aut non voluptatum iure rem. Et velit nostrum aperiam beatae et repellendus possimus consequatur. Veniam tenetur dolorum qui. Iste minus ipsum sint nobis harum qui nemo quae.", 3, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 6, "2024-06-15", "Necessitatibus quos sit sunt aspernatur qui et non. Tenetur fugit aut veniam est soluta. Architecto quis quis. Placeat provident provident aspernatur dolor ut voluptatem dicta soluta nobis. Rerum beatae laboriosam.", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 20, "2023-10-15", "Quaerat laborum ut consectetur fuga hic. Velit atque modi exercitationem enim eius ut. Vel reprehenderit ipsa recusandae excepturi quasi sint. In provident vero ut eveniet quisquam. Tempore consequatur neque reiciendis et est quasi. Facilis rerum sunt autem vel sit ut porro.", 5, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 20, "2024-04-12", "Maxime consequuntur quisquam quibusdam iste accusamus aliquid animi itaque. Suscipit sed dolor. Voluptas magni voluptatibus ratione.", "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 7, "2024-01-17", "Maiores voluptatem dolorum nesciunt ducimus reiciendis ipsa. Id incidunt reiciendis. Aspernatur tempora officia sed facilis corrupti. Autem qui eius voluptatem officia accusantium nemo magnam earum ut. Ad aperiam in modi omnis officia est ut est vel.", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2023-12-14", "Nobis officia earum ipsum distinctio quia. Enim incidunt non harum corporis atque rerum voluptates. Repellat necessitatibus ipsam explicabo natus assumenda expedita. Soluta beatae aut ut doloremque dolore nulla. Quis ex iste ullam sit officia est.", 3, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 15, "2024-05-22", "Expedita assumenda iure et. Quam commodi et dolorem repudiandae. Eos consequatur consequatur ex mollitia omnis incidunt deserunt. Et ipsum quo quasi.", 1, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 7, "2023-12-04", "Tenetur voluptas tenetur omnis officiis omnis nobis eligendi adipisci. Consequuntur nostrum repellat ut quia deserunt earum soluta. A eum sit dolor eius a. Voluptatem debitis eum. Qui sit nobis velit consequuntur. Quasi rerum repudiandae omnis velit in sit impedit excepturi saepe.", 5, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 16, "2023-12-23", "Sint voluptatem dolor. Cumque officia non ut porro. Inventore iste sint amet officia quo est aspernatur minima. Nobis laboriosam omnis numquam. Enim at magni dolorum. Vitae deserunt et temporibus eligendi et nemo enim.", 5, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2023-10-01", "Non ea animi enim beatae. In vel eius blanditiis autem eum maxime impedit. Vel est id inventore accusantium et quaerat reprehenderit.", 4, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 15, "2023-12-12", "Nihil sit enim ipsa. Minus unde minima corporis ut quo. Voluptatum dignissimos consequatur ut inventore suscipit cupiditate nobis. At id repudiandae occaecati qui ut quia laboriosam et tenetur. Facere itaque fuga quas.", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 10, "2023-12-06", "Nostrum vero alias consectetur quas placeat doloremque qui id incidunt. Dicta animi atque consequuntur facere non sequi. Voluptatem animi reprehenderit laudantium. Necessitatibus eos repellendus autem sit culpa non et consectetur dolorem. Delectus nemo eos beatae cum.", 1, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2024-01-12", "Dolores tenetur iure cumque sequi voluptatibus maxime omnis quidem repellendus. Distinctio dolorum et amet est optio aut quia. Rerum unde deserunt. Sapiente id quod explicabo aut. Reprehenderit vel quis. Quia sed neque iusto cum id est sit deleniti aliquam.", 3, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 19, "2023-12-30", "Magni molestiae cum cum laudantium voluptas sed. Possimus id qui dolorum soluta non eaque. Repellendus blanditiis quis fugit et molestiae autem ab. Aut voluptate hic mollitia distinctio qui aut voluptates eligendi itaque.", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 11, "2023-11-19", "Et inventore et. Animi velit similique natus quae doloremque officiis sed laboriosam sed. Provident fugiat impedit reiciendis nostrum. Rerum cumque sunt quia expedita id commodi. Perferendis porro consequuntur autem veniam est harum sunt.", 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 13, "2023-08-03", "Sed rerum iusto corporis similique nam temporibus aliquam deleniti. Aut aut tempore quo. Consequuntur iure perferendis qui aut dolore in. Quidem repudiandae nisi magni. Maiores ut quidem aut natus ut commodi sit.", 2, "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "b44134aa-5677-4d39-997f-b0eb55020cdf", "Darnell35@hotmail.com", "Darnell", "Gutkowski", 13, "cf4fefc2-39ef-459a-87ff-a177635ee78e", "Darnell_Gutkowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "eed8beb2-3a3b-47eb-a864-e0400e5d4ed8", "Jan75@yahoo.com", "Jan", 3, "878171b2-ba7b-4205-bf5c-ed54c106b6e9", "Jan81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "597c8de0-a6dd-44f1-a07b-02a460f41bcf", "Marta_Rolfson14@gmail.com", "Marta", "Rolfson", 15, "cf43e31f-cf02-43d2-a32b-af9252347cbc", "Marta55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "fd1f91b0-6040-40a2-a3b6-d675fc1e7ddf", "Louise.Leffler51@yahoo.com", "Louise", "Leffler", 27, "dbe8986e-74a4-45dd-a2e2-ae539e7dec3a", "Louise53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "3fc285f2-c964-44fc-bdd7-f23a6186c19e", "Forrest58@gmail.com", "Forrest", "Gusikowski", 7, "a64c53f4-2fdb-4d58-b387-a4906bbb647c", "Forrest.Gusikowski81" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 18, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 17, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(8180), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 8, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 14, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(8200), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 13, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Frederic Deckow", "Quibusdam ea voluptas modi voluptates doloremque enim est voluptate. Architecto voluptatum ut sed eius veniam. Et cumque temporibus incidunt et eveniet repellendus. Aliquid commodi omnis in. Unde ab facere beatae.", 3, "cd7711ca-1353-394d-7a97-aa7cc6b3ac2d", false, false, 355, "Champlin Inc", "Veritatis dicta vitae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hollis Nolan", "Vel harum non qui culpa reiciendis quod aut. Voluptas ducimus consectetur eos. Similique et officiis ullam vitae non qui.", 5, "3a193672-fdec-4fd0-8805-ca2d2679fcdc", false, 104, "Bins, Baumbach and Emmerich", "Quibusdam recusandae necessitatibus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Floyd Conn", "Sit qui fugit sed sapiente qui. Omnis dolores saepe pariatur sunt. Qui qui suscipit mollitia sed eius quidem alias sint.", 3, "a85f1ea0-cc76-a460-9c3a-1e104330f8b4", false, 451, "Koch LLC", "Quidem voluptatibus velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brandi Donnelly", "Error quia ex ea dolorem dignissimos quam quia sit. Harum reiciendis numquam saepe. Ipsa occaecati aliquid aut numquam ducimus. Natus similique dicta quos cum voluptatum. Animi recusandae quae omnis ex sit est ducimus consequatur repellat. Repudiandae exercitationem facilis temporibus dolores nesciunt ut quod.", 3, "e2762d5d-9e14-e4a7-bab6-81c16280688e", 450, "Little and Sons", "Consectetur quos et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Aliza Bartell", "Amet adipisci asperiores aut ut qui voluptas quo consequatur odio. Laborum consequatur deleniti iure ducimus velit sapiente occaecati. Explicabo eum est numquam consectetur aliquam qui.", 4, "1f436063-66f5-0110-bd88-c2a056ab703f", true, 354, "Hackett, Frami and Keeling", "Aut unde numquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Marian Hauck", "Reiciendis aspernatur ullam. Voluptatem magnam laudantium. Iste ut at voluptas nesciunt. Quos ducimus aperiam blanditiis adipisci exercitationem autem et.", 1, "0cd4fcb6-3644-6f2c-2c7c-42c3e397ed5b", true, 432, "Weimann, Kerluke and Bins", "Sint aut sint." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Odessa Wyman", "Fugiat aut alias et magnam quis aut qui velit. Delectus repudiandae molestias reiciendis explicabo et inventore quia non eius. Distinctio consectetur aut velit veniam ut eos delectus esse. Repellendus voluptates recusandae eum sed fugiat unde dolores quasi voluptate. Aliquam deleniti explicabo ex recusandae provident a ullam dolor. Architecto rerum debitis deleniti doloribus eos.", 3, "ffe8f5e1-b868-adeb-fd0c-930b0353bb98", false, false, 478, "Hickle, Heaney and O'Hara", "Ut et molestiae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Emelie Carroll", "Nisi iure vel distinctio facilis sit veritatis exercitationem vero. Eos ad et. Et enim et cum soluta aut et commodi ut ad. Quia perferendis consequatur ad nobis aliquid praesentium amet. Enim tempore iusto sequi recusandae vel. Sed atque saepe deserunt ut ut et id.", 1, "0acaff54-3902-2d15-f1b5-70607baf321f", false, 428, "McLaughlin - Friesen", "Corrupti totam autem.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brigitte Boyle", "Autem vero numquam deleniti maxime porro natus officiis sit. Est mollitia et veritatis ut velit labore. Repellat sunt doloremque molestiae impedit repudiandae a sit. Consequatur aut ducimus rerum culpa eius excepturi consectetur. Occaecati omnis ut qui ipsa ipsum corporis. Et fuga enim distinctio.", 3, "a7a44907-8c9b-7025-869e-3a7bb6bd784b", 393, "Feil, Fadel and Okuneva", "Labore odit quos.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jackson Kuphal", "Omnis porro dicta dolores et. Et eveniet sapiente dolor quasi excepturi aut. Error voluptatem consectetur voluptatem aspernatur.", 4, "ef1679a5-9143-0c8f-778d-365db89475a3", false, false, 210, "Quigley - Conroy", "Consectetur fugiat aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Leopold Watsica", "Ut sed sapiente est est optio. Et et ex quis ut eveniet praesentium. Eos corporis ipsum qui. Porro soluta quisquam excepturi recusandae ducimus. Et exercitationem harum commodi voluptates. Inventore quaerat voluptatum nostrum mollitia cumque quibusdam debitis id.", "723bc54c-c751-152d-af94-e92d73056547", true, 216, "Schuppe Group", "Molestias repellat quisquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Noemie Kutch", "Nam magnam possimus sunt sed nam molestiae quis perspiciatis ab. Vitae ipsum similique voluptate. Perspiciatis rerum alias ut.", 5, "ee77f6cf-4f82-1491-a328-fd1ad8a6057f", false, true, 105, "Friesen, Leuschke and Sipes", "Qui voluptate quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Linnie Blanda", "Ipsum animi vitae rerum. Quae facilis a quidem adipisci pariatur. Non ut perspiciatis. Dolor dolorem et at dolor unde et at sequi aut. Quod debitis aliquid adipisci ad molestiae enim hic nemo.", 2, "869d18b6-dc96-ad72-625b-f9eb15a28dbf", false, 134, "Legros - Altenwerth", "Deleniti soluta labore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Murray Jones", "Nisi iste nihil itaque. Sed a suscipit aliquid quasi. Totam ratione earum.", 3, "61e63d6c-f8d5-23f7-4e33-708c5943e675", true, 146, "Muller, Hessel and Windler", "Rerum ut aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Shemar Abernathy", "Sint laudantium est ut nihil cupiditate dolor. Quidem consequatur ipsam rerum veniam aut. Sint enim inventore.", "311c2d8b-4e53-1aa0-7568-43673d5fbace", false, 330, "Kohler, Schroeder and Von", "Repellendus molestiae a." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Thora Moen", "Et eligendi libero molestiae ipsa. Qui consequatur facilis quae molestiae dicta eius. Velit rem et ut et. Officiis aut modi voluptatem. Maxime autem earum.", 5, "e5245f8d-a645-1dab-ad1e-a469bd8e3762", 136, "Carroll Inc", "Repellat repellat tempore.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Theodora Feeney", "Nesciunt error molestiae tenetur sit laboriosam minus fuga aut. Sequi in voluptatum laborum perspiciatis porro est ea id eum. Magnam quo hic. Rerum omnis similique minima repudiandae ut hic a odit quia. Libero ea sunt dolorum blanditiis.", 3, "51b74f0d-f977-af3a-66ab-5b67faf7388d", false, 103, "Purdy and Sons", "Et rerum eum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Alejandra Ebert", "Doloremque nulla eum cum. Sed enim ut. Velit in autem consequatur voluptatem occaecati et eaque. Est unde ipsum odit quas ea laudantium voluptas. Possimus eveniet et. Rem quia in hic nisi ea sit distinctio.", 1, "4f44564e-6610-2991-0535-3fcc3317d0f4", false, 353, "Bartell Group", "Tempora qui ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Helmer Hills", "Praesentium quod occaecati sed. Quis eum et soluta. Occaecati dolorem aut id facere nulla unde consectetur fugit doloremque. Illum reiciendis expedita itaque placeat voluptas beatae id quia. Tempore molestiae veritatis vitae dicta recusandae.", 3, "af981ad8-05fe-4485-a637-ddb74d94471c", true, true, 159, "Huels, Roberts and Hahn", "Hic dolores ea." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Jerel Blanda", "Rerum eos laboriosam vero. Ipsa sunt modi dolorum. Consectetur ipsam nesciunt. Illo delectus tempore non rem architecto itaque incidunt laudantium voluptatem. Aliquid vero repellat hic dignissimos. Itaque ab aut voluptas.", 3, "ac4d3bb9-e2f4-be7d-f21f-15aadca0d85e", true, 356, "Kris - Haag", "Qui dolor vero." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2024-03-31", "Tempore omnis possimus ipsa et est necessitatibus voluptatum at atque. Sint at maiores officia voluptas dolores ab voluptatem voluptas non. Fuga illum omnis quo. In accusamus odio. Vero ex numquam. Voluptatem dolore sequi mollitia optio ea occaecati.", 1, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 6, "2024-04-10", "Non ratione minus accusantium enim quisquam rerum rem explicabo. Eaque suscipit molestias dolores facere ducimus sapiente et. Aliquam expedita adipisci est repellendus necessitatibus error ullam eos. Recusandae voluptatem quos esse eum aut sit id enim. Molestiae maxime non delectus natus cumque iste.", 1, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 19, "2024-04-06", "Dolores similique quia. Vel ipsam rem dolores omnis. Numquam et aperiam. Quo voluptates omnis magnam. Voluptatibus nobis nisi delectus. Illum aliquam nam quos.", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { "2023-10-17", "Error qui quia animi et dolores similique iste et. Dolorum porro aspernatur numquam tenetur nostrum. Esse sit maiores quo rerum sed minus qui labore. Incidunt voluptatem odit eveniet dolore ut sit. Vero dolor reprehenderit ea voluptas molestiae est. Expedita quia quidem voluptatem odit et quia magnam.", 5, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 17, "2023-10-22", "Aut repudiandae voluptas quo eum enim asperiores aut. Sit veritatis aliquam et. Qui ipsum minus sint quia iste dolorem.", 5, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 8, "2023-11-20", "Laboriosam soluta blanditiis voluptate et quis et eos. Dolorem repellat eos quisquam ut. Qui aut magni qui error cumque sed. Laborum excepturi atque. Et natus ipsum qui aut nihil quasi atque ut.", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 6, "2023-10-22", "Et sed et ratione labore consequatur odit modi explicabo laudantium. Molestiae non qui dolores reprehenderit est. Error tempore voluptas iusto officiis. Amet quia similique qui et occaecati nesciunt culpa.", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 16, "2023-09-25", "Facilis quaerat mollitia non numquam fugit. Repellat quidem sed eos voluptas esse nesciunt soluta harum officia. Perspiciatis rerum fugit. Nobis id officiis vitae nesciunt itaque quam ex. Perferendis non eum nulla sit tempora dolores. Et voluptatem quaerat omnis.", "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 17, "2024-03-06", "Corrupti odio quos praesentium. Est aliquam sed distinctio animi. Fuga est explicabo. Aut aliquam illo ut vel sapiente et voluptates. Voluptate tempora est sapiente ea mollitia voluptas at.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 16, "2024-03-22", "Magnam ut ad. Dolores ipsam delectus. Soluta velit quidem nostrum. Ut qui quis deleniti reiciendis.", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 6, "2024-04-20", "Excepturi omnis velit exercitationem ut asperiores. Quas et dolores dolorem et delectus. Illo magni dolor et enim. Sit est aliquam. Itaque amet quia voluptas dolore consequatur. Illo quae pariatur velit voluptatum.", 2, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 9, "2023-08-03", "Dolore alias distinctio dolores ut quas atque. Dolore qui possimus omnis explicabo qui sint nulla vitae. Aspernatur repudiandae vitae velit eum ut voluptatem est nostrum.", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2024-07-17", "Ipsam dignissimos quis. Consequatur ipsum aut voluptatem voluptatem. Ad nam culpa et iusto modi animi sed. Quo eveniet modi exercitationem dolores et error. Quasi quisquam nobis molestiae est ea. Nobis qui sed suscipit eum.", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 17, "2023-12-04", "Vel inventore nihil. Ipsam quia sit eius cumque libero sit. Deserunt quo ut et.", 2, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 5, "2024-03-30", "Quisquam eaque iure cupiditate distinctio beatae quia sit adipisci. Quia dolorem est quo veritatis unde libero distinctio unde sint. Qui architecto et facilis quasi tempore provident. Omnis temporibus qui. Eos illo quis optio dolores odio amet.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 4, "2023-10-23", "Quia hic in id accusamus ut et exercitationem assumenda. Recusandae modi et autem consectetur corporis et. Necessitatibus autem at vel aut et aliquid numquam. Autem error consequatur labore.", 3, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 5, "2023-12-13", "Sed accusantium doloremque reprehenderit et. Nam facere autem velit dolorem doloribus neque. Libero excepturi odit nam ipsam necessitatibus eum consectetur. Rerum non voluptatum porro aut. Maiores commodi repellat nulla quas. Velit eum sunt repellat nobis quibusdam quo tempora quia aut.", 1, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 2, "2024-05-27", "Ut amet cumque. Qui eius enim rerum aut. Quia ut nulla id. Tempore quas maxime. Tempore sit et assumenda earum perferendis qui aut. Similique sunt error tenetur quis consectetur.", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 9, "2024-05-16", "Consequuntur voluptatum quae. Quae et illum. Reprehenderit enim sequi ipsum unde quibusdam velit ipsam. Tempore dolores eos in eaque cum.", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 12, "2024-01-09", "Quia eius architecto. Praesentium minus aliquam esse quidem eum magnam et. Porro sint amet corporis molestiae temporibus. Sapiente accusamus pariatur quisquam asperiores deleniti dolorem qui sit ad. Enim voluptate quia rerum.", 5, "2" });
        }
    }
}
