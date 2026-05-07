using OnlineBookStoreApp.Models;

namespace OnlineBookStoreApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> books =
            new List<Book>();

        private static List<Book> cartBooks =
            new List<Book>();

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(
                x => x.Id == id);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetCartBooks()
        {
            return cartBooks;
        }

        public void AddToCart(Book book)
        {
            cartBooks.Add(book);
        }
    }
}