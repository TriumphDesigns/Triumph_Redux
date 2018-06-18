using System.Threading.Tasks;

namespace TriumphRedux.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
