using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Employee_Management_System_Data_Access_Layer
{
    public class DepartmentDAL
    {

        public void Add(string name, int id, string description)
        {   
                StreamWriter fs = new StreamWriter("Department.txt", true);
                string data = $"{name},{id},{description}";
                fs.WriteLine(data);
                fs.Close();
            
        }


        public bool delete(string name)
        {
            bool result = ValidDepartment(name);
            if (result)
            {

                List<string[]> list = new List<string[]>();
                list = GetAllDepartment();
                StreamWriter fs = new StreamWriter("Department.txt", false);
                foreach (string[] emp in list)
                {
                    if (name != emp[0])
                    {
                        fs.WriteLine(string.Join(",", emp));
                    }


                }
                fs.Close();

            }
            return result;

        }

        public List<string[]> GetAllDepartment()
        {
            StreamReader fs = new StreamReader("Department.txt");
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

        public bool ValidDepartment(string name)
        {
            bool valid = false;
            var list = GetAllDepartment();
            foreach(var portion in list)
            {
                if(name == portion[0])
                {
                    valid = true; 
                    break;
                }
            }
            return valid;
        }

        
        public void Update(string name, string updatedname,string description)
        {
            List<string[]> list = new List<string[]>();
            list = GetAllDepartment();
            StreamWriter fs = new StreamWriter("Employee.txt", false);
            string data = $"{updatedname},{description}";
            foreach (string[] emp in list)
            {
                if (name != emp[0])
                {
                    fs.WriteLine(string.Join(",", emp));
                }
                else
                {
                    emp[0] = updatedname;
                    emp[2] = description;
                    fs.WriteLine(string.Join(",", emp));
                }

            }
            fs.Close();
        }
        
       
    }
}
