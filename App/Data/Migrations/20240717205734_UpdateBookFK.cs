using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jamison Hoppe", "Nihil ad illum sapiente minima quo eius. Dignissimos quos quos porro. Sed fugit et est. Culpa fugiat labore illo aperiam qui.", "3dc6b829-9ba6-3970-d77c-153d5a8a4392", "https://picsum.photos/640/480/?image=862", 468, "Davis LLC", "Itaque ut molestiae et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Camylle Walter", "Sapiente dicta minima quas maxime aut et dolores. Et numquam et illum est. Possimus ex aperiam at id quia unde odio. Non vel possimus explicabo quae totam pariatur dignissimos. Ut voluptatem nostrum rerum ut.", 5, "b67e6939-dfe3-8aba-a455-93992de1c6ca", "https://picsum.photos/640/480/?image=76", 412, "Johnson, Hoeger and Heller", "Autem ullam ipsam est incidunt cumque impedit autem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Orie Ferry", "Dolores ut sit magnam veritatis et voluptatem. Illum maiores ut. Dolore sit aperiam reprehenderit reiciendis soluta animi iusto. Et rerum cumque qui quibusdam culpa at quo itaque sunt. Porro eum aut ut ea expedita. Fuga reiciendis eos maiores ea nihil iste.", "90b2a0ea-f0ee-d0d1-d81a-2f46c1e93c35", "https://picsum.photos/640/480/?image=955", 271, "Larson - Runte", "Iure et hic distinctio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Dorris Keebler", "Quae eligendi est velit excepturi pariatur est aliquid et. Adipisci est id ipsam. Laudantium et voluptas odio odio provident. Dicta voluptatem libero iste. Dolores eum alias debitis dolorem quae quae facilis adipisci. Ipsa tempora sit ea fugit perspiciatis in.", 5, "a06acba3-325c-2b65-ac5c-9e9f45685ebf", "https://picsum.photos/640/480/?image=45", 139, "Moen - McCullough", "Aut asperiores repellendus minima voluptates quae vel qui." });

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
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jovany Walsh", "Molestiae architecto rerum voluptatibus fugiat mollitia assumenda. Ratione ipsa quis officia quis maxime reiciendis et. Ullam consequuntur vel. Modi et aut consectetur sunt ad similique tempore. Earum placeat quo voluptas iure et iste. Itaque voluptatem et.", "9b23a5b6-c6a0-142f-c8ec-b822a4c7260c", "https://picsum.photos/640/480/?image=550", 162, "Frami Inc", "Ad eius et sit illo sequi dolorem neque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ressie Smitham", "Nostrum et sed sint aut saepe quo nobis impedit rerum. Ut accusamus dolorum. Fugit ut libero quia. Vel sed aperiam inventore expedita ipsum dolores blanditiis odit expedita.", 4, "f22221ba-a7e8-a7ba-9d5a-62cc1bcdd5fc", "https://picsum.photos/640/480/?image=760", 279, "Heaney - Schneider", "Et ea ea pariatur ad temporibus suscipit quam.", 2024 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jensen Harber", "Id sequi accusantium asperiores maxime. Inventore omnis deleniti rerum esse voluptas. Occaecati et aspernatur quis officiis neque aut aspernatur sed. Incidunt autem nulla fugiat minima. Autem corrupti vero quo vitae aut iusto.", 2, "75c22572-e022-954e-9df2-cc973ae99af4", "https://picsum.photos/640/480/?image=265", 498, "Mosciski and Sons", "Reprehenderit nihil hic sit rerum rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Lila Graham", "Hic perspiciatis ea rerum culpa animi doloribus vero est excepturi. Rem saepe tempora sed natus hic. Adipisci facere sunt velit non quia rerum. Laboriosam aliquid maxime omnis. Eveniet incidunt minima rerum omnis voluptas ullam. Voluptates natus officiis magni itaque dolores deleniti exercitationem occaecati est.", "9e575d4c-a762-b6a5-c996-43cf6b78fdb0", "https://picsum.photos/640/480/?image=161", 412, "Gleason - Wisozk", "Consequatur omnis dolorem aliquid rerum animi animi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hillary Kutch", "Iusto consequatur voluptates eaque. Eius quia porro esse odit. Corrupti esse error officiis cumque et deserunt sequi suscipit facere.", 3, "9b9fa0d3-29e4-c0d9-3e5a-331d373404cd", "https://picsum.photos/640/480/?image=528", 396, "Cronin and Sons", "Qui velit at id a voluptatem enim omnis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Malcolm Ernser", "Quam quis fugit sint ratione aliquam molestiae. Qui amet vero. Velit culpa autem et nobis maxime saepe delectus hic libero. Et accusamus unde iusto dicta.", "7451da3c-541e-2752-b7ef-c3e73fb506fb", "https://picsum.photos/640/480/?image=90", 301, "Collier, Cummings and Hudson", "Aut facilis reiciendis quia qui perspiciatis ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Rosa Ondricka", "Et velit nisi consequatur tempora consequatur voluptatem nisi natus maxime. Eum enim consequuntur sequi. Commodi eveniet in eveniet nam accusamus quam numquam. Similique eum et et et et accusantium possimus ut animi. Vel atque voluptatem sapiente dolorem nostrum voluptas fuga maxime.", 3, "01721307-23e7-7dc0-2f81-c9142155789a", "https://picsum.photos/640/480/?image=415", 382, "Kling, Mertz and Powlowski", "Harum ex aliquam quasi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Camille Hackett", "Delectus iusto tenetur praesentium voluptas tenetur nihil. Perspiciatis soluta sit ab voluptatem quo eos. Et nesciunt eum tenetur iure aperiam. Sit sit occaecati voluptas.", 2, "971a452d-2ce2-97c8-6a47-b7e70a922d45", "https://picsum.photos/640/480/?image=159", 227, "Walsh, McKenzie and Ankunding", "Quos repellendus tempore unde sed reprehenderit eum provident expedita.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Marcia Hermiston", "Ea eaque commodi amet incidunt excepturi iusto labore sint sint. Culpa eaque nisi tempora animi adipisci ut et. Modi illum exercitationem.", "37c3a6d1-0f26-ab1c-2188-c49fd166ac14", "https://picsum.photos/640/480/?image=743", 310, "Gulgowski, Schroeder and Harris", "Sunt adipisci nobis quam est nulla sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sedrick Hahn", "Et voluptatem numquam quisquam aut. Voluptatem fugit voluptate ea et et. Quis sit distinctio. Voluptatem ea sit ut corrupti corporis error inventore placeat. Iure est repudiandae placeat rerum eaque.", 2, "70072136-97d3-a288-69b5-eea84fce23ce", "https://picsum.photos/640/480/?image=39", 403, "Wunsch - Simonis", "Quibusdam dolores accusamus delectus ipsam animi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Cali Mills", "Dicta incidunt dolore quos et voluptatem dolores cum. Nihil sit tenetur ut et aut sint est cumque. Temporibus quis neque a occaecati explicabo veritatis et. Accusantium aspernatur vitae soluta eos iusto ea doloremque. Soluta sint tempore odit.", 3, "c1e2e8ea-c8ef-1674-0e78-390fca417448", "https://picsum.photos/640/480/?image=412", 125, "Kiehn and Sons", "Praesentium doloremque doloremque qui fuga." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Arnold Rowe", "Exercitationem et et. Neque qui sit aliquam rem voluptatibus eligendi modi est sit. Ab corrupti deserunt consequatur cumque cum nemo. Dolor aut incidunt necessitatibus est dolor. Repellat a aut quo voluptate et quis aut.", "67d7af08-be96-b817-8271-25d7075e251a", "https://picsum.photos/640/480/?image=302", 372, "Wiegand - Schinner", "Quia magni deserunt." });
        }
    }
}
