using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class SalaryComponent
    {
        public static decimal BasePayValue(decimal monthly_salary, decimal allowances, int no_of_overtime_hours, decimal over_time_rate)
        {
            decimal output = 0;
            output = monthly_salary + allowances + (over_time_rate * no_of_overtime_hours);
            return output;
        }

        public static decimal CalculateGrossPay(decimal base_pay_value, decimal no_pay_value, decimal government_tax_rate)
        {
            decimal output = 0;
            output = base_pay_value - (no_pay_value + base_pay_value * government_tax_rate);
            return output;
        }

        public static decimal CalculateNoPayValue(decimal total_salary, int no_of_absent_days, int salary_cycle_date_range)
        {
            decimal output = 0;
            output = (total_salary / salary_cycle_date_range) * no_of_absent_days;
            return output;
        }

        public static decimal CalculateTotalSalary(decimal base_pay_value, decimal allowances, int no_of_overtime_hours, decimal over_time_rate)
        {
            decimal output = 0;
            decimal overtimePay = no_of_overtime_hours * over_time_rate + allowances;
            output = base_pay_value + overtimePay;
            return output;
        }

        public static int NoOfLeavesHasTaken(int no_of_absent_days, int no_of_holidays)
        {
            int output = 0;
            output = no_of_absent_days + no_of_holidays;
            return output;
        }

        public static int RemainingLeaves(int no_of_leaves_an_employee_has_taken, int leaves_for_an_employee_for_year)
        {
            int output = 0;
            output = leaves_for_an_employee_for_year - no_of_leaves_an_employee_has_taken;
            return output;
        }
    }
}
