using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenreFKHotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Granville Collins", "Molestias ea dolorem distinctio ut suscipit qui quaerat facere molestias. Voluptate velit tempore. Est ea quaerat dolor non repellat vitae aliquid at.", "aeae159f-63ca-1b23-58a7-75002359f05d", "https://picsum.photos/640/480/?image=173", 456, "Bradtke - Borer", "Veritatis voluptatem culpa libero iste aperiam saepe." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Treva Crona", "Rerum soluta expedita quo omnis. Magnam quas officia quia. Ut quibusdam dolor dolore quas dignissimos amet quia. Quo sint alias accusantium laboriosam ea nisi magnam quos. Dignissimos sit ut facilis.", 5, "97256a54-0523-0735-7bb1-b1093e630e4b", "https://picsum.photos/640/480/?image=625", 233, "Larson Inc", "Reprehenderit veritatis eveniet voluptatum asperiores.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Erwin Rodriguez", "Asperiores iste sapiente officiis consequatur provident animi veniam ab consequatur. Et voluptate quia consequatur. Eaque sint et fugiat quia.", "90633bd5-9c2a-94fd-1078-babb6400e831", "https://picsum.photos/640/480/?image=144", 339, "Thompson - Ruecker", "Distinctio vel sit alias dolorum sed distinctio quibusdam doloribus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Vesta Pollich", "Laudantium ea quod sit aspernatur quae inventore nostrum natus. Nostrum magni reprehenderit eos sed labore saepe delectus. Culpa est minus est temporibus.", 2, "c668c545-adc0-6e8c-42fe-d1567f4c2d87", "https://picsum.photos/640/480/?image=838", 465, "Goodwin - Kemmer", "Asperiores at omnis molestiae dolor iure repellat in.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ludwig Abbott", "Quidem ea nemo fugit quasi qui. Sint iure veniam placeat. Consectetur et quo eligendi aperiam cupiditate tempora voluptatem necessitatibus. Consequatur laborum molestias deleniti. Deserunt est nobis qui. Possimus repellendus explicabo impedit ut sint ea.", 1, "dce7144e-486e-f459-92a7-a43a1be8bd40", "https://picsum.photos/640/480/?image=20", 415, "Emmerich - Daugherty", "Minus sapiente ad nihil sed harum aut ut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Helga Okuneva", "Ea iste veritatis quod. Sit nobis quas maiores deserunt. Voluptas optio omnis optio eos possimus quisquam. Commodi nulla voluptate at illo quidem corporis suscipit beatae occaecati. Necessitatibus reprehenderit voluptas enim excepturi nam voluptas nulla sunt.", 4, "581b3f39-95e6-f3ac-5d85-dcc636798f13", "https://picsum.photos/640/480/?image=83", 282, "Spencer - Feil", "Repellat dolores dolorem rerum dolor ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kali Kovacek", "Dolores laborum impedit eos qui officiis. Aut esse voluptatum laudantium a rerum aliquid quia illum quis. Laboriosam aliquam dignissimos sunt sed ipsum.", 3, "654043ee-884d-9f9d-b92a-ac296ba3d959", "https://picsum.photos/640/480/?image=194", 191, "Cummerata - Quigley", "Amet ducimus omnis sequi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Autumn Aufderhar", "Necessitatibus facilis aut aut. Ut est facilis. Dolores voluptas et officiis accusantium dicta nobis voluptatum. Qui non voluptas. Ut voluptatum commodi illo autem. Est tempore ea officia vel veritatis voluptas debitis numquam.", 2, "5247a001-0535-658b-c9f8-be99129fad29", "https://picsum.photos/640/480/?image=837", 226, "McLaughlin - Mitchell", "Aliquam maxime et fugiat incidunt aut perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Estevan Walker", "Et consectetur libero. Odit laudantium eligendi necessitatibus quaerat perferendis. Possimus distinctio sed soluta molestias odio. Est ut exercitationem a delectus rem similique voluptatum.", 4, "666a5d69-b126-85a6-00fc-4b42db8c3b95", "https://picsum.photos/640/480/?image=178", 420, "Zulauf - Nienow", "Maxime quod ut optio omnis ipsam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Rylee Klocko", "Sed rerum eos nulla voluptas dolore distinctio. Aut excepturi sed modi autem iusto sint consequuntur dignissimos sed. Inventore beatae est accusamus consectetur et nihil quidem sunt. Iure voluptas consequatur aut et nesciunt dolores alias. Magni cum odit neque et. Vel deleniti quaerat nobis est sed perspiciatis ducimus.", 1, "ce2ed45c-4f81-cae7-0fc6-1b95fd0a7477", "https://picsum.photos/640/480/?image=897", 200, "Satterfield and Sons", "Occaecati animi dolor." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Leanne Lehner", "Iste corporis quis dolores ea. Occaecati distinctio eum vel voluptates sint officia sit. Saepe voluptatem voluptatum et. Minus laboriosam expedita. Deserunt qui omnis facilis esse eligendi beatae voluptatem id.", "29126e22-2f8a-8bf5-e570-990364042e33", "https://picsum.photos/640/480/?image=1041", 266, "Barton, Pfeffer and Fadel", "Dolorem architecto nihil ipsa dolorem non magnam quisquam architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kyle Wisozk", "Aut optio et aut minus nihil natus animi. Impedit facilis et voluptatem veniam incidunt soluta. Corrupti ipsam voluptatum omnis at neque est consectetur. Eum natus in. Eum sed et incidunt labore ipsum voluptatum natus.", 4, "db8e81af-4ac0-79ca-b48a-b1b8d84dcbc0", "https://picsum.photos/640/480/?image=266", 473, "Bednar, Shanahan and Lubowitz", "Ullam qui neque est aspernatur qui quod.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Roman Wuckert", "Eius non enim explicabo soluta qui exercitationem non. At harum nemo vitae sint corporis ducimus ut ut numquam. Magnam non rerum architecto id. Atque et fuga non ut.", "050c9be4-d1b3-1f9b-a91f-e2fad768b920", "https://picsum.photos/640/480/?image=872", 283, "Osinski, Will and Carroll", "At nemo nulla velit eos.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Reed Wiegand", "Labore dolorem praesentium. Cum fugiat omnis ducimus. Autem sed corporis dignissimos sed magnam rerum nihil quo est. Dolorum nobis ratione modi atque nobis. Voluptatibus asperiores accusantium eius. Eius error dolor possimus consequatur et reprehenderit.", 3, "7e03c9d5-1e86-7525-dacb-84a2e8bee67f", "https://picsum.photos/640/480/?image=761", 224, "White - Gaylord", "Necessitatibus non deleniti possimus unde nam.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Leone Wunsch", "Excepturi quisquam officiis voluptatem aspernatur. Ipsam a omnis sapiente nobis illo modi cum. Repellat iste repellat aut unde id et enim in ab.", 2, "b4b4b68a-a84d-30ec-b91a-ae0214a4847f", "https://picsum.photos/640/480/?image=422", 363, "Moen, Lowe and Reynolds", "Ut eum vel.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Iva Ebert", "Sint voluptas facere nihil ea voluptatem cum vero deserunt occaecati. Architecto numquam sit nulla omnis ea optio sapiente. Dicta corporis voluptatem repellat asperiores voluptatem assumenda. Facilis dolores sit officia quidem dolorem. Quasi fugiat sed odit repellendus quia fuga. Voluptatibus magni ut eligendi qui aspernatur dolorem sunt.", 1, "3cc4f4fe-f78f-cd5c-beb0-bb9159621d7c", "https://picsum.photos/640/480/?image=237", 114, "Hilll - Sauer", "Autem vel sit voluptatem voluptas delectus autem amet distinctio quasi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tatyana Greenholt", "Illum molestiae ipsam voluptate facilis officia voluptatem rerum est. Repellat qui aperiam. Sit fuga illum. Facilis magnam voluptatem vel molestias voluptatem.", 5, "7863da40-f688-6145-c207-281d16f0e421", "https://picsum.photos/640/480/?image=180", 434, "Cassin Group", "Error cumque aperiam distinctio consequatur est sapiente eum ut quisquam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Curt Nitzsche", "Consectetur soluta qui optio et incidunt non voluptatum nemo. Facilis blanditiis placeat quibusdam. Quidem esse dolore non eum. Nemo eaque et est. Voluptas dicta impedit atque itaque et minus quasi deserunt. Voluptatum reiciendis earum eum.", 5, "4c16f05b-1971-ab1f-8121-6a609ab1d11a", "https://picsum.photos/640/480/?image=1005", 102, "Rolfson, Hegmann and Adams", "Reprehenderit optio eos ipsum adipisci non voluptatem pariatur quam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Logan Crona", "Fugiat corrupti qui. Ipsam corporis hic sequi quis eos voluptates reprehenderit. Perferendis libero est expedita voluptas et velit.", 5, "09ac2499-bbf4-e810-9271-51b09ed6969c", "https://picsum.photos/640/480/?image=130", 325, "Senger - Ullrich", "Nostrum qui et odit voluptas id omnis et velit perspiciatis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaylah Cartwright", "Dolor minus quo dicta aut. Voluptatem natus molestiae ut delectus consequuntur sit non deleniti. Voluptatibus temporibus error velit odio sit sunt itaque est. Et quisquam perspiciatis iste magnam. Perspiciatis aliquid provident quibusdam velit amet eos recusandae. Deserunt non rem porro in.", 5, "8026e628-479a-a678-ff0e-a66afa57e835", "https://picsum.photos/640/480/?image=215", 195, "Schimmel - Bayer", "Quisquam voluptatibus aspernatur magni aperiam est dolor dolores facilis." });
        }
    }
}
