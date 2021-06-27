namespace SolidPrinciples.InterfaceSegregation.Bad
{
    public interface IPrinter
    {
        void Scan();
        void Print();
        void Fax();
        void PrintDuplex();
    }

    public class AdvancedPrinter: IPrinter
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
    
    public class BasicPrinter: IPrinter
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
            // ....(Bad) basic printer can't fax, but it must implement this method
        }

        public void PrintDuplex()
        {
            // ....(Bad) basic printer can't print duplex, but it must implement this method
        }
    }
}