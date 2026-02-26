using UserForm.Models;
using UserForm.Enum;
using System.Linq;

namespace UserForm.Services
{
    public class UserService : IUserService
    {
        private static List<UserModel> Users = new List<UserModel>();

        public void CreateUser(UserModel user)
        {
            user.Id = Guid.NewGuid();
            user.Status = UserStatus.Active;
            Users.Add(user);
        }

        public List<UserModel> GetAllUsers()
        {
            return Users;
        }

        public UserModel GetUserById(Guid id)
        {
            return Users.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateUser(UserModel model)
        {
            var user = Users.FirstOrDefault(x => x.Id == model.Id);

            if (user != null)
            {
                user.Name = model.Name;
                user.Email = model.Email;
                user.Age = model.Age;
            }
        }

        public void DeactivateUser(Guid id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                user.Status = UserStatus.Inactive;
            }
        }
    }
}