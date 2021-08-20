using Microsoft.AspNetCore.Identity;
using MyApi.Models;

namespace MyApi.ModelsView
{
  public class RegisterResultViewModel
  {
    public IdentityResult Result { get; set; }

    public UserViewModel User { get; set; }

    public RegisterResultViewModel (IdentityResult result, ApplicationUser user) {
      Result = result;
      User = new UserViewModel(user);
    }
  }
}