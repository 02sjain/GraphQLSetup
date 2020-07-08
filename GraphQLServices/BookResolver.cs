using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.Repositories.Interfaces;
using HotChocolate.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoApplication.GraphQLServices
{
    public class BookResolver
    {
        private readonly IBookRepository _bookRepository;

        public BookResolver(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetBooks(Author author, IResolverContext ctx)
        {
            return _bookRepository.GetBooks().Where(z => z.AuthorId == author.Id).ToList();
        }
    }
}
