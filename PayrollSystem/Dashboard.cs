using ComponentLibrary;

namespace PayRollSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            //RejisterNewEmployeeButton.Enabled = false;
            //ViewEmployeeDetailsButton.Enabled = false;
            //SearchEmployeeButton.Enabled = false;
        }

        private void RejisterNewEmployeeButton_Click(object sender, EventArgs e)
        {
            
            RegisterEmployee employee = new RegisterEmployee();
            employee.Show();
 
        }

      

        private void AdminSettingsButton_Click(object sender, EventArgs e)
        {
            AdminSettings settings = new AdminSettings();
            settings.Show();
        }

        private void ViewEmployeeDetailsButton_Click(object sender, EventArgs e)
        {

        }
    }
}