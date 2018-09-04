using System;
using System.ComponentModel.DataAnnotations;

namespace ADOCRUDApplication.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        public int ProductPrice { get; set; }

        [Required(ErrorMessage = "Product Category is required")]
        public int ProductCategoryID { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
