using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    class MononymName : NameBase
    {
        public string Name { get; }

        public MononymName(string name)
        {
            Name = name;
        }

        public override T Accept<T>(INameVisitor<T> visitor) => visitor.Visit(this);
    }
}
