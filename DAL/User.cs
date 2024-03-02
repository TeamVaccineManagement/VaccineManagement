using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Not a valid email id")]
        public string EmailId { get; set; }

       // [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$")] // Matches 10 digit phone number
        public string Mobile { get; set; }


    }
}
