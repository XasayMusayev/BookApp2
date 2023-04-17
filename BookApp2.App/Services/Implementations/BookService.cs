using BookApp2.App.Services.Interfaces;
using BookApp2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp2.App.Services.Implementations
{
    public class BookService : IBookService
    {
        private Book[] Books = { };
        public void Create()
        {
            Book book = new Book();
            Console.WriteLine("Write book name");
            book.Name = Console.ReadLine();
            Console.WriteLine("Write book price");
            book.Price = double.Parse(Console.ReadLine());
            
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
            
        }

        public void ShowAll()
        {
            if (Books.Length==0)
            {
                Console.WriteLine("There are no books");
                
            }
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Name+" "+book.Price+" "+book.CreatedDate);
                
            }
        }
    }
}
