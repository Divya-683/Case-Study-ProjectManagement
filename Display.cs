using ProjectManagement.Models;
using ProjectManagement.Utility;
using System;
using System.Data.SqlClient;

namespace ProjectManagement.DAO
{
    public class Display
    {
        public static void DisplayEmployee()
        {
            using SqlConnection conn = DBConnection.GetConnection();
            string query = "SELECT * FROM Employee";

            using SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\nEmployee Details:");
            while (reader.Read())
            {
                Console.WriteLine($"EmployeeID: {reader["EmployeeID"]}, Name: {reader["Name"]}, Designation: {reader["Designation"]}, Gender: {reader["Gender"]},Salary: {reader["Salary"]},ProjectID: {reader["ProjectID"]}");
            }
        }
        public static void DisplayProject()
        {
            using SqlConnection con = DBConnection.GetConnection();
            string query = "SELECT * FROM Project";

            using SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\nProject Details:");
            while (reader.Read())
            {
                Console.WriteLine($"ProjectID: {reader["ProjectID"]}, ProjectName: {reader["ProjectName"]},Description: {reader["Description"]}, StartDate: {reader["StartDate"]},Status: {reader["Status"]}");
            }
        }
        public static void DisplayTask()
        {
            using SqlConnection con = DBConnection.GetConnection();
            string query = "SELECT * FROM Task";

            using SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\nTask Details:");
            while (reader.Read())
            {
                Console.WriteLine($"TaskID: {reader["TaskID"]}, TaskName: {reader["TaskName"]},ProjectID: {reader["ProjectID"]}, EmployeeID: {reader["EmployeeID"]},Status: {reader["Status"]}");
            }
        }
        public static void DisplayProjectAssigned()
        {
            string query = @"
                SELECT p.ProjectId, p.ProjectName, e.Name, t.TaskName
                FROM Task t
                JOIN Employee e ON e.EmployeeID = t.EmployeeID
                JOIN Project p ON p.ProjectID = t.ProjectID";

            using SqlConnection conn = DBConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\nProjects Assigned");
            while (reader.Read())
            {
                Console.WriteLine($"ProjectID: {reader["ProjectID"]}, ProjectName: {reader["ProjectName"]}, Name: {reader["Name"]}, TaskName: {reader["TaskName"]}");
            }
        }

    }
}