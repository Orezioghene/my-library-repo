using System.ComponentModel;
using System.Reflection;
using System.Security;
using thelibrary.Data.enums;
using thelibrary.ViewModel;

namespace thelibrary.Helpers
{
    public static class PermissionHelper
    {

        public static IEnumerable<PermissionViewModel> GetAllPermissions(this Permission[] value)
        {
            var perms = value
                .Select(p => new PermissionViewModel
                {
                    Id = p.ToString(),
                    Name = p.ToString(),
                    Description = GetPermissionDescription(p),
                    Category = p.GetPermissionCategory()
                });

            return perms;
        }

        public static string GetPermissionDescription(this Permission value)
        {
            Type type = value.GetType();

            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute? attr = Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;

                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }

            return null;
        }

        public static string GetPermissionCategory(this Permission value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);

            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    CategoryAttribute? attr = Attribute.GetCustomAttribute(field,
                             typeof(CategoryAttribute)) as CategoryAttribute;

                    if (attr != null)
                    {
                        return attr.Category;
                    }
                }
            }

            return null;
        }
    }
}
