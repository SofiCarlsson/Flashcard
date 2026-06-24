using System.ComponentModel.DataAnnotations;

namespace Flashcard.Models
{
    public class Word
    {
        public int WordId { get; set; }

        [MaxLength(50)]
        public required string Character { get; set; }

        [MaxLength(50)]
        public required string Pinyin { get; set; }

        [MaxLength(50)]
        public required string Meaning { get; set; }

        public int HskLevelId { get; set; }
        public HskLevel? HskLevel { get; set; }
    }
}
