using BRSK.AppAuthentication.AuthModels;

namespace BRSK.AppAuthentication.AuthInterfeces
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        bool IsTokenValid(string key, string issuer, string token);
        bool ValidateToken(string key, string issuer, string audience, string token);
    }
}
