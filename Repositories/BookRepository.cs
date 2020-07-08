using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLTypes;
using GraphQLDemoApplication.Repositories.Interfaces;
using System;
using System.Linq;

namespace GraphQLDemoApplication.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryGraphQLDemoContext _context;
        public BookRepository(LibraryGraphQLDemoContext context)
        {
            _context = context;
        }

        public Book AddBook(BookInputType book)
        {
            var bk = new Book
            {
                Title = book.Title,
                AuthorId = book.AuthorId,
                Price = book.Price
            };
            _context.Book.Add(bk);
            _context.SaveChanges();
            return bk;
        }

        public void DeleteBook(BookInputType book)
        {
            var bk = _context.Book.Where(z => z.Id == book.Id).FirstOrDefault();
            _context.Book.Remove(bk);
            _context.SaveChanges();
        }

        public IQueryable<Book> GetBooks() => _context.Book.AsQueryable();

        public void UpdateBook(BookInputType book)
        {
            var bk = _context.Book.Where(z => z.Id == book.Id).FirstOrDefault();
            bk.Price = book.Price;
            bk.Title = book.Title;
            bk.AuthorId = book.AuthorId;

            _context.Book.Add(bk);
            _context.SaveChanges();
        }
    }
}
