﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DimensionData.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using MimeKit;
//using SendGrid;
//using SendGrid.Helpers.Mail;
>>>>>>> parent of ee5ec31... Revert "SMTP email service instead of SendGrid"
=======
using SendGrid;
using SendGrid.Helpers.Mail;
>>>>>>> parent of 3b32726... test

namespace DimensionData.Services
{
    public class EmailSender : IEmailSender
    {
<<<<<<< HEAD
=======

>>>>>>> parent of ee5ec31... Revert "SMTP email service instead of SendGrid"
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, IOptions<EmailSettings> emailSettings)
        {
            Options = optionsAccessor.Value;
            _emailSettings = emailSettings.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {

<<<<<<< HEAD
<<<<<<< HEAD
            SmtpClient client = new SmtpClient(_emailSettings.MailServer, _emailSettings.MailPort)
=======
            var client = new SmtpClient(_emailSettings.MailServer, _emailSettings.MailPort)
>>>>>>> parent of 3b32726... test
            {
                Port = _emailSettings.MailPort,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(_emailSettings.Sender, _emailSettings.Password)
            };
            var mailMessage = new MailMessage
            {
=======
            var client = new SmtpClient(_emailSettings.MailServer, _emailSettings.MailPort)
            {
                Port = _emailSettings.MailPort,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(_emailSettings.Sender, _emailSettings.Password)
            };
            var mailMessage = new MailMessage
            {
>>>>>>> parent of ee5ec31... Revert "SMTP email service instead of SendGrid"
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