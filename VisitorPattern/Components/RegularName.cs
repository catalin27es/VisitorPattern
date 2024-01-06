using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    class RegularName : NameBase
    {
        public string FirstName { get; }
        public string LastName { get; }

        public RegularName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override T Accept<T>(INameVisitor<T> visitor) => visitor.Visit(this);
    }
}
