
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee_LIst:Employee_Properties
    {
        public List<Employee_LIst> EmployeeMethod()
        {
            List<Employee_LIst> listEmployee_LIst = new List<Employee_LIst>
            {
                new Employee_LIst{ Employee_Name="Mounika",Age=35,Gender='F', Department_id=1},
                new Employee_LIst{ Employee_Name="Shravan",Age=25,Gender='M', Department_id=2},
                new Employee_LIst{ Employee_Name="Vinay",Age=22,Gender='M', Department_id=3},
                new Employee_LIst{ Employee_Name="Durga",Age=15,Gender='F', Department_id=4},
                new Employee_LIst{ Employee_Name="Dawood",Age=22,Gender='M', Department_id=5},
                new Employee_LIst{ Employee_Name="Shilpa",Age=40,Gender='F', Department_id=6}

            };
            return listEmployee_LIst;
        }
    }
}
