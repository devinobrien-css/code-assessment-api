using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookFKSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hertha Zemlak", "A fugit voluptas in tempore quibusdam ab. Animi eum assumenda est vitae tenetur beatae aspernatur et. Iure aspernatur exercitationem qui vitae reprehenderit enim sed voluptas asperiores.", "1c4863f6-463d-1920-e61e-46f7017329b1", "https://picsum.photos/640/480/?image=1052", 266, "Ebert and Sons", "Veritatis nesciunt mollitia.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Javon Rutherford", "Omnis labore minima officia eaque at iure corporis qui similique. Ullam sequi inventore aut qui repudiandae sapiente et. Ut amet voluptate sit ut similique.", "bd5e7912-80d2-726b-1a18-74aa900d2828", "https://picsum.photos/640/480/?image=809", 466, "Gleason - Dietrich", "At officiis eius.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Christop Bode", "Possimus culpa molestiae enim. Enim consequatur et dolores alias quae culpa numquam. Similique laudantium ut voluptatem. Reiciendis omnis mollitia voluptatibus atque. Quo ducimus in saepe blanditiis ut et labore enim est. Molestiae hic ullam et explicabo dolores sapiente voluptatem.", 3, "e85daa38-d6ea-04f6-29a5-e00472578ff8", "https://picsum.photos/640/480/?image=1064", 140, "Mosciski - Cummerata", "Nisi magni dolorem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Arlene Jacobi", "Assumenda ipsa ullam voluptate possimus. Quo sint quasi. Qui fugit ea officia. Tempora praesentium ipsum dolorem ut nulla. Veniam ea adipisci omnis eius.", 1, "631b9d4b-3968-80fc-fec3-7ee52e311e0e", "https://picsum.photos/640/480/?image=556", 385, "West - Hand", "Aperiam enim nihil fuga doloribus quisquam voluptatum.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Isabell Mayert", "Nam nihil minus vitae accusamus in laudantium. Aut et mollitia quasi dolorem. Ut necessitatibus est omnis non dolor dignissimos necessitatibus sint blanditiis. In eos id et. At voluptates repellendus libero qui consequatur soluta dolorem occaecati omnis.", 4, "8d00d05d-c742-4c88-db81-e824216c25d1", "https://picsum.photos/640/480/?image=436", 460, "Corkery, Brown and Von", "Consequatur architecto fugit suscipit quas voluptas dolore.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Shanny Green", "Ratione velit repellendus voluptatem dolorum nam voluptate ut quia aliquid. Voluptate nulla sint soluta officiis ducimus. Repudiandae vero laudantium ea corrupti illo id autem. Odio est beatae et adipisci aut non. Omnis placeat architecto. Quam et eligendi pariatur.", 1, "829b191c-848c-0ed7-aeab-6dcd4d8c1d1f", "https://picsum.photos/640/480/?image=1026", 135, "Blanda - Bednar", "Omnis explicabo aspernatur sint quisquam qui." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Sandy Bergstrom", "Ipsam eum aut velit qui. Veritatis animi rem rerum odit praesentium. Cupiditate sapiente nisi voluptate.", 5, "7013dd51-8d7f-b2c6-e5ce-8c49c67e6618", "https://picsum.photos/640/480/?image=685", 384, "Schiller - Mante", "Quae eligendi nisi et quibusdam dolore eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Helen Waters", "Rerum consequatur voluptas cupiditate omnis. Voluptas possimus natus et consequatur reiciendis eum et facilis rem. Ipsum necessitatibus ipsam quas vel cumque ea libero.", "10f66a58-1039-304b-3877-7e096ddfb197", "https://picsum.photos/640/480/?image=195", 230, "Mosciski and Sons", "Ut architecto esse placeat omnis deleniti ipsum." });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Davin Kuhic", "Temporibus corrupti perferendis eos. Officiis voluptatem quasi ea doloremque saepe consequatur ratione. Recusandae id quia qui alias et. Voluptatum eius corporis veritatis doloribus quos tempora ea optio.", 1, "0c2bbb66-6015-b1a6-9d67-7b8e1353e470", "https://picsum.photos/640/480/?image=775", 484, "Grady, Farrell and Mayert", "Ipsa dolorem temporibus saepe ut voluptatum et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jamison Hoppe", "Nihil ad illum sapiente minima quo eius. Dignissimos quos quos porro. Sed fugit et est. Culpa fugiat labore illo aperiam qui.", "3dc6b829-9ba6-3970-d77c-153d5a8a4392", "https://picsum.photos/640/480/?image=862", 468, "Davis LLC", "Itaque ut molestiae et.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Camylle Walter", "Sapiente dicta minima quas maxime aut et dolores. Et numquam et illum est. Possimus ex aperiam at id quia unde odio. Non vel possimus explicabo quae totam pariatur dignissimos. Ut voluptatem nostrum rerum ut.", "b67e6939-dfe3-8aba-a455-93992de1c6ca", "https://picsum.photos/640/480/?image=76", 412, "Johnson, Hoeger and Heller", "Autem ullam ipsam est incidunt cumque impedit autem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Orie Ferry", "Dolores ut sit magnam veritatis et voluptatem. Illum maiores ut. Dolore sit aperiam reprehenderit reiciendis soluta animi iusto. Et rerum cumque qui quibusdam culpa at quo itaque sunt. Porro eum aut ut ea expedita. Fuga reiciendis eos maiores ea nihil iste.", 1, "90b2a0ea-f0ee-d0d1-d81a-2f46c1e93c35", "https://picsum.photos/640/480/?image=955", 271, "Larson - Runte", "Iure et hic distinctio.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Dorris Keebler", "Quae eligendi est velit excepturi pariatur est aliquid et. Adipisci est id ipsam. Laudantium et voluptas odio odio provident. Dicta voluptatem libero iste. Dolores eum alias debitis dolorem quae quae facilis adipisci. Ipsa tempora sit ea fugit perspiciatis in.", 5, "a06acba3-325c-2b65-ac5c-9e9f45685ebf", "https://picsum.photos/640/480/?image=45", 139, "Moen - McCullough", "Aut asperiores repellendus minima voluptates quae vel qui.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kavon Von", "Voluptatem corrupti enim blanditiis. Incidunt vel maiores aut numquam est. Error corrupti assumenda nihil accusamus et dolores numquam tenetur. Qui molestiae numquam modi ullam maiores quis.", 5, "dfa3607a-0486-9df1-5190-12aaaeb6ef26", "https://picsum.photos/640/480/?image=713", 343, "Mitchell Inc", "Doloremque veniam non.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jovany Walsh", "Molestiae architecto rerum voluptatibus fugiat mollitia assumenda. Ratione ipsa quis officia quis maxime reiciendis et. Ullam consequuntur vel. Modi et aut consectetur sunt ad similique tempore. Earum placeat quo voluptas iure et iste. Itaque voluptatem et.", 5, "9b23a5b6-c6a0-142f-c8ec-b822a4c7260c", "https://picsum.photos/640/480/?image=550", 162, "Frami Inc", "Ad eius et sit illo sequi dolorem neque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Ressie Smitham", "Nostrum et sed sint aut saepe quo nobis impedit rerum. Ut accusamus dolorum. Fugit ut libero quia. Vel sed aperiam inventore expedita ipsum dolores blanditiis odit expedita.", 4, "f22221ba-a7e8-a7ba-9d5a-62cc1bcdd5fc", "https://picsum.photos/640/480/?image=760", 279, "Heaney - Schneider", "Et ea ea pariatur ad temporibus suscipit quam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Enrico Hamill", "Distinctio porro quis mollitia saepe qui cumque unde expedita. Hic autem quod. Nulla vel et facere dolorem nisi molestias consequatur. Voluptas saepe iste quis dolorum voluptatem asperiores architecto ut praesentium.", 1, "48b51b9e-1fb1-bf02-7db4-4d15f43edfbe", "https://picsum.photos/640/480/?image=585", 123, "Cronin LLC", "Quia dicta minus rem cupiditate quos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Berenice Auer", "Voluptate incidunt voluptatem placeat non id. Unde provident nihil adipisci dolorum libero autem sequi. Eum reiciendis tempore vel consequatur. Et excepturi eum quis ullam quo atque. Veniam labore illum et necessitatibus molestiae consequatur numquam repudiandae.", "90682252-4b5b-2f1a-33b0-719416fc21a8", "https://picsum.photos/640/480/?image=1029", 166, "Beier - Tremblay", "Maxime voluptatem fugiat provident pariatur perferendis tempore totam qui aspernatur." });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId");
        }
    }
}
