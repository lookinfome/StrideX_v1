using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    public class InventoryDetailsModel
    {
        [Key]
        [Required(ErrorMessage = "Item code is required")]
        public string ItemCode { get; set; } = "";

        [Required(ErrorMessage = "Item name is required")]
        public string ItemName { get; set; } = "";

        [Required(ErrorMessage = "Item category is required")]
        public string ItemCategory { get; set; } = "";

        [Required(ErrorMessage = "Item gender is required")]
        public string ItemGender { get; set; } = "";
    }

}