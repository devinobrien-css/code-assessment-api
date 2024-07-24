using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_assessment_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenreHotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Sheridan Langworth", "Consequuntur est rerum quis et ut vel odio. Saepe neque accusamus totam qui quia. Assumenda a voluptatum placeat labore non rerum voluptate. Magnam minima ut. Voluptates et corporis sed dignissimos nisi accusamus. Quas natus commodi et et placeat consectetur molestiae et suscipit.", 3, "b070807c-1297-3be2-a4e3-afd2baa05adf", "https://picsum.photos/640/480/?image=695", 211, "Homenick, Steuber and Konopelski", "Quis est vitae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Garnet Green", "Aut sit laudantium aliquam dolores soluta nulla autem consequuntur. Magnam error labore quia molestias sed numquam ut. Itaque est eaque. Doloremque quia autem qui dolorem quos possimus consequuntur vel autem.", "f687e2ed-c413-0a30-2408-8b14d06436fc", "https://picsum.photos/640/480/?image=124", 493, "Hansen and Sons", "Distinctio vel et facere sit corrupti et.", 2024 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Cole Schultz", "Recusandae doloremque libero omnis cumque qui dolorem et. Nam voluptates dolore dolores quasi quaerat necessitatibus. Aut distinctio beatae cum.", 4, "4bbad231-44ed-f77e-da56-727e6d400ba1", "https://picsum.photos/640/480/?image=108", 146, "Grimes, Haag and Koelpin", "Rerum doloribus omnis a similique qui sit aspernatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Fern Treutel", "Vitae quia totam blanditiis ut consequatur quis voluptates dicta. Et unde dolorum vel ut perferendis eveniet quo. Omnis sed et officiis repudiandae. Ea omnis tenetur at id eum quas. Est vitae distinctio dignissimos distinctio numquam dolor impedit et.", 5, "34dadd6b-8576-d197-67dd-170c956f35b2", 477, "Feest - Bosco", "Error voluptas non natus maxime autem eaque laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Samir Keebler", "Neque ut est. Ut vel exercitationem ratione exercitationem sunt soluta. Facilis occaecati odio velit aut eum reprehenderit aspernatur unde ea. Voluptatem quia qui. Neque quis sunt accusamus quo assumenda molestiae commodi sint voluptas.", 2, "e9bbd1f1-9645-6b63-2fcc-af92dde7677a", "https://picsum.photos/640/480/?image=412", 356, "Runte - DuBuque", "Corrupti temporibus rerum provident." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Talia Wuckert", "Enim voluptatem rerum rerum ipsum pariatur veritatis porro. Voluptatem maxime dolor aut ut nisi expedita in. Optio error est ipsum exercitationem et consequatur expedita. Soluta recusandae consequuntur rerum ut temporibus unde in magni magnam.", 1, "dd13a1fb-8089-8279-2891-d0607810bbbf", "https://picsum.photos/640/480/?image=328", 239, "Hamill - Buckridge", "Maiores animi et." });

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
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Lemuel Predovic", "Omnis est modi possimus reprehenderit eveniet. Soluta iusto accusantium. Animi explicabo ut impedit quibusdam commodi quibusdam fugiat ut quod. Deleniti et consectetur enim dolores magni ipsam ipsa quis. Esse quis numquam sit.", 3, "f91d043a-efce-a4f6-97e6-055082980536", "https://picsum.photos/640/480/?image=883", 276, "Borer - Kshlerin", "Dolore molestias id aut." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Granville Collins", "Molestias ea dolorem distinctio ut suscipit qui quaerat facere molestias. Voluptate velit tempore. Est ea quaerat dolor non repellat vitae aliquid at.", 2, "aeae159f-63ca-1b23-58a7-75002359f05d", "https://picsum.photos/640/480/?image=173", 456, "Bradtke - Borer", "Veritatis voluptatem culpa libero iste aperiam saepe." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Description", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Treva Crona", "Rerum soluta expedita quo omnis. Magnam quas officia quia. Ut quibusdam dolor dolore quas dignissimos amet quia. Quo sint alias accusantium laboriosam ea nisi magnam quos. Dignissimos sit ut facilis.", "97256a54-0523-0735-7bb1-b1093e630e4b", "https://picsum.photos/640/480/?image=625", 233, "Larson Inc", "Reprehenderit veritatis eveniet voluptatum asperiores.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Erwin Rodriguez", "Asperiores iste sapiente officiis consequatur provident animi veniam ab consequatur. Et voluptate quia consequatur. Eaque sint et fugiat quia.", 2, "90633bd5-9c2a-94fd-1078-babb6400e831", "https://picsum.photos/640/480/?image=144", 339, "Thompson - Ruecker", "Distinctio vel sit alias dolorum sed distinctio quibusdam doloribus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Pages", "Publisher", "Title" },
                values: new object[] { "Vesta Pollich", "Laudantium ea quod sit aspernatur quae inventore nostrum natus. Nostrum magni reprehenderit eos sed labore saepe delectus. Culpa est minus est temporibus.", 2, "c668c545-adc0-6e8c-42fe-d1567f4c2d87", 465, "Goodwin - Kemmer", "Asperiores at omnis molestiae dolor iure repellat in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Ludwig Abbott", "Quidem ea nemo fugit quasi qui. Sint iure veniam placeat. Consectetur et quo eligendi aperiam cupiditate tempora voluptatem necessitatibus. Consequatur laborum molestias deleniti. Deserunt est nobis qui. Possimus repellendus explicabo impedit ut sint ea.", 1, "dce7144e-486e-f459-92a7-a43a1be8bd40", "https://picsum.photos/640/480/?image=20", 415, "Emmerich - Daugherty", "Minus sapiente ad nihil sed harum aut ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Helga Okuneva", "Ea iste veritatis quod. Sit nobis quas maiores deserunt. Voluptas optio omnis optio eos possimus quisquam. Commodi nulla voluptate at illo quidem corporis suscipit beatae occaecati. Necessitatibus reprehenderit voluptas enim excepturi nam voluptas nulla sunt.", 4, "581b3f39-95e6-f3ac-5d85-dcc636798f13", "https://picsum.photos/640/480/?image=83", 282, "Spencer - Feil", "Repellat dolores dolorem rerum dolor ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title", "Year" },
                values: new object[] { "Kali Kovacek", "Dolores laborum impedit eos qui officiis. Aut esse voluptatum laudantium a rerum aliquid quia illum quis. Laboriosam aliquam dignissimos sunt sed ipsum.", 3, "654043ee-884d-9f9d-b92a-ac296ba3d959", "https://picsum.photos/640/480/?image=194", 191, "Cummerata - Quigley", "Amet ducimus omnis sequi.", 2023 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Autumn Aufderhar", "Necessitatibus facilis aut aut. Ut est facilis. Dolores voluptas et officiis accusantium dicta nobis voluptatum. Qui non voluptas. Ut voluptatum commodi illo autem. Est tempore ea officia vel veritatis voluptas debitis numquam.", 2, "5247a001-0535-658b-c9f8-be99129fad29", "https://picsum.photos/640/480/?image=837", 226, "McLaughlin - Mitchell", "Aliquam maxime et fugiat incidunt aut perspiciatis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Estevan Walker", "Et consectetur libero. Odit laudantium eligendi necessitatibus quaerat perferendis. Possimus distinctio sed soluta molestias odio. Est ut exercitationem a delectus rem similique voluptatum.", 4, "666a5d69-b126-85a6-00fc-4b42db8c3b95", "https://picsum.photos/640/480/?image=178", 420, "Zulauf - Nienow", "Maxime quod ut optio omnis ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "GenreId", "ISBN", "Image", "Pages", "Publisher", "Title" },
                values: new object[] { "Rylee Klocko", "Sed rerum eos nulla voluptas dolore distinctio. Aut excepturi sed modi autem iusto sint consequuntur dignissimos sed. Inventore beatae est accusamus consectetur et nihil quidem sunt. Iure voluptas consequatur aut et nesciunt dolores alias. Magni cum odit neque et. Vel deleniti quaerat nobis est sed perspiciatis ducimus.", 1, "ce2ed45c-4f81-cae7-0fc6-1b95fd0a7477", "https://picsum.photos/640/480/?image=897", 200, "Satterfield and Sons", "Occaecati animi dolor." });
        }
    }
}
