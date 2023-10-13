using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=cmdlhrdb01;Database=Practice;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))





            //// 1. Execute Stored Procedure to Get All Students list
            using (SqlCommand command = new SqlCommand("GetAllStudents", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"StudentID: {reader["StudentID"]}, FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}, Age: {reader["Age"]}, CourseID: {reader["CourseID"]}");
                }
                connection.Close();
            }

            //    // 2. Execute Stored Procedure to Add a Student
            using (SqlCommand command = new SqlCommand("StudentsAdd", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", 1012);
                command.Parameters.AddWithValue("@FirstName", "Hamza");
                command.Parameters.AddWithValue("@LastName", "Sultan");
                command.Parameters.AddWithValue("@Age", 23);
                command.Parameters.AddWithValue("@CourseID", 4);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            //    //3.Execute Stored Procedure to Update an Students Age
            using (SqlCommand command = new SqlCommand("UpdateStudentAge", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", 1009);
                command.Parameters.AddWithValue("@NewAge", 26);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            //    // 4. Execute Stored Procedure to Delete a Student
            using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", 1005);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            // Task 9
            // 1. Execute Stored Procedure to not enrolled Students list
            using (SqlCommand command = new SqlCommand("Notenrolled", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}");
                }
                connection.Close();
            }
        }
    }
}
