using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
