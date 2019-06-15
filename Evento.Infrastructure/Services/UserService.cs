using System;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Core.Repositories;
using Evento.Infrastructure.Repositories;

namespace Evento.Infrastructure.Services
{
    public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(UserReposiotry userReposiotry)
        {
            
        }
        public async Task RegisterAsync(Guid userId, string email, string name, string password, string role = "user")
        {
            var user = _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception($"User with email: '{email}' already exists ");

                user = new User(userId, role, name, email, password);
                _userRepository.AddAsync(user);
        }
    }
}