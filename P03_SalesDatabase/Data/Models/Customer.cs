using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }
        
        /// <summary>
        /// Id of customer
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// Name of customer
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Email of customer
        /// </summary>
        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Number of customer credit card
        /// </summary>
        [Required]
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Sales made to customer
        /// </summary>
        public HashSet<Sale> Sales { get; set; }
    }
}
