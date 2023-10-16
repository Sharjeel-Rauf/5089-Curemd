using ADO_DEMO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace ADO_DEMO.Controllers
{
   
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration config) 
        { 
           _configuration = config;
        
        }

        [HttpGet]
        [Route ("GetAllStudents")]
        public List<ProductModel> GetAllStudents()
        {
            List<ProductModel> Lst = new List<ProductModel>();
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

            SqlCommand cmd = new SqlCommand("select * from Students", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            for (int i = 0;i<dt.Rows.Count;i++)
            {
                ProductModel obj= new ProductModel();
                obj.StudentID = int.Parse(dt.Rows[i]["StudentID"].ToString());
                obj.FirstName = dt.Rows[i]["FirstName"].ToString();
                obj.LastName = dt.Rows[i]["LastName"].ToString();
                obj.Age = int.Parse(dt.Rows[i]["Age"].ToString());
                obj.CourseID = int.Parse(dt.Rows[i]["CourseID"].ToString());

                Lst.Add(obj);

            }
            return Lst;



            return Lst;
        }
    }
}
