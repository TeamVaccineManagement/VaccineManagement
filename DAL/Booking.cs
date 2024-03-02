using DAL;
using System;
using System.ComponentModel.DataAnnotations;

public class Booking
{
    public int BookingID { get; set; }

    [Required]
    public int UserID { get; set; }
    public User User { get; set; }

    [Required]
    public int VaccineID { get; set; }
    public Vaccine Vaccine { get; set; }

    [Required]
    public int LocationID { get; set; }
    public Location Location { get; set; }

    [Required]
    public DateTime SlotDateTime { get; set; }

    [Required]
    [StringLength(50)]
    public string Status { get; set; } // Consider using an enum for predefined status values
}
