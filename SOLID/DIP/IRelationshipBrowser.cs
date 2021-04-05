using System.Collections.Generic;

namespace Desing_Patterns_C_.SOLID.DIP
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}