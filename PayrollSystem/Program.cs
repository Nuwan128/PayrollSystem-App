

using PayrollSystem.Models;


namespace PayrollSystem
{
    public class Program
    {
        public static List<EmployeeModel> employees = new List<EmployeeModel>();
        static void Main(string[] args)
        {
            

            DisplayMessage();

            GettingEmployeeDetails();

            DisplayAllEmployeeDetails();

            SerachEmployee();
            //displayemplyoees
            //searchemplyeoo
        }

        private static void SerachEmployee()
        {
            string firstName = RequestStringFromConsol("Enter the first name for search : ");
            string lastName = RequestStringFromConsol("Enter the last name for search : ");

            foreach (EmployeeModel employee in employees)
            {
                if ((employee.FirstName.ToLower() == firstName.ToLower()) && (employee.LastName.ToLower() == lastName.ToLower()))
                {
                    Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Address: {employee.Address}, WorkID: {employee.WorkID}, Monthly Salary: {employee.MonthlySalary}, No. of Overtime Hours: {employee.no_of_overtime_hours}, Allowances: {employee.Allowances}, No Pay Value: {employee.No_pay_value}, Base Pay Value: {employee.Base_Pay_value}, Gross Pay: {employee.GrossPay}, Total Salary: {employee.Total_Salary}, No. of Absent Days: {employee.No_of_absent_days}, No. of Leaves Taken: {employee.no_of_leaves_an_employee_has_taken}, No. of Remaining Leaves: {employee.no_of_remaining_leaves}");

                }
                
            }

        }

        private static void DisplayAllEmployeeDetails()
        {
            foreach (EmployeeModel employee in employees)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Address: {employee.Address}, WorkID: {employee.WorkID}, Monthly Salary: {employee.MonthlySalary}, No. of Overtime Hours: {employee.no_of_overtime_hours}, Allowances: {employee.Allowances}, No Pay Value: {employee.No_pay_value}, Base Pay Value: {employee.Base_Pay_value}, Gross Pay: {employee.GrossPay}, Total Salary: {employee.Total_Salary}, No. of Absent Days: {employee.No_of_absent_days}, No. of Leaves Taken: {employee.no_of_leaves_an_employee_has_taken}, No. of Remaining Leaves: {employee.no_of_remaining_leaves}");
                Console.WriteLine();
            }
        }

        public static void DisplayMessage()
        {
            Console.WriteLine("\t-------------------\n\t   Grifindo Toys\n\t-------------------");
            
            Console.WriteLine("\t" + DateTime.Now);
            Console.WriteLine();
        }
        public static int RequestIntFromConsol(string message)
        {
            
            bool isValid = false;
            string Text = "";

            Console.Write(message);

            Text = Console.ReadLine();
            isValid = int.TryParse(Text, out int output);
            while (isValid == false)
            {
                Console.WriteLine("please enter again.");
                Console.Write(message);
                Text = Console.ReadLine();
                isValid = int.TryParse(Text, out output);

            }
            return output;

        }
        public static decimal RequestDecimalFromConsol(string message)
        {

            bool isValid = false;
            string Text = "";

            Console.Write(message);

            Text = Console.ReadLine();
            isValid = decimal.TryParse(Text, out decimal output);
            while (isValid == false)
            {
                Console.WriteLine("please enter again.");
                Console.Write(message);
                Text = Console.ReadLine();
                isValid = decimal.TryParse(Text, out output);

            }
            return output;

        }
        public static string RequestStringFromConsol(string message)
        {
            string Text = "";
            Console.Write(message);
            Text = Console.ReadLine();
            
            return Text;

        }
        private static SettingsModel SetupTheSettings()
        {
            Console.WriteLine("Please Set up the follwing Settings?  ");
            Console.WriteLine();

            SettingsModel settings = new SettingsModel
            {
                salary_cycle_date_range = RequestIntFromConsol("Enter the salary cycle date range : "),//30
                Salary_cycle_begin_date = RequestIntFromConsol("Enter the salary cycle start date : "),
                Salary_cycle_end_date = RequestIntFromConsol("Enter the salary cycle end date : "),
                leaves_for_an_employee_for_year = RequestIntFromConsol("How many leaves for an employee for a year : "),
                government_tax_rate = RequestDecimalFromConsol("Enter the government tax rate : "),
                Over_time_rate = RequestDecimalFromConsol("Enter the over time rate : "),
                no_of_holidays = RequestIntFromConsol("Enter the number of holidays : ")

            };
            Console.WriteLine("--settigs are setuped--");
            return settings;
           

        }
        private static void GettingEmployeeDetails()
        {
            SettingsModel settings = SetupTheSettings();

            Console.WriteLine();  
            int employeeCount = RequestIntFromConsol("How many employees are working ? ");//50
            Console.WriteLine();

            for (int i = 0; i < employeeCount; i++)
            {
                Console.Clear();
                EmployeeModel employee = new EmployeeModel();

                Console.WriteLine($"---Enter the employee_{i+1} details---");
                Console.WriteLine();
                

                employee.FirstName = RequestStringFromConsol("Enter the employee first name : ");
                employee.LastName = RequestStringFromConsol("Enter the employee last name : ");
                employee.Address = RequestStringFromConsol("Enter the employee address : ");
                employee.WorkID = RequestIntFromConsol("Enter the employee work Id : ");
                employee.MonthlySalary = RequestDecimalFromConsol($"Enter the {employee.FirstName} {employee.LastName}'s monthly salary : ");
                employee.Allowances = RequestDecimalFromConsol($"Enter the {employee.FirstName} {employee.LastName}'s total allowances : ");
                employee.No_of_absent_days = RequestIntFromConsol($"Enter the {employee.FirstName} {employee.LastName}'s number of absent days : ");
                employee.Base_Pay_value = SalaryComponent.CalculateBasePayValue(employee.MonthlySalary,employee.Allowances,employee.no_of_overtime_hours,settings.Over_time_rate);
                employee.Total_Salary = SalaryComponent.CalculateTotalSalary(employee.Base_Pay_value,employee.Allowances, employee.no_of_overtime_hours, settings.Over_time_rate);
                employee.no_of_leaves_an_employee_has_taken = SalaryComponent.NoOfLeavesHasTaken(employee.No_of_absent_days, settings.no_of_holidays);
                employee.no_of_remaining_leaves = SalaryComponent.RemainingLeaves(employee.no_of_leaves_an_employee_has_taken,settings.leaves_for_an_employee_for_year);
                hasWorkOverTime(employee);
                CoverSalaryCycle(employee,settings);
                employee.GrossPay = SalaryComponent.CalculateGrossPay(employee.Base_Pay_value,employee.No_pay_value,settings.government_tax_rate);

                employees.Add(employee);
                Console.Clear();
            }
        }

        public static void hasWorkOverTime(EmployeeModel employee)
        {
            string hasWorkedOverTime = "";
            do
            {
                hasWorkedOverTime = RequestStringFromConsol("If an employee has worked any overtime hours (yes/no)? : ");

                if (hasWorkedOverTime.ToLower() == "yes")
                {
                    employee.no_of_overtime_hours = RequestIntFromConsol($"Enter the {employee.FirstName} {employee.LastName}'s number of overtime hours : ");
                }
                else if (hasWorkedOverTime == "no")
                {
                    employee.no_of_overtime_hours = 0;
                }
                Console.WriteLine("--please try agian--");
            } while (((hasWorkedOverTime.ToLower() != "yes") && (hasWorkedOverTime != "no")));



        }
        public static void CoverSalaryCycle(EmployeeModel employee, SettingsModel settings)
        {
            if (settings.salary_cycle_date_range <= (settings.Salary_cycle_end_date - settings.Salary_cycle_begin_date))
            {
                Console.WriteLine("--An employee cover salary cycle date range --");
                employee.No_pay_value = 0;
            }
            else
            {
                employee.No_pay_value = SalaryComponent.CalculateNoPayValue(employee.Total_Salary, employee.No_of_absent_days, settings.salary_cycle_date_range);
            }

        }
    }
}