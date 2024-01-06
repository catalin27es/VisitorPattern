using VisitorPattern;
using VisitorPattern.Components;
using VisitorPattern.Visitors;

var books = new Book[]
{
    new("Learn C# in One Day"),
    new("Modern Cross-Platform Development Fundamentals", new MononymName("Harrison")),
    new("The C++ Programming Language", new RegularName(firstName: "Anne", lastName: "Ferrone")),
    new("Microservices Design Patterns", new CompoundName(firstName:"John", middleName: "Robert", lastName: "Buonanno")),
};

Print(books, new FullNameVisitor());
Print(books, new MinimalNameFormatter());

void Print(IEnumerable<Book> books, INameVisitor<string> formatter)
{
    foreach(var  book in books)
    {
        Console.WriteLine(book.ToString(formatter));
    }

    Console.WriteLine(new string('-', 80));
    Console.WriteLine();
}