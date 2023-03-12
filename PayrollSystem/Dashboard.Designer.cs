namespace PayRollSystem
{
    partial class AdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RejisterNewEmployeeButton = new System.Windows.Forms.Button();
            this.ViewEmployeeDetailsButton = new System.Windows.Forms.Button();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.AdminSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RejisterNewEmployeeButton
            // 
            this.RejisterNewEmployeeButton.Location = new System.Drawing.Point(30, 154);
            this.RejisterNewEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.RejisterNewEmployeeButton.Name = "RejisterNewEmployeeButton";
            this.RejisterNewEmployeeButton.Size = new System.Drawing.Size(199, 119);
            this.RejisterNewEmployeeButton.TabIndex = 0;
            this.RejisterNewEmployeeButton.Text = "Rejister New Employee";
            this.RejisterNewEmployeeButton.UseVisualStyleBackColor = true;
            this.RejisterNewEmployeeButton.Click += new System.EventHandler(this.RejisterNewEmployeeButton_Click);
            // 
            // ViewEmployeeDetailsButton
            // 
            this.ViewEmployeeDetailsButton.Location = new System.Drawing.Point(237, 154);
            this.ViewEmployeeDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ViewEmployeeDetailsButton.Name = "ViewEmployeeDetailsButton";
            this.ViewEmployeeDetailsButton.Size = new System.Drawing.Size(199, 119);
            this.ViewEmployeeDetailsButton.TabIndex = 0;
            this.ViewEmployeeDetailsButton.Text = "View Employee Details";
            this.ViewEmployeeDetailsButton.UseVisualStyleBackColor = true;
            this.ViewEmployeeDetailsButton.Click += new System.EventHandler(this.ViewEmployeeDetailsButton_Click);
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.Location = new System.Drawing.Point(444, 154);
            this.SearchEmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(199, 119);
            this.SearchEmployeeButton.TabIndex = 0;
            this.SearchEmployeeButton.Text = "Search Employee ";
            this.SearchEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // AdminSettingsButton
            // 
            this.AdminSettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminSettingsButton.Location = new System.Drawing.Point(237, 27);
            this.AdminSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminSettingsButton.Name = "AdminSettingsButton";
            this.AdminSettingsButton.Size = new System.Drawing.Size(199, 119);
            this.AdminSettingsButton.TabIndex = 14;
            this.AdminSettingsButton.Text = "Setup The Settings";
            this.AdminSettingsButton.UseVisualStyleBackColor = true;
            this.AdminSettingsButton.Click += new System.EventHandler(this.AdminSettingsButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 376);
            this.Controls.Add(this.AdminSettingsButton);
            this.Controls.Add(this.SearchEmployeeButton);
            this.Controls.Add(this.ViewEmployeeDetailsButton);
            this.Controls.Add(this.RejisterNewEmployeeButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RejisterNewEmployeeButton;
        private Button ViewEmployeeDetailsButton;
        private Button SearchEmployeeButton;
        private Button AdminSettingsButton;
    }
}