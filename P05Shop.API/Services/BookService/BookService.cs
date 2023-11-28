using Bogus;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Services.BookService;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.ProductService
{
    public class BookService : IBookService
    {
        //private static List<Book> books = BookSeeder.GenerateBookData();
        private readonly DataContext _dataContext;

        public BookService(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<ServiceResponse<List<Book>>> GetBookAsync()
        {
            try
            {
                var response = new ServiceResponse<List<Book>>()
                {
                    Data = _dataContext.Books.ToList(),
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new ServiceResponse<List<Book>>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Book>> GetBookByIDAsync(int ID)
        {
            if (ID < 0)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "ID cannot be < 0",
                    Success = false
                };
            }

            try
            {
                var bookToGet = _dataContext.Books.FirstOrDefault(b => b.Id == ID);
                if (bookToGet == null)
                {
                    return new ServiceResponse<Book>()
                    {
                        Data = null,
                        Message = $"Couldn't find book with ID: {ID}",
                        Success = false
                    };
                }
                else
                {
                    return new ServiceResponse<Book>()
                    {
                        Data = bookToGet,
                        Message = "Ok",
                        Success = true
                    };
                }
            }
            catch (Exception)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Book>> AddBookAsync(Book book)
        {
            var res = new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "",
                    Success = false
                };

            var bookSameID = _dataContext.Books.FirstOrDefault(b => b.Id == book.Id);

            if (bookSameID != null)
                res.Message = "Found book with same ID, ID must be unique!";
            else if (book == null)
                res.Message = "Book couldn't be added - book is null";
            else if (book.Id < 0)
                res.Message = "Book couldn't be added - ID cannot be < 0";
            else if (book.Title == null || book.Title == "")
                res.Message = "Book couldn't be added - Title is empty";
            else if (book.Description == null || book.Description == "")
                res.Message = "Book couldn't be added - Description is empty";
            else if (book.Pages < 1)
                res.Message = "Book couldn't be added - Book has to have more than 0 pages";

            if (res.Message != "")
                return res;

            try
            {
                _dataContext.Books.Add(book);
                await _dataContext.SaveChangesAsync();

                res.Data = book;
                res.Success = true;
                res.Message = "Book added successfully";
            }
            catch (Exception ex)
            {
                res.Message = "Error while book adding: " + ex.Message;
                Console.WriteLine("EXCEPTION\n" + ex.InnerException);
            }

            return res;
        }

        public async Task<ServiceResponse<Book>> DeleteBookAsync(int ID)
        {
            var res = new ServiceResponse<Book>();
            try
            {
                if (ID < 0)
                {
                    res.Data = null;
                    res.Success = false;
                    res.Message = "Book couldn't be added - ID cannot be < 0";
                    return res;
                }

                var bookToRemove = _dataContext.Books.FirstOrDefault(b => b.Id == ID);
                if (bookToRemove != null)
                {
                    _dataContext.Books.Remove(bookToRemove);
                    await _dataContext.SaveChangesAsync();
                    res.Success = true;
                    res.Message = "Book deleted successfully";
                }
                else
                {
                    res.Success = false;
                    res.Message = "Cannot find book to delete";
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = "Error while deleting book: " + ex.Message;
            }
            return res;
        }

        public async Task<ServiceResponse<Book>> UpdateBookAsync(Book book)
        {
            var res = new ServiceResponse<Book>()
            {
                Data = null,
                Message = "",
                Success = false
            };
            
            if (book == null)
                res.Message = "Book couldn't be added - book is null";
            else if (book.Id < 0)
                res.Message = "Book couldn't be added - ID cannot be < 0";
            else if (book.Title == null || book.Title == "")
                res.Message = "Book couldn't be added - Title is empty";
            else if (book.Description == null || book.Description == "")
                res.Message = "Book couldn't be added - Description is empty";
            else if (book.Pages < 1)
                res.Message = "Book couldn't be added - Book has to have more than 0 pages";

            if (res.Message != "")
                return res;

            if (book.Id < 0)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "Book ID cannot be < 0!",
                    Success = false
                };
            }
            else if (book == null)
            {
                return new ServiceResponse<Book>()
                {
                    Data = null,
                    Message = "Book cannot be null!",
                    Success = false
                };
            }

            try
            {
                var bookToUpdate = _dataContext.Books.FirstOrDefault(b => b.Id == book.Id);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Title = book.Title;
                    bookToUpdate.Description = book.Description;
                    bookToUpdate.Pages = book.Pages;
                    bookToUpdate.ReleaseDate = book.ReleaseDate;
                    await _dataContext.SaveChangesAsync();

                    res.Success = true;
                    res.Message = "Book updated successfully";
                }
                else
                {
                    res.Success = false;
                    res.Message = "Book not found for updating";
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = "Error while updating book: " + ex.Message;
            }
            return res;
        }
    }
}
