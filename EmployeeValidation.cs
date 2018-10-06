using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using EmployeeException;
using EMSDAL;
using System.Text.RegularExpressions;
namespace EMS_BLL
{
 /// <summary>
 /// Purpose: To create a Business Class to Validate the input and access the DAL methods
 /// Author:Capgemini
 /// Creation Date: 13-Oct-2016
 /// </summary>
    public class EmployeeValidation
    {
        /// <summary>
        /// Function to Validate the Employee Information as per the requirement
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>bool</returns>
        public static bool ValidateEmployee(EmployeeInfo employee)
        {
            //Boolean Variable to get the Validation result
            bool isValidEmployee = true;
            //StringBuilder object initialized to append the Error messages
            StringBuilder message = new StringBuilder();
            //To Check the blankness od EmployeeId
            if(employee.EmployeeID.ToString().Equals(string.Empty)||employee.EmployeeID<=0)
            {
                isValidEmployee =false;
                message.Append(Environment.NewLine+"Employee ID is Required and cannot be 0");
            }
            //To Check the blankness of EmployeeName
            if (employee.EmployeeName.ToString().Equals(string.Empty))
            {
                isValidEmployee = false;
                message.Append(Environment.NewLine + "Employee Name is Required and cannot be blank");
            }
            //To Check the blankness of PhoneNo
            if (employee.PhoneNo.ToString().Equals(string.Empty))
            {
                isValidEmployee = false;
                message.Append(Environment.NewLine + "Phone Number is Required and cannot be blank");
            }
            //To check whether the EmployeeName consists of only Alphabets
            if(!Regex.IsMatch(employee.EmployeeName.ToString(),"^[A-Z][A-Za-z]+$" ))
            {
            isValidEmployee =false;
            message.Append(Environment.NewLine + "EmployeeName must Contain only Alphabets and start with capital letter");
            }
            //
            DateTime dt = DateTime.Now ;
            if (employee.DOJ.Date > dt.Date)
            {
                isValidEmployee = false;
                message.Append(Environment.NewLine + "Date of Joining must be less than today's Date");
            }

            if (isValidEmployee == false)
            { throw new EmpException(message.ToString()); }

            return isValidEmployee;
        
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newemp"></param>
        /// <returns>bool</returns>
        public static bool AddEmployeeBL(EmployeeInfo newemp)
        {
            bool isAdded = false ;

            try
            {
                if (ValidateEmployee(newemp))
                    isAdded = Ems_Operations.AddEmployee(newemp);


            }
            catch (EmpException ex)
            {
                throw ex; 
            }
            return isAdded;
        
        }

        public static List<EmployeeInfo> DisplayEmployeeBL()
        {
            List<EmployeeInfo> empList = new List<EmployeeInfo>();

            try 
            {

                empList = Ems_Operations.DisplayEmployee();
                if (empList == null)
                    throw new EmpException("No Employee Record Found");

            }
            catch (EmpException e)
            { throw e; }

            return empList;
             
        
        }
    }
}
