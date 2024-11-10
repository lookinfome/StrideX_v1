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
        public string EmpPassword {get; set;} = "";
        public string EmpName {get; set;} = "";
        public string EmpGender {get; set;} = "";

        [DataType(DataType.PhoneNumber)]
        public string EmpPhone {get; set;} = "";

        [DataType(DataType.EmailAddress)]
        public string EmpEmail {get; set;} = "";

        [DataType(DataType.Date)]
        public DateTime EmpBirthDate {get; set;} = DateTime.MinValue;

        [DataType(DataType.Date)]
        public DateTime EmpJoinDate {get; set;} = DateTime.MinValue;

    }
}