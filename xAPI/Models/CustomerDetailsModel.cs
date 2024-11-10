using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: CustomerDetailsModel | properties for customer
    public class CustomerDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Username is required")]
        public string CustId {get; set;} = "";
        
        [Required(ErrorMessage = "Name is required")]
        public string CustName {get; set;} = "";
        
        [Required(ErrorMessage = "Gender is required")]
        public string CustGender {get; set;} = "";

        [Required(ErrorMessage = "Phone is required")]
        [DataType(DataType.PhoneNumber)]
        public string CustPhone {get; set;} = "";
        
    }

}