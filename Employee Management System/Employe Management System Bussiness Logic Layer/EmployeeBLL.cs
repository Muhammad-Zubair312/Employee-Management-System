using System;
using System.Text.RegularExpressions;
using Employee_Management_System_Data_Access_Layer;
namespace Employe_Management_System_Bussiness_Logic_Layer
{
    public class EmployeeBLL
    {
        EmployeeDAL emp = new EmployeeDAL();
        DepartmentBLL dept = new DepartmentBLL();
        public bool Save(string name, int id, int age, string department, string salary, string date,DateTime time)
        {
            string pattern = @"^[A-Za-z\s]+$";
            if (name != null && Regex.IsMatch(name,pattern) &&   age > 18 && age < 60 && dept.ValidDepartment(department))
            {
                emp.Save(name, id, age, department, salary, date, time);
                return true;
            }
            return false;
          
        }

        public List<string[]> ShowAllEmployee()
        {
            return emp.ShowAllEmployee();
        }


        public List<string[]> ShowAllEmployeeById(int id)
        {
            return emp.ShowAllEmployeeById(id);
        }

        public List<string[]> ShowAllEmployeeByName(string name)
        {
            return emp.ShowAllEmployeeByName(name);
        }

        public List<string[]> ShowAllEmployeeByDeptName(string name)
        {
            return emp.ShowAllEmployeeByDeptName(name);
        }


        public List<string[]> ShowAllEmployeeByDate(string date)
        {
            return emp.ShowAllEmployeeByDate(date);
        }

        public bool SearchById(int id)
        {
            return emp.SearchById(id);
        }

        public void Update(int id, string department, string salary, DateTime time)
        {

            emp.Update(id,department, salary,time);

        }

        public void Delete(int id)
        {
          emp.Delete(id);
        }

        public bool Enroll(DateTime time)
        {
        
            return emp.Enroll(time);
        
        }
    }
}
