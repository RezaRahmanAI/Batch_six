using System.ComponentModel.DataAnnotations;

namespace Batch_six.Domain
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        public string FullName { get; set; }
    }

}










