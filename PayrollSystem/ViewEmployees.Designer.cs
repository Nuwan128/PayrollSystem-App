namespace PayRollSystem
{
    partial class ViewEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.employee_Id = new System.Windows.Forms.ColumnHeader();
            this.first_name = new System.Windows.Forms.ColumnHeader();
            this.last_name = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.contact_number = new System.Windows.Forms.ColumnHeader();
            this.birthday = new System.Windows.Forms.ColumnHeader();
            this.monthly_salary = new System.Windows.Forms.ColumnHeader();
            this.allowances = new System.Windows.Forms.ColumnHeader();
            this.no_of_overtime_hours = new System.Windows.Forms.ColumnHeader();
            this.no_of_absent_days = new System.Windows.Forms.ColumnHeader();
            this.no_of_leaves_an_employee_has_taken = new System.Windows.Forms.ColumnHeader();
            this.no_of_remaining_leaves = new System.Windows.Forms.ColumnHeader();
            this.no_pay_value = new System.Windows.Forms.ColumnHeader();
            this.base_pay_value = new System.Windows.Forms.ColumnHeader();
            this.total_salary = new System.Windows.Forms.ColumnHeader();
            this.gross_pay = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employee_Id,
            this.first_name,
            this.last_name,
            this.address,
            this.contact_number,
            this.birthday,
            this.monthly_salary,
            this.allowances,
            this.no_of_overtime_hours,
            this.no_of_absent_days,
            this.no_of_leaves_an_employee_has_taken,
            this.no_of_remaining_leaves,
            this.no_pay_value,
            this.base_pay_value,
            this.total_salary,
            this.gross_pay});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1175, 417);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // employee_Id
            // 
            this.employee_Id.Text = "Employee Id";
            this.employee_Id.Width = 110;
            // 
            // first_name
            // 
            this.first_name.Text = "First Name";
            this.first_name.Width = 110;
            // 
            // last_name
            // 
            this.last_name.Text = "Last Name";
            this.last_name.Width = 110;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 110;
            // 
            // contact_number
            // 
            this.contact_number.Text = "TP";
            this.contact_number.Width = 110;
            // 
            // birthday
            // 
            this.birthday.Text = "Birthday";
            this.birthday.Width = 110;
            // 
            // monthly_salary
            // 
            this.monthly_salary.Text = "Monthly Salary";
            this.monthly_salary.Width = 110;
            // 
            // allowances
            // 
            this.allowances.Text = "Allowances";
            this.allowances.Width = 110;
            // 
            // no_of_overtime_hours
            // 
            this.no_of_overtime_hours.Text = "Overtime Hours";
            this.no_of_overtime_hours.Width = 110;
            // 
            // no_of_absent_days
            // 
            this.no_of_absent_days.Text = "Absent Days";
            this.no_of_absent_days.Width = 110;
            // 
            // no_of_leaves_an_employee_has_taken
            // 
            this.no_of_leaves_an_employee_has_taken.DisplayIndex = 15;
            this.no_of_leaves_an_employee_has_taken.Text = "Taken Leaves";
            this.no_of_leaves_an_employee_has_taken.Width = 110;
            // 
            // no_of_remaining_leaves
            // 
            this.no_of_remaining_leaves.DisplayIndex = 10;
            this.no_of_remaining_leaves.Text = "Remaining Leaves";
            this.no_of_remaining_leaves.Width = 110;
            // 
            // no_pay_value
            // 
            this.no_pay_value.DisplayIndex = 11;
            this.no_pay_value.Text = "No Pay Value";
            this.no_pay_value.Width = 110;
            // 
            // base_pay_value
            // 
            this.base_pay_value.DisplayIndex = 12;
            this.base_pay_value.Text = "Base Pay Value";
            this.base_pay_value.Width = 110;
            // 
            // total_salary
            // 
            this.total_salary.DisplayIndex = 13;
            this.total_salary.Text = "Total Salary";
            this.total_salary.Width = 110;
            // 
            // gross_pay
            // 
            this.gross_pay.DisplayIndex = 14;
            this.gross_pay.Text = "Gross Pay";
            this.gross_pay.Width = 110;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 417);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewEmployees";
            this.Text = "View Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader first_name;
        private ColumnHeader employee_Id;
        private ColumnHeader last_name;
        private ColumnHeader address;
        private ColumnHeader contact_number;
        private ColumnHeader birthday;
        private ColumnHeader monthly_salary;
        private ColumnHeader allowances;
        private ColumnHeader no_of_overtime_hours;
        private ColumnHeader no_of_absent_days;
        private ColumnHeader no_of_remaining_leaves;
        private ColumnHeader no_pay_value;
        private ColumnHeader base_pay_value;
        private ColumnHeader total_salary;
        private ColumnHeader gross_pay;
        private ColumnHeader no_of_leaves_an_employee_has_taken;
    }
}