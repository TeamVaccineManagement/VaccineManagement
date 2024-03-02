using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Vaccine
    {
        [Key]
        public int VaccineId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

    }
}
