using thelibrary.Models;

namespace thelibrary.Helpers
{
    public static class RoleHelper
    {
        public static Guid USER_ID() => Guid.Parse("9E4D8A66-0C87-4E58-A6F8-0BDE16A24321");
        public const string USER = nameof(USER);

        public static Guid ADMIN_ID() => Guid.Parse("FEBB742D-F5DB-4CA8-B596-59F3640386FD");
        public const string ADMIN = nameof(ADMIN);

        public static List<string> GetAll()
        {
            return new List<string>
            {                
                ADMIN
            };
        }
    }
}
