using getset1;



Book book1 = new Book(1, "Rich dad & Poor dad", 9.99, "Self improvment");
Book book2 = new Book(2, "1984", 45, "Sci-Fi");
Book book3 = new Book(3, "The Little Prince", 23.99, "Children's Literature");
Book book4 = new Book(4, "The Alchemist", 29.99, "Adventure");


Library library1 = new Library();
{
    library1.Addbook(book1);
    library1.Addbook(book2);
    library1.Addbook(book3);
    library1.Addbook(book4);

    // foreach (var item in library1.books)
    // {
    //     System.Console.WriteLine(item.Name);
    // }
    
    // Book wantedBook = library1.GetBookId(5);
    // {
    //     if (wantedBook != null)
    //     {
    //         System.Console.WriteLine(wantedBook.Name);
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Bele Id'li kitab yoxdur");
    //     }
    // }

    // Book findBookByName = library1.GetBookByName("1984");
    // {
    //     if (findBookByName != null)
    //     {
    //         System.Console.WriteLine(findBookByName.Name);
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Bele kitab yoxdur");
    //     }
    // }

    // Book[] wantedBooks = library1.GetBooksByName("the");
    // {
    //     foreach (var book in wantedBooks)
    //     {
    //         System.Console.WriteLine(book.Name);
    //     }
    // }

    Book[] filteredBooksByPrice = library1.GetFilteredBooksByPrice(40,45);
    {
        foreach (var book in filteredBooksByPrice)
        {
            System.Console.WriteLine(book.Name);
        }
    }

}