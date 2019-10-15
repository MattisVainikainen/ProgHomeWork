using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bibliotek
{
    public class Books
    {
        private string bookName;
        private int shelfNumber;

        public Books(string _bookName, int _shelfNumber)
        {
            BookName = _bookName;
            ShelfNumber = _shelfNumber;

        }

        public Books()
        {

        }

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
            }
        }

        public int ShelfNumber
        {
            get { return shelfNumber; }
            set
            {
                shelfNumber = value;
            }
        }

        
        
        public static void RunCheckBooks()
        {
            Dictionary<string,int> CheckBooks = new Dictionary<string, int>();
            CheckBooks.Add("Book of Life", 24);
            CheckBooks.Add("Tree of Horror", 56);
            CheckBooks.Add("Simplify", 12);

            foreach (var books in CheckBooks)
            {
                Console.WriteLine();
                Console.WriteLine($"Book: {books}");
            }
            Console.WriteLine("Press enter to go back to menu...");
            Console.ReadLine();
            
        }
    }
}
