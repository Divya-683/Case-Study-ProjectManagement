using ProjectManagement.Exceptions;
using ProjectManagement.Models;
using ProjectManagement.Utility;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjectManagement.DAO
{
    public class Assign
    {
        public static void AssignProject()
        {
            
            Console.Write("Enter Employee ID to Assign Project: ");
            int employeeid = int.Parse(Console.ReadLine());

            Console.Write("Enter ProjectID: ");
            int projectid = int.Parse(Console.ReadLine());

            using SqlConnection conn = DBConnection.GetConnection();
            string query = "UPDATE Employee SET ProjectID = @projectid WHERE EmployeeID = @employeeid";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@employeeid", employeeid);
            cmd.Parameters.AddWithValue("@projectid", projectid);

            conn.Open();
            
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine($"{result} Project Assigned Sucessfully.");                
          

        }
        public static void AssignTask()
        {
            Console.Write("Enter Task ID to Assign Project and Employee: ");
            int taskid = int.Parse(Console.ReadLine());

            Console.Write("Enter ProjectID: ");
            int projectid = int.Parse(Console.ReadLine());

            Console.Write("Enter EmployeeID: ");
            int employeeid = int.Parse(Console.ReadLine());

            using SqlConnection conn = DBConnection.GetConnection();
            string query = "UPDATE Task SET ProjectID = @projectid, EmployeeID = @employeeid WHERE TaskID = @taskid";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskid", taskid);
            cmd.Parameters.AddWithValue("@employeeid", employeeid);
            cmd.Parameters.AddWithValue("@projectid", projectid);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine($"{result} Task Assigned Sucessfully.");

        }
    }

}
