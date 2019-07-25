

namespace TryItOut.Service
{
    public interface ILogin_Service
    {
        UserLoginDTO LoginUser(string userName, string password);
    }
}
