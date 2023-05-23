using System.Net.Mail;
using System.Net;

public class EmailSender : IEmailSender {

 public EmailSender() {}

 public Task SendEmail(string name, string email, string message) {
  
  //tempemail
  var emailTo = "gebel21535@duscore.com";
  message += $"\n\nName: {name}\nEmail: {email}\n";

  var client = new SmtpClient("smtp.office365.com", 587) {
   EnableSsl = true,
   Credentials = new NetworkCredential("julianvdam@outlook.com", "encrypted1")
  };
  return client.SendMailAsync(new MailMessage(from: email, to: emailTo, "Website Message", message));
 }
}