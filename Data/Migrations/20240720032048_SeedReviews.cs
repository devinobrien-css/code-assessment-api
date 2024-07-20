using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9740), "2" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 10, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9750), "1" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CheckOutTime", "DueTime", "UserId" },
                values: new object[] { 7, new DateTime(2024, 7, 19, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 7, 24, 23, 20, 47, 746, DateTimeKind.Local).AddTicks(9760), "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Thea Walsh", "Voluptas asperiores eligendi adipisci beatae sed assumenda aut. Et nihil reprehenderit quos assumenda vel. Consequatur occaecati maiores. Error quas eum minus.", 1, "aaa00896-bd9b-2ca4-c565-ed7789a92bed", true, 190, "Lubowitz LLC", "Quibusdam et ipsam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alayna Conroy", "Facilis et rerum. Voluptate dicta sed. Accusamus qui nulla quasi. Placeat asperiores deserunt.", 1, "f1794f01-0407-20ae-2024-d9474816051f", false, true, 188, "Muller Group", "Doloribus qui sequi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Delores Feest", "Doloribus neque eaque nulla non ut. Minus sed voluptatibus praesentium accusantium. Voluptatem suscipit exercitationem.", "899a6ae2-e42d-38ad-be64-1fd9418403ef", 415, "Robel Inc", "Repellendus non dolor.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Josefina Gutmann", "Mollitia sed molestiae autem dolores consequatur et debitis architecto. Rerum praesentium veniam et quis. Omnis velit doloribus molestiae. Sit rerum qui quia quod vero beatae ut. In ut nam ut odio quod aut corporis et.", 5, "dedb5a51-3b26-9c66-f2e2-af3890c8d078", false, 462, "Dibbert LLC", "Explicabo eligendi id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Missouri Reichert", "Quo et id quos molestias vero autem repellendus perspiciatis soluta. Sapiente suscipit aliquam fuga est ut aut ut ut qui. Nulla aliquam et rerum ut id explicabo nihil non.", 3, "2570d8e2-752b-ca8f-0e3c-4cba6611e30e", true, 308, "Cruickshank Inc", "Ad ut dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Michelle Ryan", "Unde dolor recusandae in suscipit perspiciatis nemo. Ut earum nam. Quia qui molestias alias necessitatibus eos. Asperiores nihil quia consequatur qui ducimus consectetur aperiam. Et et error enim nemo dolor voluptatem voluptatum. Et aliquam impedit quis est harum et et et.", "281fcd62-d583-53a1-e797-bab44ffd0f43", 312, "Gulgowski and Sons", "Reprehenderit quia veritatis." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marquise Waelchi", "Vero et quam ut neque sint magni atque. Laudantium magnam qui id sint sint ullam aliquam sint accusamus. Rerum ut voluptatem cupiditate. Numquam sunt esse rerum autem dicta aut.", 3, "9b7fedb2-22f2-966d-1747-7a7a5d052af1", true, 100, "Bednar LLC", "Est voluptas quod.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Isabel Lockman", "Sit odit nam repellendus quaerat a. Odit neque voluptatem unde qui ipsum labore officiis voluptatem id. Iste nesciunt perferendis aspernatur a. Voluptatem id et voluptates voluptas et ab.", 3, "12f601f8-6922-aeae-44b9-636f03cff3db", true, 287, "Johns Inc", "Nam et repudiandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maudie Goodwin", "Iusto voluptas vel totam. Enim repellendus aut laborum. Modi officia qui. Ut nihil optio iure incidunt assumenda qui. Sed suscipit est autem exercitationem dolor dolor. Quo aut adipisci recusandae voluptas officiis.", 1, "a19dd26f-555a-21a4-33ef-d799dca8c902", true, true, 428, "Sporer - White", "Neque repellendus deserunt.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Nathen Kassulke", "Mollitia maiores velit omnis et nisi et excepturi. Ea autem voluptatem amet dolorem ratione sit ea est est. Earum qui illo nemo dolore. Consequatur vel neque quaerat eum delectus qui. Vitae cupiditate ea perferendis voluptatem sed dolore qui culpa.", 2, "1e3adb0b-1d79-d375-194f-3837466a89a1", true, 443, "Skiles LLC", "Labore quia ratione.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alejandrin Welch", "Tempora suscipit modi unde praesentium dolore non voluptatem. Libero et molestiae sint beatae quas animi. Quas deserunt magni consectetur quos sapiente. Illum et et in rem quas aut blanditiis veniam molestiae. Et eaque debitis vitae ab unde ut.", 3, "20b8958a-fd8f-1027-9fa2-0fcf4695bf5c", 191, "Bednar - Zemlak", "Vitae minima voluptates.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Herminia Breitenberg", "Libero et iste reiciendis ex rerum recusandae. Consequatur sequi beatae. Tempore rerum omnis culpa eos itaque quod saepe unde. Tempora exercitationem neque dolor dolorem sint voluptatibus quam beatae alias. Praesentium sint autem corporis omnis. Voluptate sed reiciendis voluptatum similique.", 1, "967866d8-e493-d64a-1da1-e37dc1890456", true, false, 301, "Hansen, Skiles and Ledner", "Ut enim quia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kathryne Wintheiser", "Nam asperiores sit qui rem omnis nemo magni. Esse iure alias. Qui ullam autem nulla. Quasi ipsa accusamus laboriosam quae exercitationem eos corrupti sunt. Ad in quas sed minus. Itaque hic optio blanditiis officiis aut earum in.", 3, "3e002e44-891f-fb37-567a-d8acaa765504", 257, "Becker - Stracke", "Facere similique aperiam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Dejuan Walsh", "Ut numquam quam dolor. Ut dicta soluta. Ut placeat id quia ad laboriosam recusandae quos. Veniam ad dolores adipisci odio quibusdam itaque omnis et eveniet. Maiores enim corrupti voluptatibus voluptatem corrupti non natus voluptatum. Exercitationem similique eum ea sunt quis voluptas.", 1, "9e6c6e06-d0a2-99f4-d5ee-a8320c3e50e1", 432, "Metz, Parker and Schroeder", "Quibusdam quasi vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Garret McCullough", "Libero quia sunt rerum modi voluptatem quod quae. Ipsum sapiente blanditiis ut est reiciendis et molestiae. Rem velit atque.", 5, "7a9b8228-d9fe-b4ff-f600-937b2c2381d7", false, 316, "Hand - Stracke", "Cum eveniet eum.", 2024 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Asia Fritsch", "Et eaque qui optio similique libero odit recusandae harum. Aut doloremque placeat velit aut voluptate dolores. Ratione qui et perferendis sed nobis. Perferendis voluptatibus aperiam reiciendis ea recusandae in dolorem. Quis tempore aut eos magni quo.", 5, "d86b3a91-7456-3389-7c66-1cdf78cacd7d", false, 167, "Kohler - Sipes", "Facere ut est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Velma Mertz", "Molestiae sit sunt sunt nostrum sed placeat occaecati. Sit nesciunt sequi deserunt nihil quasi non illum aut. Officiis ut qui ab cupiditate nemo a accusantium ipsa. Et vel quaerat et maxime eum qui totam ut. Maxime aperiam est minus et non. Quas et qui voluptates officia soluta accusantium voluptas nihil.", 1, "52936059-6933-6f78-56df-0642e44938e5", 169, "Bergstrom Inc", "Ut exercitationem aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaci Weissnat", "Non rerum voluptatem dolores optio quos. Autem perferendis qui ut. Velit esse accusamus ipsam qui. Dolorum consectetur sed natus omnis voluptatem optio voluptates eum. Sed quia blanditiis numquam eos veritatis at sequi aut. Aut possimus eaque.", 5, "a3af90ad-ec7f-989e-04f5-b734d1026d3e", 234, "Volkman - Rippin", "Minima dicta eveniet." });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "DateReviewed", "Description", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, 8, "2023-12-01", "Molestiae officiis molestiae voluptatem soluta velit. Omnis suscipit aliquid. Ea amet quo commodi aliquid nulla voluptate voluptates. Eum ad qui. Tempore deleniti reprehenderit quis nobis ullam doloribus in et. Excepturi voluptatem sed voluptas quia quam consequatur alias.", 4, "1" },
                    { 2, 5, "2023-12-14", "Ex temporibus fuga et sed. Vero nesciunt doloremque eos voluptas. Hic ipsum et molestias deleniti. Nobis ad quisquam sint nobis rerum iure. Quaerat mollitia quos totam corrupti. Voluptas nihil et quibusdam nemo placeat quasi omnis.", 4, "1" },
                    { 3, 1, "2023-12-15", "Repudiandae ea dolore voluptate delectus id. Voluptatem eaque totam consectetur voluptate ut dicta similique inventore voluptatem. Reiciendis qui et ut id.", 3, "4" },
                    { 4, 1, "2023-10-19", "Ratione tempore molestiae. Repellendus non ducimus fugiat. Est occaecati neque temporibus eum quia qui voluptatem sapiente aliquam. Quas ratione eum nostrum veritatis. Voluptas et eligendi omnis qui qui. Magnam doloribus aut vel magni aut.", 4, "2" },
                    { 5, 6, "2023-09-26", "Ut voluptatem autem nemo omnis alias recusandae consectetur dicta. Sed quibusdam aspernatur modi dolore odit. Recusandae possimus quas illo. In sit illum. Architecto atque voluptates earum deleniti nobis dolore.", 1, "3" },
                    { 6, 2, "2024-07-17", "Et nihil harum velit. Quas ea fuga ut magni minus. Ut aut ex delectus sint. A mollitia maiores. Dolor magni voluptate voluptatem rem sed vel in rerum. Sed ipsam illum officia.", 5, "3" },
                    { 7, 4, "2023-09-16", "Ipsam quas in et soluta voluptas amet quas. Magni modi corrupti mollitia fugiat est natus pariatur animi. Enim delectus enim inventore sit id.", 2, "4" },
                    { 8, 8, "2023-12-09", "Distinctio a cumque sit doloribus incidunt sapiente dolores. Aut qui reprehenderit voluptatem eos. Fuga et temporibus beatae. Nemo ut dicta laboriosam quia.", 3, "4" },
                    { 9, 3, "2023-11-04", "Suscipit saepe odio enim. Saepe quis ut. Nobis praesentium repellendus quis esse consequatur. Rerum et ducimus. Voluptas unde error perferendis eaque id repellat.", 1, "1" },
                    { 10, 7, "2024-04-19", "Magni voluptas enim et. Dignissimos omnis ipsum. Nobis molestias voluptas nostrum.", 1, "1" },
                    { 11, 16, "2024-02-26", "Corporis velit nobis possimus sed quis. Sequi animi in voluptates. Et eum et aut suscipit voluptate explicabo voluptates consectetur sit.", 3, "2" },
                    { 12, 2, "2023-08-11", "Hic quia enim ut rerum sunt id non. Iusto doloremque vero temporibus deleniti nemo dolor qui. Illum maxime illo.", 2, "2" },
                    { 13, 9, "2023-09-27", "Consequuntur praesentium placeat iusto eligendi itaque. Nulla sapiente recusandae et voluptatem dolore amet eaque. Similique impedit ea sed blanditiis quod aut. Quos cumque fuga dolor expedita aliquam laborum molestias. Inventore quia explicabo illum. Eius ipsa vel laboriosam sint est inventore fugiat rem.", 4, "4" },
                    { 14, 3, "2024-05-23", "Excepturi iusto autem totam aspernatur veritatis. Nihil tempore voluptatem. Eligendi ratione quasi aut mollitia sit blanditiis nihil. Cumque minus quia saepe veniam aut fugiat quaerat ut.", 1, "1" },
                    { 15, 11, "2024-01-03", "Eligendi dolor quae in officiis corrupti. Delectus ex labore rerum voluptatum eum error. Et laudantium assumenda voluptate quas accusamus debitis eveniet.", 5, "2" },
                    { 16, 5, "2024-04-06", "Expedita minima sunt vel iure veniam. Provident aut nostrum rerum magnam iure aliquam esse qui. Esse vitae quia. Consequatur inventore nisi minima architecto. Eveniet hic et aperiam culpa.", 1, "4" },
                    { 17, 5, "2024-06-23", "Et explicabo distinctio quis deleniti pariatur. Facilis ipsum dignissimos qui sed fuga quibusdam optio omnis quisquam. Voluptatem enim non. Sapiente ab dolorum aut qui eaque minus rerum maiores. Quia qui nihil maxime voluptatem fugiat est. Repudiandae eveniet omnis iure.", 5, "3" },
                    { 18, 18, "2024-01-13", "Nesciunt rem sunt suscipit veniam quis eum sunt et et. Harum et quia. Vero voluptatem maxime quia exercitationem ut voluptatem. Sint et exercitationem aut ut possimus.", 5, "4" },
                    { 19, 16, "2024-01-20", "Praesentium aut cum id odit dignissimos non. Dolor qui et hic occaecati consequatur. Officiis sint maiores molestiae et perferendis.", 1, "1" },
                    { 20, 5, "2024-03-11", "Est sed in accusantium nisi voluptatem dolor temporibus in. Repudiandae autem qui qui sed laudantium. Eius sit quo sequi quia quas non.", 5, "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sydnee Luettgen", "Commodi soluta eveniet. Voluptatem ratione in ad atque est eum pariatur minima. Qui est at excepturi iure in velit. Quo cumque eius quia consequuntur et repellat. Aut quidem est est.", 5, "2f96bb1a-9d65-7245-a748-5ef34ab39bb3", false, 362, "Murphy, Kunze and Ledner", "Qui est eveniet.", 2023 });

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
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Zula Rogahn", "Dolor voluptas quis dolor rerum voluptatibus deserunt repudiandae incidunt. At architecto enim adipisci tempora molestiae accusamus eligendi aut provident. Quasi debitis iste et labore dignissimos quis molestiae consequuntur. Facere id velit sed. Odio ratione cum molestiae amet nam optio omnis odio. Excepturi quis voluptatem.", "8e5aa50a-38a0-2838-86b6-22fbf7685f60", 209, "O'Connell LLC", "Minima delectus reiciendis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Keshaun Bogisich", "Voluptatem sit et qui soluta accusantium. Voluptate velit vitae eaque quia accusamus veniam incidunt. Maxime rerum voluptatem sed pariatur hic autem. Sit sequi rem voluptates dolorem unde rerum.", 3, "39432f0f-6949-428b-404a-d05f67ab264c", true, 458, "Beer, Walker and O'Keefe", "Qui et velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Angel Will", "Asperiores corrupti error tenetur ullam est optio. Nostrum et delectus quis sint saepe et autem voluptatem. Tenetur aliquid deserunt facilis maiores ut qui harum nihil eius. Magni a tempora magni sed. Dicta neque velit deleniti quae odio quibusdam maiores rerum. Qui eveniet reiciendis hic qui.", 4, "99c392d9-d2bd-646f-bb67-3b4491bdf408", false, 230, "Stanton - Weimann", "Porro illum quibusdam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kenya Purdy", "Excepturi recusandae sint unde in. Neque veniam numquam nesciunt aperiam eos ut temporibus. Odit rem sit tenetur. Ratione excepturi illo. Laudantium qui veritatis quis fugit officia aut rerum iure laborum. Facere sed nihil sit quae sunt fugit.", "db429b9c-ba60-c4f2-d826-39e82711608d", 105, "Pouros - Greenholt", "Sed et omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Felicia Abshire", "Sit dicta vel voluptatem quam unde cum aut. Voluptatum dolores doloremque qui vel et minus vel eaque. Vel voluptatibus ad officiis sequi dolores debitis ex. Et dolore sit doloremque error nostrum reprehenderit asperiores dolorem quia.", 5, "a64b7635-3832-38d1-1a1c-9213cb8504d8", 403, "Feest - Erdman", "Dolor quam rerum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marquis Daniel", "Quidem dolorem est harum. Molestiae voluptates tempora aliquid autem repellendus ipsum ducimus. Corrupti aut provident qui et et dolorum libero odio. Commodi numquam veritatis. Aut maiores officia tempora facilis odit. Vero maiores illo quod odit aspernatur fuga perferendis consequuntur.", 2, "bec2ceff-f790-2e60-6f58-7f7f3d027ae9", false, 309, "McLaughlin - Gleichner", "Officiis esse quas.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title" },
                values: new object[] { "Rosa Gleason", "Reiciendis consectetur dolor error. Impedit sunt deleniti quo mollitia totam est. Vel atque dolores est quod consequatur ipsa aliquid. Earum quas quasi.", 1, "92d167f0-617f-f2d1-cd32-a7410a07229c", false, 348, "Casper Inc", "Fugiat quibusdam dolores." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sibyl Little", "Nihil fugiat occaecati animi reprehenderit perspiciatis voluptatem laudantium perspiciatis. Id mollitia quaerat dolores aut quis rerum omnis error consequuntur. Dolorem expedita quibusdam accusantium quasi illo aut nesciunt sint eaque. Ut dolorem velit deleniti repellat facilis.", 4, "384e2970-fe0e-104d-e34c-9bf60d8278ed", false, false, 404, "Yundt, Deckow and Lockman", "Nihil natus et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsFeatured", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kayli Brakus", "Laboriosam omnis est nihil adipisci. Voluptatem inventore quia saepe saepe assumenda qui earum et. Ut perferendis corporis at alias facilis aut et.", 4, "9d35867a-9a2d-1de7-61e5-32b6a5d2a7c1", false, 207, "Christiansen, Lang and Brown", "Debitis eum aspernatur.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Easter Rohan", "Alias aut placeat optio. Itaque et est et rerum earum illo et dolorum. Quia odit cumque qui.", 2, "01f46e10-1b73-7823-564e-f89cd5b3c184", 265, "Larson, Kertzmann and Roberts", "Minima enim repudiandae.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Zella D'Amore", "Illum et odio eos repellat quia eius nihil eligendi possimus. Laboriosam ut non aut debitis. Suscipit fugit molestias odit necessitatibus. Enim fuga voluptas. Nisi neque omnis vel est assumenda doloribus. Accusantium atque atque doloremque quo iusto accusamus quo eligendi corporis.", 1, "0c46b706-7241-abe6-2715-1394fa4d29c9", 280, "Satterfield, Toy and Bergnaum", "Iure distinctio voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Penelope Dooley", "Expedita id aut ut ea. Mollitia suscipit vel dolorem quia. Nemo ut labore ad. Dolorem amet necessitatibus corrupti dolorem commodi.", 4, "f1e5aff7-9b7a-9608-a00e-4950cb241de3", 328, "Jones - Durgan", "Vitae in quas." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Laila Collier", "Ea dolorem in quibusdam soluta. Occaecati et consequatur aliquam beatae iste dolores corrupti. Quia minima in provident explicabo quidem et laudantium repudiandae iure. Reprehenderit quia aperiam dicta et rerum dolor laudantium esse nulla. Consequatur dolorem dolores aut eum non voluptas consequatur asperiores. Voluptates nam rem eos veritatis rerum quos omnis quo.", 3, "764cd694-12f7-eed5-e9be-e83a0bf1c1c1", 166, "Stroman - Christiansen", "Veniam et porro.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "IsBestSeller", "Pages", "Publisher", "Title" },
                values: new object[] { "Lilliana Block", "Aliquam et corporis voluptatibus a ut culpa. Voluptas exercitationem vel illum laborum mollitia repudiandae impedit explicabo. Corrupti molestiae blanditiis molestiae. Ea ratione consequatur. Dolores qui ullam. Occaecati a sint quis magni voluptatem eum fuga quas.", 1, "13afb7b0-424e-6162-fafc-89a26393ed9b", true, 421, "Paucek Inc", "Deleniti sed illum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jakob Nienow", "Qui autem possimus dolor. Voluptatibus et minima natus dolorum sit magnam omnis. Libero quos eos est vel qui sapiente unde tenetur qui. Iusto harum eligendi molestiae nostrum.", 2, "cfd548a1-f696-a609-fcdf-4c16ca12b059", 244, "Stiedemann Inc", "Et debitis qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Matilda West", "Dolorum inventore itaque odio ipsam a nemo. Enim omnis et. Aspernatur iusto quis aut similique aliquid. Ratione iste saepe labore inventore eos omnis alias.", 4, "53acca8c-6428-7df9-2963-79b497f622e6", 406, "Muller LLC", "Deleniti iusto veritatis." });
        }
    }
}
