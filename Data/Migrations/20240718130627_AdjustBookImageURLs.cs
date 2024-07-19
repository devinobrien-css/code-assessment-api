using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBookImageURLs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Juwan Nicolas", "Laborum numquam aperiam sit voluptatem nisi ipsa veritatis. Est similique repudiandae iusto. Vitae ut quia. Vitae provident consequatur et incidunt. Et voluptatem perspiciatis officia inventore quidem totam incidunt. Aut ea ratione praesentium nesciunt est et illum sint blanditiis.", 3, "37e57dff-fe43-0c47-ea7c-67220108f8e6", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb", 201, "Mraz - Stamm", "Molestias sunt totam voluptatibus architecto est deleniti laudantium expedita." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Abigale Boehm", "Odit atque sequi vitae nam atque enim possimus. Ullam vel quos perspiciatis sit omnis dolores. Voluptatem sint beatae totam ut. Laborum similique corrupti dolor vel et voluptas ut beatae sint. Minima ea quia nulla aliquam omnis maxime quasi.", "ca4089c2-2630-4200-475f-5d08d05dff6c", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA", 239, "Kassulke LLC", "Et placeat maiores est est ullam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Maud Beer", "Qui quod quo itaque nulla ut. Eligendi necessitatibus sunt dolore odit autem quia. Aut alias et vel pariatur.", "9753b244-7284-0544-0c65-f58ad35a7b90", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh", 348, "McClure Inc", "Et atque quas ducimus veniam ab ratione quae fuga eveniet.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Cordelia Mueller", "Perspiciatis reprehenderit fugiat quo aspernatur ad. Molestiae ut quia et nulla. Aperiam iure impedit eos et qui maiores veritatis minus.", 1, "9a92d717-7337-bd7a-e7f4-a3c60f22511e", "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi", 115, "Koch, O'Reilly and Weimann", "Mollitia exercitationem dolor." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Lexie Keeling", "Aut itaque omnis qui ab. Tempore itaque dolor quo impedit. Veniam quos et sed aut laboriosam et adipisci. Et voluptatem perspiciatis enim. Doloremque praesentium animi.", 1, "7955261a-5d6f-d849-a4d9-a3def6a0e87f", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc", 295, "Volkman, Collier and Welch", "Enim et deserunt qui a voluptas itaque rem repudiandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Taryn Bernhard", "Saepe placeat nemo esse voluptates corrupti optio animi beatae. Qui fugit sit odio beatae voluptas facilis molestiae omnis. Deleniti laborum dolorum rerum rerum soluta. Sunt sit vel praesentium distinctio officia veritatis molestiae voluptatem illum. Hic impedit quas commodi accusamus quidem aspernatur.", 5, "4733d995-57d3-990b-57e2-4cd39c8660d6", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71", 329, "Hoppe, Dach and Crona", "Id ab esse aut animi maxime temporibus et vitae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cody Schroeder", "Omnis nam omnis facilis incidunt veniam et. Quia adipisci doloribus id totam magni ea. Magnam et quisquam velit eos quis est beatae. Dolor eaque vel et. Earum fugiat ipsum ut libero velit est. Delectus neque tenetur soluta qui veniam.", 5, "6b815094-1ada-130d-0a94-d341cbd81c22", "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ", 488, "Osinski - Bernier", "Quo quidem voluptate aut soluta.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Alexandria Raynor", "Et quo et aut autem. Nihil minima et. Exercitationem necessitatibus repellat officiis enim et. Qui vitae omnis ut expedita dolorem autem est.", 1, "d9c304c6-0c03-1416-c37b-f26c3b36a98b", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl", 286, "Hintz - Abshire", "Autem odit aut eum dolor natus tempore iure perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lia Considine", "Id et quis commodi consequatur ut. Incidunt laboriosam odio consequatur minima rerum architecto accusamus aliquam. Dolore omnis suscipit libero et consequatur sit. Mollitia ab cupiditate perspiciatis soluta repudiandae reprehenderit iusto nostrum dolorem.", 2, "f9991fad-7721-77d5-ae2d-e73765bd65b0", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5", 246, "Koelpin, Strosin and Kub", "Nihil possimus iure tempora.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Elfrieda Mohr", "Molestiae fugiat sunt non inventore dolorem. Sed vero ducimus qui aut. Ex ut doloribus repellat iure deleniti. Aliquam qui aut facilis eum ut est temporibus labore sunt.", "18939735-3fb1-f629-9352-fbc2cbc1a99a", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK", 442, "Champlin - DuBuque", "Similique vel veniam cum.", 2024 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Mozelle Kessler", "Nostrum tempore est tempora occaecati eligendi. Architecto qui asperiores ullam et. Est amet sit eius aut commodi officiis. Vel expedita quasi enim corporis totam aspernatur rerum.", 5, "2cb59d59-df68-fa41-b602-d3223860191f", "1zycl7EiCECK541ialA9UCrs9HdfddUQb", 312, "Waters, Wolff and Braun", "Omnis eaque dolor fugit deserunt modi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Sadie Stoltenberg", "Ex eum aut suscipit et animi provident non. Dicta cupiditate amet accusamus. Illum ex earum. Quibusdam adipisci ducimus voluptates ducimus vel reiciendis. Numquam ea ullam voluptates laudantium odit.", "1ec378b5-ec78-e712-6674-c16dbd746e70", "1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA", 244, "Gusikowski - Hoppe", "Consequatur quod qui dolorem illo temporibus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Angie Moen", "Quos non eveniet quae incidunt. Dolor et quam. Quasi fuga et. Aut optio ex sunt reprehenderit magni veniam et.", "5757bb79-31d7-f4e7-2c70-158776c0254b", "12xFmb08WRoRr5omVtZ38Obo1imbutVlh", 165, "Wiegand, Funk and Upton", "Dolor amet iure laborum eligendi veritatis iste iusto.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Beatrice Stark", "Similique minus doloribus inventore perferendis. At qui est. Veritatis nostrum quia sint voluptas voluptas. Non quam earum doloremque provident et. Explicabo aut in blanditiis ut dolorem. Vel eum iusto rerum pariatur fugiat placeat ex.", 3, "ce6f7a4b-5060-ecf6-1a5c-61871cde2bc6", "1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi", 332, "Hamill, McClure and McKenzie", "Modi illo accusamus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Minerva Lind", "Totam fugit totam labore. Repellendus natus sit sed iste. Error ut totam dolorem. Magni velit praesentium consequatur. In qui veritatis ab nesciunt sed. Et suscipit harum et porro enim iusto soluta.", 2, "d146a097-6abf-9e01-d8bf-321a2f37f3be", "1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc", 203, "Mohr Group", "Expedita inventore repudiandae aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Manley Haley", "Corporis consequuntur rerum voluptatem. Ullam magnam ut reprehenderit qui id iste minima ut quod. Aut et delectus est molestiae ea aut. Aut aut aut eos assumenda ad nemo molestiae ut quisquam. Eos recusandae reiciendis debitis perspiciatis omnis autem. Consequatur quo a asperiores.", 1, "b363a9a9-6294-5e9f-4c33-6f980c328a2a", "1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71", 156, "Deckow - Altenwerth", "Sed et sequi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jerry Kshlerin", "Numquam voluptate alias. Corrupti in voluptas perspiciatis eius totam. Provident quia debitis sequi ut nulla aut ipsam debitis et. In ad veniam rerum cupiditate quibusdam numquam praesentium.", 4, "777a2196-9374-4b98-b9fb-d3045c30806a", "1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ", 256, "Conn - Towne", "Dolor et sed pariatur accusamus nihil quia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Henderson Bogisich", "Id voluptatem asperiores natus aut non nemo aliquam. Dolores temporibus hic et veritatis voluptatem. Assumenda neque sed nostrum porro earum nesciunt debitis excepturi animi. Et voluptatibus qui atque perspiciatis est sit fugit. Quis quos libero ad eligendi.", 2, "90a222fe-407f-3a3c-3ae3-2c11fbf076f2", "1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl", 497, "O'Keefe - Koelpin", "Consequatur quam et perferendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mylene Gerhold", "Pariatur odio earum illo vero. Est sit sed consequatur ut velit modi rerum. Fugit ipsum numquam placeat. Laborum voluptatibus aut ut sunt aut ad voluptatibus nihil. Ab praesentium animi vel sed id dolor sint. Eos totam veniam aut consequatur voluptatem sunt est cupiditate velit.", 3, "d731adac-e749-2479-37b9-f18523a83bc1", "1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5", 201, "Wunsch, Larson and Senger", "Voluptatem et qui libero aliquam.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Fausto Koch", "Tempora accusamus ullam nemo non ut. Nulla exercitationem quos aut. Consequatur hic qui rerum autem distinctio unde illo aperiam. Facilis qui sunt. Molestias nihil voluptatem veritatis quidem fuga quaerat. Rerum nulla neque voluptatum rerum sunt at blanditiis.", "458695fb-b1e1-6e20-40fb-26e23fca2b49", "1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK", 403, "Dooley, Osinski and Fadel", "Eveniet ad doloremque et in adipisci laudantium.", 2023 });
        }
    }
}
