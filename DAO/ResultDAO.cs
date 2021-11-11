using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using QuizApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace QuizApp.DAO
{
    class ResultDAO
    {
        // đối tượng kết nối
        SqlConnection connection;

        // đối tượng thực thi các truy vấn
        SqlCommand command;


        string getConnectionString()
        {
            // khai báo và lấy chuỗi từ appsettings.json
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();

            return config["ConnectionString:MyQuizDB"];
        }

        public int saveResult(int setID, string mark, DateTime takenAt)
        {
            int result = 0;

            connection = new SqlConnection(getConnectionString());
            string sql = "insert into TestResult values(@setID, @userID, @mark, @takenAt)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@setID", setID);
            command.Parameters.AddWithValue("@userID", Common.user.userID);
            command.Parameters.AddWithValue("@mark", mark);
            command.Parameters.AddWithValue("@takenAt", takenAt);

            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public int saveResultDetails(List<Result> results)
        {
            int result = 0;
            connection = new SqlConnection(getConnectionString());
            string sql = "insert into TestResult values(@setID, @userID, @mark, @takenAt)";
            foreach (var r in results)
            {

            }

            return result;
        }

    }
}
