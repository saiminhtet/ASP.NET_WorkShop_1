using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodStall.DAL
{
    public class OrderDetail
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int OrderDetailID { get; set; }

        public int Size { get; set; }
        public bool Chilli { get; set; }
        public bool MoreSalt { get; set; }

        public bool Pepper { get; set; }
        public int Quantity { get; set; }

       
        public int FoodID { get; set; }
        public int OrderID { get; set; }

        public virtual Food Food { get; set; }
        public virtual Order Order { get; set; }

    }
}