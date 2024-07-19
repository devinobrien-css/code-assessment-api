using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genre",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Chanel Gottlieb", "Esse esse rerum et exercitationem et itaque. Iusto quia dignissimos nihil ipsum sequi eum quae et voluptate. Eum vitae ex et perspiciatis ea est vero.", 1, "b14c883d-f5f2-3bde-3fd0-533f96a98b3d", "https://picsum.photos/640/480/?image=749", 164, "Doyle, Turner and Klein", "Sed illo architecto sunt non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Litzy Fritsch", "Libero et voluptatum delectus deserunt nihil exercitationem. Dolor non tempore eaque dignissimos explicabo qui. Perspiciatis veritatis provident cumque. Iusto assumenda saepe beatae numquam excepturi non amet. Similique vero excepturi facilis sapiente cumque omnis. Dolorem itaque omnis aut quia magni labore maiores laudantium est.", 2, "ca6e35a4-a71c-95c3-af15-c40dcc8d31b6", "https://picsum.photos/640/480/?image=552", 450, "Murazik, Mosciski and Bruen", "Voluptatibus porro vitae qui voluptas voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Noemie Reilly", "Accusantium ullam qui qui ut id nemo incidunt. Quia eos rerum officiis. Ratione minus voluptatibus. Est iure quis id deserunt delectus at eos odit eos. Eius possimus laborum ut sequi perferendis qui molestias sed. Sit et quis.", 3, "c58847ed-20c9-0844-17c3-9a75ee27f065", "https://picsum.photos/640/480/?image=337", 498, "Hartmann, Upton and Kris", "Et quia deleniti quam veritatis occaecati cupiditate.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Craig Hahn", "Ullam ea sint animi necessitatibus illo quia voluptas fugit quam. Aspernatur ullam consectetur voluptates qui. Aspernatur maiores et rem.", 5, "12441b1f-d1c5-24e2-804f-351bb7509626", "https://picsum.photos/640/480/?image=606", 433, "Rippin - Goodwin", "Qui ut neque.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jedediah Gutmann", "Velit aut dolor inventore tempora quisquam tenetur. Voluptas perferendis odit beatae soluta qui qui est soluta. Est et magnam sint dolorem eius eos. Et et cum quia esse sunt dolorum aut. Fuga vitae non sit repudiandae nihil saepe enim totam quod.", "23edaff6-a571-3e8e-e957-05ffcbd0bfef", "https://picsum.photos/640/480/?image=834", 322, "Koss - Farrell", "Possimus voluptatem quaerat porro id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Brandt Vandervort", "Sit et et et consequuntur amet voluptas quis. Corporis quas voluptatum iure consequatur. Tempora aut tempore autem dolorem voluptas mollitia dignissimos est. Magni velit tenetur beatae quaerat fuga alias vel quo temporibus. Earum voluptas quam ea ipsa eos nostrum esse velit est.", 5, "c1b1eee3-ae0a-51a8-db79-c728712260c3", "https://picsum.photos/640/480/?image=747", 394, "Torp Group", "Labore natus qui laborum voluptatibus sint dolores dolorem ex deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Vivien Harber", "Et aperiam odio vel quae excepturi dolorum et fugiat autem. Possimus cumque ab hic. Velit ducimus qui harum provident ipsa. Atque ex culpa illo neque iusto cupiditate veritatis. Perspiciatis non tempora rerum perspiciatis ut dolor. Nesciunt quia enim exercitationem reprehenderit et.", 2, "4a5adb0f-1f3a-825e-30c8-63115a5c037e", "https://picsum.photos/640/480/?image=1", 211, "Kihn, Swaniawski and Grimes", "Optio voluptates incidunt quia soluta esse aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Gregoria Herman", "Est voluptas dolor repudiandae. Voluptatem sint accusamus culpa ex unde. Et aut et reiciendis. Quas dolor velit aliquid omnis facere qui. Voluptatem eum dolorem. Suscipit repellendus voluptate non consequuntur voluptatem odit.", 1, "2eaa91f2-4ebe-433c-89b8-4f936ff95a78", "https://picsum.photos/640/480/?image=945", 210, "Mosciski Inc", "Corrupti qui eaque cupiditate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Ansel Pagac", "Numquam in animi nemo rerum dolorem ut aut quos. Est in totam exercitationem officia quia at ipsum voluptatem. Ut beatae est. Laudantium minus tempore modi laborum omnis. Quo quos error maiores. Enim vel maxime aut enim et et tempore.", 2, "1ce0e12e-f91a-783a-435c-42d688b38cc4", "https://picsum.photos/640/480/?image=591", 278, "McLaughlin - Dickinson", "Sequi adipisci doloribus placeat voluptates natus cupiditate quisquam iusto necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Publisher", "Title", "Year" },
                values: new object[] { "Patrick Howe", "Velit impedit aut ratione ut neque cumque. Ipsa illo eius numquam tempora. Eum reiciendis molestiae et. Fuga iure et aperiam commodi soluta. Ratione enim consequatur est. Incidunt necessitatibus molestiae ut eos omnis pariatur vel.", 3, "25f6f42f-4cc4-347e-eff2-a93e7121c887", "https://picsum.photos/640/480/?image=772", "Mraz - Kiehn", "Voluptatem voluptas maiores.", 2024 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genre",
                newName: "GenreId");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Janice Koepp", "Reprehenderit quia suscipit impedit. Ex incidunt nemo et explicabo reiciendis similique ipsa quasi. Nesciunt rerum qui placeat illo enim quaerat eius. Voluptas sed quos voluptatem laudantium consectetur voluptatem excepturi culpa. Qui fuga enim.", 4, "93d62e4d-fc8e-a093-7477-72f013d24f60", "https://picsum.photos/640/480/?image=549", 393, "Keebler, Kreiger and Weimann", "Iste omnis ipsa aut rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Madaline Okuneva", "Ea accusamus doloremque libero. Enim animi quos. Unde minima totam. Aut tempore aliquam alias ut ut rerum itaque sint.", 3, "496bbcf7-76df-85c4-e6bc-763380ed9a3d", "https://picsum.photos/640/480/?image=14", 390, "Stoltenberg and Sons", "Repellendus corrupti est consequatur cumque voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Aric Kilback", "Et rem ut at qui est. Laboriosam nesciunt ratione. Debitis nostrum reiciendis beatae impedit neque.", 4, "64a89d26-01ad-db8c-1884-02f09cdd98e3", "https://picsum.photos/640/480/?image=467", 232, "Treutel and Sons", "Amet quaerat expedita asperiores rem nulla et omnis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Julianne Mraz", "Enim corporis non. Voluptatem dolorum fugit optio illum sint doloremque sunt earum deserunt. Soluta aut molestiae quisquam quia architecto nesciunt aspernatur.", 2, "3bc51cda-d5f4-3801-8954-000e5ff569ba", "https://picsum.photos/640/480/?image=607", 139, "Shields Group", "Nisi rerum hic ea illo culpa pariatur doloribus enim.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Marjolaine Turner", "Autem occaecati aliquid facere sint eos nam non tempora. Adipisci qui exercitationem occaecati beatae. Doloribus sint qui nobis omnis voluptas sit aut est.", "354f41bf-29c7-c7cd-a2c8-577ddef49240", "https://picsum.photos/640/480/?image=749", 218, "Schultz and Sons", "Odio voluptatem fugit dicta." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Assunta DuBuque", "Quos omnis repellendus at aut natus velit fuga. Cupiditate amet quam omnis sint quidem quidem id itaque iure. Et laudantium nisi eveniet beatae dolorum itaque velit impedit. Non excepturi dolorum asperiores.", 1, "41a32a39-57a6-d257-03cd-b98fd35bd1b1", "https://picsum.photos/640/480/?image=90", 299, "Leffler, Robel and Fritsch", "Laborum nesciunt iure incidunt et laborum veritatis distinctio tempore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Madelyn Gaylord", "Ut ea voluptates quaerat labore necessitatibus. Tenetur quos dolores. Ex non dolore aliquid consequatur quaerat sit natus eos officia. Laborum autem eum et distinctio quasi vel. Fugiat molestiae aliquam dolores quibusdam quo quia. Ipsam qui dolores dolor magni cum aut itaque.", 5, "f142e7ae-f2e8-f3d7-0621-e7d1f3911917", "https://picsum.photos/640/480/?image=965", 206, "Robel - Nienow", "Aut est est deleniti minus." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Publisher", "Title", "Year" },
                values: new object[] { "Noemie O'Kon", "Laudantium sunt quibusdam quaerat quidem. Quam at et. Rerum earum debitis est laboriosam dolor quasi quis unde qui.", 2, "146f1011-1eeb-b028-ebcd-d7ac17e31a1f", "https://picsum.photos/640/480/?image=144", "Labadie Group", "Non quidem maiores quae cumque molestiae consequatur praesentium corporis temporibus.", 2023 });
        }
    }
}
