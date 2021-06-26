using SolidPrinciples.SingleResponsibility.Model;

namespace SolidPrinciples.SingleResponsibility.Good
{
    // (Good) Separate class, each class only do one functionality
    
    /// <summary>
    /// UserAuth authenticate user
    /// </summary>
    class UserAuth
    {
        private User User;

        public UserAuth(User user)
        {
            User = user;
        }

        public bool VerifyCredentials()
        {
            // ...
            return true;
        }
    }

    /// <summary>
    /// UserSettings manage settings of user 
    /// </summary>
    class UserSettings
    {
        private User User;
        private UserAuth Auth;

        public UserSettings(User user)
        {
            User = user;
            Auth = new UserAuth(user);
        }

        public void ChangeSettings(Settings settings)
        {
            if (Auth.VerifyCredentials())
            {
                // ...
            }
        }
    }
}