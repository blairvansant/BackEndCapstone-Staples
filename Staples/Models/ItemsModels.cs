using System.ComponentModel.DataAnnotations;

namespace Staples.Models
{
    public class ItemsModels
    {
        [Key]
        public int Id { get; set; }
        public string NameOfItem { get; set; }
        public string DateOfPurchase { get; set; }
        public string ExpirationDate { get; set; }
       
        public virtual ApplicationUser User { get; set; }          
    }
}