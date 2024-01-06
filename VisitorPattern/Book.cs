using VisitorPattern.Components;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    class Book
    {
        public string Title { get; private init; }
        public IEnumerable<NameBase> Authors => AuthorsList;
        private List<NameBase> AuthorsList { get; }

        public Book(string title, params NameBase[] authors)
        {
            Title = title;
            AuthorsList = authors.ToList();
        }

        public string ToString(INameVisitor<string> formatter)
        {
            return AuthorsList.Any() ?
                $"{Title}, {string.Join(", ", Authors.Select(a => a.Accept(formatter)))}"
                : Title;
        }
    }
}
