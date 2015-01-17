using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformation.BLL;
using EmployeeInformation.DAO;

namespace EmployeeInformation.Web
{
    public partial class FindandEditWebUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        EmployeeManager aEmployeeManager = new EmployeeManager();
        protected void searchButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.Name = nameSearchTextBox.Text;
            
            List<Employee> employees = new List<Employee>();
            showGridView.DataSource = aEmployeeManager.SeaarchEmployees(aEmployee.Name);
            showGridView.DataBind();
        }

        protected void showGridView_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void showGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.Name = nameSearchTextBox.Text;
            showGridView.PageIndex = e.NewPageIndex;

            foreach (Employee anEmployee in aEmployeeManager.SeaarchEmployees(aEmployee.Name))
            {
                showGridView.DataSource = anEmployee;
            }
            ;
            showGridView.DataBind();
        }
    }
}