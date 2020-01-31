using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public DateTime CreateDate { get; set; }

        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

        //public Product()
        //{
        //    Category = new Category();
        //}
    }
}
