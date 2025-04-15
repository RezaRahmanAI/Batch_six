namespace Batch_six.Domain
{
    public class Doctor : BaseModel
    {
        public required int DoctorId { get; set; }//PK
        public required string FullName { get; set; }
        public required string Specialty { get; set; }
        public required string ContactNumber { get; set; }
        public required string Email { get; set; }
        public required string Qualification { get; set; }
        public required int ExperienceYears { get; set; }
 
    }
}
