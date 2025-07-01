using ProjectManagement.DAO;

namespace ProjectManagement
{
    public class MainProgram
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n------ MENU ------");
                Console.WriteLine("1. Add Project");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("3. Add Task");
                Console.WriteLine("4. Assign project to employee ");
                Console.WriteLine("5. Assign Task");
                Console.WriteLine("6. Display Employee Details");
                Console.WriteLine("7. Display Project Details");
                Console.WriteLine("8. Display Task Details");
                Console.WriteLine("9. Delete Employee");
                Console.WriteLine("10. Delete Task");
                Console.WriteLine("11. List all projects assigned with tasks to an employeee ");


                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Create.CreateProject();
                        Console.WriteLine("Project Created SucessFully");
                        break;
                    case "2":
                        Create.CreateEmployee();
                        Console.WriteLine("Employee Data Created SucessFully");
                        break;
                    case "3":
                        Create.CreateTask();
                        Console.WriteLine("Task Created Sucessfully");
                        break ;
                    case "4":
                        Assign.AssignProject();
                        break;
                    case "5":
                        Assign.AssignTask();
                        break;
                    case "6":
                        Display.DisplayEmployee();
                        break;
                    case "7":
                        Display.DisplayProject();
                        break;
                    case "8":
                        Display.DisplayTask();
                        break;
                    case "9":
                        Delete.DeleteEmployee();
                        break;
                    case "10":
                        Delete.DeleteTask();
                        break;
                    case "11":
                        Display.DisplayProjectAssigned();
                        break;
                    case "12":
                        exit = true;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            }

        }
    }
}