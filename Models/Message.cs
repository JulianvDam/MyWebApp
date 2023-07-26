using MyWebApp.Services;
using Microsoft.Extensions.Options;
namespace MyWebApp.Models;

public class Message
{
    private string name = "none";
    private string email = "none";
    private string message = "none";
    private EmailSender _emailSender;

    public Message(string Name, string Email, string Message) {
        this.name = Name;
        this.email = Email;
        this.message = Message;
        this._emailSender = new EmailSender();
    }

    public void SendEmail() {
        _emailSender.SendEmail(name, email, message);
    }

}