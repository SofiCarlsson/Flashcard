using System.ComponentModel.DataAnnotations;

namespace Flashcard.Models
{
    public class HskLevel
    {
        public int HskLevelId { get; set; }

        [MaxLength(50)]
        public required string Name { get; set; }

        public List<Word> Words { get; set; } = new List<Word>();

    }
}
