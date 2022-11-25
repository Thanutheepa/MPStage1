using ManPowerCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Domain
{
    public class EmployeeContact
    {
        [DBField("ID")]
        public int EmployeeContactId { get; set; }

        [DBField("CONTACT_MODE")]
        public int ContactMode { get; set; }

        [DBField("EMPLOYEE_ID")]
        public int EmpID { get; set; }

        [DBField("CONTACT_DETAIL")]
        public string ContactDetials { get; set; }
    }
}
