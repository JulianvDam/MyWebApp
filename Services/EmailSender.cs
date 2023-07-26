using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Services;

public class EmailSender : IEmailSender
{
    public EmailSender() {}

    public Task SendEmail(string name, string email, string message)
    {
        var emailTo = "julianvdam@outlook.com";
        message += $"\n\nName: {name}\nEmail: {email}\n";

        var client = new SmtpClient("smtp.office365.com", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential("julianwebsite@outlook.com", "Encrypted_pass")
        };

        Console.WriteLine(email);

        return client.SendMailAsync(new MailMessage(from: "julianwebsite@outlook.com", to: emailTo, "Website Message", message));
    }
}
