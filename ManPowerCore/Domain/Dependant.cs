using ManPowerCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Domain
{
    public class Dependant
    {
        [DBField("ID")]
        public int DependantId { get; set; }

        [DBField("DEPENDANT_TYPE_ID")]
        public int DependantTypeId { get; set; }

        [DBField("EMPLOYEE_ID")]
        public int EmpId { get; set; }

        [DBField("FIRST_NAME")]
        public string FirstName { get; set; }

        [DBField("LAST_NAME")]
        public string LastName { get; set; }

        [DBField("NIC")]
        public string DependantNIC { get; set; }

        [DBField("PASSPORT_NO")]
        public string DependantPassportNo { get; set; }
    }
}
