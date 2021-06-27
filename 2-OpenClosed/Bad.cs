namespace SolidPrinciples.OpenClosed.Bad
{
    enum InvoiceType
    {
        ElectronicInvoice,
        PaperInvoice
    }
    
    abstract class InvoiceBase
    {
        protected InvoiceType Type;

        public InvoiceType GetType()
        {
            return Type;
        }
    }

    class ElectronicInvoice : InvoiceBase
    {
        public ElectronicInvoice()
        {
            Type = InvoiceType.ElectronicInvoice;
        }
    }

    class PaperInvoice : InvoiceBase
    {
        public PaperInvoice()
        {
            Type = InvoiceType.PaperInvoice;
        }
    }

    class Order
    {
        private readonly InvoiceBase _invoice;

        public Order(InvoiceBase invoice)
        {
            _invoice = invoice;
        }

        // (Bad) Modify existing code to implement create invoice methods for each invoice type.
        public string Fetch(string url)
        {
            var invoiceType = _invoice.GetType();
            switch (invoiceType)
            {
                case InvoiceType.ElectronicInvoice:
                    return CreateElectronicInvoice();
                case InvoiceType.PaperInvoice:
                    return CreatePaperInvoice();
                default:
                    return null;
            }
        }

        private string CreateElectronicInvoice() => "Electronic invoice created";
        private string CreatePaperInvoice() => "Paper invoice created";
    }
}