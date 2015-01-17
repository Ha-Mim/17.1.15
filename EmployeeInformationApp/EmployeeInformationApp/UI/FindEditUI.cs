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
    public partial class FindEditUI : Form
    {
        public FindEditUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            EmployeeManager aEmployeeManager=new EmployeeManager();
            Employee aEmployee=new Employee();
            aEmployee.Name = searchTextBox.Text;
            List<Employee> employees=new List<Employee>();
            employees = aEmployeeManager.SeaarchEmployees(aEmployee.Name);
            showListView.Items.Clear();

            foreach (Employee employee in employees)
            {
                ListViewItem myListViewItem=new ListViewItem();
                myListViewItem.Text = (employee.SerialNo.ToString());
                myListViewItem.SubItems.Add(employee.Name);
                myListViewItem.SubItems.Add(employee.Email);
                myListViewItem.SubItems.Add(employee.Address);
                myListViewItem.SubItems.Add(employee.ADesignation.Code);
                myListViewItem.SubItems.Add(employee.ADesignation.Title);
                
                myListViewItem.Tag = employee;
                showListView.Items.Add(myListViewItem);
            }
        }
    }
}
