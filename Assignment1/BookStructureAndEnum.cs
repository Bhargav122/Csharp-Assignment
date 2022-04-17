using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    struct Books
    {
        public enum bookType
        {
            Magazine, Novel, ReferenceBook, Miscellaneous
        }

        private string _Title;
        private int _price;
        private int _bookId;
        private bookType _bookType;

       
        public string Title{ get; set; }

        public int Price { get; set; }
        public int BookId { get; set; }
        public bookType BookType { get; set; }
        
    }
    class BookStructureAndEnum
    {
        public static void Main()
        {
            Books book = new Books();

            Console.Write("Enter Book Id :");
            book.BookId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title:");
            book.Title=(Console.ReadLine());

            Console.Write("Enter Book Price:");
            book.Price = Convert.ToInt32(Console.ReadLine());

            

            book.BookType =Books.bookType.Magazine;
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("The Book ID :"+book.BookId);
            Console.WriteLine("The Book Title:" + book.Title);
            Console.WriteLine("The Book Price:" + book.Price);
            Console.WriteLine("The Book BookType:" + book.BookType);
        }
    }
}