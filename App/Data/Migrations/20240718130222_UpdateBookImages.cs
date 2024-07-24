using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sadie Stoltenberg", "Ex eum aut suscipit et animi provident non. Dicta cupiditate amet accusamus. Illum ex earum. Quibusdam adipisci ducimus voluptates ducimus vel reiciendis. Numquam ea ullam voluptates laudantium odit.", 1, "1ec378b5-ec78-e712-6674-c16dbd746e70", "1C4sRKzQrFUDNQ1X12WVeKbX0knOoC6tA", 244, "Gusikowski - Hoppe", "Consequatur quod qui dolorem illo temporibus et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Angie Moen", "Quos non eveniet quae incidunt. Dolor et quam. Quasi fuga et. Aut optio ex sunt reprehenderit magni veniam et.", 5, "5757bb79-31d7-f4e7-2c70-158776c0254b", "12xFmb08WRoRr5omVtZ38Obo1imbutVlh", 165, "Wiegand, Funk and Upton", "Dolor amet iure laborum eligendi veritatis iste iusto." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Minerva Lind", "Totam fugit totam labore. Repellendus natus sit sed iste. Error ut totam dolorem. Magni velit praesentium consequatur. In qui veritatis ab nesciunt sed. Et suscipit harum et porro enim iusto soluta.", 2, "d146a097-6abf-9e01-d8bf-321a2f37f3be", "1Eu7yiiaAMfb0ktMOKhJZN6htKhF-TPDc", 203, "Mohr Group", "Expedita inventore repudiandae aliquid.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Henderson Bogisich", "Id voluptatem asperiores natus aut non nemo aliquam. Dolores temporibus hic et veritatis voluptatem. Assumenda neque sed nostrum porro earum nesciunt debitis excepturi animi. Et voluptatibus qui atque perspiciatis est sit fugit. Quis quos libero ad eligendi.", 2, "90a222fe-407f-3a3c-3ae3-2c11fbf076f2", "1X_DcLIDCuXHtlh2LDJrS07h8lNcK1vXl", 497, "O'Keefe - Koelpin", "Consequatur quam et perferendis.", 2023 });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Fausto Koch", "Tempora accusamus ullam nemo non ut. Nulla exercitationem quos aut. Consequatur hic qui rerum autem distinctio unde illo aperiam. Facilis qui sunt. Molestias nihil voluptatem veritatis quidem fuga quaerat. Rerum nulla neque voluptatum rerum sunt at blanditiis.", 4, "458695fb-b1e1-6e20-40fb-26e23fca2b49", "1kSEao7g56ZMPYkBxqCQi70rpfxSqGvMK", 403, "Dooley, Osinski and Fadel", "Eveniet ad doloremque et in adipisci laudantium.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Chanel Gottlieb", "Esse esse rerum et exercitationem et itaque. Iusto quia dignissimos nihil ipsum sequi eum quae et voluptate. Eum vitae ex et perspiciatis ea est vero.", 1, "b14c883d-f5f2-3bde-3fd0-533f96a98b3d", "https://picsum.photos/640/480/?image=749", 164, "Doyle, Turner and Klein", "Sed illo architecto sunt non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Litzy Fritsch", "Libero et voluptatum delectus deserunt nihil exercitationem. Dolor non tempore eaque dignissimos explicabo qui. Perspiciatis veritatis provident cumque. Iusto assumenda saepe beatae numquam excepturi non amet. Similique vero excepturi facilis sapiente cumque omnis. Dolorem itaque omnis aut quia magni labore maiores laudantium est.", 2, "ca6e35a4-a71c-95c3-af15-c40dcc8d31b6", "https://picsum.photos/640/480/?image=552", 450, "Murazik, Mosciski and Bruen", "Voluptatibus porro vitae qui voluptas voluptatem.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Noemie Reilly", "Accusantium ullam qui qui ut id nemo incidunt. Quia eos rerum officiis. Ratione minus voluptatibus. Est iure quis id deserunt delectus at eos odit eos. Eius possimus laborum ut sequi perferendis qui molestias sed. Sit et quis.", 3, "c58847ed-20c9-0844-17c3-9a75ee27f065", "https://picsum.photos/640/480/?image=337", 498, "Hartmann, Upton and Kris", "Et quia deleniti quam veritatis occaecati cupiditate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Craig Hahn", "Ullam ea sint animi necessitatibus illo quia voluptas fugit quam. Aspernatur ullam consectetur voluptates qui. Aspernatur maiores et rem.", 5, "12441b1f-d1c5-24e2-804f-351bb7509626", "https://picsum.photos/640/480/?image=606", 433, "Rippin - Goodwin", "Qui ut neque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Jedediah Gutmann", "Velit aut dolor inventore tempora quisquam tenetur. Voluptas perferendis odit beatae soluta qui qui est soluta. Est et magnam sint dolorem eius eos. Et et cum quia esse sunt dolorum aut. Fuga vitae non sit repudiandae nihil saepe enim totam quod.", 3, "23edaff6-a571-3e8e-e957-05ffcbd0bfef", "https://picsum.photos/640/480/?image=834", 322, "Koss - Farrell", "Possimus voluptatem quaerat porro id.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Brandt Vandervort", "Sit et et et consequuntur amet voluptas quis. Corporis quas voluptatum iure consequatur. Tempora aut tempore autem dolorem voluptas mollitia dignissimos est. Magni velit tenetur beatae quaerat fuga alias vel quo temporibus. Earum voluptas quam ea ipsa eos nostrum esse velit est.", 5, "c1b1eee3-ae0a-51a8-db79-c728712260c3", "https://picsum.photos/640/480/?image=747", 394, "Torp Group", "Labore natus qui laborum voluptatibus sint dolores dolorem ex deserunt.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Vivien Harber", "Et aperiam odio vel quae excepturi dolorum et fugiat autem. Possimus cumque ab hic. Velit ducimus qui harum provident ipsa. Atque ex culpa illo neque iusto cupiditate veritatis. Perspiciatis non tempora rerum perspiciatis ut dolor. Nesciunt quia enim exercitationem reprehenderit et.", 2, "4a5adb0f-1f3a-825e-30c8-63115a5c037e", "https://picsum.photos/640/480/?image=1", 211, "Kihn, Swaniawski and Grimes", "Optio voluptates incidunt quia soluta esse aut.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Gregoria Herman", "Est voluptas dolor repudiandae. Voluptatem sint accusamus culpa ex unde. Et aut et reiciendis. Quas dolor velit aliquid omnis facere qui. Voluptatem eum dolorem. Suscipit repellendus voluptate non consequuntur voluptatem odit.", 1, "2eaa91f2-4ebe-433c-89b8-4f936ff95a78", "https://picsum.photos/640/480/?image=945", 210, "Mosciski Inc", "Corrupti qui eaque cupiditate.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Ansel Pagac", "Numquam in animi nemo rerum dolorem ut aut quos. Est in totam exercitationem officia quia at ipsum voluptatem. Ut beatae est. Laudantium minus tempore modi laborum omnis. Quo quos error maiores. Enim vel maxime aut enim et et tempore.", 2, "1ce0e12e-f91a-783a-435c-42d688b38cc4", "https://picsum.photos/640/480/?image=591", 278, "McLaughlin - Dickinson", "Sequi adipisci doloribus placeat voluptates natus cupiditate quisquam iusto necessitatibus.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Patrick Howe", "Velit impedit aut ratione ut neque cumque. Ipsa illo eius numquam tempora. Eum reiciendis molestiae et. Fuga iure et aperiam commodi soluta. Ratione enim consequatur est. Incidunt necessitatibus molestiae ut eos omnis pariatur vel.", 3, "25f6f42f-4cc4-347e-eff2-a93e7121c887", "https://picsum.photos/640/480/?image=772", 370, "Mraz - Kiehn", "Voluptatem voluptas maiores.", 2024 });
        }
    }
}
