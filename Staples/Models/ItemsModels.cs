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
        public string TimeToPurchase { get; set; }
        public string Perishable { get; set; }
        public string NonPerishable { get; set; }
    }
}