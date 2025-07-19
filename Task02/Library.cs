using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task02
{
    internal class Library
    {
        private readonly List<Book> books = [];
        private readonly List<Book> Borrowing = [];

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        private void BorrowBook(string title)
        {
            Console.WriteLine("Congratulations, Now you have this book");
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    Borrowing.Add(books[i]);
                    books.Remove(books[i]);
                    break;
                }
            }
        }
        public void SearchBook(string title)
        {
            bool foundIt = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    foundIt = true;
                    Console.WriteLine("This book is available 👌 Do you want to Borrow it: \"yes\" or \"no\": ");
                    string iWantToBorrow = Console.ReadLine()!.ToLower();
                    if (iWantToBorrow == "yes")
                    {
                        BorrowBook(title);
                        break;
                    }
                    else
                        Console.WriteLine("Okay Thank you to use our Library 🙏");
                }
            }
            if (!foundIt)
                Console.WriteLine("Sory this book is not in the library");
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < Borrowing.Count; i++)
            {
                if (Borrowing[i].Title == title)
                {
                    Borrowing.Remove(books[i]);
                    books.Add(books[i]);
                    Console.WriteLine("Thank You for using our books!!!");
                    break;
                }
            }
        }
    }
}