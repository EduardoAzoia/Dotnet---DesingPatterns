using System;

namespace Desing_Patterns_C_.SOLID.ISP
{
    public class MultiFunctionMachine : IMultiFuctionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;
        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
            _printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
        }

        // Decorator pattern
        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}