using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLTypes;
using System.Linq;

namespace GraphQLDemoApplication.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        IQueryable<Author> GetAuthors();
        Author AddAuthor(AuthorInputType author);
        void DeleteAuthor(AuthorInputType author);
        void UpdateAuthor(AuthorInputType author);
    }
}
