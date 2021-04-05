using System.IO;

namespace Desing_Patterns_C_.SOLID.SRP
{
    public class Persistence 
    {
        public void SaveToFile(Journal journal, string fileName, bool overwitre = false)
        {
            if (overwitre || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}