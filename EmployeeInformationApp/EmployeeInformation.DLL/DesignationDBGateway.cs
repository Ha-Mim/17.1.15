using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Configuration;
using EmployeeInformation.DAO;

namespace EmployeeInformation.DLL
{
    public class DesignationDBGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        private SqlConnection aSqlConnection;
        private SqlCommand aSqlCommand;

        public DesignationDBGateway()
        {
            aSqlConnection = new SqlConnection(connectionString);
        }

        public void Save(Designation aDesignation)
        {
            string query = "INSERT INTO tbl_Designation VALUES('" + aDesignation.Code + "' , '" + aDesignation.Title +
                           "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }

        public List<Designation> GetAll()
        {
            string query = "SELECT *FROM tbl_Designation";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            List<Designation> designations = new List<Designation>();

            while (aSqlDataReader.Read())
            {

                Designation aDesignation = new Designation();
                aDesignation.Id = (int) aSqlDataReader["Id"];
                aDesignation.Code = aSqlDataReader["Code"].ToString();
                aDesignation.Title = aSqlDataReader["Title"].ToString();
                designations.Add(aDesignation);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return designations;
        }

        public Designation Find(string code)
        {
            string query = "SELECT *FROM tbl_Designation";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();


            while (aSqlDataReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Id = (int) aSqlDataReader["Id"];
                aDesignation.Code = aSqlDataReader["Code"].ToString();
                aDesignation.Title = aSqlDataReader["Title"].ToString();


                if (aDesignation.Code == code)
                {
                    aSqlDataReader.Close();
                    aSqlConnection.Close();
                    return aDesignation;
                }
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return null;
        }

        public Designation Find(int id) 
        {
            string query = "SELECT * FROM tbl_Designation";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();


            while (aSqlDataReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Id = (int) aSqlDataReader["Id"];
                aDesignation.Code = aSqlDataReader["Code"].ToString();
                aDesignation.Title = aSqlDataReader["Title"].ToString();


                if (aDesignation.Id == id)
                {
                    aSqlDataReader.Close();
                    aSqlConnection.Close();
                    return aDesignation;
                }
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();
            return null;
        }

    }
}
