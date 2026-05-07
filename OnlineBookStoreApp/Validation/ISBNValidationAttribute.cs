using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApp.Validation
{
    public class ISBNValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isbn = value as string;

            return !string.IsNullOrEmpty(isbn)
                   && isbn.Length == 13;
        }
    }
}