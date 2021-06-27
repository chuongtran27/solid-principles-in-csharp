namespace SolidPrinciples.InterfaceSegregation.Good
{
    public interface IPrinter
    {
        void Scan();
        void Print();
    }

    public interface IFax
    {
        void Fax();
    }

    public interface IPrintDuplex
    {
        void PrintDuplex();
    }

    public class AdvancedPrinter : IPrinter, IFax, IPrintDuplex
    {
        public void Scan()
        {
            // ....scan
        }

        public void Print()
        {
            // ....print
        }

        public void Fax()
        {
            // ....fax
        }

        public void PrintDuplex()
        {
            // ....print duplex
        }
    }

    // (Good) Separate interface help low-level modules only implement interfaces that they need
    public class BasicPrinter : IPrinter
    {
        public void Scan()
        {
            // ....scan
        }

        public void Print()
        {
            // ....print
        }
    }
}