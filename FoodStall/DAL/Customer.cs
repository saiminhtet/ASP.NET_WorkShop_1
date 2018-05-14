using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodStall.DAL
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UnitNumber { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Password { get; set; }
    }
}