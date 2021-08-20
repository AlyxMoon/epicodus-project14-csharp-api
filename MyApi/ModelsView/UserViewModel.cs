using MyApi.Models;

namespace MyApi.ModelsView 
{
  public class UserViewModel 
{
    public string Id { get; set; }
    public string UserName { get; set; }
 
    public UserViewModel () {}

    public UserViewModel (ApplicationUser user) 
    {
      Id = user.Id;
      UserName = user.UserName;
    }
  }
}
