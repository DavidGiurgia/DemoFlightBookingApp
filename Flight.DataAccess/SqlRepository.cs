using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Flight.DataAccess
{
    public abstract class SqlRepository<T> : IRepository<T>
    {
        protected string _connection = ConfigurationManager.AppSettings["SqlConnectionString"];
        public T Create(T value)
        {
            string sqlText = CreateQuery();
            List<SqlParameter> parameters = CreateParameters(value);

            using (var con = new SqlConnection(_connection))
            {
                using (var cmd = new SqlCommand(sqlText, con))
                {
                    try
                    {
                        con.Open();
                        if (parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }
                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        return GetById(result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return default;
                    }
                }
            }
        }

        public void Delete(int id)
        {
            string sqlText = DeleteQuery();
            List<SqlParameter> parameters = DeleteParameters(id);

            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                using (var cmd = new SqlCommand(sqlText, con))
                {
                    try
                    {
                        if (parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public List<T> GetAll()
        {
            string sqlText = GetAllQuery();

            List<T> result = new List<T>();

            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                using (var cmd = new SqlCommand(sqlText, con))
                {
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                result.Add(MapFromReader(reader));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return result;
        }

        public T GetById(int id)
        {
            string sqlText = GetByIdQuery();
            List<SqlParameter> parameters = GetByIdParameters(id);

            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                using (var cmd = new SqlCommand(sqlText, con))
                {
                    try
                    {
                        if (parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapFromReader(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return default(T);
        }

        public T Update(T value)
        {
            string sqlText = UpdateQuery();
            List<SqlParameter> parameters = UpdateParameters(value);

            using (var con = new SqlConnection(_connection))
            {
                con.Open();
                using (var cmd = new SqlCommand(sqlText, con))
                {
                    try
                    {
                        if (parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return value;
        }

        public virtual List<SqlParameter> CreateParameters(T value)
        {
            return new List<SqlParameter>();
        }
        public virtual List<SqlParameter> UpdateParameters(T value)
        {
            return new List<SqlParameter>();
        }
        public virtual List<SqlParameter> DeleteParameters(int id)
        {
            return new List<SqlParameter>();
        }
        public virtual List<SqlParameter> GetByIdParameters(int id)
        {
            return new List<SqlParameter>();
        }
        public abstract string CreateQuery();

        public abstract string DeleteQuery();

        public abstract string UpdateQuery();

        public abstract string GetAllQuery();

        public abstract string GetByIdQuery();

        public abstract T MapFromReader(SqlDataReader reader);
    }
}
