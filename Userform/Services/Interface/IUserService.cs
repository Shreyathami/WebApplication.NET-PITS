using UserForm.Models;

namespace UserForm.Services
{
    public interface IUserService
    {
        void CreateUser(UserModel user);
        List<UserModel> GetAllUsers();
        UserModel GetUserById(Guid id);
        void UpdateUser(UserModel user);
        void DeactivateUser(Guid id);
    }
}