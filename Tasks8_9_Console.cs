using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=EHSAN\\SQLEXPRESS;Database=Stored_procedures;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))





            ////// 1. Execute Stored Procedure to Get All Students list
            //using (SqlCommand command = new SqlCommand("GetAllStudents", connection))
            ////{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"StudentID: {reader["StudentID"]}, FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}, Age: {reader["Age"]}, CourseID: {reader["CourseID"]}");
            //    }
            //    connection.Close();
            //}

            ////    // 2. Execute Stored Procedure to Add a Student
            //using (SqlCommand command = new SqlCommand("StudentsAdd", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@StudentID", 1012);
            //command.Parameters.AddWithValue("@FirstName", "Hamza");
            //command.Parameters.AddWithValue("@LastName", "Sultan");
            //command.Parameters.AddWithValue("@Age", 23);
            //command.Parameters.AddWithValue("@CourseID", 4);
            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();
            //}

            ////    //3.Execute Stored Procedure to Update an Students Age
            //using (SqlCommand command = new SqlCommand("UpdateStudentAge", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@StudentID", 1002);
            //    command.Parameters.AddWithValue("@NewAge", 23);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}

            ////    // 4. Execute Stored Procedure to Delete a Student
            //using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@StudentID", 1005);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}
            //// Task 9
            //// 1. Execute Stored Procedure to not enrolled Students list
            //using (SqlCommand command = new SqlCommand("Notenrolled", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}");
            //    }
            //    connection.Close();
            //}
            //// 2. Execute Stored Procedure to find  most popular course
            //using (SqlCommand command = new SqlCommand("Most_popular", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"CourseName: {reader["CourseName"]}");
            //    }
            //    connection.Close();
            //}
            //	3. List the students who are older than the average age of students.
            //using (SqlCommand command = new SqlCommand("Older_than_average", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}");
            //    }
            //    connection.Close();
            //}
            //4. 	Find the total number of students and average age for each course.
            //using (SqlCommand command = new SqlCommand("total_average", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"CourseName: {reader["CourseName"]},AverageAge: {reader["AverageAge"]}");
                   
            //    }
            //    connection.Close();
            //    Console.ReadKey();
            //}

            //5. List the courses that have no students enrolled in them
            //using (SqlCommand command = new SqlCommand("no_student_course", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"CourseName: {reader["CourseName"]}");

            //    }
            //    connection.Close();
            //    Console.ReadKey();
            //}
            //6. List students who share courses with a specific student (choose one from your records
            //using (SqlCommand command = new SqlCommand("share_course", connection))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine($"FirstName: {reader["FirstName"]},LastName: {reader["LastName"]}");

            //    }
            //    connection.Close();
            //    Console.ReadKey();
            //}
            //7. For each course, list the youngest and oldest student.
            using (SqlCommand command = new SqlCommand("young_old_student", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"CourseName: {reader["CourseName"]},YoungestAge: {reader["YoungestAge"]}, OldestAge: {reader["OldestAge"]}");

                }
                connection.Close();
                Console.ReadKey();
            }

        }
    }
}
