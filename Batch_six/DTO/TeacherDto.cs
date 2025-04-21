namespace Batch_six.DTO
{
    public class TeacherDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required DateTime JoiningDate { get; set; }
        public required string Qualification { get; set; }
        public required int Experience { get; set; }
        public required string PhotoPath { get; set; }
        public required string Status { get; set; }
    }
}
