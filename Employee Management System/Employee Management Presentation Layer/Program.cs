using Employe_Management_System_Bussiness_Logic_Layer;
using System;
using System.ComponentModel.Design;
namespace Employee_Management_System_Presentation_Layer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=>Welcome to Employee Management System<=");
            DepartmentBLL department = new DepartmentBLL();
            EmployeeBLL Emp = new EmployeeBLL();
            List<string[]> list = new List<string[]>();

            Console.WriteLine("\n");
            while (true)
            {
                Console.WriteLine("\n"+
                    "1. List All Employees\n" +
                    "2. Add New Employee\n" +
                    "3. Update Employee Details\n" +
                    "4. Delete Employee\n" +
                    "5. Search Employees\n" +
                    "6. Manage Departments\n" +
                    "7. To Exit"
                    );

                Console.WriteLine("\n");
                Console.Write("Enter your choice: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("List of all employee is here!");
                    list = null;
                    list = Emp.ShowAllEmployee();
                    foreach (string[] emp in list)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine(
                            $"Employee Name: {emp[0]}\n" +
                            $"Employee ID: {emp[1]}\n" +
                            $"Employee Age: {emp[2]}\n" +
                            $"Employee Department: {emp[3]}\n" +
                            $"Employee Salary: {emp[4]}\n" +
                            $"Employee Joining Date: {emp[5]}\n" +
                            $"Employee Project Duration: {emp[6]}\n"
                            );
                    }

                }

                else if (option == 2)
                {
                    Console.WriteLine("\n");
                    Console.Write("Enter the Employee Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Enter the Employee ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Employee Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Employee Department: ");
                    string? dept = Console.ReadLine();
                    Console.Write("Enter the Employee Salary: ");
                    string? salary = Console.ReadLine();
                    Console.Write("Enter the Employee Joining Date(dd/mm/yyyy): ");
                    string? date = Console.ReadLine();
                    DateTime ProjectDuration = DateTime.Now.AddHours(9);
                    bool result = Emp.Save(name, id, age, dept, salary, date, ProjectDuration);
                    if (result)
                    {
                        Console.WriteLine($"Employee {name} is added successfully");
                    }
                    else
                    {
                        Console.WriteLine("Error: Employee is not added!");
                    }
                    Console.WriteLine("\n");
                }

                else if (option == 3)
                {
                    Console.WriteLine("\n");
                    Console.Write("Enter the Employee ID You want to Update: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    bool check = Emp.SearchById(ID);
                    
                    if (check)
                    {
                        Console.Write("Enter the Employee Department(you want to transfer!): ");
                        string? dept = Console.ReadLine();
                        Console.Write("Enter the Employee Updated Salary: ");
                        string? salary = Console.ReadLine();
                        DateTime ProjectDuration = DateTime.Now.AddHours(9);
                        bool result = department.ValidDepartment(dept);
                        if (result)
                        {
                            Emp.Update(ID, dept, salary, ProjectDuration);
                        }
                        else
                        {
                            Console.WriteLine("Employee department does not exist");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Id does not exist");
                    }
                }
                
                else if (option == 4)
                {
                    Console.WriteLine("\n");
                    Console.Write("Enter the Employee ID You want to Delete: ");
                    int ID = int.Parse(Console.ReadLine());

                    bool check = Emp.SearchById(ID);
                    DateTime time = DateTime.Now;
                    bool message = Emp.Enroll(time);

                    if (check && message)
                    {
                        Emp.Delete(ID);
                        Console.WriteLine("Employee Deleted Successfully");
                    }
                    else if (message == false)
                    {
                        Console.WriteLine("This Employee is part of ongoing project");
                    }
                    else
                    {
                        Console.WriteLine("Employee doesn't exist!");
                    }
                }

                else if (option == 5)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(
                        "1.Search By Id\n" +
                        "2.Search By Name\n" +
                        "3.Search By Department\n" +
                        "4.Search By Date of Joining"
                        );

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n");
                            Console.Write("Enter the Employee Id you want to search: ");
                            int id = int.Parse(Console.ReadLine());
                            list = null;
                            list = Emp.ShowAllEmployeeById(id);
                            if (list.Count > 0)
                            {

                                foreach (string[] emp in list)
                                {
                                    Console.WriteLine(
                                        $"Employee Name: {emp[0]}\n" +
                                        $"Employee ID: {emp[1]}\n" +
                                        $"Employee Age: {emp[2]}\n" +
                                        $"Employee Department: {emp[3]}\n" +
                                        $"Employee Salary: {emp[4]}\n" +
                                        $"Employee Joining Date: {emp[5]}" +
                                        $"Employee Project Duration: {emp[6]}\n"
                                        );
                                }

                            }
                            else
                            {
                                Console.WriteLine($"Employee with ID: {id} does not exist");
                            }

                            break;
                        case 2:
                            Console.Write("Enter the Employee name you want to search: ");
                            string name = Console.ReadLine();
                            list = null;
                            list = Emp.ShowAllEmployeeByName(name);
                            if (list.Count > 0)
                            {

                                foreach (string[] emp in list)
                                {
                                    Console.WriteLine(
                                        $"Employee Name: {emp[0]}\n" +
                                        $"Employee ID: {emp[1]}\n" +
                                        $"Employee Age: {emp[2]}\n" +
                                        $"Employee Department: {emp[3]}\n" +
                                        $"Employee Salary: {emp[4]}\n" +
                                        $"Employee Joining Date: {emp[5]}" +
                                        $"Employee Project Duration: {emp[6]}\n"
                                        );
                                }
                            }

                            else
                            {
                                Console.WriteLine($"Employee with Name: {name} does not exist");
                            }
                            break;
                        case 3:
                            Console.Write("Enter the Employee Department Name you want to search: ");
                            string deptname = Console.ReadLine();
                            list = null;
                            list = Emp.ShowAllEmployeeByDeptName(deptname);
                            if (list.Count > 0)
                            {
                                foreach (string[] emp in list)
                                {
                                    Console.WriteLine(
                                        $"Employee Name: {emp[0]}\n" +
                                        $"Employee ID: {emp[1]}\n" +
                                        $"Employee Age: {emp[2]}\n" +
                                        $"Employee Department: {emp[3]}\n" +
                                        $"Employee Salary: {emp[4]}\n" +
                                        $"Employee Joining Date: {emp[5]}" +
                                        $"Employee Project Duration: {emp[6]}\n"
                                        );
                                }


                            }
                            else
                            {
                                Console.WriteLine($"Employee with department name: {deptname} does not exist");
                            }
                            break;
                        case 4:
                            Console.WriteLine("\n");
                            Console.Write("Enter the Employee Date of joining(dd/mm/yyyy) you want to search: ");
                            string date = Console.ReadLine();
                            list = null;
                            list = Emp.ShowAllEmployeeByDate(date);
                            if (list.Count > 0)
                            {
                                foreach (string[] emp in list)
                                {
                                    Console.WriteLine(
                                        $"Employee Name: {emp[0]}\n" +
                                        $"Employee ID: {emp[1]}\n" +
                                        $"Employee Age: {emp[2]}\n" +
                                        $"Employee Department: {emp[3]}\n" +
                                        $"Employee Salary: {emp[4]}\n" +
                                        $"Employee Joining Date: {emp[5]}" +
                                        $"Employee Project Duration: {emp[6]}\n"
                                        );
                                }


                            }
                            else
                            {
                                Console.WriteLine($"Employee with date of joining: {date} does not exist");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }

                else if (option == 6)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(
                        "1.Add Department\n" +
                        "2.Update Department\n" +
                        "3.Remove Department\n"
                        );

                    Console.Write("Enter Your Choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n");
                            Console.Write("Enter Department Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Department Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Department description: ");
                            string description = Console.ReadLine();
                            department.Add(name, id, description);
                            break;

                        case 2:
                            Console.WriteLine("\n");
                            Console.Write("Enter Department Name you want to update: ");
                            string name1 = Console.ReadLine();

                            bool result = department.ValidDepartment(name1);
                            if (result)
                            {

                                Console.Write("Enter Department Name: ");
                                string name2 = Console.ReadLine();
                                Console.Write("Enter Department description: ");
                                string description2 = Console.ReadLine();
                                department.Update(name1, name2, description2);
                            }
                            else
                            {
                                Console.WriteLine($"The department: {name1} does not exist");
                            }
                            break;
                        case 3:
                            Console.WriteLine("\n");
                            Console.Write("Enter Department Name you want to delete: ");
                            string name3 = Console.ReadLine();
                            bool result1 = department.ValidDepartment(name3);
                            if (result1)
                            {
                                department.Delete(name3);
                                Console.WriteLine("Delete Successful");
                            }
                            else
                            {
                                Console.WriteLine($"The department: {name3} does not exist");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }


                }
                else if(option == 7)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Good Bye");
                    break;
                }

                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Invalid Choice");
                }
            }
           
        }
    }
}