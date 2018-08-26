using EmailService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public interface IEmailSender
    {
        Task<bool> SendOneAsync(EmailMessage message);
        bool SendOne(EmailMessage message);
    }
}
