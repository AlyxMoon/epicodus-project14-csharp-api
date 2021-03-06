using Microsoft.AspNetCore.Identity;
using MyApi.Models;

namespace MyApi.ModelsView
{
  public class LoginResultViewModel
  {
    public SignInResult Result { get; set; }

    public UserViewModel User { get; set; }

    public string Token { get; set; }

    public LoginResultViewModel (SignInResult result, ApplicationUser user, string token) 
    {
      Result = result;
      User = new UserViewModel(user);
      Token = token;
    }
  }
}