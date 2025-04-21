using Batch_six.Domain;

namespace Batch_six.DTO
{
    public class AppointmentDto
    {
        public required DateTime AppointmentDate { get; set; }
        public required string Reason { get; set; }
        public required string Status { get; set; }

        public required Patient Patient { get; set; }
        public required Doctor Doctor { get; set; }
        public required Prescription Prescription { get; set; }
        public required Billing Billing { get; set; }
    }
}
