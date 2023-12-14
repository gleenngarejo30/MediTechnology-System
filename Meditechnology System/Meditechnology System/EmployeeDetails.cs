using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditechnology_System
{
    internal class EmployeeDetails
    {
        public static void toOffline() {
            string refNum = prescriptionDetails.getemployeeID().ToString();
            SqlQueries.changeEmployeeToOffline(refNum);
        }
    }
}
