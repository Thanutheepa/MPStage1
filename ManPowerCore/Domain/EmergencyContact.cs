﻿using ManPowerCore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerCore.Domain
{
    public class EmergencyContact
    {
        [DBField("ID")]
        public int DependantTypeId { get; set; }

        [DBField("EMPLOYEE_ID")]
        public int EmployeeId { get; set; }

        [DBField("CONTACT_PERSON_NAME")]
        public string Name { get; set; }

        [DBField("DEPENDENT_TYPE_TO_EMPLOYEE")]
        public string DependentToEmployee { get; set; }

        [DBField("ADDRESS_OF_EMERGENCY_PERSON")]
        public string Address { get; set; }
    }
}
