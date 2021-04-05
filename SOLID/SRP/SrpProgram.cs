using System.Diagnostics;
using static System.Console;

//Single Responsability Principle
namespace Desing_Patterns_C_.SOLID.SRP
{
    public class SprProgram
    {        
        public void SprMain()
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            WriteLine(journal);
            
            var persistence = new Persistence();
            var fileName = @"c:\temp\journal.txt";
            persistence.SaveToFile(journal, fileName, true);
            Process.Start(@"notepad.exe", fileName);

        }
    }
}