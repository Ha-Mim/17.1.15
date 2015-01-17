using EmployeeInformation.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformation.DAO;

namespace EmployeeInformation.Web
{
    public partial class EmployeeEntryWebUi : System.Web.UI.Page
    {
        DesignationManager adesignationManager = new DesignationManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            employeeEntryDropDownList.DataSource = adesignationManager.GetAll();
            employeeEntryDropDownList.DataValueField = "Id";
            employeeEntryDropDownList.DataTextField = "Title";
            employeeEntryDropDownList.DataBind();
        }

        protected void saveEmployeeEnteryButton_Click(object sender, EventArgs e)
        {
            DesignationManager aDesignationManager = new DesignationManager();
            Employee aEmployee = new Employee();
            aEmployee.Name = nameEntryTextBox.Text;
            aEmployee.Email = emailEntryTextBox.Text;
            aEmployee.Address = adressEntryTextBox.Text;
            Designation aDesignation =
                aDesignationManager.GetSelectedDesignation(Convert.ToInt32(employeeEntryDropDownList.SelectedValue)); 
            aEmployee.ADesignation = aDesignation ;
            EmployeeManager aEmployeeManager= new EmployeeManager();
            string msg = aEmployeeManager.Save(aEmployee);
            messegeLabel.Text = msg;
        }
    }
}