namespace MyWebApp.Services
{
    public interface IEmailSender
    {
      Task SendEmail(string name, string email, string message);
    }
}
