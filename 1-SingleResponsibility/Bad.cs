using SolidPrinciples.SingleResponsibility.Model;

namespace SolidPrinciples.SingleResponsibility.Bad
{
    class UserSettings
    {
        private User User;

        public UserSettings(User user)
        {
            User = user;
        }

        public void ChangeSettings(Settings settings)
        {
            if (VerifyCredentials())
            {
                // ...
            }
        }

        // (Bad) UserSettings also need to verify credentials
        private bool VerifyCredentials()
        {
            // ...
            return true;
        }
    }
}