using System.ComponentModel.DataAnnotations;

namespace Batch_six.Domain
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public required string Title { get; set; }
        public required string Author { get; set; }
        public object Id { get; internal set; }
        // public bool IsAvailable { get; set; } = true;
    }


}














