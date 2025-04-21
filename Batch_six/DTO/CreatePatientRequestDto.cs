namespace Batch_six.DTO
{
    public class CreatePatientRequestDto
    {
        public required string FullName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required string ContactNumber { get; set; }
        public required string Address { get; set; }
        public required string BloodGroup { get; set; }
        public required string MedicalHistory { get; set; }

    }
}
