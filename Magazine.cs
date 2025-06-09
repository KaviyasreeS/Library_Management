namespace libraryManagement;
public class Magazine : LibraryItem
{
    public string Title { get; set; }
    public string Issue_no { get; set; }
    public string ID { get; set; }

    public Magazine ( string title , string issue_no, string id) : base(title, id)
    {
        Title = title;
        ID = id; 
        Issue_no = issue_no;
    }
    public void displayDetails()
    {
        Console.WriteLine($"Issue_no: {Issue_no}");
        Console.WriteLine("---------------------------------------------------------------");
    }
}