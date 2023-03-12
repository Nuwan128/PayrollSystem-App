using ComponentLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollSystem
{
    public partial class AdminSettings : Form ,ISettings
    {
        //public SettingsModel _settings;
        public AdminSettings()
        {
            InitializeComponent();
        }

        public SettingsModel SetSettings()
        {
            SettingsModel settings = new SettingsModel
            {
                salary_cycle_date_range = int.Parse(salary_cycle_date_rangeTextBox.Text),
                salary_cycle_begin_date = int.Parse(salary_cycle_begin_dateTextBox.Text),
                salary_cycle_end_date = int.Parse(salary_cycle_end_dateTextBox.Text),
                leaves_for_an_employee_for_year = int.Parse(lleaves_for_an_employee_for_yearTextBox.Text),
                government_tax_rate = decimal.Parse(government_tax_rateTextBox.Text),
                Over_time_rate = decimal.Parse(over_time_rateTextBox.Text),
                no_of_holidays = int.Parse(no_of_holidaysTextBox.Text),
                no_of_employee = int.Parse(no_of_employeeTextBox.Text),

            };
            return settings;
        }

        private void EmployeeSettignsSaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(no_of_employeeTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                no_of_employeeTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(salary_cycle_date_rangeTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                salary_cycle_date_rangeTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(salary_cycle_begin_dateTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                salary_cycle_begin_dateTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(salary_cycle_end_dateTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                salary_cycle_end_dateTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(lleaves_for_an_employee_for_yearTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                lleaves_for_an_employee_for_yearTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(government_tax_rateTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                government_tax_rateTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(over_time_rateTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                over_time_rateTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(no_of_holidaysTextBox.Text))
            {
                MessageBox.Show("Fill Again");
                no_of_holidaysTextBox.Focus();
            }
            else
            {
                SetSettings();
                //_settings= settings;
                this.Close();
            }
           
        }
    }
}
