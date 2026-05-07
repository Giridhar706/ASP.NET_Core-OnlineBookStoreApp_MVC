using System.ComponentModel.DataAnnotations;
using OnlineBookStoreApp.Validation;

namespace OnlineBookStoreApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [ISBNValidation]
        public string ISBN { get; set; }

        [PriceValidation]
        public decimal Price { get; set; }
    }
}