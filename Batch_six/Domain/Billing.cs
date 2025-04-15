namespace Batch_six.Domain
{
    public class Billing: BaseModel
    {
        public  required int BillId { get; set; }//PK
        public required int PatientId { get; set; }
        public required int? AppointmentId { get; set; }
        public required DateTime BillingDate { get; set; }
        public required decimal ConsultationFee { get; set; }

        public required Patient Patient { get; set; }
        public required Appointment Appointment { get; set; }
    }
}
