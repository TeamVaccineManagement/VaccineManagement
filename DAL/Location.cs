using System.ComponentModel.DataAnnotations;

public class Location
{
    public int LocationID { get; set; }

    [Required]
    [StringLength(100)]
    public string City { get; set; }

    [Required]
    [StringLength(100)]
    public string State { get; set; }

    [Required]
    [StringLength(100)]
    public string Country { get; set; }
}
