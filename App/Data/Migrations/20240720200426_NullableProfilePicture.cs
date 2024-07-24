using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class NullableProfilePicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "eed8beb2-3a3b-47eb-a864-e0400e5d4ed8", "Jan75@yahoo.com", "Jan", "Dach", 3, "878171b2-ba7b-4205-bf5c-ed54c106b6e9", "Jan81" });

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 18, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7760), "4" });

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
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 14, new DateTime(2024, 7, 20, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 7, 25, 16, 4, 26, 270, DateTimeKind.Local).AddTicks(8200) });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Frederic Deckow", "Quibusdam ea voluptas modi voluptates doloremque enim est voluptate. Architecto voluptatum ut sed eius veniam. Et cumque temporibus incidunt et eveniet repellendus. Aliquid commodi omnis in. Unde ab facere beatae.", 3, "cd7711ca-1353-394d-7a97-aa7cc6b3ac2d", false, 355, "Champlin Inc", "Veritatis dicta vitae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Hollis Nolan", "Vel harum non qui culpa reiciendis quod aut. Voluptas ducimus consectetur eos. Similique et officiis ullam vitae non qui.", 5, "3a193672-fdec-4fd0-8805-ca2d2679fcdc", true, false, 104, "Bins, Baumbach and Emmerich", "Quibusdam recusandae necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Floyd Conn", "Sit qui fugit sed sapiente qui. Omnis dolores saepe pariatur sunt. Qui qui suscipit mollitia sed eius quidem alias sint.", 3, "a85f1ea0-cc76-a460-9c3a-1e104330f8b4", false, 451, "Koch LLC", "Quidem voluptatibus velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brandi Donnelly", "Error quia ex ea dolorem dignissimos quam quia sit. Harum reiciendis numquam saepe. Ipsa occaecati aliquid aut numquam ducimus. Natus similique dicta quos cum voluptatum. Animi recusandae quae omnis ex sit est ducimus consequatur repellat. Repudiandae exercitationem facilis temporibus dolores nesciunt ut quod.", 3, "e2762d5d-9e14-e4a7-bab6-81c16280688e", true, true, 450, "Little and Sons", "Consectetur quos et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Aliza Bartell", "Amet adipisci asperiores aut ut qui voluptas quo consequatur odio. Laborum consequatur deleniti iure ducimus velit sapiente occaecati. Explicabo eum est numquam consectetur aliquam qui.", 4, "1f436063-66f5-0110-bd88-c2a056ab703f", 354, "Hackett, Frami and Keeling", "Aut unde numquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marian Hauck", "Reiciendis aspernatur ullam. Voluptatem magnam laudantium. Iste ut at voluptas nesciunt. Quos ducimus aperiam blanditiis adipisci exercitationem autem et.", "0cd4fcb6-3644-6f2c-2c7c-42c3e397ed5b", false, 432, "Weimann, Kerluke and Bins", "Sint aut sint.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Odessa Wyman", "Fugiat aut alias et magnam quis aut qui velit. Delectus repudiandae molestias reiciendis explicabo et inventore quia non eius. Distinctio consectetur aut velit veniam ut eos delectus esse. Repellendus voluptates recusandae eum sed fugiat unde dolores quasi voluptate. Aliquam deleniti explicabo ex recusandae provident a ullam dolor. Architecto rerum debitis deleniti doloribus eos.", 3, "ffe8f5e1-b868-adeb-fd0c-930b0353bb98", 478, "Hickle, Heaney and O'Hara", "Ut et molestiae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emelie Carroll", "Nisi iure vel distinctio facilis sit veritatis exercitationem vero. Eos ad et. Et enim et cum soluta aut et commodi ut ad. Quia perferendis consequatur ad nobis aliquid praesentium amet. Enim tempore iusto sequi recusandae vel. Sed atque saepe deserunt ut ut et id.", 1, "0acaff54-3902-2d15-f1b5-70607baf321f", 428, "McLaughlin - Friesen", "Corrupti totam autem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brigitte Boyle", "Autem vero numquam deleniti maxime porro natus officiis sit. Est mollitia et veritatis ut velit labore. Repellat sunt doloremque molestiae impedit repudiandae a sit. Consequatur aut ducimus rerum culpa eius excepturi consectetur. Occaecati omnis ut qui ipsa ipsum corporis. Et fuga enim distinctio.", "a7a44907-8c9b-7025-869e-3a7bb6bd784b", false, 393, "Feil, Fadel and Okuneva", "Labore odit quos.", 2024 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Leopold Watsica", "Ut sed sapiente est est optio. Et et ex quis ut eveniet praesentium. Eos corporis ipsum qui. Porro soluta quisquam excepturi recusandae ducimus. Et exercitationem harum commodi voluptates. Inventore quaerat voluptatum nostrum mollitia cumque quibusdam debitis id.", "723bc54c-c751-152d-af94-e92d73056547", 216, "Schuppe Group", "Molestias repellat quisquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Noemie Kutch", "Nam magnam possimus sunt sed nam molestiae quis perspiciatis ab. Vitae ipsum similique voluptate. Perspiciatis rerum alias ut.", 5, "ee77f6cf-4f82-1491-a328-fd1ad8a6057f", false, 105, "Friesen, Leuschke and Sipes", "Qui voluptate quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Linnie Blanda", "Ipsum animi vitae rerum. Quae facilis a quidem adipisci pariatur. Non ut perspiciatis. Dolor dolorem et at dolor unde et at sequi aut. Quod debitis aliquid adipisci ad molestiae enim hic nemo.", 2, "869d18b6-dc96-ad72-625b-f9eb15a28dbf", false, true, 134, "Legros - Altenwerth", "Deleniti soluta labore.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Murray Jones", "Nisi iste nihil itaque. Sed a suscipit aliquid quasi. Totam ratione earum.", "61e63d6c-f8d5-23f7-4e33-708c5943e675", true, 146, "Muller, Hessel and Windler", "Rerum ut aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Shemar Abernathy", "Sint laudantium est ut nihil cupiditate dolor. Quidem consequatur ipsam rerum veniam aut. Sint enim inventore.", 5, "311c2d8b-4e53-1aa0-7568-43673d5fbace", false, 330, "Kohler, Schroeder and Von", "Repellendus molestiae a." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Thora Moen", "Et eligendi libero molestiae ipsa. Qui consequatur facilis quae molestiae dicta eius. Velit rem et ut et. Officiis aut modi voluptatem. Maxime autem earum.", "e5245f8d-a645-1dab-ad1e-a469bd8e3762", true, false, 136, "Carroll Inc", "Repellat repellat tempore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Theodora Feeney", "Nesciunt error molestiae tenetur sit laboriosam minus fuga aut. Sequi in voluptatum laborum perspiciatis porro est ea id eum. Magnam quo hic. Rerum omnis similique minima repudiandae ut hic a odit quia. Libero ea sunt dolorum blanditiis.", 3, "51b74f0d-f977-af3a-66ab-5b67faf7388d", 103, "Purdy and Sons", "Et rerum eum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Alejandra Ebert", "Doloremque nulla eum cum. Sed enim ut. Velit in autem consequatur voluptatem occaecati et eaque. Est unde ipsum odit quas ea laudantium voluptas. Possimus eveniet et. Rem quia in hic nisi ea sit distinctio.", 1, "4f44564e-6610-2991-0535-3fcc3317d0f4", true, false, 353, "Bartell Group", "Tempora qui ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Helmer Hills", "Praesentium quod occaecati sed. Quis eum et soluta. Occaecati dolorem aut id facere nulla unde consectetur fugit doloremque. Illum reiciendis expedita itaque placeat voluptas beatae id quia. Tempore molestiae veritatis vitae dicta recusandae.", 3, "af981ad8-05fe-4485-a637-ddb74d94471c", 159, "Huels, Roberts and Hahn", "Hic dolores ea.", 2024 });

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
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 12, "2023-10-17", "Error qui quia animi et dolores similique iste et. Dolorum porro aspernatur numquam tenetur nostrum. Esse sit maiores quo rerum sed minus qui labore. Incidunt voluptatem odit eveniet dolore ut sit. Vero dolor reprehenderit ea voluptas molestiae est. Expedita quia quidem voluptatem odit et quia magnam.", 5, "4" });

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
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 8, "2023-11-20", "Laboriosam soluta blanditiis voluptate et quis et eos. Dolorem repellat eos quisquam ut. Qui aut magni qui error cumque sed. Laborum excepturi atque. Et natus ipsum qui aut nihil quasi atque ut.", 4, "2" });

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
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 17, "2024-03-06", "Corrupti odio quos praesentium. Est aliquam sed distinctio animi. Fuga est explicabo. Aut aliquam illo ut vel sapiente et voluptates. Voluptate tempora est sapiente ea mollitia voluptas at.", "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateReviewed", "Description" },
                values: new object[] { 16, "2024-03-22", "Magnam ut ad. Dolores ipsam delectus. Soluta velit quidem nostrum. Ut qui quis deleniti reiciendis." });

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
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 9, "2023-08-03", "Dolore alias distinctio dolores ut quas atque. Dolore qui possimus omnis explicabo qui sint nulla vitae. Aspernatur repudiandae vitae velit eum ut voluptatem est nostrum.", 3 });

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
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 17, "2023-12-04", "Vel inventore nihil. Ipsam quia sit eius cumque libero sit. Deserunt quo ut et.", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 5, "2024-03-30", "Quisquam eaque iure cupiditate distinctio beatae quia sit adipisci. Quia dolorem est quo veritatis unde libero distinctio unde sint. Qui architecto et facilis quasi tempore provident. Omnis temporibus qui. Eos illo quis optio dolores odio amet.", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 4, "2023-10-23", "Quia hic in id accusamus ut et exercitationem assumenda. Recusandae modi et autem consectetur corporis et. Necessitatibus autem at vel aut et aliquid numquam. Autem error consequatur labore.", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { "2023-12-13", "Sed accusantium doloremque reprehenderit et. Nam facere autem velit dolorem doloribus neque. Libero excepturi odit nam ipsam necessitatibus eum consectetur. Rerum non voluptatum porro aut. Maiores commodi repellat nulla quas. Velit eum sunt repellat nobis quibusdam quo tempora quia aut.", 1, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 2, "2024-05-27", "Ut amet cumque. Qui eius enim rerum aut. Quia ut nulla id. Tempore quas maxime. Tempore sit et assumenda earum perferendis qui aut. Similique sunt error tenetur quis consectetur.", 4, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 9, "2024-05-16", "Consequuntur voluptatum quae. Quae et illum. Reprehenderit enim sequi ipsum unde quibusdam velit ipsam. Tempore dolores eos in eaque cum.", 3, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 12, "2024-01-09", "Quia eius architecto. Praesentium minus aliquam esse quidem eum magnam et. Porro sint amet corporis molestiae temporibus. Sapiente accusamus pariatur quisquam asperiores deleniti dolorem qui sit ad. Enim voluptate quia rerum.", "2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "46631cfa-46a4-4cc6-9841-b686d09ecb8d", "Francis_VonRueden@gmail.com", "Francis", "VonRueden", 8, "4544cc07-bc95-4ea5-9766-780ae48bd8bb", "Francis32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "52bf440a-e0ee-4573-af50-f802cf4d8edc", "Dianna_Rice31@hotmail.com", "Dianna", "Rice", 24, "4cedcc3b-cb88-44c4-ab7f-e712bf595db7", "Dianna74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "2be24c8f-ebb0-41fa-abc0-c207f1fe7f5a", "Jane33@hotmail.com", "Jane", "Schaden", 1, "7e9880fc-b001-4ca9-98e4-a50b7592a380", "Jane_Schaden50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "f8837887-4ed0-4f98-8d40-0892c3f682dc", "Renee51@gmail.com", "Renee", "Volkman", 21, "b7e98fe8-0c34-42ee-b49b-33a9c6d806d3", "Renee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "First", "Last", "ProfileAvatarId", "SecurityStamp", "UserName" },
                values: new object[] { "12b77618-8d3f-44dd-ad95-8215e05d87fd", "Anthony_Gerhold@yahoo.com", "Anthony", "Gerhold", 20, "88b1086c-4605-404b-a68d-60bb93b98df8", "Anthony28" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 7, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9210), "3" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 19, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9720), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime" },
                values: new object[] { 7, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Thea Walsh", "Voluptas asperiores eligendi adipisci beatae sed assumenda aut. Et nihil reprehenderit quos assumenda vel. Consequatur occaecati maiores. Error quas eum minus.", 1, "aaa00896-bd9b-2ca4-c565-ed7789a92bed", true, 190, "Lubowitz LLC", "Quibusdam et ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Alayna Conroy", "Facilis et rerum. Voluptate dicta sed. Accusamus qui nulla quasi. Placeat asperiores deserunt.", 1, "f1794f01-0407-20ae-2024-d9474816051f", false, true, 188, "Muller Group", "Doloribus qui sequi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Delores Feest", "Doloribus neque eaque nulla non ut. Minus sed voluptatibus praesentium accusantium. Voluptatem suscipit exercitationem.", 5, "899a6ae2-e42d-38ad-be64-1fd9418403ef", true, 415, "Robel Inc", "Repellendus non dolor." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Josefina Gutmann", "Mollitia sed molestiae autem dolores consequatur et debitis architecto. Rerum praesentium veniam et quis. Omnis velit doloribus molestiae. Sit rerum qui quia quod vero beatae ut. In ut nam ut odio quod aut corporis et.", 5, "dedb5a51-3b26-9c66-f2e2-af3890c8d078", false, false, 462, "Dibbert LLC", "Explicabo eligendi id.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Missouri Reichert", "Quo et id quos molestias vero autem repellendus perspiciatis soluta. Sapiente suscipit aliquam fuga est ut aut ut ut qui. Nulla aliquam et rerum ut id explicabo nihil non.", 3, "2570d8e2-752b-ca8f-0e3c-4cba6611e30e", 308, "Cruickshank Inc", "Ad ut dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Michelle Ryan", "Unde dolor recusandae in suscipit perspiciatis nemo. Ut earum nam. Quia qui molestias alias necessitatibus eos. Asperiores nihil quia consequatur qui ducimus consectetur aperiam. Et et error enim nemo dolor voluptatem voluptatum. Et aliquam impedit quis est harum et et et.", "281fcd62-d583-53a1-e797-bab44ffd0f43", true, 312, "Gulgowski and Sons", "Reprehenderit quia veritatis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rusty Adams", "Quisquam error autem qui non tempore aut quas. Repellendus at enim dolore quisquam eveniet a rerum fuga. Veniam earum corporis. Sapiente rerum et. Earum laboriosam eum aliquid.", 1, "6c2e6fac-ec72-63b6-97b8-b4bd29040786", 463, "Lindgren - Okuneva", "Eum ratione non.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Marquise Waelchi", "Vero et quam ut neque sint magni atque. Laudantium magnam qui id sint sint ullam aliquam sint accusamus. Rerum ut voluptatem cupiditate. Numquam sunt esse rerum autem dicta aut.", 3, "9b7fedb2-22f2-966d-1747-7a7a5d052af1", 100, "Bednar LLC", "Est voluptas quod." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Isabel Lockman", "Sit odit nam repellendus quaerat a. Odit neque voluptatem unde qui ipsum labore officiis voluptatem id. Iste nesciunt perferendis aspernatur a. Voluptatem id et voluptates voluptas et ab.", "12f601f8-6922-aeae-44b9-636f03cff3db", true, 287, "Johns Inc", "Nam et repudiandae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Maudie Goodwin", "Iusto voluptas vel totam. Enim repellendus aut laborum. Modi officia qui. Ut nihil optio iure incidunt assumenda qui. Sed suscipit est autem exercitationem dolor dolor. Quo aut adipisci recusandae voluptas officiis.", 1, "a19dd26f-555a-21a4-33ef-d799dca8c902", true, true, 428, "Sporer - White", "Neque repellendus deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Nathen Kassulke", "Mollitia maiores velit omnis et nisi et excepturi. Ea autem voluptatem amet dolorem ratione sit ea est est. Earum qui illo nemo dolore. Consequatur vel neque quaerat eum delectus qui. Vitae cupiditate ea perferendis voluptatem sed dolore qui culpa.", "1e3adb0b-1d79-d375-194f-3837466a89a1", 443, "Skiles LLC", "Labore quia ratione." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Alejandrin Welch", "Tempora suscipit modi unde praesentium dolore non voluptatem. Libero et molestiae sint beatae quas animi. Quas deserunt magni consectetur quos sapiente. Illum et et in rem quas aut blanditiis veniam molestiae. Et eaque debitis vitae ab unde ut.", 3, "20b8958a-fd8f-1027-9fa2-0fcf4695bf5c", true, 191, "Bednar - Zemlak", "Vitae minima voluptates." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Herminia Breitenberg", "Libero et iste reiciendis ex rerum recusandae. Consequatur sequi beatae. Tempore rerum omnis culpa eos itaque quod saepe unde. Tempora exercitationem neque dolor dolorem sint voluptatibus quam beatae alias. Praesentium sint autem corporis omnis. Voluptate sed reiciendis voluptatum similique.", 1, "967866d8-e493-d64a-1da1-e37dc1890456", true, false, 301, "Hansen, Skiles and Ledner", "Ut enim quia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Kathryne Wintheiser", "Nam asperiores sit qui rem omnis nemo magni. Esse iure alias. Qui ullam autem nulla. Quasi ipsa accusamus laboriosam quae exercitationem eos corrupti sunt. Ad in quas sed minus. Itaque hic optio blanditiis officiis aut earum in.", "3e002e44-891f-fb37-567a-d8acaa765504", false, 257, "Becker - Stracke", "Facere similique aperiam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Dejuan Walsh", "Ut numquam quam dolor. Ut dicta soluta. Ut placeat id quia ad laboriosam recusandae quos. Veniam ad dolores adipisci odio quibusdam itaque omnis et eveniet. Maiores enim corrupti voluptatibus voluptatem corrupti non natus voluptatum. Exercitationem similique eum ea sunt quis voluptas.", 1, "9e6c6e06-d0a2-99f4-d5ee-a8320c3e50e1", true, 432, "Metz, Parker and Schroeder", "Quibusdam quasi vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Garret McCullough", "Libero quia sunt rerum modi voluptatem quod quae. Ipsum sapiente blanditiis ut est reiciendis et molestiae. Rem velit atque.", "7a9b8228-d9fe-b4ff-f600-937b2c2381d7", false, true, 316, "Hand - Stracke", "Cum eveniet eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Pablo Abernathy", "Facilis magni sit molestias odit voluptas eum atque sequi et. Nam esse iure aut quis vel est consequuntur ipsa. Id sapiente doloribus explicabo aliquam est non sit tempora ab. Illo eum laboriosam dicta impedit. Dolorem quia quisquam cum ullam possimus ea.", 4, "32c4474e-03b9-37e3-4523-671f8f3e97a8", 233, "Johnston, Ryan and Bogan", "Qui consequatur minus.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Asia Fritsch", "Et eaque qui optio similique libero odit recusandae harum. Aut doloremque placeat velit aut voluptate dolores. Ratione qui et perferendis sed nobis. Perferendis voluptatibus aperiam reiciendis ea recusandae in dolorem. Quis tempore aut eos magni quo.", 5, "d86b3a91-7456-3389-7c66-1cdf78cacd7d", false, true, 167, "Kohler - Sipes", "Facere ut est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Velma Mertz", "Molestiae sit sunt sunt nostrum sed placeat occaecati. Sit nesciunt sequi deserunt nihil quasi non illum aut. Officiis ut qui ab cupiditate nemo a accusantium ipsa. Et vel quaerat et maxime eum qui totam ut. Maxime aperiam est minus et non. Quas et qui voluptates officia soluta accusantium voluptas nihil.", 1, "52936059-6933-6f78-56df-0642e44938e5", 169, "Bergstrom Inc", "Ut exercitationem aliquid.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaci Weissnat", "Non rerum voluptatem dolores optio quos. Autem perferendis qui ut. Velit esse accusamus ipsam qui. Dolorum consectetur sed natus omnis voluptatem optio voluptates eum. Sed quia blanditiis numquam eos veritatis at sequi aut. Aut possimus eaque.", 5, "a3af90ad-ec7f-989e-04f5-b734d1026d3e", false, 234, "Volkman - Rippin", "Minima dicta eveniet." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 8, "2023-12-01", "Molestiae officiis molestiae voluptatem soluta velit. Omnis suscipit aliquid. Ea amet quo commodi aliquid nulla voluptate voluptates. Eum ad qui. Tempore deleniti reprehenderit quis nobis ullam doloribus in et. Excepturi voluptatem sed voluptas quia quam consequatur alias.", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 5, "2023-12-14", "Ex temporibus fuga et sed. Vero nesciunt doloremque eos voluptas. Hic ipsum et molestias deleniti. Nobis ad quisquam sint nobis rerum iure. Quaerat mollitia quos totam corrupti. Voluptas nihil et quibusdam nemo placeat quasi omnis.", 4, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 1, "2023-12-15", "Repudiandae ea dolore voluptate delectus id. Voluptatem eaque totam consectetur voluptate ut dicta similique inventore voluptatem. Reiciendis qui et ut id.", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 1, "2023-10-19", "Ratione tempore molestiae. Repellendus non ducimus fugiat. Est occaecati neque temporibus eum quia qui voluptatem sapiente aliquam. Quas ratione eum nostrum veritatis. Voluptas et eligendi omnis qui qui. Magnam doloribus aut vel magni aut.", 4, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 6, "2023-09-26", "Ut voluptatem autem nemo omnis alias recusandae consectetur dicta. Sed quibusdam aspernatur modi dolore odit. Recusandae possimus quas illo. In sit illum. Architecto atque voluptates earum deleniti nobis dolore.", 1, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 2, "2024-07-17", "Et nihil harum velit. Quas ea fuga ut magni minus. Ut aut ex delectus sint. A mollitia maiores. Dolor magni voluptate voluptatem rem sed vel in rerum. Sed ipsam illum officia.", 5, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 4, "2023-09-16", "Ipsam quas in et soluta voluptas amet quas. Magni modi corrupti mollitia fugiat est natus pariatur animi. Enim delectus enim inventore sit id.", 2, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 8, "2023-12-09", "Distinctio a cumque sit doloribus incidunt sapiente dolores. Aut qui reprehenderit voluptatem eos. Fuga et temporibus beatae. Nemo ut dicta laboriosam quia.", "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 3, "2023-11-04", "Suscipit saepe odio enim. Saepe quis ut. Nobis praesentium repellendus quis esse consequatur. Rerum et ducimus. Voluptas unde error perferendis eaque id repellat.", "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "DateReviewed", "Description" },
                values: new object[] { 7, "2024-04-19", "Magni voluptas enim et. Dignissimos omnis ipsum. Nobis molestias voluptas nostrum." });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 16, "2024-02-26", "Corporis velit nobis possimus sed quis. Sequi animi in voluptates. Et eum et aut suscipit voluptate explicabo voluptates consectetur sit.", 3, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 2, "2023-08-11", "Hic quia enim ut rerum sunt id non. Iusto doloremque vero temporibus deleniti nemo dolor qui. Illum maxime illo.", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 9, "2023-09-27", "Consequuntur praesentium placeat iusto eligendi itaque. Nulla sapiente recusandae et voluptatem dolore amet eaque. Similique impedit ea sed blanditiis quod aut. Quos cumque fuga dolor expedita aliquam laborum molestias. Inventore quia explicabo illum. Eius ipsa vel laboriosam sint est inventore fugiat rem.", 4, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 3, "2024-05-23", "Excepturi iusto autem totam aspernatur veritatis. Nihil tempore voluptatem. Eligendi ratione quasi aut mollitia sit blanditiis nihil. Cumque minus quia saepe veniam aut fugiat quaerat ut.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 11, "2024-01-03", "Eligendi dolor quae in officiis corrupti. Delectus ex labore rerum voluptatum eum error. Et laudantium assumenda voluptate quas accusamus debitis eveniet.", 5, "2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating" },
                values: new object[] { 5, "2024-04-06", "Expedita minima sunt vel iure veniam. Provident aut nostrum rerum magnam iure aliquam esse qui. Esse vitae quia. Consequatur inventore nisi minima architecto. Eveniet hic et aperiam culpa.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { "2024-06-23", "Et explicabo distinctio quis deleniti pariatur. Facilis ipsum dignissimos qui sed fuga quibusdam optio omnis quisquam. Voluptatem enim non. Sapiente ab dolorum aut qui eaque minus rerum maiores. Quia qui nihil maxime voluptatem fugiat est. Repudiandae eveniet omnis iure.", 5, "3" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 18, "2024-01-13", "Nesciunt rem sunt suscipit veniam quis eum sunt et et. Harum et quia. Vero voluptatem maxime quia exercitationem ut voluptatem. Sint et exercitationem aut ut possimus.", 5, "4" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[] { 16, "2024-01-20", "Praesentium aut cum id odit dignissimos non. Dolor qui et hic occaecati consequatur. Officiis sint maiores molestiae et perferendis.", 1, "1" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "DateReviewed", "Description", "UserId" },
                values: new object[] { 5, "2024-03-11", "Est sed in accusantium nisi voluptatem dolor temporibus in. Repudiandae autem qui qui sed laudantium. Eius sit quo sequi quia quas non.", "4" });
        }
    }
}
