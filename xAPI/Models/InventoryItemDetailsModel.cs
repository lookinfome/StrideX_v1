using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace xAPI.Models
{
    // class: InventoryItemDetailsModel | properties for inventory items 
    public class InventoryItemDetailsModel
    {
        [Key]
        public int InvntoryItemId { get; set; }

        [Required(ErrorMessage = "Item code is required")]
        public string ItemCode { get; set; } = "";

        [Required(ErrorMessage = "Item size is required")]
        public string ItemSize { get; set; } = "";

        [Required(ErrorMessage = "Item value is required")]
        public int ItemPrice { get; set; } = 0;

        [Required(ErrorMessage = "Item units available count is required")]
        public int ItemUnitsAvailable {get; set;}
    }

}