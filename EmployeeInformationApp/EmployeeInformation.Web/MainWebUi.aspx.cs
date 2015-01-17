using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeInformation.Web
{
    public partial class MainWebUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void designationButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDesignationWebUi.aspx");
        }

        protected void employeeEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeEntryWebUi.aspx");
        }

        protected void findAndEditButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FindandEditWebUi.aspx");
        }

        
    }
}