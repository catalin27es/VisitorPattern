using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    interface INameVisitor<T>
    {
        T Visit(RegularName name);
        T Visit(MononymName name);
        T Visit(CompoundName name);
    }
}
