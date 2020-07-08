using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLTypes;
using GraphQLDemoApplication.Repositories.Interfaces;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Linq;

namespace GraphQLDemoApplication.GraphQLServices
{
    public class LibraryQuery
    {
        [UsePaging(SchemaType =typeof(BookType))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> Books([Service] IBookRepository bookRepository) => bookRepository.GetBooks();

        [UsePaging(SchemaType = typeof(AuthorType))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Author> Authors([Service] IAuthorRepository authorRepository) => authorRepository.GetAuthors();


    }
}
