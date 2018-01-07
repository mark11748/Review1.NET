using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review1NET.Models
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
        }
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public virtual ICollection<Ingredient> Ingredients { get; set; }
        
    }
}
