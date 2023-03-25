using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalApplianceStore
{
    public class Email
    {
        private const string EMAIL = "Danzi001@yandex.ru";
        private const string PASSWORD = "twtbaqghjocgzmpq";

        public static async Task SendEmailAsync(string toMailAdress, string subject, string body)
        {
            MailAddress from = new MailAddress(EMAIL, "ElectricalApplianceStore");
            MailAddress to = new MailAddress(toMailAdress);
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential(EMAIL, PASSWORD);
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(message);
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
