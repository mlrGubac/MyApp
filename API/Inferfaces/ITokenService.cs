using API.Entities;

namespace API.Inferfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}