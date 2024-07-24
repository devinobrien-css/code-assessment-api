using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookGenreFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Leanne Lehner", "Iste corporis quis dolores ea. Occaecati distinctio eum vel voluptates sint officia sit. Saepe voluptatem voluptatum et. Minus laboriosam expedita. Deserunt qui omnis facilis esse eligendi beatae voluptatem id.", 2, "29126e22-2f8a-8bf5-e570-990364042e33", "https://picsum.photos/640/480/?image=1041", 266, "Barton, Pfeffer and Fadel", "Dolorem architecto nihil ipsa dolorem non magnam quisquam architecto." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Roman Wuckert", "Eius non enim explicabo soluta qui exercitationem non. At harum nemo vitae sint corporis ducimus ut ut numquam. Magnam non rerum architecto id. Atque et fuga non ut.", 2, "050c9be4-d1b3-1f9b-a91f-e2fad768b920", "https://picsum.photos/640/480/?image=872", 283, "Osinski, Will and Carroll", "At nemo nulla velit eos.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Reed Wiegand", "Labore dolorem praesentium. Cum fugiat omnis ducimus. Autem sed corporis dignissimos sed magnam rerum nihil quo est. Dolorum nobis ratione modi atque nobis. Voluptatibus asperiores accusantium eius. Eius error dolor possimus consequatur et reprehenderit.", "7e03c9d5-1e86-7525-dacb-84a2e8bee67f", "https://picsum.photos/640/480/?image=761", 224, "White - Gaylord", "Necessitatibus non deleniti possimus unde nam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Leone Wunsch", "Excepturi quisquam officiis voluptatem aspernatur. Ipsam a omnis sapiente nobis illo modi cum. Repellat iste repellat aut unde id et enim in ab.", 2, "b4b4b68a-a84d-30ec-b91a-ae0214a4847f", "https://picsum.photos/640/480/?image=422", 363, "Moen, Lowe and Reynolds", "Ut eum vel." });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Logan Crona", "Fugiat corrupti qui. Ipsam corporis hic sequi quis eos voluptates reprehenderit. Perferendis libero est expedita voluptas et velit.", "09ac2499-bbf4-e810-9271-51b09ed6969c", "https://picsum.photos/640/480/?image=130", 325, "Senger - Ullrich", "Nostrum qui et odit voluptas id omnis et velit perspiciatis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Kaylah Cartwright", "Dolor minus quo dicta aut. Voluptatem natus molestiae ut delectus consequuntur sit non deleniti. Voluptatibus temporibus error velit odio sit sunt itaque est. Et quisquam perspiciatis iste magnam. Perspiciatis aliquid provident quibusdam velit amet eos recusandae. Deserunt non rem porro in.", 5, "8026e628-479a-a678-ff0e-a66afa57e835", "https://picsum.photos/640/480/?image=215", 195, "Schimmel - Bayer", "Quisquam voluptatibus aspernatur magni aperiam est dolor dolores facilis." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Tomas Windler", "Amet nihil dicta officia sunt aut explicabo. Voluptatem accusantium voluptas tempora rerum. Exercitationem corrupti et sint repellendus. Amet optio eum culpa voluptas. Nostrum in hic veritatis sunt.", 4, "50f7dbff-74ce-cad0-f9fe-0d882083baa2", "https://picsum.photos/640/480/?image=143", 489, "Kovacek, Bartell and Purdy", "Expedita quia recusandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hertha Zemlak", "A fugit voluptas in tempore quibusdam ab. Animi eum assumenda est vitae tenetur beatae aspernatur et. Iure aspernatur exercitationem qui vitae reprehenderit enim sed voluptas asperiores.", 5, "1c4863f6-463d-1920-e61e-46f7017329b1", "https://picsum.photos/640/480/?image=1052", 266, "Ebert and Sons", "Veritatis nesciunt mollitia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Javon Rutherford", "Omnis labore minima officia eaque at iure corporis qui similique. Ullam sequi inventore aut qui repudiandae sapiente et. Ut amet voluptate sit ut similique.", 5, "bd5e7912-80d2-726b-1a18-74aa900d2828", "https://picsum.photos/640/480/?image=809", 466, "Gleason - Dietrich", "At officiis eius.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Christop Bode", "Possimus culpa molestiae enim. Enim consequatur et dolores alias quae culpa numquam. Similique laudantium ut voluptatem. Reiciendis omnis mollitia voluptatibus atque. Quo ducimus in saepe blanditiis ut et labore enim est. Molestiae hic ullam et explicabo dolores sapiente voluptatem.", "e85daa38-d6ea-04f6-29a5-e00472578ff8", "https://picsum.photos/640/480/?image=1064", 140, "Mosciski - Cummerata", "Nisi magni dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Arlene Jacobi", "Assumenda ipsa ullam voluptate possimus. Quo sint quasi. Qui fugit ea officia. Tempora praesentium ipsum dolorem ut nulla. Veniam ea adipisci omnis eius.", 1, "631b9d4b-3968-80fc-fec3-7ee52e311e0e", "https://picsum.photos/640/480/?image=556", 385, "West - Hand", "Aperiam enim nihil fuga doloribus quisquam voluptatum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Isabell Mayert", "Nam nihil minus vitae accusamus in laudantium. Aut et mollitia quasi dolorem. Ut necessitatibus est omnis non dolor dignissimos necessitatibus sint blanditiis. In eos id et. At voluptates repellendus libero qui consequatur soluta dolorem occaecati omnis.", 4, "8d00d05d-c742-4c88-db81-e824216c25d1", "https://picsum.photos/640/480/?image=436", 460, "Corkery, Brown and Von", "Consequatur architecto fugit suscipit quas voluptas dolore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Shanny Green", "Ratione velit repellendus voluptatem dolorum nam voluptate ut quia aliquid. Voluptate nulla sint soluta officiis ducimus. Repudiandae vero laudantium ea corrupti illo id autem. Odio est beatae et adipisci aut non. Omnis placeat architecto. Quam et eligendi pariatur.", 1, "829b191c-848c-0ed7-aeab-6dcd4d8c1d1f", "https://picsum.photos/640/480/?image=1026", 135, "Blanda - Bednar", "Omnis explicabo aspernatur sint quisquam qui.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Andre Kihn", "Eveniet nostrum odit eos ullam. Omnis quos officiis omnis nobis et voluptatem necessitatibus exercitationem. Aliquam voluptas cumque voluptatem soluta aperiam illum veniam omnis. Autem perferendis provident at ad eos. A dignissimos enim qui voluptates qui perferendis.", 3, "d15d8447-216d-0f4d-029f-b94094bee551", "https://picsum.photos/640/480/?image=139", 333, "Altenwerth, Hintz and Dietrich", "Minima aliquam itaque dolor doloremque commodi id quidem et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sandy Bergstrom", "Ipsam eum aut velit qui. Veritatis animi rem rerum odit praesentium. Cupiditate sapiente nisi voluptate.", "7013dd51-8d7f-b2c6-e5ce-8c49c67e6618", "https://picsum.photos/640/480/?image=685", 384, "Schiller - Mante", "Quae eligendi nisi et quibusdam dolore eum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Helen Waters", "Rerum consequatur voluptas cupiditate omnis. Voluptas possimus natus et consequatur reiciendis eum et facilis rem. Ipsum necessitatibus ipsam quas vel cumque ea libero.", 2, "10f66a58-1039-304b-3877-7e096ddfb197", "https://picsum.photos/640/480/?image=195", 230, "Mosciski and Sons", "Ut architecto esse placeat omnis deleniti ipsum." });
        }
    }
}
