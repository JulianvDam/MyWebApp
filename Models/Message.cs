namespace MyWebApp.Models;

public class Message
{
    private string name = "none";
    private string email = "none";
    private string message = "none";

    public Message(string Name, string Email, string Message) {
        this.name = Name;
        this.email = Email;
        this.message = Message;
    }

    private EmailSender _emailSender = new EmailSender();

    public void SendEmail() {
        _emailSender.SendEmail(name, email, message);
    }

}