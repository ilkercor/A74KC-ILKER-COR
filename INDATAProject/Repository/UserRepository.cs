using INDATAProject.Models;

namespace INDATAProject.Repository
{
    public class UserRepository : IUserRepository
    {

        private DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<User>(User user)
        {
            _context.Add(user);
        }

        public void Delete<User>(User user)
        {
            _context.Remove(user);
        }

        public void Update<User>(User user)
        {
            _context.Update(user);
        }

        public List<User> GetUsers()
        {
            var userList = _context.Users.ToList();
            return userList;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
