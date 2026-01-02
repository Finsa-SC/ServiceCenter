using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter
{
    internal class UserSession
    {
        public static int? userId {  get; private set; }
        public static string? userName {  get; private set; }
        public static int? roleId{  get; private set; }
        public static string? full_name {  get; private set; }
        public static string? phone {  get; private set; }
        public static string? photo {  get; private set; }

        public static bool isLogged()
        {
            return userId.HasValue && !string.IsNullOrWhiteSpace(userName) && roleId.HasValue;
        }

        public static void setSession(
            int UserID,
            string Username,
            int RoleId,
            string FullName,
            string Phone,
            string? Photo
        )
        {
            userId = UserID;
            userName = Username;
            roleId = RoleId;
            phone = Phone;
            photo = Photo;
        }

        public static void clear()
        {
            userId = null;
            userName = null;
            roleId = null;
            full_name = null;
            phone = null;
            photo = null;
        }
    }
}
