using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbu_Nicoleta_Lab9.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
