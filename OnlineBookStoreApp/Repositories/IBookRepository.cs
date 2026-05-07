using OnlineBookStoreApp.Models;

namespace OnlineBookStoreApp.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        List<Book> GetCartBooks();

        void AddToCart(Book book);
    }
}