using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace thelibrary.NewHelpers
{
    public class UserPrincipal : ClaimsPrincipal
    {
        public UserPrincipal(ClaimsPrincipal principal) : base(principal)
        {
        }

        private string GetClaimValue(string key)
        {
            var claim = this.Claims.FirstOrDefault(c => c.Type == key);
            return claim?.Value;
        }


        public string Department
        {
            get
            {
                if (FindFirst(ClaimTypeHelpers.Department) == null)
                    return null;

                var value = GetClaimValue(ClaimTypeHelpers.Department);
                return GetClaimValue(ClaimTypeHelpers.Department);
            }
        }

        

        public bool IsDefaultPassword
        {
            get
            {
                if (FindFirst(ClaimTypeHelpers.IsDefaultPassword) == null)
                    return false;

                var value = GetClaimValue(ClaimTypeHelpers.IsDefaultPassword);
                bool.TryParse(value, out bool isDefaultPassword);
                return isDefaultPassword;
            }
        }

        public String Role
        {
            get
            {
                if (FindFirst(ClaimTypes.Role) == null)
                    return String.Empty;

                return GetClaimValue(ClaimTypes.Role);
            }
        }

        public string UserName
        {
            get
            {
                if (FindFirst(ClaimTypeHelpers.Name) == null)
                    return String.Empty;

                return GetClaimValue(ClaimTypeHelpers.Name);
            }
        }
        public string Matric_No
        {
            get
            {
                if (FindFirst(ClaimTypeHelpers.Matric_No) == null)
                    return String.Empty;

                return GetClaimValue(ClaimTypeHelpers.Matric_No);
            }
        }       

        public string UserId
        {
            get
            {
                if (FindFirst(JwtRegisteredClaimNames.Sub) == null)
                    return string.Empty;

                return GetClaimValue(JwtRegisteredClaimNames.Sub);
            }
        }

        public string Email
        {
            get
            {
                if (FindFirst(ClaimTypes.Email) == null)
                    return string.Empty;

                return GetClaimValue(ClaimTypes.Email);
            }
        }

        public string UserType
        {
            get
            {
                if (FindFirst(ClaimTypeHelpers.UserType) == null)
                    return string.Empty;

                return GetClaimValue(ClaimTypeHelpers.UserType);
            }
        }



        

    }
}
