using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: EmployeeDetailsModel | properties for employee
    public class EmployeeDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Employee id is required")]
        public string EmpId {get; set;} = "";

        [Required(ErrorMessage = "")]
        public string EmpPassword {get; set;} = "";

        [Required(ErrorMessage = "")]
        public string EmpName {get; set;} = "";

        [Required(ErrorMessage = "")]
        public string EmpGender {get; set;} = "";

        [Required(ErrorMessage = "")]
        [DataType(DataType.PhoneNumber)]
        public string EmpPhone {get; set;} = "";

        [Required(ErrorMessage = "")]
        [DataType(DataType.EmailAddress)]
        public string EmpEmail {get; set;} = "";

        [Required(ErrorMessage = "")]
        [DataType(DataType.Date)]
        public DateTime EmpBirthDate {get; set;} = DateTime.MinValue;

        [Required(ErrorMessage = "")]
        [DataType(DataType.Date)]
        public DateTime EmpJoinDate {get; set;} = DateTime.MinValue;

    }

}

namespace xAPI.Dto
{
    public class EmployeeDetailsDto
    {
        public string EmpId {get; set;} = "";
        public string EmpName {get; set;} = "";
        public string EmpGender {get; set;} = "";
        public string EmpPhone {get; set;} = "";
        public string EmpEmail {get; set;} = "";
        public DateTime EmpBirthDate {get; set;} = DateTime.MinValue;
        public DateTime EmpJoinDate {get; set;} = DateTime.MinValue;
    }
}