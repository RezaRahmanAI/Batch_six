namespace Batch_six.Domain
{
    public class Prescription: BaseModel
        
    {
        public required int PrescriptionId { get; set; }//PK
        public required int PatientId { get; set; }//FK
        public required int DoctorId { get; set; }//FK
        public required int? AppointmentId { get; set; }//FK
        public required DateTime Date { get; set; }
        public required string Diagnosis { get; set; }
        public required string Medications { get; set; }

        public required Patient Patient { get; set; }
        public required Doctor Doctor { get; set; }
        public required Appointment Appointment { get; set; }
    }

}

