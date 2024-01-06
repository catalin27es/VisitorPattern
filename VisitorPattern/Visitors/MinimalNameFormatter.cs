using VisitorPattern.Components;

namespace VisitorPattern.Visitors
{
    class MinimalNameFormatter : INameVisitor<string>
    {
        public string Visit(RegularName name) => $"{name.FirstName} {name.LastName[0]}.";

        public string Visit(MononymName name) => name.Name;

        public string Visit(CompoundName name) => $"{name.FirstName} {name.MiddleName[0]}. {name.LastName[0]}.";
    }
}
