using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    public class EmployeeSalesPerformanceDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Sales Id is required")]
        public string SalesId {get; set;} = "";
        public string EmpId {get; set;} = "";
        public string SalesCount {get; set;} = "";
    }

}