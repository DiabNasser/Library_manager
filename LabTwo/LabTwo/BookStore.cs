using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using LabTwo;

namespace LabTwo
{

    public class BookStore
    {
        public List<Book> books;
        public List<Item> items = new List<Item>();

       
        public BookStore()
        {
            books = new List<Book>();
        }

        public List<Book> Books
        {
            get { return this.books; }
        }

        public void AddNewBook()
        {
            Console.WriteLine("Enter book details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            int barcode = GetNewBarcode();
            Book book = new Book(title, barcode, author, isbn);
            books.Add(book);
            Item newItem = new Item(title, barcode);
            items.Add(newItem);
            Console.WriteLine("Book added successfully.");

        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter the ISBN of the book you want to remove:");
            string isbn = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ISBN == isbn)
                {
                    Books.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Book removed successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchBooksByAuthor(string author)
        {


            List<Book> matchedBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Author == author)
                {
                    matchedBooks.Add(book);
                }
            }

            if (matchedBooks.Count == 0)
            {
                Console.WriteLine("No books found with author '{0}'", author);
            }
            else
            {
                Console.WriteLine("Books found with author '{0}':", author);
                foreach (Book book in matchedBooks)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}, ISBN: {book.ISBN}");
                }
            }
        }

        public void SearchBookByISBN(string isbn)
        {


            List<Book> matchedBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.ISBN == isbn)
                {
                    matchedBooks.Add(book);
                }
            }

            if (matchedBooks.Count == 0)
            {
                Console.WriteLine("No books found with ISBN '{0}'", isbn);
            }
            else
            {
                Console.WriteLine("Books found with ISBN '{0}':", isbn);
                foreach (Book book in matchedBooks)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}, ISBN: {book.ISBN}");
                }
            }
        }


        public List<Book> ListBooks()
        {
            Console.WriteLine("List of stored Books:");
            return books;
        }
        private int GetNewBarcode()
        {
            // Code to generate new barcode goes here
            return 0;
        }
    }


}

