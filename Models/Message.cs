namespace MyWebApp.Models;

public class Message
{
    public string? name = "placeholder";
    public string? email = "placeholder";
    public string? message = "placeholder";

    private EmailSender _emailSender = new EmailSender;

 public void SetEmailDetails(string Name, string Email, string Message) {
        this.name = Name;
        this.email = Email;
        this.message = Message;
    }
    public void SendEmail() {
        _emailSender.SendEmail(name, email, message);
    }

}