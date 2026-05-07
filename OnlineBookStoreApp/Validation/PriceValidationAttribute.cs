using System.ComponentModel.DataAnnotations;

namespace OnlineBookStoreApp.Validation
{
    public class PriceValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            decimal price = (decimal)value;

            return price > 0 && price <= 5000;
        }
    }
}