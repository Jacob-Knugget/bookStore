using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book FirstBook = new book();
            FirstBook.SetId(1);
            FirstBook.SetTitle("Demons In Farceat");
            FirstBook.SetAuthor("John L. Crascow");

            book SecondBook = new book();
            Console.Write("Please enter the book's ID: ");
            SecondBook.SetId(int.Parse(Console.ReadLine()));
            Console.Write("Please enter the book's title: ");
            SecondBook.SetTitle(Console.ReadLine());
            Console.Write("Please enter the book's author: ");
            SecondBook.SetAuthor(Console.ReadLine());

            book ThirdBook = new book(3, "Resistance In Skarmaka", "John L. Crascow");

            Console.Write("Please enter the book's ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.Write("Please enter the book's title: ");
            string tempTitle = Console.ReadLine();
            Console.Write("Please enter the book's author: ");
            string tempAuthor = Console.ReadLine();
            book FourthBook = new book(tempID, tempTitle, tempAuthor);

            Console.WriteLine("Here are the books listed: ");
            displayBooks(FirstBook);
            displayBooks(SecondBook);
            displayBooks(ThirdBook);
            displayBooks(FourthBook);
        }

        static void displayBooks(book number) {
            Console.WriteLine($"Book ID: {number.GetId()}");
            Console.WriteLine($"Book Title: {number.GetTitle()}");
            Console.WriteLine($"Book Author: {number.GetAuthor()}");
        }
    }
}

class book
{
    private int _Id;
    private string _Title;
    private string _Author;

    public book()
    {
        _Id = 0;
        _Title = "";
        _Author = "";
    }

    public book(int i, string title, string author)
    {
        _Id = i;
        _Title = title;
        _Author = author;
    }

    public int GetId()
    {
        return _Id;
    }
    public string GetTitle()
    {
        return _Title;
    }
    
    public string GetAuthor()
    {
        return _Author;
    }

    public void SetId(int identification)
    {
        _Id = identification;
    }

    public void SetTitle(string Title)
    {
        _Title = Title;
    }

    public void SetAuthor(string Author)
    {
        _Author = Author;
    }
}