using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBookImageRevert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Darby Collins", "Impedit magnam incidunt numquam natus natus eaque sequi. Qui architecto dolore animi est quod. Iste libero quos sed enim voluptatem. Magnam sequi velit expedita neque quia et maxime. Aut quo minima. In porro sit quisquam ipsa nihil neque.", 4, "8055c7f8-3e64-3944-d110-91e99de0b888", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000", 459, "Bartell, Terry and Crooks", "Quas nostrum eligendi et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Georgiana Wolf", "Magnam ullam qui ex ullam culpa impedit aut sapiente. Ut ut maiores illo sit. Optio autem quis quaerat amet expedita voluptas debitis aperiam.", 5, "11fa585b-3769-ac05-0b73-405895ae2baf", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000", 265, "Goldner LLC", "Ut est at." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Anjali Bergstrom", "Eveniet consequatur est perspiciatis voluptatum molestias modi accusantium aut a. Et reiciendis deserunt aut delectus inventore fuga optio qui maiores. Velit officiis nulla officia optio. Natus corporis eius quo qui ipsum voluptatem repellendus.", 1, "29a6e2eb-eb97-2509-66de-e6b29276083b", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000", 283, "Schowalter and Sons", "Quos adipisci qui et aliquam itaque deleniti molestiae nulla.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Clemmie Hauck", "Deleniti vel beatae. Nam minima repudiandae. Quas laboriosam quia optio. Voluptas aut soluta temporibus aspernatur assumenda molestiae.", 1, "2e6f56d5-9429-2e2e-fae6-c16e9b00e09c", "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000", 458, "Bogan, Schmidt and Mayer", "Dolores amet nulla cupiditate pariatur expedita delectus est.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Leda Hermann", "Consectetur dolorum nulla a. Voluptatem omnis repellat in aut aut rerum libero. Id aut velit aut. Perferendis id rem nihil eos necessitatibus quis ratione aliquid perferendis. Deserunt necessitatibus veniam voluptas error quo atque.", 3, "50b50921-e7f0-be87-0ad6-b0167a0c9476", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000", 183, "Lakin, Schinner and Lynch", "Dolor possimus libero.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Angus Flatley", "Qui et animi vitae est odit dolore deserunt. Sed quam eum alias est iure. Eius harum assumenda laboriosam qui.", 1, "4629d77c-e287-f97f-651d-fae2c8fab1ec", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000", 440, "Macejkovic, Labadie and Hyatt", "Rerum vel in sequi sint omnis error quo.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gage O'Connell", "Neque dolor sed fuga error. Et voluptatem qui omnis impedit voluptates incidunt nesciunt quis dolore. Qui quia officiis. Saepe perspiciatis in sapiente. Aperiam soluta consequuntur autem.", 4, "fc738efb-89ef-f451-35ec-88f85f35c1b9", "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000", 353, "Wehner - O'Conner", "Impedit totam saepe delectus quaerat fuga id doloribus aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jordon Windler", "Earum ipsam explicabo. At et similique. Quo modi maiores. Amet architecto explicabo enim perspiciatis iure. In odio ipsam. Occaecati soluta voluptas.", "2dc6f096-000a-ae8a-ac60-b38f70f56a60", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000", 201, "Harber and Sons", "Velit repudiandae velit eaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Kennith Mosciski", "Sunt rerum quia dolores aperiam expedita esse accusamus. Quaerat harum sunt doloribus. Incidunt ad excepturi similique quo dignissimos. Ab laboriosam ullam commodi assumenda odit ut quia sint dolores. Facere aut odit ab in aliquid repellendus adipisci.", 1, "61abef4b-002d-21f2-884b-ac723c818c52", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000", 477, "Turner LLC", "Numquam tempore dolorem sint laborum ratione optio commodi quia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Arlie Rolfson", "Quo rem aperiam. Alias culpa sunt. Ut ut totam reiciendis aspernatur aperiam cumque quam quibusdam ut. Magnam saepe facere animi et quos dolor aliquid quasi. Quis enim aperiam quidem sit occaecati id facilis ad dolorem.", 3, "13077e9b-518c-76c1-dbf9-a1abb31282e8", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000", 409, "Fadel, Legros and Kassulke", "Sit aut est qui ab mollitia." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Carlo Rohan", "Rem cumque impedit aliquam. Suscipit aliquam ut. Illum aspernatur ut incidunt consequatur qui voluptatem sunt dolorem. Alias laudantium id assumenda delectus deleniti.", 5, "c17eb86d-84c9-6e74-0222-adf255ab1595", "https://lh3.googleusercontent.com/d/1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000?authuser=0", 355, "Dibbert Inc", "Et saepe voluptatum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Ashtyn Blick", "Magni cum laborum. Voluptatem aut ut necessitatibus. Libero consectetur qui qui quas rerum ea quidem cum sint.", 1, "76a58579-2abf-7aae-886e-9c0802913af0", "https://lh3.googleusercontent.com/d/1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000?authuser=0", 326, "Lockman and Sons", "Qui et sapiente doloremque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Robert Herman", "Sunt vitae architecto et architecto nostrum modi occaecati. Illum et ab voluptas et minima non eaque. Minus est voluptatem libero beatae. Libero eius cupiditate ipsum nihil ratione. Et sunt sequi laboriosam iure natus tempora commodi laboriosam. Et maxime quo impedit aut qui ullam voluptatem.", 4, "9d1e6fb9-601a-1f92-f239-9262a8089182", "https://lh3.googleusercontent.com/d/12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000?authuser=0", 221, "Pacocha, Schimmel and Klein", "Iure et vitae soluta laboriosam placeat consequatur dolorem porro.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Pearlie Keebler", "Incidunt amet saepe totam excepturi. Dolorem in provident laboriosam. Suscipit qui blanditiis aspernatur est ipsum.", 3, "d26de6e3-5b3a-95bf-60dc-64c797292163", "https://lh3.googleusercontent.com/d/1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000?authuser=0", 394, "Goyette - Goldner", "Voluptas nihil praesentium dolorum.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Rosamond Schoen", "Expedita et soluta. Accusantium sed consequatur. Provident nam dolor non.", 1, "b37fb92b-b6f4-1da3-e813-6866ac0f8878", "https://lh3.googleusercontent.com/d/1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000?authuser=0", 410, "Monahan LLC", "Saepe sunt vel.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kendrick Harris", "Ea illo optio enim est blanditiis non sed. Suscipit exercitationem quo est. Maiores consequatur ut ullam vero consequuntur nostrum quibusdam corporis eos. Nemo sint consectetur perferendis quae nobis dolore commodi facere aut. Debitis et culpa.", 3, "b975831b-283a-3ee5-a113-dde678c7838e", "https://lh3.googleusercontent.com/d/1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000?authuser=0", 376, "Considine and Sons", "Rerum amet eaque consequatur laboriosam voluptas nobis et doloremque.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hope Balistreri", "Sequi est reiciendis architecto voluptatibus debitis. Occaecati dolorem magnam soluta quia cumque aut est eligendi. Eos voluptatem sed tenetur quos modi.", 5, "6335c6db-a5bf-219b-0fd9-b3c620b308d0", "https://lh3.googleusercontent.com/d/1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000?authuser=0", 425, "Cruickshank - Hettinger", "Est iure architecto in nemo id ut dolores.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Alberta Bradtke", "Ullam porro ipsam rerum neque minima. Distinctio nihil debitis nisi ipsa occaecati inventore omnis est distinctio. Doloremque dolor dolores recusandae quam officiis. Expedita repudiandae voluptate cumque dolor. Dolorum eius error aut.", "c2706ba5-c452-4f1f-aa7f-6e7dbbb40f11", "https://lh3.googleusercontent.com/d/1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000?authuser=0", 216, "Hamill, McCullough and Quitzon", "Et repellat et et eius omnis ut omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Pearl Stanton", "Sunt vero veritatis eaque. Quidem qui deserunt error et. Nobis velit ipsum nihil. Nobis libero eos et nesciunt commodi illo. Inventore quo doloribus expedita culpa accusantium nam facilis non. Quia numquam dolorum ut sed.", 4, "402f6299-8dc2-65f9-842f-25b7c03a6c91", "https://lh3.googleusercontent.com/d/1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000?authuser=0", 350, "Kozey, Kreiger and Schmeler", "Ex et maxime aliquam dolor libero nam consectetur blanditiis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Tara VonRueden", "Ex doloribus possimus architecto veritatis ut quod. Eos perspiciatis reprehenderit minus modi. Quia recusandae pariatur et odio cum quia. Ea et cum perspiciatis velit quibusdam debitis quasi aperiam provident. Consectetur nostrum dolor dolor voluptas eveniet. Tempora eos ut harum exercitationem esse et.", 5, "2e902b4a-8b7c-21d9-f292-ffcd11277d02", "https://lh3.googleusercontent.com/d/1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000?authuser=0", 173, "Krajcik Inc", "Qui illum sit." });
        }
    }
}
