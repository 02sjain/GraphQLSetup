using GraphQLDemoApplication.Entities;
using GraphQLDemoApplication.GraphQLServices;
using HotChocolate.Types;

namespace GraphQLDemoApplication.GraphQLTypes 
{
    public class AuthorType :ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Name("Authors");
            descriptor.Field(z => z.Id).Type<IdType>();
            descriptor.Field(z => z.Name).Type<NameType>();
            descriptor.Field(z => z.Surname).Type<NameType>();
            descriptor.Field<BookResolver>(x => x.GetBooks(default, default));
        }
    }
}
