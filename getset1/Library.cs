using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getset1
{
    public class Library
    {
        public Book[] books = new Book [0];
        public void Addbook (Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;
        }

        public Book GetBookId (int id)
        {
            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            return null;
        }

        public Book GetBookByName(string name)
        {
            foreach (var book in books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }

            return null;
        }

        public Book[] GetBooksByName (string name)
        {
            Book[] wantedBooks = new Book[0];
            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref wantedBooks, wantedBooks.Length + 1);
                    wantedBooks[^1] = book;
                }
            }
            return wantedBooks;
        }

        // public Book[] GetFilteredBooks(string genre)
        // {
        //     Book[] filteredBooks = new Book[0];
        //     foreach (var book in books)
        //     {
                
        //     }
        // }

        public Book[] GetFilteredBooksByPrice(double minPrice, double maxPrice)
        {
            Book[] filteredBooksByPrice = new Book[0];
            foreach (var book in books)
            {
                if (book.Price > minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref filteredBooksByPrice, filteredBooksByPrice.Length + 1);
                    filteredBooksByPrice[^1] = book;
                }
            }
            return filteredBooksByPrice;
        }
    }

}