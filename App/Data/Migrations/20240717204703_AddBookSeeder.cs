using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBookSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "Description", "GenreId", "ISBN", "Image", "IsBestSeller", "IsDeleted", "IsFeatured", "IsNewArrival", "Pages", "Publisher", "Title", "UpdatedAt", "Year" },
                values: new object[,]
                {
                    { 1, "Jensen Harber", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Id sequi accusantium asperiores maxime. Inventore omnis deleniti rerum esse voluptas. Occaecati et aspernatur quis officiis neque aut aspernatur sed. Incidunt autem nulla fugiat minima. Autem corrupti vero quo vitae aut iusto.", 2, "75c22572-e022-954e-9df2-cc973ae99af4", "https://picsum.photos/640/480/?image=265", false, false, false, false, 498, "Mosciski and Sons", "Reprehenderit nihil hic sit rerum rerum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2023 },
                    { 2, "Lila Graham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hic perspiciatis ea rerum culpa animi doloribus vero est excepturi. Rem saepe tempora sed natus hic. Adipisci facere sunt velit non quia rerum. Laboriosam aliquid maxime omnis. Eveniet incidunt minima rerum omnis voluptas ullam. Voluptates natus officiis magni itaque dolores deleniti exercitationem occaecati est.", 5, "9e575d4c-a762-b6a5-c996-43cf6b78fdb0", "https://picsum.photos/640/480/?image=161", false, false, false, false, 412, "Gleason - Wisozk", "Consequatur omnis dolorem aliquid rerum animi animi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 3, "Hillary Kutch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Iusto consequatur voluptates eaque. Eius quia porro esse odit. Corrupti esse error officiis cumque et deserunt sequi suscipit facere.", 3, "9b9fa0d3-29e4-c0d9-3e5a-331d373404cd", "https://picsum.photos/640/480/?image=528", false, false, false, false, 396, "Cronin and Sons", "Qui velit at id a voluptatem enim omnis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 4, "Malcolm Ernser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Quam quis fugit sint ratione aliquam molestiae. Qui amet vero. Velit culpa autem et nobis maxime saepe delectus hic libero. Et accusamus unde iusto dicta.", 1, "7451da3c-541e-2752-b7ef-c3e73fb506fb", "https://picsum.photos/640/480/?image=90", false, false, false, false, 301, "Collier, Cummings and Hudson", "Aut facilis reiciendis quia qui perspiciatis ducimus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 5, "Rosa Ondricka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Et velit nisi consequatur tempora consequatur voluptatem nisi natus maxime. Eum enim consequuntur sequi. Commodi eveniet in eveniet nam accusamus quam numquam. Similique eum et et et et accusantium possimus ut animi. Vel atque voluptatem sapiente dolorem nostrum voluptas fuga maxime.", 3, "01721307-23e7-7dc0-2f81-c9142155789a", "https://picsum.photos/640/480/?image=415", false, false, false, false, 382, "Kling, Mertz and Powlowski", "Harum ex aliquam quasi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 6, "Camille Hackett", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delectus iusto tenetur praesentium voluptas tenetur nihil. Perspiciatis soluta sit ab voluptatem quo eos. Et nesciunt eum tenetur iure aperiam. Sit sit occaecati voluptas.", 2, "971a452d-2ce2-97c8-6a47-b7e70a922d45", "https://picsum.photos/640/480/?image=159", false, false, false, false, 227, "Walsh, McKenzie and Ankunding", "Quos repellendus tempore unde sed reprehenderit eum provident expedita.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2023 },
                    { 7, "Marcia Hermiston", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ea eaque commodi amet incidunt excepturi iusto labore sint sint. Culpa eaque nisi tempora animi adipisci ut et. Modi illum exercitationem.", 5, "37c3a6d1-0f26-ab1c-2188-c49fd166ac14", "https://picsum.photos/640/480/?image=743", false, false, false, false, 310, "Gulgowski, Schroeder and Harris", "Sunt adipisci nobis quam est nulla sed.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2023 },
                    { 8, "Sedrick Hahn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Et voluptatem numquam quisquam aut. Voluptatem fugit voluptate ea et et. Quis sit distinctio. Voluptatem ea sit ut corrupti corporis error inventore placeat. Iure est repudiandae placeat rerum eaque.", 2, "70072136-97d3-a288-69b5-eea84fce23ce", "https://picsum.photos/640/480/?image=39", false, false, false, false, 403, "Wunsch - Simonis", "Quibusdam dolores accusamus delectus ipsam animi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2023 },
                    { 9, "Cali Mills", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dicta incidunt dolore quos et voluptatem dolores cum. Nihil sit tenetur ut et aut sint est cumque. Temporibus quis neque a occaecati explicabo veritatis et. Accusantium aspernatur vitae soluta eos iusto ea doloremque. Soluta sint tempore odit.", 3, "c1e2e8ea-c8ef-1674-0e78-390fca417448", "https://picsum.photos/640/480/?image=412", false, false, false, false, 125, "Kiehn and Sons", "Praesentium doloremque doloremque qui fuga.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 10, "Arnold Rowe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Exercitationem et et. Neque qui sit aliquam rem voluptatibus eligendi modi est sit. Ab corrupti deserunt consequatur cumque cum nemo. Dolor aut incidunt necessitatibus est dolor. Repellat a aut quo voluptate et quis aut.", 2, "67d7af08-be96-b817-8271-25d7075e251a", "https://picsum.photos/640/480/?image=302", false, false, false, false, 372, "Wiegand - Schinner", "Quia magni deserunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
