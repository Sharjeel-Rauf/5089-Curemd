using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using The_ultimate.Model;
using System.Collections.Generic;


//////////////////////////////////////CREATING STUDENT CONTROLLER////////////////////////////////////////////////////
namespace The_ultimate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly string _connectionString;

        public StudentsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        //PERFORMING CRUD OPERATIONS//


        //READING OPERATION//

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            List<Students> Students = new List<Students>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetAllStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())  
                    {
                        Students emp = new Students();
                        emp.StudentID = (int)reader["StudentID"];
                        emp.FirstName = reader["LastName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.Age = (int)reader["Age"];
                        emp.CourseID = (int)reader["CourseID"];

                        Students.Add(emp);
                    }
                }
            }
            return Ok(Students);
        }
        // CREATING OPERATION

        [HttpPut]
        public IActionResult StudentsAdd(Students Student)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("StudentsAdd", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", Student.StudentID);
                    command.Parameters.AddWithValue("@FirstName", Student.FirstName);
                    command.Parameters.AddWithValue("@LastName", Student.LastName);
                    command.Parameters.AddWithValue("@Age", Student.Age);
                    command.Parameters.AddWithValue("@CourseID", Student.CourseID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return Ok();
        }

        //UPDATING OPERATION
        [HttpPut("{id}")]
        public IActionResult UpdateStudentAge(int CourseID, Students Student)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("UpdateStudentAge", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CourseID", CourseID);
                    command.Parameters.AddWithValue("@FirstName", Student.FirstName);
                    command.Parameters.AddWithValue("@LastName", Student.LastName);
                    command.Parameters.AddWithValue("@Age", Student.Age);
                    command.Parameters.AddWithValue("@DepartmentID", Student.CourseID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return Ok(Student);
        }
        //DELETING OPERATION

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int StudentID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("DeleteStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return Ok();
        }

    }
}
