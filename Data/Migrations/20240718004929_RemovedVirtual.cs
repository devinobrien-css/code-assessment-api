using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedVirtual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Janice Koepp", "Reprehenderit quia suscipit impedit. Ex incidunt nemo et explicabo reiciendis similique ipsa quasi. Nesciunt rerum qui placeat illo enim quaerat eius. Voluptas sed quos voluptatem laudantium consectetur voluptatem excepturi culpa. Qui fuga enim.", 4, "93d62e4d-fc8e-a093-7477-72f013d24f60", "https://picsum.photos/640/480/?image=549", 393, "Keebler, Kreiger and Weimann", "Iste omnis ipsa aut rerum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Madaline Okuneva", "Ea accusamus doloremque libero. Enim animi quos. Unde minima totam. Aut tempore aliquam alias ut ut rerum itaque sint.", "496bbcf7-76df-85c4-e6bc-763380ed9a3d", "https://picsum.photos/640/480/?image=14", 390, "Stoltenberg and Sons", "Repellendus corrupti est consequatur cumque voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Aric Kilback", "Et rem ut at qui est. Laboriosam nesciunt ratione. Debitis nostrum reiciendis beatae impedit neque.", "64a89d26-01ad-db8c-1884-02f09cdd98e3", "https://picsum.photos/640/480/?image=467", 232, "Treutel and Sons", "Amet quaerat expedita asperiores rem nulla et omnis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Julianne Mraz", "Enim corporis non. Voluptatem dolorum fugit optio illum sint doloremque sunt earum deserunt. Soluta aut molestiae quisquam quia architecto nesciunt aspernatur.", "3bc51cda-d5f4-3801-8954-000e5ff569ba", "https://picsum.photos/640/480/?image=607", 139, "Shields Group", "Nisi rerum hic ea illo culpa pariatur doloribus enim.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Marjolaine Turner", "Autem occaecati aliquid facere sint eos nam non tempora. Adipisci qui exercitationem occaecati beatae. Doloribus sint qui nobis omnis voluptas sit aut est.", 3, "354f41bf-29c7-c7cd-a2c8-577ddef49240", "https://picsum.photos/640/480/?image=749", 218, "Schultz and Sons", "Odio voluptatem fugit dicta.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Assunta DuBuque", "Quos omnis repellendus at aut natus velit fuga. Cupiditate amet quam omnis sint quidem quidem id itaque iure. Et laudantium nisi eveniet beatae dolorum itaque velit impedit. Non excepturi dolorum asperiores.", 1, "41a32a39-57a6-d257-03cd-b98fd35bd1b1", "https://picsum.photos/640/480/?image=90", 299, "Leffler, Robel and Fritsch", "Laborum nesciunt iure incidunt et laborum veritatis distinctio tempore.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Madelyn Gaylord", "Ut ea voluptates quaerat labore necessitatibus. Tenetur quos dolores. Ex non dolore aliquid consequatur quaerat sit natus eos officia. Laborum autem eum et distinctio quasi vel. Fugiat molestiae aliquam dolores quibusdam quo quia. Ipsam qui dolores dolor magni cum aut itaque.", 5, "f142e7ae-f2e8-f3d7-0621-e7d1f3911917", "https://picsum.photos/640/480/?image=965", 206, "Robel - Nienow", "Aut est est deleniti minus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Travon Schroeder", "Sed eum omnis. Cum voluptas reiciendis sit aut incidunt minima et cum. Culpa deserunt omnis rerum praesentium sunt qui quia architecto.", 2, "8fb589d8-dffe-c244-dab0-dc8f0ad64915", "https://picsum.photos/640/480/?image=259", 205, "Littel, Mayert and Goodwin", "Cupiditate ut sit dolores dignissimos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Wendy Rowe", "Itaque explicabo alias pariatur aut ut placeat ut fugiat. Officiis et ea molestias eligendi iure consequuntur. Ratione molestiae maiores quis sapiente ab quaerat eaque. Quae officiis qui expedita est ut commodi quia quidem et.", 5, "a5f01f78-99d7-775a-0bae-65e7dd58066c", "https://picsum.photos/640/480/?image=283", 126, "Bartell - Bogisich", "Iste dolores at." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Noemie O'Kon", "Laudantium sunt quibusdam quaerat quidem. Quam at et. Rerum earum debitis est laboriosam dolor quasi quis unde qui.", 2, "146f1011-1eeb-b028-ebcd-d7ac17e31a1f", "https://picsum.photos/640/480/?image=144", 370, "Labadie Group", "Non quidem maiores quae cumque molestiae consequatur praesentium corporis temporibus." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Clovis Kautzer", "Aut ipsa enim culpa culpa aperiam. Deserunt quo suscipit iste quia. Non ullam expedita. Saepe eum adipisci qui quisquam ut adipisci est. Harum sed et dolorem qui ut. Id ut unde explicabo dolore nobis.", 2, "3b43fac6-a05c-097b-361c-e40fb82be891", "https://picsum.photos/640/480/?image=325", 371, "Kautzer, Halvorson and Rogahn", "Illo dolor aliquid laudantium consectetur esse est commodi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Vada Reinger", "Asperiores quaerat cum velit ipsam voluptas porro voluptatum perspiciatis. Rerum enim repudiandae. Expedita est illo ad eum aliquid quia. Delectus nam et magnam possimus ut molestias porro. Et eveniet sit sit assumenda quia. Sapiente aut et corrupti id incidunt.", "3413b926-49fd-1869-c2cd-d461ca0348d1", "https://picsum.photos/640/480/?image=338", 143, "Lockman Inc", "Soluta quidem perspiciatis repudiandae non voluptatum aliquid culpa vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Chasity Mosciski", "Qui et facilis repellendus rerum animi. Velit cupiditate perspiciatis occaecati expedita quia. Quis voluptatem occaecati. Qui tempore quasi voluptatem expedita dignissimos rem ea qui rerum.", "bdb177fb-90aa-8860-e2b5-70fce1b93df3", "https://picsum.photos/640/480/?image=285", 198, "Howe - Langosh", "Odit porro ut deserunt autem occaecati et quisquam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alexane Goyette", "Soluta eum delectus quia similique aliquam et. Maxime nisi in qui non. Quia aut mollitia et non beatae quam. Laboriosam sequi fugiat facilis deserunt velit. Odit itaque eveniet cum voluptas nesciunt dolor tempore.", "668b3f0a-e246-ad8d-1b27-bc107f013c43", "https://picsum.photos/640/480/?image=399", 150, "Ferry - Hilll", "Voluptas ut atque modi tempora laboriosam repudiandae quisquam ex.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Andrew Padberg", "Modi vitae dolor. Qui eos atque quos recusandae omnis sunt harum. Et deserunt similique hic ut reiciendis ab. Dolor et inventore nemo et non corrupti. Pariatur dolorem quaerat expedita.", 5, "c2a5b8e9-9117-b06f-3ee3-72c00ea075de", "https://picsum.photos/640/480/?image=258", 461, "Welch, Miller and Schamberger", "Quos porro in rem ut dignissimos ratione nisi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Georgiana Auer", "Corrupti recusandae impedit laboriosam eos soluta et omnis consectetur distinctio. Suscipit accusamus eum rem fugiat qui eum recusandae sequi labore. Dolores ducimus voluptatibus ut odio accusamus neque modi. Temporibus ut saepe odit dolor. Aspernatur rerum et sunt alias soluta.", 5, "a56dd4c5-46ac-f952-c298-efb1776c1a99", "https://picsum.photos/640/480/?image=1060", 253, "Bayer, Daniel and Gulgowski", "Quasi et recusandae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Scotty Toy", "Illum dicta suscipit. Sed labore tenetur ab. Cum sint impedit. Impedit qui iure eaque animi. Sit deserunt dolorum qui perspiciatis.", 2, "acf2d1c1-44d0-87c4-49ee-7408c87feec5", "https://picsum.photos/640/480/?image=893", 269, "Hackett - Baumbach", "Et omnis minima labore sit aliquam repellendus non.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Matilde Thiel", "Nobis dolorem voluptatem voluptas minus corrupti sunt totam. Et asperiores eligendi repellendus officiis eius quae. Sequi soluta deleniti rerum quo non nulla tempore. Eveniet eius enim fugiat aut nesciunt explicabo quo dolores ab. Atque hic quibusdam doloremque dolores ratione. Tempora dolorem quia eum quia perferendis voluptas explicabo sunt.", 1, "fc197208-2830-dae7-fe8a-1648bc657776", "https://picsum.photos/640/480/?image=871", 415, "Conn, McClure and Upton", "Vel culpa accusamus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jana Dickens", "Vel debitis alias incidunt sit omnis debitis voluptatem est explicabo. Sed eligendi dignissimos distinctio animi qui qui. Consequatur sed quisquam.", 4, "1c82d797-5ef6-3aa1-55b9-680e743e391e", "https://picsum.photos/640/480/?image=394", 180, "Schultz Group", "Rerum corrupti ipsam saepe doloribus alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Hal Toy", "Aut voluptate aut dolore eaque velit esse. Aliquid ut aut. Repellendus dolores placeat et repudiandae. Atque qui est eos laudantium fuga. Ad quia accusantium qui voluptatem omnis. Non nobis et id quae voluptate.", 5, "dfa8e374-5e7e-c721-a414-5e48e1ef87d9", "https://picsum.photos/640/480/?image=120", 424, "Huel, Botsford and Lockman", "Dicta iure omnis atque odit incidunt commodi inventore." });
        }
    }
}
