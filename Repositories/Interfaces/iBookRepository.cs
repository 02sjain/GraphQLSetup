using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLTypes;
using System.Linq;
namespace GraphQLDemoApplication.Repositories.Interfaces
{
    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();
        Book AddBook(BookInputType book);

        void DeleteBook(BookInputType book);
        void UpdateBook(BookInputType book);
    }
}
