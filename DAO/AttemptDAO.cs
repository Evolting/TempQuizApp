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
    class AttemptDAO
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

        public List<Attempt> getAttempt(int userID, int setID, string criteria, string order)
        {
            List<Attempt> attempts = new List<Attempt>();

            connection = new SqlConnection(getConnectionString());
            string query = "select testID, setID, [user].username, score, takenAt from TestResult inner join[user] on TestResult.userID = [user].userID  " +
                " where setID = @set and [user].userID = @user order by " + criteria + " " + order + " ";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@set", setID);
            command.Parameters.AddWithValue("@user", userID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Attempt a = new Attempt()
                        {
                            ID = reader.GetInt32("testID"),
                            username = reader.GetString("username"),
                            score = Double.Parse(reader.GetString("score")),
                            takenAt = reader.GetDateTime("takenAt")
                        };
                        attempts.Add(a);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return attempts;
        }

        public List<Attempt> getTopScore(int setID)
        {
            List<Attempt> attempts = new List<Attempt>();

            connection = new SqlConnection(getConnectionString());
            string query = "select top 10 testID, setID, [user].username, score, takenAt from TestResult inner join[user] on TestResult.userID = [user].userID  " +
                " where setID = @set order by takenAt desc";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@set", setID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Attempt a = new Attempt()
                        {
                            ID = reader.GetInt32("testID"),
                            username = reader.GetString("username"),
                            score = Double.Parse(reader.GetString("score")),
                            takenAt = reader.GetDateTime("takenAt")
                        };
                        attempts.Add(a);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return attempts;
        }
    }
}
