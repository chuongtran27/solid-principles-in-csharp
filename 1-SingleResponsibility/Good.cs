using System;

namespace SolidPrinciples.SingleResponsibility.Good
{
    // (Good) Separate class then each class only do one functionality
    public class MailSender
    {
        public void SendEmail(string eMailFrom ,string eMailTo , string eMailSubject , string eMailBody)
        {
            // send email
        }
    }

    public class Invoice
    {
        private readonly MailSender _mailSender;
        
        private long _amount;
        private DateTime _createdDate;

        public Invoice(MailSender mailSender)
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