using VisitorPattern.Visitors;

namespace VisitorPattern.Components
{
    abstract class NameBase
    {
        public abstract T Accept<T>(INameVisitor<T> visitor);
    }
}
