namespace Batch_six.Domain
{
    
    public class Appointment: BaseModel
    {
        public required int AppointmentId { get; set; } //PK
        public required int PatientId { get; set; }//FK
        public required int DoctorId { get; set; }//FK
        public required DateTime AppointmentDate { get; set; }
        public required string Reason { get; set; }
        public required string Status { get; set; }

        public required Patient Patient { get; set; }
        public required Doctor Doctor { get; set; }
        public required Prescription Prescription { get; set; }
        public required Billing Billing { get; set; }
        

    }







}
