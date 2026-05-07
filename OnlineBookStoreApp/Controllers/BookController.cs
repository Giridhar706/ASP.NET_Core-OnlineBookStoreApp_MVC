using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreApp.Models;
using OnlineBookStoreApp.Repositories;
using OnlineBookStoreApp.Filters;

namespace OnlineBookStoreApp.Controllers
{
    [ServiceFilter(typeof(LoggingFilter))]
    public class BookController : Controller
    {
        private readonly IBookRepository _repository;

        public BookController(
            IBookRepository repository)
        {
            _repository = repository;
        }

        // LOGIN PAGE

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(
            string username,
            string role)
        {
            HttpContext.Session.SetString(
                "User",
                username);

            HttpContext.Session.SetString(
                "Role",
                role);

            return RedirectToAction("Dashboard");
        }

        // DASHBOARD

        public IActionResult Dashboard()
        {
            return View();
        }

        // BOOK LIST

        public IActionResult Index()
        {
            var books =
                _repository.GetBooks();

            return View(books);
        }

        // BOOK DETAILS

        [Route("Book/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            var book =
                _repository.GetBookById(id);

            return View(book);
        }

        // ADD TO CART

        public IActionResult AddToCart(int id)
        {
            var book =
                _repository.GetBookById(id);

            if (book != null)
            {
                _repository.AddToCart(book);
            }

            return RedirectToAction("Cart");
        }

        // CART PAGE

        public IActionResult Cart()
        {
            var cartBooks =
                _repository.GetCartBooks();

            return View(cartBooks);
        }

        // ADD BOOK

        [HttpGet]
        [ServiceFilter(typeof(AdminFilter))]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [ServiceFilter(typeof(AdminFilter))]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id =
                    new Random().Next(1, 1000);

                _repository.AddBook(book);

                return RedirectToAction("Index");
            }

            return View(book);
        }

        // ERROR TEST

        public IActionResult GenerateError()
        {
            int x = 0;
            int y = 10 / x;

            return View();
        }
    }
}