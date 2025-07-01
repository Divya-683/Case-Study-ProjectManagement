using ProjectManagement.Exceptions;
using ProjectManagement.Models;
using ProjectManagement.Utility;
using System;
using System.Data.SqlClient;

namespace ProjectManagement.DAO
{
    public class Delete
    {
        public static void DeleteEmployee()
        {

            Console.Write("Enter Employee ID to delete: ");
            int EmployeeID = int.Parse(Console.ReadLine());

            using SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string deleteCourses = "DELETE FROM Employee WHERE EmployeeID = @id";
            using SqlCommand cmd1 = new SqlCommand(deleteCourses, conn);
            cmd1.Parameters.AddWithValue("@id", EmployeeID);
            cmd1.ExecuteNonQuery();
            Console.WriteLine("Employee deleted.");
        }
            
        public static void DeleteTask()
        {
            
                Console.Write("Enter Task ID to delete: ");
                int TaskID = int.Parse(Console.ReadLine());

                using SqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string deleteCourses = "DELETE FROM Task WHERE TaskID = @id";
                using SqlCommand cmd1 = new SqlCommand(deleteCourses, conn);
                cmd1.Parameters.AddWithValue("@id", TaskID);
                cmd1.ExecuteNonQuery();
                Console.WriteLine("Task deleted.");

                
        }

    }
    }