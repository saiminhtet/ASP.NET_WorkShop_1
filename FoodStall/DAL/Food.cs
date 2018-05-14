using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodStall.DAL
{
    public class Food
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int FoodID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public byte[] Food_Photo { get; set; }
    }
}