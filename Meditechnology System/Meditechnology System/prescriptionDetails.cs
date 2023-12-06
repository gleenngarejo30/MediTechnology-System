using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditechnology_System
{
	internal class prescriptionDetails
	{
		public static ArrayList medName = new ArrayList();
		public static ArrayList medQuantity = new ArrayList();
		public static ArrayList medAvailability = new ArrayList();
		public static ArrayList medRemarks;

		public static String reserved = "PRESCRIPTION";
		public static string patientID;
        public static string patientName;
        public static int employeeID;
        public static string employeeName;
        public static DataTable datatable;

        public static void setMedName(string meds) {
			medName.Add(meds);
		}
		public static void setMedQuantity(int quantity)
		{
			medQuantity.Add(quantity);
		}
		public static void setMedAvailability(bool availability)
		{
			medAvailability.Add(availability);
		}
		//important vv
		public static void setPatientID(string pID) {
            patientID = pID;
		}
		public static string getPatientID()
		{
			return patientID;
		}
		public static void setPatientName(string pName) {
			patientName = pName;
		}
        public static string getPatientName()
        {
            return patientName;
        }
		//important ^^

		//getDataGridView
		public static void setDataGrid(DataTable dt)
		{
			datatable = dt;
		}
        public static DataTable getDataGrid()
        {
            return datatable;
        }
		//getRemarks
		public static void setRemarks(ArrayList remarks)
		{
			medRemarks = remarks;
		}
		public static ArrayList getRemarks()
		{
			return medRemarks;
		}

		//getEmployeeID
		public static void setemployeeID(int ID)
		{
			employeeID = ID;
		}
		public static int getemployeeID()
		{
			return employeeID;
		}
        //getEmployeeName
        public static void setemployeeName(string name)
        {
            employeeName = name;
        }
        public static string getemployeeName()
        {
            return employeeName;
        }

        public static void setReserved(Boolean isReserved) {
			if (isReserved)
				reserved = "RESERVED PRESCRIPTION";
			else
				reserved = "PRESCRIPTION";
		}
		public static string getReserved()
		{
			return reserved;
		}
	}
}
