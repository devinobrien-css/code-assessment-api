using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBookImageLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Robert Herman", "Sunt vitae architecto et architecto nostrum modi occaecati. Illum et ab voluptas et minima non eaque. Minus est voluptatem libero beatae. Libero eius cupiditate ipsum nihil ratione. Et sunt sequi laboriosam iure natus tempora commodi laboriosam. Et maxime quo impedit aut qui ullam voluptatem.", "9d1e6fb9-601a-1f92-f239-9262a8089182", "https://lh3.googleusercontent.com/d/12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000?authuser=0", 221, "Pacocha, Schimmel and Klein", "Iure et vitae soluta laboriosam placeat consequatur dolorem porro." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Pearlie Keebler", "Incidunt amet saepe totam excepturi. Dolorem in provident laboriosam. Suscipit qui blanditiis aspernatur est ipsum.", 3, "d26de6e3-5b3a-95bf-60dc-64c797292163", "https://lh3.googleusercontent.com/d/1bOcpnwGFqsWJVLKxwXC4pdQgo5M1wzDi&sz=w1000?authuser=0", 394, "Goyette - Goldner", "Voluptas nihil praesentium dolorum." });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kendrick Harris", "Ea illo optio enim est blanditiis non sed. Suscipit exercitationem quo est. Maiores consequatur ut ullam vero consequuntur nostrum quibusdam corporis eos. Nemo sint consectetur perferendis quae nobis dolore commodi facere aut. Debitis et culpa.", "b975831b-283a-3ee5-a113-dde678c7838e", "https://lh3.googleusercontent.com/d/1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000?authuser=0", 376, "Considine and Sons", "Rerum amet eaque consequatur laboriosam voluptas nobis et doloremque.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Pearl Stanton", "Sunt vero veritatis eaque. Quidem qui deserunt error et. Nobis velit ipsum nihil. Nobis libero eos et nesciunt commodi illo. Inventore quo doloribus expedita culpa accusantium nam facilis non. Quia numquam dolorum ut sed.", 4, "402f6299-8dc2-65f9-842f-25b7c03a6c91", "https://lh3.googleusercontent.com/d/1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000?authuser=0", 350, "Kozey, Kreiger and Schmeler", "Ex et maxime aliquam dolor libero nam consectetur blanditiis.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tara VonRueden", "Ex doloribus possimus architecto veritatis ut quod. Eos perspiciatis reprehenderit minus modi. Quia recusandae pariatur et odio cum quia. Ea et cum perspiciatis velit quibusdam debitis quasi aperiam provident. Consectetur nostrum dolor dolor voluptas eveniet. Tempora eos ut harum exercitationem esse et.", 5, "2e902b4a-8b7c-21d9-f292-ffcd11277d02", "https://lh3.googleusercontent.com/d/1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000?authuser=0", 173, "Krajcik Inc", "Qui illum sit.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Mikayla Thompson", "Rerum nobis alias voluptas voluptatem rerum recusandae consequatur. Excepturi molestias ut. Tempore vel nemo. Nulla sed suscipit omnis sit vero provident id voluptate voluptatem. Tenetur mollitia minus architecto porro recusandae at aut minus est.", 3, "cce14fc9-9601-30e2-32aa-95bd09a22d10", "https://drive.google.com/thumbnail?id=1zycl7EiCECK541ialA9UCrs9HdfddUQb&sz=w1000", 146, "Hessel Group", "Deleniti officia veritatis quia laudantium laudantium eos voluptatem velit." });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Augusta Deckow", "Corrupti accusamus velit pariatur et vero et. Sint et ut et ratione. Sed saepe aut aut ipsum fuga veniam impedit. Consequatur voluptatem velit. Sed et occaecati ratione omnis. Ut itaque sit aliquam saepe fugiat eos voluptatem velit.", "51016ca2-684f-25c7-1716-33156da29b69", "https://drive.google.com/thumbnail?id=12xFmb08WRoRr5omVtZ38Obo1imbutVlh&sz=w1000", 309, "Schiller Inc", "Totam vitae vitae." });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Esta Dicki", "Ab ut provident magni eaque similique odio dolores voluptatum. Deserunt voluptates mollitia et hic nemo dolores. Et velit ex et deleniti. Consequatur rerum nisi sed blanditiis explicabo qui nemo fugit. Aut molestiae praesentium inventore.", "7757334b-a940-c562-9b73-eb5504597746", "https://drive.google.com/thumbnail?id=1Hk2fvOg7hpmRwKWc-QTl82NGerqKib71&sz=w1000", 416, "Koelpin Group", "Voluptatibus itaque beatae.", 2024 });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jaqueline Bruen", "Enim omnis omnis est saepe omnis voluptatem molestiae. Est ut vel quia culpa. Sed ut soluta dolor architecto vel. Sed nam soluta facere consequuntur aut asperiores.", "74f772b0-121f-009f-751b-1b0e2a2bb1fc", "https://drive.google.com/thumbnail?id=1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl&sz=w1000", 487, "Casper - Davis", "Veniam ipsa doloremque reprehenderit autem velit assumenda amet est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Troy Lowe", "Sunt earum itaque saepe nulla. Dolor alias dolorem nam libero recusandae asperiores quia accusantium consectetur. Nobis ad voluptatum molestiae voluptate quae in error tempore.", 3, "e5584287-f2ce-3a4a-d82e-e119392795ba", "https://drive.google.com/thumbnail?id=1UMX2PhE5C46EQuRL8UkbdUqIKGuBNbJ5&sz=w1000", 220, "Heathcote - Oberbrunner", "Voluptatem pariatur vel nihil nemo.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Erna Schmitt", "Itaque quas cupiditate consequatur iusto. Corporis animi quia consequuntur. Cum autem aliquid quasi.", 4, "6788c41a-cf8f-0609-eaff-e4523f0dfc6c", "https://drive.google.com/thumbnail?id=1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK&sz=w1000", 183, "Labadie Group", "Non nisi iure et veritatis est similique perferendis praesentium quo.", 2024 });
        }
    }
}
