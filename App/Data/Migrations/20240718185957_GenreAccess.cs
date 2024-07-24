using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class GenreAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Hanna Jones", "Ex et in aut. Aliquam aperiam inventore magnam consequatur in. Animi pariatur odit minus autem numquam possimus itaque.", 2, "86dabeef-0749-938e-b8ca-eeb7975fadc8", 374, "Dach - Kris", "Natus molestias voluptate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Vivianne Hickle", "Quaerat aut totam est voluptate impedit omnis accusamus qui. Esse dolorem et. In ut dicta minima.", "73e55795-3c39-8528-8c7f-a4a5c58d6373", 177, "Torp and Sons", "Facere ea rem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Bernadine Ledner", "Voluptas non reprehenderit odit et eos nulla dignissimos. Sint ea praesentium et et. Eligendi voluptas omnis id soluta maxime libero quia nulla qui. Est tenetur perferendis ipsam quos facere dignissimos reiciendis. Error excepturi ut itaque et adipisci.", 1, "557a6d51-b5ab-55fa-1e63-b25ab6366884", 376, "Nader Group", "Aut mollitia tempora.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Oren Kulas", "Quaerat est omnis. Blanditiis distinctio eum perspiciatis beatae blanditiis soluta est non sed. Sed inventore voluptatum deserunt veniam quia ratione.", 2, "f89c11df-9a98-a7e9-6185-a3004f9cb3c5", 346, "Corkery - Waters", "Quo non voluptatem.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jeromy Gaylord", "Illum impedit ut voluptas. Eaque rerum quos tenetur distinctio modi repellendus quos. Non incidunt veniam ut libero veritatis est quidem reiciendis ea. Dolor quidem animi perspiciatis neque optio corrupti. Aliquid excepturi dignissimos.", 3, "2dda26d8-f44a-beca-9276-1da1c717c311", 217, "Runolfsdottir LLC", "Tempora sed totam.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Greyson Boehm", "Rerum nemo nemo dolor rerum rerum. Quisquam provident commodi tenetur quos omnis veritatis explicabo iure harum. Quae facilis perspiciatis facere nostrum tempore eos eaque.", 1, "449c26a6-cdee-44b5-e59d-4739ff54d568", 440, "Jerde, Kertzmann and Waelchi", "Praesentium quo hic.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Una Lemke", "Tempore nulla qui voluptatem in eveniet. Facilis corrupti minus eum placeat quae voluptatum. Accusantium est repellendus in ut eveniet voluptatum ipsa dolorem. Vitae eum perspiciatis et consequatur quos impedit sint aut sunt. Maiores reprehenderit quis animi quia pariatur nostrum consequuntur eum. Ut quos quis molestiae ab et at commodi nihil.", 4, "ccd76777-b735-99b3-73b9-23b6c8533b91", 372, "Kessler - Rohan", "Delectus ipsam sunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Moriah Larson", "Officiis voluptatem ut. Eum ratione sapiente voluptas voluptatem in ut dolore rerum suscipit. Non rem maiores.", 4, "3748b3a8-98a1-2c2b-4c48-293950b11744", 183, "Buckridge - Steuber", "Voluptas cupiditate unde.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Brain Hegmann", "Quo mollitia possimus ducimus sint doloribus quidem voluptas facilis. Iste dolorum laboriosam et unde. Quo libero perspiciatis repudiandae consequuntur officia et blanditiis vitae itaque. Exercitationem nostrum voluptatibus labore magnam tenetur dolores incidunt.", 2, "9bee71b2-f7f8-4502-00c4-db82587a85fa", 251, "Mante and Sons", "Quod perferendis laboriosam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Macy Auer", "Illum ipsum culpa animi omnis consequatur possimus qui sed. Aut architecto magnam. Vel error sint sit eum occaecati aut ducimus exercitationem aliquid. Mollitia voluptatem quibusdam voluptas quis in provident quisquam.", 5, "00897ead-3e70-8695-5570-4541452eacd0", 496, "Little, Rowe and Larkin", "Distinctio dignissimos incidunt.", 2024 });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Emanuel Larkin", "Ex doloremque et voluptas. Et optio et aut delectus illo recusandae. Ullam incidunt quia et. Sequi ut occaecati ut illum voluptas repellendus quia quos aliquid. Ea qui itaque non dicta quia.", 4, "058ab78c-ac96-b13b-d0c9-53b754d82bd3", 483, "Carter, Dach and Kulas", "Minus consectetur ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Edmond Raynor", "Reiciendis debitis consequatur dolores omnis illum debitis voluptatem. Rerum nemo aspernatur soluta. Ab excepturi dolorem et tempora. Harum ipsam voluptate harum. Eius ab culpa repudiandae.", "d08d32a5-6b13-69c5-9797-c66cc82a1aa3", 113, "Bosco, Franecki and Gusikowski", "Eveniet nam odit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Adella Upton", "Sed molestiae aliquam exercitationem earum ipsum. Maxime dolor modi qui aut labore sit natus exercitationem et. Architecto at enim autem reprehenderit delectus placeat et. Modi sint molestiae et fugiat vitae quaerat quos.", 5, "1ed4ecad-0bf1-4cf4-4dd9-03bd4d28e9bb", 432, "Hane - Koepp", "In velit recusandae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Allan Kuhn", "Ipsa ut velit dignissimos magnam illo. Accusantium ea ea quia et ad voluptatem. Qui blanditiis aut accusantium placeat. Iste asperiores velit et sit unde non ullam odio. Qui libero repellendus quo non.", 3, "545592bd-2533-5e3e-c259-e9974db4012f", 454, "Langworth - Rowe", "Eaque enim consequatur.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Denis Lebsack", "Rerum corporis nulla nam et quos harum sapiente. Est perspiciatis fuga quaerat. Nesciunt voluptatem atque dolores esse nulla perspiciatis omnis. Provident facere autem iure dolor cumque tenetur odit. Repudiandae voluptates tempora qui sit consectetur commodi.", 4, "ddba81b5-0ff8-bfb0-6bff-f1e0ca1a4ce7", 295, "Grant LLC", "Reiciendis inventore ipsa.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Tiffany Wiegand", "Rerum ut aut mollitia iusto ab. Officia excepturi reiciendis velit eos corporis enim. Velit fuga quia sapiente. Voluptates velit temporibus velit dolorem architecto. Deleniti repudiandae quia dicta dignissimos.", 4, "8e1b48f7-4c54-6355-8206-fc70f2463d03", 394, "Schmeler and Sons", "Est vero quis.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Kamille Mills", "Est non delectus non laudantium reprehenderit sed veniam rem. Eligendi sit nulla numquam. Eveniet voluptatibus mollitia et. In nihil qui repellat. Sunt quod vel dolorum quas ut quod et ut.", 5, "abba7ad0-2410-82a9-449b-9aff76b6104f", 193, "Ruecker - Parisian", "Hic atque quia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Garrison Powlowski", "Ut recusandae iure itaque consequatur incidunt mollitia. Natus suscipit et fuga. Excepturi voluptatibus ipsa est mollitia nobis numquam.", 3, "ba87dbca-9f06-e10f-cf49-3c72b7a0415d", 113, "Kiehn, Crona and Donnelly", "Doloribus corporis sequi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Tyson Howe", "Ut at et voluptas perferendis. In atque labore nobis molestiae harum assumenda dicta aut ipsum. Aliquam possimus quisquam. Consectetur dignissimos modi voluptatem placeat doloremque repudiandae in ut et. Fugiat mollitia quaerat sed tempora ex mollitia harum ullam. Voluptatem reiciendis a sint soluta.", 1, "de7ee96c-5221-e695-190d-a73dbffdd6fb", 460, "Jacobi - Schulist", "Pariatur consequatur rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Mack Tremblay", "In itaque facilis molestiae repellat facilis. Illo et totam expedita nemo consequatur. Consectetur ut qui ut non maxime est accusamus. Nam ullam alias saepe ipsa ipsa consequuntur.", 1, "a588ed65-84c5-0e9f-eafb-480b6d7b7c70", 268, "Kris and Sons", "Labore itaque qui.", 2023 });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genre_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
