using System;
using System.Collections;
using System.Collections.Generic;
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

		public static String reserved = "PRESCRIPTION";
		public static string patientID;
        public static string patientName;

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
