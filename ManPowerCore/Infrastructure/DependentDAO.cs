using ManPowerCore.Common;
using ManPowerCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Infrastructure
{
    public interface DependentDAO
    {
        //List<Dependant> GetAllDependant(DBConnection dbConnection);

        //Dependant GetDependantById(int id, DBConnection dbConnection);

        int SaveDependant(Dependant dependant, DBConnection dbConnection);

        //int UpdateDependant(Dependant dependant, DBConnection dbConnection);
    }

    public class DependentDAOImpl : DependentDAO
    {
        public int SaveDependant(Dependant dependant, DBConnection dbConnection)
        {
            if (dbConnection.dr != null)
                dbConnection.dr.Close();

            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "INSERT INTO DEPENDANT(DEPENDANT_TYPE_ID,EMPLOYEE_ID,FIRST_NAME,LAST_NAME " +
                "NIC,PASSPORT_NO)" +
                " VALUES(@DependantTypeId,@EmpID,@FirstName,@LastName,@DependantNIC,@DependantPassportNo)";



            dbConnection.cmd.Parameters.AddWithValue("@DependantTypeId", dependant.DependantTypeId);
            dbConnection.cmd.Parameters.AddWithValue("@EmpId", dependant.EmpId);
            dbConnection.cmd.Parameters.AddWithValue("@FirstName", dependant.FirstName);
            dbConnection.cmd.Parameters.AddWithValue("@LastName", dependant.LastName);
            dbConnection.cmd.Parameters.AddWithValue("@DependantNIC", dependant.DependantNIC);
            dbConnection.cmd.Parameters.AddWithValue("@DependantPassportNo", dependant.DependantPassportNo);

            dbConnection.cmd.ExecuteNonQuery();
            return 1;
        }
    }
}

