using System.ComponentModel.DataAnnotations;

namespace KoreMVC.Models
{
    public class MembershipDetails
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime MembershipStartDate { get; set; }

    }
}
