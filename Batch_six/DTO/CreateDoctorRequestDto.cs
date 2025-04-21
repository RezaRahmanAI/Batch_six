namespace Batch_six.DTO
{
    public class CreateDoctorRequestDto
    {
        public required string FullName { get; set; }
        public required string Specialty { get; set; }
        public required string ContactNumber { get; set; }
        public required string Email { get; set; }
        public required string Qualification { get; set; }
        public required int ExperienceYears { get; set; }
    }
}
