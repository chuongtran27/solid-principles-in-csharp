using System;
using System.Net.Mail;

namespace SolidPrinciples.SingleResponsibility.Bad
{
    public class InvoiceService
    {
        private long _amount;
        private DateTime _createdDate;

        public void AddInvoice()
        {
            // (Bad) Invoice service also send email
            var mailMessage = new MailMessage("Store101", "customer@email.com", "Invoice created", "InvoiceDetail");
            this.SendInvoiceEmail(mailMessage);
        }

        public void DeleteInvoice()
        {
            // ...delete invoice
        }

        private void SendInvoiceEmail(MailMessage mailMessage)
        {
            // ...send invoice mail
        }
    }
}