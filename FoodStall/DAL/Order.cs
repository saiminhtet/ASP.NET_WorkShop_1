using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodStall.DAL
{
    public class Order
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

    }
}