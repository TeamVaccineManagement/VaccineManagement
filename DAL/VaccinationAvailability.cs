using DAL;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Availability
{
    [Key]
    public int AvailabilityID { get; set; }

    [Required]
    public int LocationID { get; set; }
    public Location Location { get; set; }

    [Required]
    public int VaccineID { get; set; }
    public Vaccine Vaccine { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Available slots must be at least 1.")]
    public int AvailableSlots { get; set; }

    [Required]
    [Column(TypeName = "date")]
    public DateTime Date { get; set; }
}
