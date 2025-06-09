using libraryManagement;

public class LibraryItem
{
    public string title { get; set;}
    public string id { get; set;}

    public LibraryItem( string T, string I)
    {
        title = T;
        id = I;
    }

    public void showinfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"ID: {id}");
    }
}