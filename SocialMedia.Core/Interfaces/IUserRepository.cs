using System.Collections.Generic;
using System.Threading.Tasks;
using VY.SocialMedia.Data.Contracts.Entities;

namespace VY.SocialMedia.Data.Contracts.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntities> GetUserById(int id);
        Task<IEnumerable<UserEntities>> GetUsers();
    }
}