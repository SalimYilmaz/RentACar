using Business.Requests.User;
using Core.Utilities.Security.JWT;
namespace Business.Abstract
{
    public interface IUserService
    {
        void Register(RegisterRequest request);
        // bool Login(LoginRequest request); //TODO: return type: JWT  Alttakine dönüştü.
        AccessToken Login(LoginRequest request); //TODO: return type: JWT 

    }
}