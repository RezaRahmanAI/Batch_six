namespace Batch_six.DTO
{
    public class CreateClassRequestDto
    {
        public int Id { get; set; }
        public required string ClassName { get; set; }
        public required string? Section { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
