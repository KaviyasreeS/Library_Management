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