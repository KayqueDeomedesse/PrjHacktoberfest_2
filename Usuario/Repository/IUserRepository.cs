using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuario.Model;

namespace Usuario.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> SearchUser();
        Task<User> SearchUser(int Id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);


        Task<bool> SaveChangesAsync();
    }
}