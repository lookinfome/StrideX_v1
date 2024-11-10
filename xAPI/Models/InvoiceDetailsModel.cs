using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: InvoiceDetailsModel | properties for invoice
    public class InvoiceDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Invoice number is required")]
        public string InvoiceNumber { get; set; } = "";

        [Required(ErrorMessage = "User id is required")]
        public string UserId { get; set; } = "";

        [Required(ErrorMessage = "Invoice date is required")]
        [DataType(DataType.DateTime)]
        public DateTime InvoiceDate { get; set; } = DateTime.MinValue;

        [Required(ErrorMessage = "Total bill is required")]
        public float InvoiceAmount { get; set; } = 0;
    }

}