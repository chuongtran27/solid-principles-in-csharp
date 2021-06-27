using System;

namespace SolidPrinciples.SingleResponsibility.Good
{
    public interface IMailSender
    {
        public void SendEmail(string eMailFrom, string eMailTo, string eMailSubject, string eMailBody);
    }
    
    // (Good) Separate class then each class only do one functionality
    public class MailSender : IMailSender
    {
        public void SendEmail(string eMailFrom ,string eMailTo , string eMailSubject , string eMailBody)
        {
            // send email
        }
    }

    public class Invoice
    {
        private readonly IMailSender _mailSender;
        
        private long _amount;
        private DateTime _createdDate;

        public Invoice(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public void AddInvoice()
        {
            //...add invoice
            _mailSender.SendEmail("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
        }

        public void DeleteInvoice()
        {
            //...delete invoice
        }
    }
}