using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemoApplication.GraphQLTypes
{
    public class BookInputType
    {
        public int? Id { get; set; }
        public int? AuthorId { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }

    }
}
