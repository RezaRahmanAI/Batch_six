namespace Batch_six.DTO
{
    public class BookDto
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public object Id { get; internal set; }
    }
}
