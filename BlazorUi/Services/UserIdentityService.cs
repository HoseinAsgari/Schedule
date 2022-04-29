using System.Threading.Tasks;
using Application.Helpers.IdentityHelper;
using Blazored.LocalStorage;

namespace BlazorUi.Services;

public class UserIdentityService : IUserIdentityService
{
    private readonly ILocalStorageService _localStorageService;
    public UserIdentityService(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }
    
    public async Task<string> GetUserName()
    {
        var userName = await _localStorageService.GetItemAsync<string>("userName");
        return userName;
    }
}