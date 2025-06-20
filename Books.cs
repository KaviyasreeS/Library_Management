﻿// See https://aka.ms/new-console-template for more information
namespace libraryManagement;

public class Book : LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string ID { get; set; }

    public Book ( string title , string author, string isbn, string id) : base(title, id)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        ID = id; 
    }
    public void displayDetails()
    {
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine("---------------------------------------------------------------");
    }

}