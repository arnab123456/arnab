using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    /// <summary>
    /// Purpose: To Create an Entity Class with the Properties
    /// </summary>
    public class EmployeeInfo
    {
        //Property for EmployeeID
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public DateTime DOJ { get; set; }
        public long PhoneNo { get; set; }

    }
}
