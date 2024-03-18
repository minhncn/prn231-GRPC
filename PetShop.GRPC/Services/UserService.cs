using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using PetShop.BusinessObject.Models;
using PetShop.Repositories.Implements;
using PetShop.Repositories.Interfaces;
using PetShop.Services.Enums;

namespace PetShop.GRPC.Services
{
    public class UserService : UserServices.UserServicesBase
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
