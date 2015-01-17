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
    public partial class AddDesignationUI : Form
    {
        public AddDesignationUI()
        {
            InitializeComponent();
        }

        private void saveDesignationButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation=new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;

            DesignationManager aDesignationManager=new DesignationManager();
            string msg= aDesignationManager.Save(aDesignation);
            MessageBox.Show(msg);
        }
    }
}
