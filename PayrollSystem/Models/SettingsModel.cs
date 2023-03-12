using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class SettingsModel
    {
        public int salary_cycle_date_range { get; set; }
        public int Salary_cycle_begin_date { get; set; }
        public int Salary_cycle_end_date { get; set; }
        public int leaves_for_an_employee_for_year { get; set; }
        public decimal government_tax_rate { get; set; }
        public decimal Over_time_rate { get; set; }

        public int no_of_holidays { get; set; }

    }
}
