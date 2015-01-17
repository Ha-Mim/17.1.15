using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using EmployeeInformation.DAO;
using System.Web.UI.WebControls;

namespace EmployeeInformation.DLL
{
    public class EmployeeDBGateway
    {
        static string connectionString = WebConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        private SqlConnection aSqlConnection=new SqlConnection(connectionString);
        private SqlCommand aSqlCommand;
                
        public void Save(Employee aEmployee)
        {
            
            string query = "INSERT INTO tbl_Employee VALUES ('" + aEmployee.Name + "','" + aEmployee.Email + "','" +
                           aEmployee.Address + "','" + aEmployee.ADesignation.Id + "')";
            aSqlConnection.Open();
            aSqlCommand=new SqlCommand(query,aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Employee> SearcheEmployees(string name)
        {
            string query = "";
            if (name!=string.Empty)
            {
                query = "SELECT Emp.Id,Emp.Name,Emp.Email,Emp.Address,Dis.Code As Code,Dis.Title AS Title INTO ANEW FROM tbl_Employee Emp right JOIN tbl_Designation Dis On Emp.DesignationId=Dis.Id WHERE Emp.Name LIKE'%"+name+"%'";
            }
            else
            {
                query = "SELECT  Emp.Id,Emp.Name,Emp.Email,Emp.Address,Dis.Code As Code,Dis.Title AS Title INTO ANEW FROM tbl_Employee Emp right JOIN tbl_Designation  Dis On Emp.DesignationId=Dis.Id";
            }
            
            aSqlConnection.Open();
            
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlCommand.CommandText="SELECT * FROM ANEW";
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (aSqlDataReader.Read())
            {

                Employee aEmployee = new Employee();
                aEmployee.SerialNo = (int)aSqlDataReader["Id"];
                aEmployee.Name = aSqlDataReader["Name"].ToString();
                aEmployee.Email = aSqlDataReader["Email"].ToString();
                aEmployee.Address = aSqlDataReader["Address"].ToString();
                Designation aDesignation= new Designation();
                aDesignation.Code = aSqlDataReader["Code"].ToString();
                aDesignation.Title = aSqlDataReader["Title"].ToString();
                aEmployee.ADesignation = aDesignation;
                
                employees.Add(aEmployee);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return employees;

        }

        public Employee UniqueCheker(string email)
        {
            string query = "SELECT *FROM tbl_Employee WHERE Email='"+email+"'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Read();
                Employee aEmployee = new Employee();
                aEmployee.SerialNo = (int) aSqlDataReader["Id"];
                aEmployee.Name = aSqlDataReader["Name"].ToString();
                aEmployee.Email = aSqlDataReader["Email"].ToString();
                aEmployee.Address = aSqlDataReader["Address"].ToString();
                aSqlDataReader.Close();
                aSqlConnection.Close();

                return aEmployee;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return null;
            }
        }
       
    }
}
