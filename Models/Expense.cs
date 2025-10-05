using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{

//these classes/modells will be later stored in the database
    public class Expense
    {
        public int Id { get; set; }

        public decimal Value { get; set; }

        [Required]
        public string? Description { get; set; }
//? means we cannot have null values for this property
    }
}
