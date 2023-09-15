using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface IAuthenticationRepository
    {
       Task<string> Login(LoginViewModel login);
       Task<string> RegisterUser(RegisterViewModel login);
    }
}
