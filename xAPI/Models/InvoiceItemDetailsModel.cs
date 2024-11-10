using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: InvoiceItemDetailsModel | properties for invoice items
    public class InvoiceItemDetailsModel
    {
        [Key]
        public int InvoiceItemId { get; set; }

        [Required(ErrorMessage = "Invoice number is required")]
        public string InvoiceNumber { get; set; } = "";

        [Required(ErrorMessage = "Item code is required")]
        public string ItemCode { get; set; } = "";

        [Required(ErrorMessage = "Item unit is required")]
        public int ItemUnit { get; set; } = 0;
    }

}