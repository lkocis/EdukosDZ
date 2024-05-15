using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća3_
{
    //Zadatak 1.
    //Obrasci stvaranja - Graditelj
    public class Mail
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Recipient { get; set; }
        public string Attachments { get; set; }
    }

    public class MailConstructor : IMailConstructor
    {
        Mail mail;
        public MailConstructor()
        {
            mail = new Mail();
        }

        public IMailConstructor AddSubject(string subject)
        {
            mail.Subject = subject;
            return this;
        }
        public IMailConstructor AddContent(string content)
        {
            mail.Content = content;
            return this;
        }
        public IMailConstructor AddRecipient(string recipient)
        {
            mail.Recipient = recipient;
            return this;
        }

        public IMailConstructor AddAttachments(string attachment)
        {
            mail.Attachments = attachment;
            return this;
        }

        public Mail Construct()
        {
            return mail;
        }

        public IMailConstructor Reset()
        {
            mail = new Mail();
            return this;
        }
    }

    public class SMTP
    {
        IMailConstructor mailConstructor;
        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }

        public void SendNoReplyMail()
        {
            Mail mail = mailConstructor.AddSubject("No Reply").AddContent("Hello World").Construct();
            Console.WriteLine($"Subject: {mail.Subject}");
            Console.WriteLine($"Content: {mail.Content}");
        }
    }

    public interface IMailConstructor
    {
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        IMailConstructor AddRecipient(string recepient);
        IMailConstructor AddAttachments(string attachment);
        Mail Construct();
        IMailConstructor Reset();
    }
}
