using System;
using System.Net.Mail;

namespace SolidPrinciples.SingleResponsibility.Bad
{
    public class Invoice
    {
        private long _amount;
        private DateTime _createdDate;

        public void AddInvoice()
        {
            // (Bad) Invoice class also send email
            var mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
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