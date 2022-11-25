using ManPowerCore.Common;
using ManPowerCore.Domain;
using ManPowerCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Controller
{
    public interface EmployeeController
    {
        int SaveEmployee(Employee emp);
    }

    public class EmployeeControllerImpl : EmployeeController
    {
        DBConnection dBConnection;
        EmployeeDAO employeeDAO = DAOFactory.CreateEmployeeDAO();


        public int SaveEmployee(Employee emp)
        {

            try
            {
                dBConnection = new DBConnection();
                employeeDAO.SaveEmployee(emp, dBConnection);
                return 1;
            }
            catch (Exception)
            {
                dBConnection.RollBack();
                return 0;
            }
            finally
            {
                if (dBConnection.con.State == System.Data.ConnectionState.Open)
                    dBConnection.Commit();
            }
        }

        
    }

}

