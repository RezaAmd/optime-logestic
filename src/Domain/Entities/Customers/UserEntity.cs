namespace Domain.Entities.Customers
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; private set; }
        // TODO:
        // Password should be hash.
        public string Password { get; set; }

        #region Relations



        #endregion

        #region Ctor

        public UserEntity(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("Username cannot be null or empty.");
            Username = username;

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Password cannot be null or empty.");
            Password = password;
        }

        #endregion
    }
}