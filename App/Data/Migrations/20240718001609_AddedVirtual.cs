using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedVirtual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Clovis Kautzer", "Aut ipsa enim culpa culpa aperiam. Deserunt quo suscipit iste quia. Non ullam expedita. Saepe eum adipisci qui quisquam ut adipisci est. Harum sed et dolorem qui ut. Id ut unde explicabo dolore nobis.", 2, "3b43fac6-a05c-097b-361c-e40fb82be891", "https://picsum.photos/640/480/?image=325", 371, "Kautzer, Halvorson and Rogahn", "Illo dolor aliquid laudantium consectetur esse est commodi.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Vada Reinger", "Asperiores quaerat cum velit ipsam voluptas porro voluptatum perspiciatis. Rerum enim repudiandae. Expedita est illo ad eum aliquid quia. Delectus nam et magnam possimus ut molestias porro. Et eveniet sit sit assumenda quia. Sapiente aut et corrupti id incidunt.", 3, "3413b926-49fd-1869-c2cd-d461ca0348d1", "https://picsum.photos/640/480/?image=338", 143, "Lockman Inc", "Soluta quidem perspiciatis repudiandae non voluptatum aliquid culpa vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Chasity Mosciski", "Qui et facilis repellendus rerum animi. Velit cupiditate perspiciatis occaecati expedita quia. Quis voluptatem occaecati. Qui tempore quasi voluptatem expedita dignissimos rem ea qui rerum.", "bdb177fb-90aa-8860-e2b5-70fce1b93df3", "https://picsum.photos/640/480/?image=285", 198, "Howe - Langosh", "Odit porro ut deserunt autem occaecati et quisquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Alexane Goyette", "Soluta eum delectus quia similique aliquam et. Maxime nisi in qui non. Quia aut mollitia et non beatae quam. Laboriosam sequi fugiat facilis deserunt velit. Odit itaque eveniet cum voluptas nesciunt dolor tempore.", 2, "668b3f0a-e246-ad8d-1b27-bc107f013c43", "https://picsum.photos/640/480/?image=399", 150, "Ferry - Hilll", "Voluptas ut atque modi tempora laboriosam repudiandae quisquam ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Andrew Padberg", "Modi vitae dolor. Qui eos atque quos recusandae omnis sunt harum. Et deserunt similique hic ut reiciendis ab. Dolor et inventore nemo et non corrupti. Pariatur dolorem quaerat expedita.", 5, "c2a5b8e9-9117-b06f-3ee3-72c00ea075de", "https://picsum.photos/640/480/?image=258", 461, "Welch, Miller and Schamberger", "Quos porro in rem ut dignissimos ratione nisi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Georgiana Auer", "Corrupti recusandae impedit laboriosam eos soluta et omnis consectetur distinctio. Suscipit accusamus eum rem fugiat qui eum recusandae sequi labore. Dolores ducimus voluptatibus ut odio accusamus neque modi. Temporibus ut saepe odit dolor. Aspernatur rerum et sunt alias soluta.", 5, "a56dd4c5-46ac-f952-c298-efb1776c1a99", "https://picsum.photos/640/480/?image=1060", 253, "Bayer, Daniel and Gulgowski", "Quasi et recusandae.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Scotty Toy", "Illum dicta suscipit. Sed labore tenetur ab. Cum sint impedit. Impedit qui iure eaque animi. Sit deserunt dolorum qui perspiciatis.", 2, "acf2d1c1-44d0-87c4-49ee-7408c87feec5", "https://picsum.photos/640/480/?image=893", 269, "Hackett - Baumbach", "Et omnis minima labore sit aliquam repellendus non.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Matilde Thiel", "Nobis dolorem voluptatem voluptas minus corrupti sunt totam. Et asperiores eligendi repellendus officiis eius quae. Sequi soluta deleniti rerum quo non nulla tempore. Eveniet eius enim fugiat aut nesciunt explicabo quo dolores ab. Atque hic quibusdam doloremque dolores ratione. Tempora dolorem quia eum quia perferendis voluptas explicabo sunt.", 1, "fc197208-2830-dae7-fe8a-1648bc657776", "https://picsum.photos/640/480/?image=871", 415, "Conn, McClure and Upton", "Vel culpa accusamus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jana Dickens", "Vel debitis alias incidunt sit omnis debitis voluptatem est explicabo. Sed eligendi dignissimos distinctio animi qui qui. Consequatur sed quisquam.", 4, "1c82d797-5ef6-3aa1-55b9-680e743e391e", "https://picsum.photos/640/480/?image=394", 180, "Schultz Group", "Rerum corrupti ipsam saepe doloribus alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Hal Toy", "Aut voluptate aut dolore eaque velit esse. Aliquid ut aut. Repellendus dolores placeat et repudiandae. Atque qui est eos laudantium fuga. Ad quia accusantium qui voluptatem omnis. Non nobis et id quae voluptate.", 5, "dfa8e374-5e7e-c721-a414-5e48e1ef87d9", "https://picsum.photos/640/480/?image=120", 424, "Huel, Botsford and Lockman", "Dicta iure omnis atque odit incidunt commodi inventore.", 2023 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Sheridan Langworth", "Consequuntur est rerum quis et ut vel odio. Saepe neque accusamus totam qui quia. Assumenda a voluptatum placeat labore non rerum voluptate. Magnam minima ut. Voluptates et corporis sed dignissimos nisi accusamus. Quas natus commodi et et placeat consectetur molestiae et suscipit.", 3, "b070807c-1297-3be2-a4e3-afd2baa05adf", "https://picsum.photos/640/480/?image=695", 211, "Homenick, Steuber and Konopelski", "Quis est vitae.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Garnet Green", "Aut sit laudantium aliquam dolores soluta nulla autem consequuntur. Magnam error labore quia molestias sed numquam ut. Itaque est eaque. Doloremque quia autem qui dolorem quos possimus consequuntur vel autem.", 5, "f687e2ed-c413-0a30-2408-8b14d06436fc", "https://picsum.photos/640/480/?image=124", 493, "Hansen and Sons", "Distinctio vel et facere sit corrupti et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Cole Schultz", "Recusandae doloremque libero omnis cumque qui dolorem et. Nam voluptates dolore dolores quasi quaerat necessitatibus. Aut distinctio beatae cum.", "4bbad231-44ed-f77e-da56-727e6d400ba1", "https://picsum.photos/640/480/?image=108", 146, "Grimes, Haag and Koelpin", "Rerum doloribus omnis a similique qui sit aspernatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Fern Treutel", "Vitae quia totam blanditiis ut consequatur quis voluptates dicta. Et unde dolorum vel ut perferendis eveniet quo. Omnis sed et officiis repudiandae. Ea omnis tenetur at id eum quas. Est vitae distinctio dignissimos distinctio numquam dolor impedit et.", 5, "34dadd6b-8576-d197-67dd-170c956f35b2", "https://picsum.photos/640/480/?image=838", 477, "Feest - Bosco", "Error voluptas non natus maxime autem eaque laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Samir Keebler", "Neque ut est. Ut vel exercitationem ratione exercitationem sunt soluta. Facilis occaecati odio velit aut eum reprehenderit aspernatur unde ea. Voluptatem quia qui. Neque quis sunt accusamus quo assumenda molestiae commodi sint voluptas.", 2, "e9bbd1f1-9645-6b63-2fcc-af92dde7677a", "https://picsum.photos/640/480/?image=412", 356, "Runte - DuBuque", "Corrupti temporibus rerum provident.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Talia Wuckert", "Enim voluptatem rerum rerum ipsum pariatur veritatis porro. Voluptatem maxime dolor aut ut nisi expedita in. Optio error est ipsum exercitationem et consequatur expedita. Soluta recusandae consequuntur rerum ut temporibus unde in magni magnam.", 1, "dd13a1fb-8089-8279-2891-d0607810bbbf", "https://picsum.photos/640/480/?image=328", 239, "Hamill - Buckridge", "Maiores animi et.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Eliza Price", "Harum explicabo deserunt ipsa. Quisquam ut voluptate non velit. Aut est aut nesciunt non quia. Libero quia qui quos vel. Excepturi voluptatem qui.", 5, "d89af12c-b6c9-7ce0-e8f7-27ef8aa37501", "https://picsum.photos/640/480/?image=275", 206, "Greenholt - Auer", "Voluptatem in quos enim voluptas vitae eum totam molestias.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Jonas Lind", "Doloremque et dicta atque ut possimus dolor. Officiis ut eum velit et nobis atque. Amet beatae rem quasi et sed. Voluptates nihil consequatur cum possimus. Eveniet et qui aut voluptas qui mollitia.", 4, "b7f8cb9a-b922-e61c-a96c-5ad3a08ae443", "https://picsum.photos/640/480/?image=1062", 334, "Funk - Mueller", "Quos consectetur quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Sandrine Abernathy", "Quia aliquam accusantium tempore corporis dolorum et est. Aut est nisi vel id voluptatem. Inventore ab eveniet ut.", 3, "acf6dff8-164a-f24c-33af-66ca66ba7b1b", "https://picsum.photos/640/480/?image=829", 222, "Pagac and Sons", "Dolores corporis numquam eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Lemuel Predovic", "Omnis est modi possimus reprehenderit eveniet. Soluta iusto accusantium. Animi explicabo ut impedit quibusdam commodi quibusdam fugiat ut quod. Deleniti et consectetur enim dolores magni ipsam ipsa quis. Esse quis numquam sit.", 3, "f91d043a-efce-a4f6-97e6-055082980536", "https://picsum.photos/640/480/?image=883", 276, "Borer - Kshlerin", "Dolore molestias id aut.", 2024 });
        }
    }
}
