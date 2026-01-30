using System;
using System.IO;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
namespace Employee_Management_System_Data_Access_Layer
{
    public class EmployeeDAL
    {
        public void Save(string name, int id, int age, string department, string salary, string date,DateTime time)
        {
            StreamWriter fs = new StreamWriter("Employee.txt", true);
            string data = $"{name},{id},{age},{department},{salary},{date},{time}";
            fs.WriteLine(data);
            fs.Close();
        }

        public List<string[]> ShowAllEmployee()
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                list.Add(data);
                line = fs.ReadLine();
            }
            fs.Close();
            return list;
        }


        public List<string[]> ShowAllEmployeeById(int id)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (id == int.Parse(data[1]))
                {
                
                    list.Add(data);
                    
                }
                line = fs.ReadLine();
            }
            fs.Close();
            return list;
        }



        public List<string[]> ShowAllEmployeeByName(string name)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (name == data[0])
                {

                    list.Add(data);

                }
                line = fs.ReadLine();
            }
            fs.Close();
            return list;
        }

        public List<string[]> ShowAllEmployeeByDeptName(string name)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (name == data[3])
                {

                    list.Add(data);

                }
                line = fs.ReadLine();
            }
            fs.Close();
            return list;
        }


        public List<string[]> ShowAllEmployeeByDate(string date)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (date == data[5])
                {

                    list.Add(data);

                }
                line = fs.ReadLine();
            }
            fs.Close();
            return list;
        }


        public bool SearchById(int id)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            bool answer = false;
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (id == int.Parse(data[1]))
                {
                    answer = true;
                }
                line = fs.ReadLine();
            }
            fs.Close();
            return answer;
        }


        public void Update(int id,string department, string salary,DateTime time)
        {
            List<string[]> list = new List<string[]>();
            list = ShowAllEmployee();
            StreamWriter fs = new StreamWriter("Employee.txt", false);
            foreach (string[] emp in list) 
            {
                if (id != int.Parse(emp[1]))
                {
                    fs.WriteLine(string.Join(",", emp));
                }
                else
                {
                    emp[3] = department;
                    emp[4] = salary;
                    emp[6] = time.ToString("yyyy-MM-dd HH:mm:ss");
                    fs.WriteLine(string.Join(",", emp));
                }
                
            }
            fs.Close();
        }
        public void Delete(int id)
        {
            List<string[]> list = new List<string[]>();
            list = ShowAllEmployee();
            StreamWriter fs = new StreamWriter("Employee.txt", false);
            foreach (string[] emp in list)
            {
                if (id != int.Parse(emp[1]))
                {
                    fs.WriteLine(string.Join(",", emp));
                }
               

            }
            fs.Close();
        }

        public bool Enroll(DateTime time)
        {
            StreamReader fs = new StreamReader("Employee.txt");
            List<string[]> list = new List<string[]>();
            bool answer = false;
            string line = fs.ReadLine();
            while (line != null)
            {
                string[] data = line.Split(',');
                if (time >= DateTime.Parse(data[6]))
                {
                    answer = true;
                }
                line = fs.ReadLine();
            }
            fs.Close();
            return answer;
        }
    }
}
