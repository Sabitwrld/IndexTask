using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexTask.Models
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; }

        public Book(string name,string authorName,int pageCount,int number)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = MyLibraryHelper.Helper.CreateBookCode(name,number);
        }
    }
     
}
