using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Employee_Management_System_Data_Access_Layer;

namespace Employe_Management_System_Bussiness_Logic_Layer
{
    public class DepartmentBLL
    {

        DepartmentDAL dept = new DepartmentDAL();

        public bool ValidDepartment(string name)
        {
            return dept.ValidDepartment(name);
        }

        public void Add(string name,int id, string description)
        {
             dept.Add(name,id,description);
        }

        public void Update(string name, string updatedname, string description)
        {
            dept.Update(name,updatedname,description);
        }

        public void Delete(string name)
        {
            dept.delete(name);
        }
    }
}
