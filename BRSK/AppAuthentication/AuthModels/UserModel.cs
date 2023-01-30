using System.ComponentModel.DataAnnotations;

namespace BRSK.AppAuthentication.AuthModels
{
    public class UserModel
    {
      
            [Required]
            public string UserName { get; set; }

            [Required]
            public string Password { get; set; }
        
    }
}
