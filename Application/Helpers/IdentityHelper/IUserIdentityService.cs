using System.Threading.Tasks;

namespace Application.Helpers.IdentityHelper;

public interface IUserIdentityService
{
    Task<string> GetUserName();
}