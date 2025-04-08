using FOLYFOOD.Dto;
using FOLYFOOD.Dto.UserDto;
using FOLYFOOD.Entitys;

namespace FOLYFOOD.IService
{
    public interface IUserService
    {
        public Task<Account> Register(RegisterRequets data);

        public Task<Account> getOneUser(int id);

        public Task<RetunObject<Account>> updateOneAccount(UserUpdateClient account, int id, string accountId, string role);

        public Task<RetunObject<Account>> DeleteUser(int id);
    }
}
