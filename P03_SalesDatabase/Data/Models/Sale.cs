using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Sales")]
    public class Sale
    {
        /// <summary>
        /// Id of sale
        /// </summary>
        [Key]
        public int SaleId { get; set; }

        /// <summary>
        /// Date of sale
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Id of product
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Id of buyer
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Id of store
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Product sold
        /// </summary>
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        /// <summary>
        /// Buyer
        /// </summary>
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        /// <summary>
        /// Store of deal
        /// </summary>
        [ForeignKey(nameof(StoreId))]
        public Store Store { get; set; }
    }
}
