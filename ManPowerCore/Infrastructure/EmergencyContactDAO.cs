using ManPowerCore.Common;
using ManPowerCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Infrastructure
{
    public interface EmergencyContactDAO
    {
        int SaveEmergencyContact(EmergencyContact emergencyContact, DBConnection dbConnection);
    }

    public class EmergencyContactDAOImpl : EmergencyContactDAO
    {
        public int SaveEmergencyContact(EmergencyContact emergencyContact, DBConnection dbConnection)
        {
            if (dbConnection.dr != null)
                dbConnection.dr.Close();

            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "INSERT INTO EMERGENCY_CONTACT(EMPLOYEE_ID,CONTACT_PERSON_NAME,DEPENDENT_TYPE_TO_EMPLOYEE,ADDRESS_OF_EMERGENCY_PERSON)" +
                "VALUES(@EmployeeId,@Name,@DependentToEmployee,@Address)";



            dbConnection.cmd.Parameters.AddWithValue("@EmployeeId", emergencyContact.EmployeeId);
            dbConnection.cmd.Parameters.AddWithValue("@Name", emergencyContact.Name);
            dbConnection.cmd.Parameters.AddWithValue("@DependentToEmployee", emergencyContact.DependentToEmployee);
            dbConnection.cmd.Parameters.AddWithValue("@Address", emergencyContact.Address);

            dbConnection.cmd.ExecuteNonQuery();
            return 1;
        }
    }
}

