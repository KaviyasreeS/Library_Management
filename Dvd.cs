namespace libraryManagement;
public class Dvd : LibraryItem
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string ID { get; set; }

    public Dvd ( string title , string isbn, string id) : base(title, id)
    {
        Title = title;
        ID = id; 
        ISBN = isbn;
    }
    public void displayDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine("---------------------------------------------------------------");
    }
}