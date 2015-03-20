using Typesafe.Mailgun;

namespace DefibrilatorProject.BusinessLogic.Mails
{
    public class MailManager
    {
        public void SendEmail(string subject, string body, string from, string to)
        {
            var client = new MailgunClient("appaebdb208be5b42ec946fd962f8563417.mailgun.org", "key-f93b2c9ab5b7424f4528f521d69b3a65");
            client.SendMail(new System.Net.Mail.MailMessage(from, to)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            });
        }
    }
}
