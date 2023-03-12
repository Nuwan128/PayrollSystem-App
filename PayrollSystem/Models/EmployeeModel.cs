using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int WorkID { get; set; }
        public decimal MonthlySalary { get; set; }
        public int no_of_overtime_hours { get; set; }
        public decimal Allowances { get; set; }
        public decimal No_pay_value { get; set; }
        public decimal Base_Pay_value { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Total_Salary { get; set; }

        public int No_of_absent_days { get; set; }

        public int no_of_leaves_an_employee_has_taken { get; set; }
        public int no_of_remaining_leaves { get; set; }

        //public List<SettingsModel> Settings { get; set; }
    }
}
