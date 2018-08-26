using EmailService.Models;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task<bool> SendOneAsync(EmailMessage message)
        {
            return true;
        }

        public bool SendOne(EmailMessage message)
        {
            return true;
        }

        private SmtpClient GetSmtpClient()
        {
            SmtpClient client = new SmtpClient();
            //client.Host = 

            return client;
        }

        //private SmtpClient GetSmtpClient()
        //{
        //    SmtpClient client = new SmtpClient();
        //    return client;
        //}
    }
}
