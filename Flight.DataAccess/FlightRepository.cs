using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Flight.Model;

namespace Flight.DataAccess
{
    public class FlightRepository : SqlRepository<FlightModel>
    {

        public override string CreateQuery()
        {
            return "INSERT INTO Flight ([From], [To], Date, Price)" +
                "VALUES (@From, @To, @Date, @Price);" +
                "SELECT SCOPE_IDENTITY();";
        }

        public override string DeleteQuery()
        {
            return "DELETE FROM Flight WHERE FlightId = @Id";
        }

        public override string UpdateQuery()
        {
            return "UPDATE Flight " +
                "SET [From] = @From," +
                " [To] = @To," +
                " Date = @Date," +
                " Price = @Price " +
                "WHERE FlightId = @Id;";
        }

        public override string GetAllQuery()
        {
            return "SELECT * FROM Flight;";
        }

        public override string GetByIdQuery()
        {
            return "SELECT * FROM Flight WHERE FlightId = @Id;";
        }

        public override List<SqlParameter> CreateParameters(FlightModel value)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@From", value.From),
                new SqlParameter("@To", value.To),
                new SqlParameter("@Date", value.Date),
                new SqlParameter("@Price", value.Price)
            };
        }
        public override List<SqlParameter> UpdateParameters(FlightModel value)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@From", value.From),
                new SqlParameter("@To", value.To),
                new SqlParameter("@Date", value.Date),
                new SqlParameter("@Price", value.Price),
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

        public override FlightModel MapFromReader(SqlDataReader reader)
        {
            return new FlightModel()
            {
                Id = (int)reader["FlightId"],
                From = reader["From"].ToString(),
                To = reader["To"].ToString(),
                Date = (DateTime)reader["Date"],
                Price = (int)reader["Price"]
            };
        }
    }
}
