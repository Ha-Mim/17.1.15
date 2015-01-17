using System.Collections.Generic;
using EmployeeInformation.DAO;
using EmployeeInformation.DLL;

namespace EmployeeInformation.BLL
{
    public class DesignationManager
    {
        private const int MIN_CHAR_CODE = 3;
        DesignationDBGateway aDesignationDbGateway = new DesignationDBGateway();
        public string Save(Designation aDesignation)
        {
            if (aDesignation.Code.Length>=MIN_CHAR_CODE)
            {
                Designation selectDesignation=new Designation();
                selectDesignation = aDesignationDbGateway.Find(aDesignation.Code);
                if (selectDesignation==null)
                {
                    aDesignationDbGateway.Save(aDesignation);
                    return "Saved";
                }
                else
                {
                    return "This code already exists";
                }
                
            }
            else
            {
                return "Code Must Be " + MIN_CHAR_CODE + " Carecter long!";
            }
        }

        public Designation GetSelectedDesignation(int id)
        {
            return aDesignationDbGateway.Find(id);
        }

        public List<Designation> GetAll()
        {
            return aDesignationDbGateway.GetAll();
        }
    }
}
