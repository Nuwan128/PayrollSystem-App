using ComponentLibrary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollSystem
{
    public partial class RegisterEmployee : Form
    {
        BindingList<EmployeeModel> employees = new BindingList<EmployeeModel>();
        //public SettingsModel _settings;
        private ISettings _setsettings;
        public RegisterEmployee(ISettings setsettings)
        {
            
            InitializeComponent();
            employeeCountLabel.Text = $"Emp_1";
            _setsettings= setsettings;

        }
        
        private void RegisteEmployeeSaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                

                if (string.IsNullOrWhiteSpace(employeeIdTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    employeeIdTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    firstNameTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    lastNameTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(birthdayPiker.Text))
                {
                    MessageBox.Show("Fill Again");
                    birthdayPiker.Focus();
                }
                else if (string.IsNullOrWhiteSpace(addressTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    addressTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(contactNumberTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    contactNumberTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(monthlySalaryTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    monthlySalaryTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(overtimeHoursTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    overtimeHoursTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(allowancesTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    allowancesTextBox.Focus();
                }
                else if (string.IsNullOrWhiteSpace(absentDaysTextBox.Text))
                {
                    MessageBox.Show("Fill Again");
                    absentDaysTextBox.Focus();
                }
                else
                {
                    
                    EmployeeModel employee = new EmployeeModel
                    {
                        employee_Id = int.Parse(employeeIdTextBox.Text),
                        first_name = firstNameTextBox.Text,
                        last_name = lastNameTextBox.Text,
                        address = addressTextBox.Text,
                        contact_number = int.Parse(contactNumberTextBox.Text),
                        birthday = DateTime.Parse(birthdayPiker.Value.ToString()),
                        monthly_salary = decimal.Parse(monthlySalaryTextBox.Text),
                        no_of_overtime_hours = int.Parse(overtimeHoursTextBox.Text),
                        allowances = decimal.Parse(allowancesTextBox.Text),
                        no_of_absent_days = int.Parse(absentDaysTextBox.Text),

                        //no_of_leaves_an_employee_has_taken = SalaryComponent.NoOfLeavesHasTaken(employee.no_of_absent_days, _settings.no_of_holidays),
                        //base_pay_value = SalaryComponent.BasePayValue(employee.monthly_salary, employee.allowances, employee.no_of_overtime_hours, _settings.Over_time_rate),
                        //total_salary = SalaryComponent.CalculateTotalSalary(employee.base_pay_value, employee.allowances, employee.no_of_overtime_hours, _settings.Over_time_rate),
                        //no_of_remaining_leaves = SalaryComponent.RemainingLeaves(employee.no_of_leaves_an_employee_has_taken, _settings.leaves_for_an_employee_for_year),
                        //no_pay_value = SalaryComponent.CalculateNoPayValue(employee.total_salary, employee.no_of_absent_days, _settings.salary_cycle_date_range),
                        //gross_pay = SalaryComponent.CalculateGrossPay(employee.base_pay_value, employee.no_pay_value, _settings.government_tax_rate)
               
                    };
                    employees.Add(employee);
                    employeeIdTextBox.Text = "";
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    birthdayPiker.Text = "";
                    addressTextBox.Text = "";
                    contactNumberTextBox.Text = "";
                    monthlySalaryTextBox.Text = "";
                    monthlySalaryTextBox.Text = "";
                    overtimeHoursTextBox.Text = "";
                    allowancesTextBox.Text = "";
                    absentDaysTextBox.Text = "";
                }

                employeeCountLabel.Text = $"Emp_{i + 1}";
            }

            
            
        }

        //public EmployeeModel CreateEmployee()
        //{
            
        //    return employee;
        //}

        //public static int RequestIntFromUser(string message)
        //{

        //    bool isValid = false;
        //    string Text = "";

        //    Console.Write(message);

        //    Text = Console.ReadLine();
        //    isValid = int.TryParse(Text, out int output);
        //    while (isValid == false)
        //    {
        //        Console.WriteLine("please enter again.");
        //        Console.Write(message);
        //        Text = Console.ReadLine();
        //        isValid = int.TryParse(Text, out output);

        //    }
        //    return output;

        //}
    }
}
