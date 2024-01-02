using System.ComponentModel.DataAnnotations;

namespace Project_CRUD.Models
{
  public class Car
  {
    public Guid Id { get; set; }
    public string Brand { get; set; }

    public string Model { get; set; }

    [Range(1900, 2100, ErrorMessage = "Please enter a valid year between 1900 and 2100.")]
    public int ManufactureDate { get; set; }
  }
}
