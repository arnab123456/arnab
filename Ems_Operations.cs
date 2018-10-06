using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using EmployeeException;
namespace EMSDAL
{
    /// <summary>
    /// To Create Functions or Methods for EMployee Mngt System
    /// </summary>
    public class Ems_Operations
    {
        public static List<EmployeeInfo> employeeList = new List<EmployeeInfo>();
        /// <summary>
        /// Function to Add/Insert New Employee into the List
        /// </summary>
        /// <param name="newemployee"></param>
        /// <returns></returns>
        public static bool AddEmployee(EmployeeInfo newemployee)
        {
            bool empadded = false;
            try
            {
                employeeList.Add(newemployee);
                empadded = true;
            }
            catch (EmpException)

            { throw; }
            return empadded;
        }

        public static  List<EmployeeInfo> DisplayEmployee()
        {
          
                      
                    return employeeList;
        
        }
    }
}
