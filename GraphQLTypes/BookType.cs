using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLServices;
using HotChocolate.Types;

namespace GraphQLDemoApplication.GraphQLTypes
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Name("Books");
            descriptor.Field(z => z.Id).Type<IdType>();
            descriptor.Field(z => z.AuthorId).Type<IntType>();
            descriptor.Field(z => z.Title).Type<StringType>();  
            descriptor.Field(z => z.Price).Type<DecimalType>();
            descriptor.Field<AuthorResolver>(x => x.GetAuthor(default, default));
        }
    }
}
