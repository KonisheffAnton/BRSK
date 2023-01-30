using BRSK.AppAuthentication.AuthModels;

namespace BRSK.AppAuthentication.AuthInterfeces
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userMode);
    }
}
