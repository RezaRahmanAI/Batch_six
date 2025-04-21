namespace Batch_six.DTO
{
    public class CreateSubjectRequestDto
    {
        public required int Id { get; set; }
        public required string SubjectName { get; set; }
        public required string SubjectCode { get; set; }
    }
}
