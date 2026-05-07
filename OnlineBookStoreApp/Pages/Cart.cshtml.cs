using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineBookStoreApp.Pages
{
    public class CartModel : PageModel
    {
        [BindProperty]
        public string BookName { get; set; }

        public string CartMessage { get; set; }

        public void OnPost()
        {
            HttpContext.Session.SetString(
                "CartItem",
                BookName);

            CartMessage =
                $"{BookName} added to cart";
        }
    }
}