using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ShortenBookTitlesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emanuel Larkin", "Ex doloremque et voluptas. Et optio et aut delectus illo recusandae. Ullam incidunt quia et. Sequi ut occaecati ut illum voluptas repellendus quia quos aliquid. Ea qui itaque non dicta quia.", 4, "058ab78c-ac96-b13b-d0c9-53b754d82bd3", 483, "Carter, Dach and Kulas", "Minus consectetur ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Edmond Raynor", "Reiciendis debitis consequatur dolores omnis illum debitis voluptatem. Rerum nemo aspernatur soluta. Ab excepturi dolorem et tempora. Harum ipsam voluptate harum. Eius ab culpa repudiandae.", 2, "d08d32a5-6b13-69c5-9797-c66cc82a1aa3", 113, "Bosco, Franecki and Gusikowski", "Eveniet nam odit.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Adella Upton", "Sed molestiae aliquam exercitationem earum ipsum. Maxime dolor modi qui aut labore sit natus exercitationem et. Architecto at enim autem reprehenderit delectus placeat et. Modi sint molestiae et fugiat vitae quaerat quos.", 5, "1ed4ecad-0bf1-4cf4-4dd9-03bd4d28e9bb", 432, "Hane - Koepp", "In velit recusandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Allan Kuhn", "Ipsa ut velit dignissimos magnam illo. Accusantium ea ea quia et ad voluptatem. Qui blanditiis aut accusantium placeat. Iste asperiores velit et sit unde non ullam odio. Qui libero repellendus quo non.", 3, "545592bd-2533-5e3e-c259-e9974db4012f", 454, "Langworth - Rowe", "Eaque enim consequatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Denis Lebsack", "Rerum corporis nulla nam et quos harum sapiente. Est perspiciatis fuga quaerat. Nesciunt voluptatem atque dolores esse nulla perspiciatis omnis. Provident facere autem iure dolor cumque tenetur odit. Repudiandae voluptates tempora qui sit consectetur commodi.", 4, "ddba81b5-0ff8-bfb0-6bff-f1e0ca1a4ce7", 295, "Grant LLC", "Reiciendis inventore ipsa.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tiffany Wiegand", "Rerum ut aut mollitia iusto ab. Officia excepturi reiciendis velit eos corporis enim. Velit fuga quia sapiente. Voluptates velit temporibus velit dolorem architecto. Deleniti repudiandae quia dicta dignissimos.", 4, "8e1b48f7-4c54-6355-8206-fc70f2463d03", 394, "Schmeler and Sons", "Est vero quis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kamille Mills", "Est non delectus non laudantium reprehenderit sed veniam rem. Eligendi sit nulla numquam. Eveniet voluptatibus mollitia et. In nihil qui repellat. Sunt quod vel dolorum quas ut quod et ut.", 5, "abba7ad0-2410-82a9-449b-9aff76b6104f", 193, "Ruecker - Parisian", "Hic atque quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Garrison Powlowski", "Ut recusandae iure itaque consequatur incidunt mollitia. Natus suscipit et fuga. Excepturi voluptatibus ipsa est mollitia nobis numquam.", 3, "ba87dbca-9f06-e10f-cf49-3c72b7a0415d", 113, "Kiehn, Crona and Donnelly", "Doloribus corporis sequi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tyson Howe", "Ut at et voluptas perferendis. In atque labore nobis molestiae harum assumenda dicta aut ipsum. Aliquam possimus quisquam. Consectetur dignissimos modi voluptatem placeat doloremque repudiandae in ut et. Fugiat mollitia quaerat sed tempora ex mollitia harum ullam. Voluptatem reiciendis a sint soluta.", 1, "de7ee96c-5221-e695-190d-a73dbffdd6fb", 460, "Jacobi - Schulist", "Pariatur consequatur rerum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mack Tremblay", "In itaque facilis molestiae repellat facilis. Illo et totam expedita nemo consequatur. Consectetur ut qui ut non maxime est accusamus. Nam ullam alias saepe ipsa ipsa consequuntur.", 1, "a588ed65-84c5-0e9f-eafb-480b6d7b7c70", 268, "Kris and Sons", "Labore itaque qui.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Creola Hartmann", "Dolorem veniam consequatur vero consectetur ea et quo provident nesciunt. Quis beatae unde quia facere quod. Nihil accusamus illum dolorum iste. Veniam ipsa recusandae. Ducimus dignissimos rerum sapiente est itaque. Aut ut eos hic.", 1, "fdc48621-1bac-ba26-ed5e-abf505c44468", 286, "Kovacek LLC", "Laudantium perferendis delectus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Dawson Dach", "Quia in qui blanditiis. Itaque facere quae et asperiores et. Laboriosam et autem. Vel culpa possimus culpa est necessitatibus ea aliquam animi deserunt.", 1, "c6008db2-37fc-f366-937d-4e40d494aa6f", 193, "Hahn, Schiller and Harber", "Eum perspiciatis et qui velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Reginald Hauck", "Quo voluptatem voluptatum. Nam et corrupti. Sint explicabo aperiam et eaque quia ut quae. Ut ab aut tempore sunt ab. Aut distinctio quasi omnis et aperiam id impedit ullam recusandae.", 2, "5dcec6a5-a445-a3e5-a88f-8e5e8ba5f1e2", 176, "Will, Kilback and Parker", "Voluptatem aliquam natus nisi ducimus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Terry Kunze", "Tempora vero dolores et unde rerum consequatur est sed maxime. Repudiandae iusto voluptatem expedita et. Accusamus ad aperiam et officia delectus. Doloremque quod alias odio modi recusandae sapiente adipisci cum repudiandae. Praesentium molestias et. Doloremque aspernatur qui beatae velit dicta.", 1, "d74f1cfb-6434-b09c-d408-0a9bfdcb5367", 148, "Hudson, Mohr and Goldner", "Aliquam et eaque quae excepturi voluptas eligendi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Otis Schmitt", "Perferendis dolore porro eum laudantium aut amet. Pariatur corporis quas numquam beatae alias architecto. Iusto dolores provident. Facere ut aliquid aut rem vero. Consequatur doloremque iusto. Odit itaque sint libero id optio laboriosam sit libero quo.", 4, "4be2a407-b692-2930-0ba6-fa8c14773c21", 436, "Krajcik, MacGyver and Paucek", "Aspernatur earum ut libero rerum ratione.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Elise Bashirian", "Soluta voluptatem voluptate molestiae. Minima cumque veritatis. Atque est molestias eligendi et dolores sit. Necessitatibus excepturi neque odio quod velit. Et dolorum magni tempore eveniet numquam commodi voluptas culpa laboriosam.", 1, "900967e0-9362-4fa4-b956-f85ca880ced2", 178, "Christiansen, Harber and Shanahan", "Non porro delectus deserunt sint sed dicta." });

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
    }
}
