using System.Net.Mail;
using System.Net;

public class EmailSender : IEmailSender {
 public Task SendEmail(string name, string email, string message) {
  
  //tempemail
  var emailTo = "helixo6628@andorem.com";
  message += $"\n\nName: {name}\nEmail: {email}\n";

  var client = new SmtpClient("smtp.office365.com", 587) {
   EnableSsl = true,
   Credentials = new NetworkCredential("julianvdam@outlook.com", "encrypted1")
  };

  return client.SendMailAsync(new MailMessage(from: email, to: emailTo, "Website Message", message));
 }
}