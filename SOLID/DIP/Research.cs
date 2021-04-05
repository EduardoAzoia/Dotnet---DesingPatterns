using static System.Console;

namespace Desing_Patterns_C_.SOLID.DIP
{
    public class Research
    {
        public Research()
        {
            
        }
        public Research(IRelationshipBrowser browser, Person person)
        {
            var children = browser.FindAllChildrenOf(person.Name);

            foreach (var child in children)
            {
                WriteLine($"{person.Name} has a child called {child.Name}");
            }
        }

        public void DipMain()
        {
            var parent = new Person {Name = "John"};
            var olderChild = new Person {Name = "Chris"};
            var youngerChild = new Person {Name = "Mary"};

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, olderChild);
            relationships.AddParentAndChild(parent, youngerChild);

            new Research(relationships, parent);
        }
    }
}