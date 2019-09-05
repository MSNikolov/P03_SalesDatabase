using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            this.Sales = new HashSet<Sale>();
        }

        /// <summary>
        /// Id of product
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Product quantity
        /// </summary>
        public decimal Quantity { get; set; }


        /// <summary>
        /// Product price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Product sales
        /// </summary>
        public HashSet<Sale> Sales { get; set; }


        /// <summary>
        /// Description of the product
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
