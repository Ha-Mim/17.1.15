using System.Collections.Generic;
using EmployeeInformation.DAO;
using EmployeeInformation.DLL;
using System.Web.UI.WebControls;

namespace EmployeeInformation.BLL
{
    public class EmployeeManager
    {
        private EmployeeDBGateway aEmployeeDbGateway = new EmployeeDBGateway();

        public string Save(Employee aEmployee)
        {
            Employee uniquEmployee = new Employee();
            uniquEmployee = aEmployeeDbGateway.UniqueCheker(aEmployee.Email);
            if (uniquEmployee == null)
            {
                aEmployeeDbGateway.Save(aEmployee);
                return "Saved";
            }
            else
            {
                return "Please Enter Unique Email Address";
            }
        }

        public List<Employee> SeaarchEmployees(string name)
        {
          return aEmployeeDbGateway.SearcheEmployees(name);
        }

      
        
    }
}
