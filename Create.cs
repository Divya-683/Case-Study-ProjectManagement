using ProjectManagement.Models;
using ProjectManagement.Utility;
using System;
using System.Data.SqlClient;

namespace ProjectManagement.DAO
{
    public class Create
    {
        public static void CreateEmployee()
        {
            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter Salary: ");
            int salary = int.Parse(Console.ReadLine());

            int EmployeeID = 0;

            using SqlConnection conn = DBConnection.GetConnection();

            // Insert Employee
            string studentQuery = "INSERT INTO Employee (Name,Designation,Gender,Salary) OUTPUT INSERTED.EmployeeID VALUES (@name, @designation,@gender,@salary)";
            using SqlCommand cmd = new SqlCommand(studentQuery, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@salary", salary);
          
            conn.Open();
            EmployeeID = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        public static void CreateProject()
        {
            Console.Write("Enter ProjectName: ");
            string projectname = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Start Date (YYYY-MM-DD): ");
            string startdate = Console.ReadLine();

            Console.Write("Enter Status: ");
            string status = Console.ReadLine();

            int ProjectID = 0;

            using SqlConnection conn = DBConnection.GetConnection();

            // Insert Project
            string studentQuery = "INSERT INTO Project ( ProjectName,Description,StartDate,Status) OUTPUT INSERTED.ProjectID VALUES (@projectname, @description,@startdate,@status)";
            using SqlCommand cmd = new SqlCommand(studentQuery, conn);
            cmd.Parameters.AddWithValue("@projectname", projectname);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@startdate", startdate);
            cmd.Parameters.AddWithValue("@status", status);

            conn.Open();
            ProjectID = (int)cmd.ExecuteScalar();
            conn.Close();
        }
        public static void CreateTask()
        {
            Console.Write("Enter Task: ");
            string taskname = Console.ReadLine();

            //Console.Write("Enter ProjectID: ");
            //int projectid = int.Parse(Console.ReadLine());

            //Console.Write("Enter EmployeeID: ");
            //int employeeid = int.Parse(Console.ReadLine());

            Console.Write("Enter Status: ");
            string status = Console.ReadLine();

            int TaskID = 0;

            using SqlConnection conn = DBConnection.GetConnection();

            // Insert Task
            string studentQuery = "INSERT INTO Task ( TaskName,Status) OUTPUT INSERTED.TaskID VALUES (@taskname, @status)";
            
            using SqlCommand cmd = new SqlCommand(studentQuery, conn);
            
            cmd.Parameters.AddWithValue("@taskname", taskname);
            //cmd.Parameters.AddWithValue("@projectid", projectid);
            //cmd.Parameters.AddWithValue("@employeeid", employeeid);
            cmd.Parameters.AddWithValue("@status", status);

            conn.Open();
            TaskID = (int)cmd.ExecuteScalar();
            conn.Close();

        }

        internal bool CreateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}