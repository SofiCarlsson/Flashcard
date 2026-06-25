using Flashcard.Models;
using Microsoft.EntityFrameworkCore;

namespace Flashcard.Data
{
    public class FlashcardDbContext : DbContext
    {
        public DbSet<HskLevel> HskLevels { get; set; }
        public DbSet<Word> Words { get; set; }

        public FlashcardDbContext(DbContextOptions<FlashcardDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            // Lägg till Seeddata i tabellerna
            SeedDataHskLevels(modelbuilder);
            SeedDataWords(modelbuilder);
        }

        private static void SeedDataHskLevels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HskLevel>().HasData(
                new HskLevel { HskLevelId = 1, Name = "HSK 1" },
                new HskLevel { HskLevelId = 2, Name = "HSK 2" },
                new HskLevel { HskLevelId = 3, Name = "HSK 3" });
        }

        private static void SeedDataWords(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>().HasData(
                new Word { WordId = 1, Character = "爱", Pinyin = "ài", Meaning = "to love", HskLevelId = 1 },
                new Word { WordId = 2, Character = "八", Pinyin = "bā", Meaning = "eight", HskLevelId = 1 },
                new Word { WordId = 3, Character = "爸爸", Pinyin = "bàba", Meaning = "father", HskLevelId = 1 },
                new Word { WordId = 4, Character = "杯子", Pinyin = "bēizi", Meaning = "cup; glass; mug", HskLevelId = 1 },
                new Word { WordId = 5, Character = "北京", Pinyin = "běijīng", Meaning = "Beijing", HskLevelId = 1 },
                new Word { WordId = 6, Character = "本", Pinyin = "běn", Meaning = "measure word for books", HskLevelId = 1 },
                new Word { WordId = 7, Character = "不客气", Pinyin = "búkèqi", Meaning = "you're welcome", HskLevelId = 1 },
                new Word { WordId = 8, Character = "不", Pinyin = "bù", Meaning = "not; no", HskLevelId = 1 },
                new Word { WordId = 9, Character = "菜", Pinyin = "cài", Meaning = "vegetable; dish", HskLevelId = 1 },
                new Word { WordId = 10, Character = "茶", Pinyin = "chá", Meaning = "tea", HskLevelId = 1 },
                new Word { WordId = 11, Character = "吧", Pinyin = "ba", Meaning = "[particle making suggestion, e.g. 'let’s…']", HskLevelId = 2 },
                new Word { WordId = 12, Character = "白", Pinyin = "bái", Meaning = "white", HskLevelId = 2 },
                new Word { WordId = 13, Character = "百", Pinyin = "bǎi", Meaning = "hundred", HskLevelId = 2 },
                new Word { WordId = 14, Character = "帮助", Pinyin = "bāngzhù", Meaning = "to help", HskLevelId = 2 },
                new Word { WordId = 15, Character = "报纸", Pinyin = "bàozhǐ", Meaning = "newspaper", HskLevelId = 2 },
                new Word { WordId = 16, Character = "比", Pinyin = "bǐ", Meaning = "to compare", HskLevelId = 2 },
                new Word { WordId = 17, Character = "别", Pinyin = "bié", Meaning = "don’t; other; separate", HskLevelId = 2 },
                new Word { WordId = 18, Character = "宾馆", Pinyin = "bīnguǎn", Meaning = "guesthouse; hotel", HskLevelId = 2 },
                new Word { WordId = 19, Character = "长", Pinyin = "cháng", Meaning = "long", HskLevelId = 2 },
                new Word { WordId = 20, Character = "唱歌", Pinyin = "chànggē", Meaning = "to sing; singing", HskLevelId = 2 },
                new Word { WordId = 21, Character = "阿姨", Pinyin = "āyí", Meaning = "auntie [mother's younger sister]", HskLevelId = 3 },
                new Word { WordId = 22, Character = "啊", Pinyin = "a", Meaning = "ah", HskLevelId = 3 },
                new Word { WordId = 23, Character = "矮", Pinyin = "ǎi", Meaning = "short (height)", HskLevelId = 3 },
                new Word { WordId = 24, Character = "爱好", Pinyin = "àihào", Meaning = "interests; hobbies", HskLevelId = 3 },
                new Word { WordId = 25, Character = "安静", Pinyin = "ānjìng", Meaning = "to be quiet", HskLevelId = 3 },
                new Word { WordId = 26, Character = "把", Pinyin = "bǎ", Meaning = "grasp; measure word for knives", HskLevelId = 3 },
                new Word { WordId = 27, Character = "搬", Pinyin = "bān", Meaning = "to move", HskLevelId = 3 },
                new Word { WordId = 28, Character = "班", Pinyin = "bān", Meaning = "class", HskLevelId = 3 },
                new Word { WordId = 29, Character = "半", Pinyin = "bàn", Meaning = "half", HskLevelId = 3 },
                new Word { WordId = 30, Character = "办法", Pinyin = "bànfǎ", Meaning = "way; method; solution", HskLevelId = 3 });
        }
    }
}
