using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.Repositories.Interfaces;
using HotChocolate.Resolvers;
using System.Linq;

namespace GraphQLDemoApplication.GraphQLServices
{
    public class AuthorResolver
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorResolver(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Author GetAuthor(Book book, IResolverContext ctx)
        {
            return _authorRepository.GetAuthors().Where(z => z.Id == book.AuthorId).FirstOrDefault();
        }
    }
}
