using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Staples.Models
{
    public class SingleItemModel
    {
        [Key]
        public int id { get; set; }
        public string DateOfPurchase { get; set; }
        public string ExpirationDate { get; set; }
        public string TimeToPurchase { get; set; }
    }
}