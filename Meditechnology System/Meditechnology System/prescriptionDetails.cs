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
		public static String patientName;

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

		public static void setPatientName(String name) {
			patientName = name;
		}
		public static String getPatientName() {
			return patientName;
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
