using Microsoft.Data.SqlClient;
using ServiceCenter.core.network;
using System;
using System.Collections;
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
        public static string? roleString { get; private set; }


        private static void setRole()
        {
            string query = "select role_name from roles where role_id = @roleId";
            var result = DBHelper.executeReader(query, dr=>roleString = dr["role_name"].ToString(), new Microsoft.Data.SqlClient.SqlParameter("@roleId", roleId));
        }
        public static bool isLogged()
        {
            return userId.HasValue && !string.IsNullOrWhiteSpace(userName) && roleId.HasValue;
        }

        public static void loadUserSession()
        {
            string query = "select user_id, username, role_id, full_name, phone, photo_profile from users where user_id = @userid and status_id = 1";
            DBHelper.executeReader(query, dr =>
            {
                 UserSession.setSession(
                     Convert.ToInt32(dr["user_id"]),
                     dr["username"].ToString(),
                     Convert.ToInt32(dr["role_id"]),
                     dr["full_name"].ToString(),
                     dr["phone"].ToString(),
                     dr["photo_profile"].ToString()
                 );
            return true;
            },
                 new SqlParameter("@userid", userId)
            );
        }

        public static void updatePhoto(string Photo)
        {
            photo = Photo;
        }

        public static void updateUsername(string username)
        {
            userName = username;
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
            full_name = FullName;
            phone = Phone;
            photo = Photo;

            setRole();
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
