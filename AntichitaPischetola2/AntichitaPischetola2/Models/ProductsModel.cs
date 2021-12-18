using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntichitaPischetola2.Models
{
    public class ProductsModel
    {
        
        [DisplayName("Product ID")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Product Description")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Category ID")]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Product Year")]
        [DataType(DataType.Date)]
        public DateTime ModelYear { get; set; }
        [Required]
        [DisplayName("Product Height")]
        public decimal ProductHeight { get; set; }
        [Required]
        [DisplayName("Product width")]
        public decimal ProductWidth { get; set; }
        [Required]
        [DisplayName("Product Is Available")]
        public int IsAvailable { get; set; }
        [Required]
        [DisplayName("Product Added on")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        [Required]
        [DisplayName("Image 1")]
        [DataType(DataType.ImageUrl)]
        public string Url1 { get; set; }
        [DisplayName("Image 2")]
        [DataType(DataType.ImageUrl)]
        public string Url2 { get; set; }
        [DisplayName("Image 3")]
        [DataType(DataType.ImageUrl)]
        public string Url3 { get; set; }
        [DisplayName("Image 4")]
        [DataType(DataType.ImageUrl)]
        public string Url4 { get; set; }

    }
}
