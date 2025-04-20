namespace Batch_six.DTO
{
    public class CreateAdminRequestDTO
    {
        public required int Id { get; set; }

        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
