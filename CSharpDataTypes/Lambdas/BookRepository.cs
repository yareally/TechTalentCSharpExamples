using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDataTypes.Lambdas
{
    class BookRepository
    {
        public List<Book> Books {
            get {
                return new List<Book>
                {
                    new Book() { Title ="bk 1", Price = 5},
                    new Book() { Title = "bk 2", Price = 6 },
                    new Book() { Title = "bk 3", Price = 17 }
                };
            }
        }
    }
}
