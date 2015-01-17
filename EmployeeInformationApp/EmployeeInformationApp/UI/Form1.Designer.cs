namespace EmployeeInformationApp.UI
{
    partial class MainUI
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.AddDesignationButton = new System.Windows.Forms.Button();
            this.findEditButton = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.GroupBox();
            this.employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(26, 57);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(127, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // AddDesignationButton
            // 
            this.AddDesignationButton.Location = new System.Drawing.Point(192, 57);
            this.AddDesignationButton.Name = "AddDesignationButton";
            this.AddDesignationButton.Size = new System.Drawing.Size(144, 23);
            this.AddDesignationButton.TabIndex = 1;
            this.AddDesignationButton.Text = "Add Designation";
            this.AddDesignationButton.UseVisualStyleBackColor = true;
            this.AddDesignationButton.Click += new System.EventHandler(this.AddDesignationButton_Click);
            // 
            // findEditButton
            // 
            this.findEditButton.Location = new System.Drawing.Point(381, 57);
            this.findEditButton.Name = "findEditButton";
            this.findEditButton.Size = new System.Drawing.Size(119, 23);
            this.findEditButton.TabIndex = 2;
            this.findEditButton.Text = "Find and Edit";
            this.findEditButton.UseVisualStyleBackColor = true;
            this.findEditButton.Click += new System.EventHandler(this.findEditButton_Click);
            // 
            // employee
            // 
            this.employee.Controls.Add(this.findEditButton);
            this.employee.Controls.Add(this.AddDesignationButton);
            this.employee.Controls.Add(this.addEmployeeButton);
            this.employee.Location = new System.Drawing.Point(12, 25);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(522, 140);
            this.employee.TabIndex = 3;
            this.employee.TabStop = false;
            this.employee.Text = "Employee";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 184);
            this.Controls.Add(this.employee);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.employee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button AddDesignationButton;
        private System.Windows.Forms.Button findEditButton;
        private System.Windows.Forms.GroupBox employee;
    }
}

