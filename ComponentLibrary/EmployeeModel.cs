using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class EmployeeModel
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public int employee_Id { get; set; }
        public int contact_number { get; set; }
        public DateTime birthday { get; set; }
        public decimal monthly_salary { get; set; } = 0;
        public int no_of_overtime_hours { get; set; } = 0;
        public decimal allowances { get; set; } = 0;
        public decimal no_pay_value { get; set; } = 0;
        public decimal base_pay_value { get; set; } = 0;
        public decimal gross_pay { get; set; } = 0;
        public decimal total_salary { get; set; } = 0;
        public int no_of_absent_days { get; set; } = 0;
        public int no_of_leaves_an_employee_has_taken { get; set; } = 0;
        public int no_of_remaining_leaves { get; set; } = 0;
    }
}
