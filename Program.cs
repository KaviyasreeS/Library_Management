// See https://aka.ms/new-console-template for more information
using libraryManagement;
// Book b1 = new Book { Title = "Pride and prejustice", Author = "Jane Ausren", ISBN = "71762104024" };
Book b1 = new Book ("Pride and prejustice", "Jane Ausren", "71762104024", "123");
Book b2 = new Book ("Life of Pi", "Kaviyasree", "71762104043", "234" );
b1.showinfo();
b1.displayDetails();
b2.showinfo();
b2.displayDetails();
Magazine m1 = new Magazine ("The Great book", "10000", "456");
m1.showinfo();
m1.displayDetails();
Dvd d1 = new Dvd ("Sharmie Life Story","99999","789");
d1.showinfo();
d1.displayDetails();

Console.WriteLine("enter the due days:");
int due_days = Convert.ToInt32(Console.ReadLine());
int a = 1;
double fine = 0;
// if( due_days > 5 )
// {
//     due_days = due_days - 5;
//     while(due_days >= 1)
//     {
//         fine = fine+a;
//         --due_days;
//     }
//     Console.WriteLine($"Fine: {fine}");
// }
// else
// {
//     Console.WriteLine("NO FINE");
// }

if( due_days > 5 )
{
    due_days = due_days - 5;
    while(due_days >= 1)
    {
        fine = fine+a;
        --due_days;
        ++a;
    }
    Console.WriteLine($"Fine: {fine}");
}
else
{
    Console.WriteLine("NO FINE");
}

Console.WriteLine("Enter memebership or not ?");
string Con = (Console.ReadLine());
if (Con == "yes")
{
    fine = fine  -  0.2*fine;
    Console.WriteLine($"fine:{fine}");
}