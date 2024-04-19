using Flight.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Flight.DataAccess
{
    public class UserRepository : SqlRepository<User>
    {
        public override string CreateQuery()
        {
            return "INSERT INTO [User] (Username, Password, Role)" +
                "VALUES (@Username, @Password, @Role);" +
                "SELECT SCOPE_IDENTITY();";
        }
        public override string UpdateQuery()
        {
            return "UPDATE [User] SET Username = @Username," +
                " Password = @Password, " +
                "Role = @Role " +
                "WHERE Id = @Id;";
        }
        public override string DeleteQuery()
        {
            return "DELETE FROM [User] WHERE Id = @Id";
        }
        public override string GetAllQuery()
        {
            return "SELECT * FROM [User];";
        }
        public override string GetByIdQuery()
        {
            return "SELECT * FROM [User] WHERE Id = @Id;";
        }

        public override List<SqlParameter> CreateParameters(User value)
        {
            return new List<SqlParameter>() 
            { 
                new SqlParameter("@Username", value.Username),
                new SqlParameter("@Password", value.Password),
                new SqlParameter("@Role", value.Role)
            };
        }
        public override List<SqlParameter> UpdateParameters(User value)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Username", value.Username),
                new SqlParameter("@Password", value.Password),
                new SqlParameter("@Role", value.Role),
                new SqlParameter("@Id", value.Id)
            };
        }
        public override List<SqlParameter> DeleteParameters(int id)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };
        }
        public override List<SqlParameter> GetByIdParameters(int id)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };
        }

        public override User MapFromReader(SqlDataReader reader)
        {
            return new User()
            {
                Id = (int)reader["Id"],
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString(),
                Role = (Role)reader["Role"]
            };
        }


        ///other
        public User ValidateLogin(string username, string password)
        {
            string query = "SELECT * FROM [User] WHERE Username = @Username AND Password = @Password";

            SqlParameter[] UserParameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            
            using(var  conn = new SqlConnection(base._connection))
            {
                conn.Open();
                using(var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(UserParameters);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapFromReader(reader);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return null;
        }
    }
}
