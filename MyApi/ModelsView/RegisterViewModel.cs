using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyApi.ModelsView
{
  public class RegisterViewModel
  {
    [Required]
    [DisplayName("Username")]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [DisplayName("Password")]
    public string Password { get; set; }
  }
}