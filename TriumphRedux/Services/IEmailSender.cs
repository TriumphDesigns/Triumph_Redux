using System.Threading.Tasks;

namespace TriumphRedux.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
