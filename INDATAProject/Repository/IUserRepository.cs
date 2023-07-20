using INDATAProject.Models;

namespace INDATAProject.Repository
{
    public interface IUserRepository
    {
        void Add<User>(User user);
        void Delete<User>(User user);
        void Update<User>(User user);

        bool SaveAll();

        List<User> GetUsers();


    }
}
