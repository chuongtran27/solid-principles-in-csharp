using System;

namespace SolidPrinciples.SingleResponsibility.Good
{
    public interface IMailService
    {
        public void SendEmail(string eMailFrom, string eMailTo, string eMailSubject, string eMailBody);
    }
    
    // (Good) Separate class then each class only do one functionality
    public class MailService : IMailService
    {
        public void SendEmail(string eMailFrom ,string eMailTo , string eMailSubject , string eMailBody)
        {
            //...send email
        }
    }

    public class InvoiceService
    {
        private readonly IMailService _mailService;
        
        private long _amount;
        private DateTime _createdDate;

        public InvoiceService(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void AddInvoice()
        {
            //...add invoice
            _mailService.SendEmail("Store101", "customer@email.com", "Invoice created", "InvoiceDetail");
        }

        public void DeleteInvoice()
        {
            //...delete invoice
        }
    }
}