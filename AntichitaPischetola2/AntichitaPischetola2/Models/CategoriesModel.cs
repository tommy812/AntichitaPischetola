using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntichitaPischetola2.Models
{
    public class CategoriesModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category")]
        public string CategoryName { get; set; }
    }
}
