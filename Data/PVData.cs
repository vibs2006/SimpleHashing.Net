using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class PVData
    {
    
        public IEnumerable<UserData> getUserData(string userName, string connectionString, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: connectionString))
            {                
                return conn.Query<UserData>($"select [NewPassword], [Password], [User_Name] as PlainTextPassword from {tableName} where [User_Name] = @User_Name", new { User_Name = userName },null,true,null,CommandType.Text);
            }
        }

        //public int UpdateUser(string salt, string hash, string username)
        //{

        //    using (SqlConnection conn = new SqlConnection(connectionString: "Data Source=sqlserver;Initial Catalog=ParcelHero_TEST;user id=sa;password=pass#word1;Connect Timeout=600;max pool size=100000;"))
        //    {

        //        return conn.Execute("update M_WebUsersForHash set [PasswordSalt] = @salt, [NewPassword] = @hash where [User_Name] = @username"
        //            , new { salt = salt, hash = hash, username = username }, null, null, CommandType.Text);

        //        //return conn.Query<UserData>("select [PasswordSalt], [NewPassword] from M_WebUsersForHash where [User_Name] = @User_Name", new { User_Name = userName }, null, true, null, CommandType.Text);
        //    }
        //}      

        public int UpdateUser(string passwordHashString, string username, string connectionString, string tableName)
        {

            using (SqlConnection conn = new SqlConnection(connectionString: connectionString))
            {

                return conn.Execute($"update {tableName} set [NewPassword] = @NewPassword where [User_Name] = @username"
                    , new { NewPassword = passwordHashString, username = username }, null, null, CommandType.Text);

                //return conn.Query<UserData>("select [PasswordSalt], [NewPassword] from M_WebUsersForHash where [User_Name] = @User_Name", new { User_Name = userName }, null, true, null, CommandType.Text);
            }
        }

        public IEnumerable<UserData> getAllUsers(string connectionString, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString: connectionString))
            {
                return conn.Query<UserData>($"select [NewPassword], [Password] as PlainTextPassword, [User_Name] from {tableName} where ([Password] <> '') and ([Password] is not null) ", 
                    null, null, true, null, CommandType.Text);
            }
        }
    }

    public class UserData
    {        
        public string NewPassword { get; set; }        
        public string PlainTextPassword { get; set; }
        public string User_Name { get; set; }
    }
}
