using System;

namespace Desing_Patterns_C_.SOLID.ISP
{
    public class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            // do print;
        }

        public void Scan(Document document)
        {
            // do scan;
        }
    }
}