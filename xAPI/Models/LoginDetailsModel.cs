using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: LoginDetailsModel | properties for login
    public class LoginDetailsModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserId {get; set;} = "";

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password {get; set;} = "";
    }
}

