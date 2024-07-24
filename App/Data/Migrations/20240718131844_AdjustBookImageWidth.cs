using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBookImageWidth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Mikayla Thompson", "Rerum nobis alias voluptas voluptatem rerum recusandae consequatur. Excepturi molestias ut. Tempore vel nemo. Nulla sed suscipit omnis sit vero provident id voluptate voluptatem. Tenetur mollitia minus architecto porro recusandae at aut minus est.", "cce14fc9-9601-30e2-32aa-95bd09a22d10", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000", 146, "Hessel Group", "Deleniti officia veritatis quia laudantium laudantium eos voluptatem velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Dashawn Friesen", "Atque ipsum voluptatem maiores cupiditate possimus aut. Tempore animi saepe sit et unde quasi veniam id. Ut aut eum corporis.", 2, "5b946d65-e958-99dc-af00-bdeb84c01a59", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA&sz=w1000", 118, "Effertz - Boyer", "Laboriosam voluptatem autem molestiae laboriosam deserunt eligendi quia amet qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Augusta Deckow", "Corrupti accusamus velit pariatur et vero et. Sint et ut et ratione. Sed saepe aut aut ipsum fuga veniam impedit. Consequatur voluptatem velit. Sed et occaecati ratione omnis. Ut itaque sit aliquam saepe fugiat eos voluptatem velit.", 4, "51016ca2-684f-25c7-1716-33156da29b69", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000", 309, "Schiller Inc", "Totam vitae vitae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Lawrence Goodwin", "Vel omnis doloremque in totam velit culpa. Eaque aut ullam atque rerum ex enim. Sed necessitatibus praesentium optio rerum aut deleniti. Ab ea cum. Occaecati minima id numquam harum libero quis ea. Aspernatur repudiandae cum ipsa consequatur odit qui voluptatibus eos beatae.", 2, "be5b7391-8438-b64e-8680-21c2e74e9423", "https://drive.google.com/thumbnail?id=1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000", 240, "Zboncak, Grant and Kuhlman", "Laboriosam non est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Cielo Mann", "Et voluptatem quas tempora corporis debitis debitis. Sunt ad consequatur aperiam. Sunt aut perferendis velit. Deleniti aliquam dolorum maxime cum id.", 5, "451e8970-188a-96c9-68ca-2fa96de369bb", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc&sz=w1000", 139, "Wiegand, Schmitt and Koelpin", "Ipsum quia laboriosam voluptas et sunt quidem suscipit.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Esta Dicki", "Ab ut provident magni eaque similique odio dolores voluptatum. Deserunt voluptates mollitia et hic nemo dolores. Et velit ex et deleniti. Consequatur rerum nisi sed blanditiis explicabo qui nemo fugit. Aut molestiae praesentium inventore.", 3, "7757334b-a940-c562-9b73-eb5504597746", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000", 416, "Koelpin Group", "Voluptatibus itaque beatae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Annalise Lockman", "Quae ut voluptas earum est. Rerum sequi qui omnis laborum accusantium et facere doloribus. Cupiditate hic omnis illo alias exercitationem. Architecto inventore aperiam autem sapiente magnam repudiandae aut.", 2, "025603a1-3f1c-e577-0219-c23d8d8a9c62", "https://drive.google.com/thumbnail?id=1cozBSsETbbn8YWA27-cyfpxAgOKX-FwJ&sz=w1000", 335, "Barton - Connelly", "Corrupti alias dignissimos reiciendis aut.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jaqueline Bruen", "Enim omnis omnis est saepe omnis voluptatem molestiae. Est ut vel quia culpa. Sed ut soluta dolor architecto vel. Sed nam soluta facere consequuntur aut asperiores.", "74f772b0-121f-009f-751b-1b0e2a2bb1fc", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000", 487, "Casper - Davis", "Veniam ipsa doloremque reprehenderit autem velit assumenda amet est.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Troy Lowe", "Sunt earum itaque saepe nulla. Dolor alias dolorem nam libero recusandae asperiores quia accusantium consectetur. Nobis ad voluptatum molestiae voluptate quae in error tempore.", 3, "e5584287-f2ce-3a4a-d82e-e119392795ba", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000", 220, "Heathcote - Oberbrunner", "Voluptatem pariatur vel nihil nemo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Erna Schmitt", "Itaque quas cupiditate consequatur iusto. Corporis animi quia consequuntur. Cum autem aliquid quasi.", "6788c41a-cf8f-0609-eaff-e4523f0dfc6c", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000", 183, "Labadie Group", "Non nisi iure et veritatis est similique perferendis praesentium quo." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Juwan Nicolas", "Laborum numquam aperiam sit voluptatem nisi ipsa veritatis. Est similique repudiandae iusto. Vitae ut quia. Vitae provident consequatur et incidunt. Et voluptatem perspiciatis officia inventore quidem totam incidunt. Aut ea ratione praesentium nesciunt est et illum sint blanditiis.", "37e57dff-fe43-0c47-ea7c-67220108f8e6", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb", 201, "Mraz - Stamm", "Molestias sunt totam voluptatibus architecto est deleniti laudantium expedita." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Abigale Boehm", "Odit atque sequi vitae nam atque enim possimus. Ullam vel quos perspiciatis sit omnis dolores. Voluptatem sint beatae totam ut. Laborum similique corrupti dolor vel et voluptas ut beatae sint. Minima ea quia nulla aliquam omnis maxime quasi.", 1, "ca4089c2-2630-4200-475f-5d08d05dff6c", "https://drive.google.com/thumbnail?id=1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA", 239, "Kassulke LLC", "Et placeat maiores est est ullam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Maud Beer", "Qui quod quo itaque nulla ut. Eligendi necessitatibus sunt dolore odit autem quia. Aut alias et vel pariatur.", 5, "9753b244-7284-0544-0c65-f58ad35a7b90", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh", 348, "McClure Inc", "Et atque quas ducimus veniam ab ratione quae fuga eveniet." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lexie Keeling", "Aut itaque omnis qui ab. Tempore itaque dolor quo impedit. Veniam quos et sed aut laboriosam et adipisci. Et voluptatem perspiciatis enim. Doloremque praesentium animi.", 1, "7955261a-5d6f-d849-a4d9-a3def6a0e87f", "https://drive.google.com/thumbnail?id=1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc", 295, "Volkman, Collier and Welch", "Enim et deserunt qui a voluptas itaque rem repudiandae.", 2023 });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Alexandria Raynor", "Et quo et aut autem. Nihil minima et. Exercitationem necessitatibus repellat officiis enim et. Qui vitae omnis ut expedita dolorem autem est.", "d9c304c6-0c03-1416-c37b-f26c3b36a98b", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl", 286, "Hintz - Abshire", "Autem odit aut eum dolor natus tempore iure perspiciatis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Lia Considine", "Id et quis commodi consequatur ut. Incidunt laboriosam odio consequatur minima rerum architecto accusamus aliquam. Dolore omnis suscipit libero et consequatur sit. Mollitia ab cupiditate perspiciatis soluta repudiandae reprehenderit iusto nostrum dolorem.", 2, "f9991fad-7721-77d5-ae2d-e73765bd65b0", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5", 246, "Koelpin, Strosin and Kub", "Nihil possimus iure tempora." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Elfrieda Mohr", "Molestiae fugiat sunt non inventore dolorem. Sed vero ducimus qui aut. Ex ut doloribus repellat iure deleniti. Aliquam qui aut facilis eum ut est temporibus labore sunt.", "18939735-3fb1-f629-9352-fbc2cbc1a99a", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK", 442, "Champlin - DuBuque", "Similique vel veniam cum." });
        }
    }
}
