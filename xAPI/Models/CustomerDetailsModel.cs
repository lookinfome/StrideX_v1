using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{

    public class CustomerDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Username is required")]
        public string UserId {get; set;} = "";
        
        [Required(ErrorMessage = "Name is required")]
        public string Name {get; set;} = "";
        
        [Required(ErrorMessage = "Gender is required")]
        public string Gender {get; set;} = "";

        [Required(ErrorMessage = "Phone is required")]
        [DataType(DataType.PhoneNumber)]
        public string Phone {get; set;} = "";
        
    }

}