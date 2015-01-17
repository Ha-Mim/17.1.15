using EmployeeInformation.BLL;
using EmployeeInformation.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeInformation.Web
{
    public partial class AddDesignationWebUi : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saveDesignationButton_Click(object sender, EventArgs e)
        {
            DesignationManager aDesignationManager = new DesignationManager();
            Designation aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = designationTextBox.Text;
            string msg = aDesignationManager.Save(aDesignation);
            messageLabel.Text = msg;
        }

    }
}