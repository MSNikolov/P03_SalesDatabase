using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    [Table("Stores")]
    public class Store
    {
        public Store()
        {
            this.Sales = new HashSet<Sale>();
        }
        
        /// <summary>
        /// Id of store
        /// </summary>
        [Key]
        public int StoreId { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// Sales made in store
        /// </summary>
        public HashSet<Sale> Sales { get; set; }
    }
}
