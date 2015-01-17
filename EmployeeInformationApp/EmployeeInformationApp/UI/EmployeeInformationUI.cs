using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformation.BLL;
using EmployeeInformation.DAO;

namespace EmployeeInformationApp.UI
{
    public partial class EmployeeInformationUI : Form
    {
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }
       
        DesignationManager aDesignationManager=new DesignationManager();
        EmployeeManager aEmployeeManager=new EmployeeManager();
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            designationComboBox.DataSource = aDesignationManager.GetAll();
            designationComboBox.DisplayMember = "Code";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee=new Employee();
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Address = addressTextBox.Text;
            Designation selectedDesignation = (Designation) designationComboBox.SelectedItem;
            aEmployee.ADesignation.Id = selectedDesignation.Id;
            string msg=aEmployeeManager.Save(aEmployee);
            MessageBox.Show(msg);
        }

        private void designationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
