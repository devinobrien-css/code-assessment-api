using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShortenBookTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emmy Ryan", "Enim rerum mollitia unde magnam nihil. Magnam architecto voluptatem quibusdam quia et. Sunt provident quia repellat deserunt.", 2, "189f312f-a60a-46c9-a303-b373add7400f", 384, "Crooks, Oberbrunner and Kemmer", "Repellat commodi velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alvera Ziemann", "Et porro velit provident. Reiciendis cum autem nesciunt ipsa. Iusto doloremque mollitia. In totam porro voluptate alias dolores saepe sed beatae.", 1, "704d1b23-323a-f439-4ed0-bbd545b0fb11", 480, "Hartmann and Sons", "Repellat tempora minus vel totam commodi pariatur quia.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Creola Hartmann", "Dolorem veniam consequatur vero consectetur ea et quo provident nesciunt. Quis beatae unde quia facere quod. Nihil accusamus illum dolorum iste. Veniam ipsa recusandae. Ducimus dignissimos rerum sapiente est itaque. Aut ut eos hic.", "fdc48621-1bac-ba26-ed5e-abf505c44468", 286, "Kovacek LLC", "Laudantium perferendis delectus et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Dawson Dach", "Quia in qui blanditiis. Itaque facere quae et asperiores et. Laboriosam et autem. Vel culpa possimus culpa est necessitatibus ea aliquam animi deserunt.", "c6008db2-37fc-f366-937d-4e40d494aa6f", 193, "Hahn, Schiller and Harber", "Eum perspiciatis et qui velit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Reginald Hauck", "Quo voluptatem voluptatum. Nam et corrupti. Sint explicabo aperiam et eaque quia ut quae. Ut ab aut tempore sunt ab. Aut distinctio quasi omnis et aperiam id impedit ullam recusandae.", 2, "5dcec6a5-a445-a3e5-a88f-8e5e8ba5f1e2", 176, "Will, Kilback and Parker", "Voluptatem aliquam natus nisi ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Terry Kunze", "Tempora vero dolores et unde rerum consequatur est sed maxime. Repudiandae iusto voluptatem expedita et. Accusamus ad aperiam et officia delectus. Doloremque quod alias odio modi recusandae sapiente adipisci cum repudiandae. Praesentium molestias et. Doloremque aspernatur qui beatae velit dicta.", "d74f1cfb-6434-b09c-d408-0a9bfdcb5367", 148, "Hudson, Mohr and Goldner", "Aliquam et eaque quae excepturi voluptas eligendi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Otis Schmitt", "Perferendis dolore porro eum laudantium aut amet. Pariatur corporis quas numquam beatae alias architecto. Iusto dolores provident. Facere ut aliquid aut rem vero. Consequatur doloremque iusto. Odit itaque sint libero id optio laboriosam sit libero quo.", "4be2a407-b692-2930-0ba6-fa8c14773c21", 436, "Krajcik, MacGyver and Paucek", "Aspernatur earum ut libero rerum ratione.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Elise Bashirian", "Soluta voluptatem voluptate molestiae. Minima cumque veritatis. Atque est molestias eligendi et dolores sit. Necessitatibus excepturi neque odio quod velit. Et dolorum magni tempore eveniet numquam commodi voluptas culpa laboriosam.", "900967e0-9362-4fa4-b956-f85ca880ced2", 178, "Christiansen, Harber and Shanahan", "Non porro delectus deserunt sint sed dicta." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cheyanne Little", "Et sed minus odio qui qui voluptatibus ut qui. Itaque laudantium accusantium sequi temporibus mollitia. Sequi alias velit esse quis et est.", 4, "c3aa82fd-f79a-da10-40dd-d555340ae31a", 456, "Morar Group", "Dolores deserunt aut alias.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Laurie Nader", "Rem delectus doloremque quod ex blanditiis doloribus. Molestias dolore veritatis deleniti. Et laudantium et nam praesentium quam deserunt et voluptatem accusamus. Incidunt quos eos ullam atque laboriosam alias deleniti est unde. Debitis qui eveniet. Repellendus consequatur veritatis ratione molestiae aut repellat ad.", 5, "96089ae4-cb96-2fda-f9e4-29ed67597314", 138, "Nitzsche, Beier and Aufderhar", "Quis error doloremque voluptas.", 2024 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Darby Collins", "Impedit magnam incidunt numquam natus natus eaque sequi. Qui architecto dolore animi est quod. Iste libero quos sed enim voluptatem. Magnam sequi velit expedita neque quia et maxime. Aut quo minima. In porro sit quisquam ipsa nihil neque.", 4, "8055c7f8-3e64-3944-d110-91e99de0b888", 459, "Bartell, Terry and Crooks", "Quas nostrum eligendi et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Georgiana Wolf", "Magnam ullam qui ex ullam culpa impedit aut sapiente. Ut ut maiores illo sit. Optio autem quis quaerat amet expedita voluptas debitis aperiam.", 5, "11fa585b-3769-ac05-0b73-405895ae2baf", 265, "Goldner LLC", "Ut est at.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Anjali Bergstrom", "Eveniet consequatur est perspiciatis voluptatum molestias modi accusantium aut a. Et reiciendis deserunt aut delectus inventore fuga optio qui maiores. Velit officiis nulla officia optio. Natus corporis eius quo qui ipsum voluptatem repellendus.", "29a6e2eb-eb97-2509-66de-e6b29276083b", 283, "Schowalter and Sons", "Quos adipisci qui et aliquam itaque deleniti molestiae nulla.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Clemmie Hauck", "Deleniti vel beatae. Nam minima repudiandae. Quas laboriosam quia optio. Voluptas aut soluta temporibus aspernatur assumenda molestiae.", "2e6f56d5-9429-2e2e-fae6-c16e9b00e09c", 458, "Bogan, Schmidt and Mayer", "Dolores amet nulla cupiditate pariatur expedita delectus est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Leda Hermann", "Consectetur dolorum nulla a. Voluptatem omnis repellat in aut aut rerum libero. Id aut velit aut. Perferendis id rem nihil eos necessitatibus quis ratione aliquid perferendis. Deserunt necessitatibus veniam voluptas error quo atque.", 3, "50b50921-e7f0-be87-0ad6-b0167a0c9476", 183, "Lakin, Schinner and Lynch", "Dolor possimus libero." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Angus Flatley", "Qui et animi vitae est odit dolore deserunt. Sed quam eum alias est iure. Eius harum assumenda laboriosam qui.", "4629d77c-e287-f97f-651d-fae2c8fab1ec", 440, "Macejkovic, Labadie and Hyatt", "Rerum vel in sequi sint omnis error quo.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gage O'Connell", "Neque dolor sed fuga error. Et voluptatem qui omnis impedit voluptates incidunt nesciunt quis dolore. Qui quia officiis. Saepe perspiciatis in sapiente. Aperiam soluta consequuntur autem.", "fc738efb-89ef-f451-35ec-88f85f35c1b9", 353, "Wehner - O'Conner", "Impedit totam saepe delectus quaerat fuga id doloribus aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Jordon Windler", "Earum ipsam explicabo. At et similique. Quo modi maiores. Amet architecto explicabo enim perspiciatis iure. In odio ipsam. Occaecati soluta voluptas.", "2dc6f096-000a-ae8a-ac60-b38f70f56a60", 201, "Harber and Sons", "Velit repudiandae velit eaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kennith Mosciski", "Sunt rerum quia dolores aperiam expedita esse accusamus. Quaerat harum sunt doloribus. Incidunt ad excepturi similique quo dignissimos. Ab laboriosam ullam commodi assumenda odit ut quia sint dolores. Facere aut odit ab in aliquid repellendus adipisci.", 1, "61abef4b-002d-21f2-884b-ac723c818c52", 477, "Turner LLC", "Numquam tempore dolorem sint laborum ratione optio commodi quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Arlie Rolfson", "Quo rem aperiam. Alias culpa sunt. Ut ut totam reiciendis aspernatur aperiam cumque quam quibusdam ut. Magnam saepe facere animi et quos dolor aliquid quasi. Quis enim aperiam quidem sit occaecati id facilis ad dolorem.", 3, "13077e9b-518c-76c1-dbf9-a1abb31282e8", 409, "Fadel, Legros and Kassulke", "Sit aut est qui ab mollitia.", 2023 });
        }
    }
}
