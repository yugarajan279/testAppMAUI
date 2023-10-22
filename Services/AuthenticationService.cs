using testapp.Data;

namespace testapp.Services
{
    public class AuthenticationService
    {
        private readonly DatabaseContext _dbContext;

        public AuthenticationService(string connectionString)
        {
            _dbContext = new DatabaseContext(connectionString);
        }

        public void RegisterUser(string username, string password)
        {

            var user = new SecurityAuthentication
            {
                UserName = username,
                Password = password
            };

            _dbContext.SecurityAuthentications.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
