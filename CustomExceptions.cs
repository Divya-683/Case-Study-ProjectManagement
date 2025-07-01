using System;

namespace ProjectManagement.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(int EmployeeID)
            : base($"Employee with ID {EmployeeID} not found.") { }
    }

    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException(int TaskID)
            : base($"Task with ID {TaskID} not found.") { }
    }

    public class ProjectNotFoundException : Exception
    {
        public ProjectNotFoundException(int ProjectID)
            : base($"Task with ID {ProjectID} not found.") { }
    }
}

