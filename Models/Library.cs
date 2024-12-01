using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexTask.Models
{
    public class Library
    {
        private List<Book> _books=new List<Book>();
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= _books.Count)
                {
                    Console.WriteLine("Index is invalid.");
                }
                    
                return _books[index];
            }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public List<Book> FindAllBooksByName(string value)
        {
            _books.FindAll(b => b.Name.ToLower().Contains(value.ToLower()));
            return _books;

        }
        public Book FindBookByCode(string code)
        {
            _books.FindAll(b => b.Name.ToLower().Contains(code.ToLower()));
            return null;
        }
        public void RemoveAllBooksByName(string value)
        {
            _books.RemoveAll(b => b.Name.ToLower().Contains(value.ToLower()));
        }
        public List<Book> SearchBooks(string value)
        {
        _books.FindAll(x => x.Name.ToLower().Contains(value.ToLower()) || 
        x.AuthorName.ToLower().Contains(value.ToLower()) || 
        x.PageCount.ToString().Contains(value));
            return _books;
        }
        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
        _books.FindAll(x => x.PageCount >= min && x.PageCount <= max);
            return _books;
        }
        public void RemoveBookByCode(string code)
        {
            var book = FindBookByCode(code);
            if (book != null)
            {
                Console.WriteLine("Book cannot be null");
            }
            else
            {
                _books.Remove(book);
            }
        }
    }
}
