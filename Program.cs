using IndexTask.Models;

namespace IndexTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Library library = new Library();

          library.AddBook(new Book("Programming","Sabit Jafarov",300,1));
          library.AddBook(new Book("Economics","William Abc",500,2));
          library.AddBook(new Book("Web","John Doe",700,3));

            var booksbyname = library.FindAllBooksByName("Web");
                 
            booksbyname.ForEach(b => Console.WriteLine(b.Name));

           
            var bookByCode = library.FindBookByCode("PR1");
            Console.WriteLine($"Book with code 'PR1': {bookByCode.Name}");

            
            library.RemoveBookByCode("PR1");
            Console.WriteLine("Book with code 'PR1' removed.");

            
            var searchResults = library.SearchBooks("John");
            Console.WriteLine("Books matching 'John':");
            searchResults.ForEach(b => Console.WriteLine(b.Name));

            
            var booksInRange = library.FindAllBooksByPageCountRange(200, 500);
            Console.WriteLine("Books with page count between 200 and 500:");
            booksInRange.ForEach(b => Console.WriteLine(b.Name));
        }
    }
}
