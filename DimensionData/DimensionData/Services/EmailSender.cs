using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DimensionData.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace DimensionData.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, IOptions<EmailSettings> emailSettings)
        {
            Options = optionsAccessor.Value;
            _emailSettings = emailSettings.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {

            SmtpClient client = new SmtpClient(_emailSettings.MailServer, _emailSettings.MailPort)
            {
                Port = _emailSettings.MailPort,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(_emailSettings.Sender, _emailSettings.Password)
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(_emailSettings.Sender),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);

            return client.SendMailAsync(mailMessage);
        }

    }
}