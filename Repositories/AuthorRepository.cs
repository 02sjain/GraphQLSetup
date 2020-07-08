using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLTypes;
using GraphQLDemoApplication.Repositories.Interfaces;
using System;
using System.Linq;

namespace GraphQLDemoApplication.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryGraphQLDemoContext _context;
        public AuthorRepository(LibraryGraphQLDemoContext context)
        {
            _context = context;
        }

        public Author AddAuthor(AuthorInputType author)
        {
            var auth = new Author
            {
                Name = author.Name,
                Surname = author.Surname
            };
            _context.Author.Add(auth);
            _context.SaveChanges();
            return auth;
        }

        public void DeleteAuthor(AuthorInputType author)
        {
            var auth = _context.Author.Where(z => z.Id == author.Id).FirstOrDefault();
            _context.Author.Remove(auth);
            _context.SaveChanges();
        }

        public IQueryable<Author> GetAuthors() => _context.Author.AsQueryable();

        public void UpdateAuthor(AuthorInputType author)
        {
            var auth = _context.Author.Where(z => z.Id == author.Id).FirstOrDefault();
            auth.Name = author.Name;
            auth.Surname = author.Surname;

            _context.Author.Update(auth);
            _context.SaveChanges();
        }
    }
}
