using EmailService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public class EmailService : IEmailSender
    {
        public async Task<bool> SendOneAsync(EmailMessage message)
        {
            return true;
        }

        public bool SendOne(EmailMessage message)
        {
            return true;
        }

        private SmtpClient GetMailClient()
        {
            SmtpClient client = new SmtpClient();
            client.Host = ConfigurationManager.AppSettings["SmtpServer"];
            client.Port = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            return client;
        }
       

        private MailMessage GetMailMessage(EmailMessage emailMessage)
        {
            MailAddress sender = new MailAddress(emailMessage.FromAddress, emailMessage?.FromDisplayName);
            MailAddress recipient = new MailAddress(emailMessage.ToAddress, emailMessage?.ToDisplayName);

            var msg = new MailMessage()
            {
                From = sender,
                Subject = emailMessage.Subject,
                Body = emailMessage.Body,
                IsBodyHtml = emailMessage.UseHtml
            };
            msg.To.Add(emailMessage.ToAddress);
            return msg;
        }


        //private SmtpClient GetSmtpClient()
        //{
        //    SmtpClient client = new SmtpClient();
        //    return client;
        //}
    }
}
