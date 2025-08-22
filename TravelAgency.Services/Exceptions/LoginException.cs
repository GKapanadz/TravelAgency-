namespace TravelAgency.Services.Exceptions
{
    public class LoginException : Exception
    {
        private const string MessageTemplate = "Login failed. User with username : '{0}' not found.";

        public LoginException(string username) : base(string.Format(MessageTemplate, username))
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        public string Username { get; set; }
    }
}
