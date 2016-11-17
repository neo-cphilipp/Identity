// <auto-generated />
namespace Microsoft.AspNetCore.Identity.EntityFrameworkCore
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Identity.EntityFrameworkCore.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// AddEntityFrameworkStores can only be called with a role that derives from IdentityRole&lt;TKey&gt;. If you are specifying more generic arguments, use AddRoleStore&lt;TStore&gt;() where TStore is your custom IRoleStore that uses your generics instead.
        /// </summary>
        internal static string NotIdentityRole
        {
            get { return GetString("NotIdentityRole"); }
        }

        /// <summary>
        /// AddEntityFrameworkStores can only be called with a role that derives from IdentityRole&lt;TKey&gt;. If you are specifying more generic arguments, use AddRoleStore&lt;TStore&gt;() where TStore is your custom IRoleStore that uses your generics instead.
        /// </summary>
        internal static string FormatNotIdentityRole()
        {
            return GetString("NotIdentityRole");
        }

        /// <summary>
        /// AddEntityFrameworkStores can only be called with a user that derives from IdentityUser&lt;TKey&gt;. If you are specifying more generic arguments, use IdentityBuilder.AddUserStore&lt;TStore&gt;() where TStore is your custom IUserStore that uses your generics instead.
        /// </summary>
        internal static string NotIdentityUser
        {
            get { return GetString("NotIdentityUser"); }
        }

        /// <summary>
        /// AddEntityFrameworkStores can only be called with a user that derives from IdentityUser&lt;TKey&gt;. If you are specifying more generic arguments, use IdentityBuilder.AddUserStore&lt;TStore&gt;() where TStore is your custom IUserStore that uses your generics instead.
        /// </summary>
        internal static string FormatNotIdentityUser()
        {
            return GetString("NotIdentityUser");
        }

        /// <summary>
        /// Role {0} does not exist.
        /// </summary>
        internal static string RoleNotFound
        {
            get { return GetString("RoleNotFound"); }
        }

        /// <summary>
        /// Role {0} does not exist.
        /// </summary>
        internal static string FormatRoleNotFound(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RoleNotFound"), p0);
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string ValueCannotBeNullOrEmpty
        {
            get { return GetString("ValueCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string FormatValueCannotBeNullOrEmpty()
        {
            return GetString("ValueCannotBeNullOrEmpty");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
