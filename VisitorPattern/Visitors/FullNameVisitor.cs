using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    class FullNameVisitor : INameVisitor<string>
    {
        public string Visit(RegularName name) => $"{name.FirstName} {name.LastName}";

        public string Visit(MononymName name) => name.Name;

        public string Visit(CompoundName name) => $"{name.FirstName} {name.MiddleName} {name.LastName}";
    }
}
