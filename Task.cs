using ProjectManagement.Models;

namespace ProjectManagement.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public string Status { get; set; }

    }
}

