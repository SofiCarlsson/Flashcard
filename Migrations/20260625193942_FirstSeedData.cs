using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flashcard.Migrations
{
    /// <inheritdoc />
    public partial class FirstSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HskLevels",
                columns: new[] { "HskLevelId", "Name" },
                values: new object[,]
                {
                    { 1, "HSK 1" },
                    { 2, "HSK 2" },
                    { 3, "HSK 3" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "WordId", "Character", "HskLevelId", "Meaning", "Pinyin" },
                values: new object[,]
                {
                    { 1, "爱", 1, "to love", "ài" },
                    { 2, "八", 1, "eight", "bā" },
                    { 3, "爸爸", 1, "father", "bàba" },
                    { 4, "杯子", 1, "cup; glass; mug", "bēizi" },
                    { 5, "北京", 1, "Beijing", "běijīng" },
                    { 6, "本", 1, "measure word for books", "běn" },
                    { 7, "不客气", 1, "you're welcome", "búkèqi" },
                    { 8, "不", 1, "not; no", "bù" },
                    { 9, "菜", 1, "vegetable; dish", "cài" },
                    { 10, "茶", 1, "tea", "chá" },
                    { 11, "吧", 2, "[particle making suggestion, e.g. 'let’s…']", "ba" },
                    { 12, "白", 2, "white", "bái" },
                    { 13, "百", 2, "hundred", "bǎi" },
                    { 14, "帮助", 2, "to help", "bāngzhù" },
                    { 15, "报纸", 2, "newspaper", "bàozhǐ" },
                    { 16, "比", 2, "to compare", "bǐ" },
                    { 17, "别", 2, "don’t; other; separate", "bié" },
                    { 18, "宾馆", 2, "guesthouse; hotel", "bīnguǎn" },
                    { 19, "长", 2, "long", "cháng" },
                    { 20, "唱歌", 2, "to sing; singing", "chànggē" },
                    { 21, "阿姨", 3, "auntie [mother's younger sister]", "āyí" },
                    { 22, "啊", 3, "ah", "a" },
                    { 23, "矮", 3, "short (height)", "ǎi" },
                    { 24, "爱好", 3, "interests; hobbies", "àihào" },
                    { 25, "安静", 3, "to be quiet", "ānjìng" },
                    { 26, "把", 3, "grasp; measure word for knives", "bǎ" },
                    { 27, "搬", 3, "to move", "bān" },
                    { 28, "班", 3, "class", "bān" },
                    { 29, "半", 3, "half", "bàn" },
                    { 30, "办法", 3, "way; method; solution", "bànfǎ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "WordId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HskLevels",
                keyColumn: "HskLevelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HskLevels",
                keyColumn: "HskLevelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HskLevels",
                keyColumn: "HskLevelId",
                keyValue: 3);
        }
    }
}
