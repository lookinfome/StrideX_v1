using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    public class LoginDetailsModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username {get; set;} = "";

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password {get; set;} = "";
    }
}

