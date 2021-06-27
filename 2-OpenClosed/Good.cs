namespace SolidPrinciples.OpenClosed.Good
{
    interface IInvoice
    {
        public string Create();
    }

    // (Good) Each class implement their own Create() method
    class ElectronicInvoice : IInvoice
    {
        public string Create() => "Electronic invoice created";
    }

    class PaperInvoice : IInvoice
    {
        public string Create() => "Paper invoice created";
    }

    class Order
    {
        private readonly IInvoice _invoice;

        public Order(IInvoice invoice)
        {
            _invoice = invoice;
        }

        // Low-level module just need to call Create() method
        public void CreateInvoice(string url)
        {
            _invoice.Create();
        }
    }
}