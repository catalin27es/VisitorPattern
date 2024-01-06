using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    class CompoundName : NameBase
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public CompoundName(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public override T Accept<T>(INameVisitor<T> visitor) => visitor.Visit(this);
    }
}
