using P06Shop.Shared.Shop;

namespace P06Shop.Shared.Services.BookService
{
    public interface IBookService
    {
        Task<ServiceResponse<List<Book>>> GetBookAsync();
        Task<ServiceResponse<Book>> GetBookByIDAsync(int ID);
        Task<ServiceResponse<Book>> AddBookAsync(Book book);
        Task<ServiceResponse<Book>> DeleteBookAsync(int ID);
        Task<ServiceResponse<Book>> UpdateBookAsync(Book book);
    }
}
