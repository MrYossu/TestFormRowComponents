using System.ComponentModel.DataAnnotations;

namespace TestFormRowComponents.Data {
  public class Customer {
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public Frequency Frequency { get; set; }
  }
}