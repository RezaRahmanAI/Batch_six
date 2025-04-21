namespace Batch_six.DTO
{
    public class CreateStudentRequestDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required DateTime AdmissionDate { get; set; }
        public required string PhotoPath { get; set; }

        public required string RollNumber { get; set; }
        public required string Status { get; set; }
    }
}
