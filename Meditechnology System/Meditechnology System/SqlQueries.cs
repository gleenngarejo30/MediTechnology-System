﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Meditechnology_System
{
    public class SqlQueries
    {
        //public static string ConnectionString = "Data Source=DESKTOP-6ABT2HR\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";
        public static string ConnectionString = "Data Source=justinstudent.database.windows.net;Initial Catalog=Pharmacy1;Persist Security Info=True;User ID=justin;Password=mediTechnology!23";

        public static void AddPatientQuery(string firstname, string lastname, string middlename, int age, string sex, string email, string contactnum)
        {
            int patientIDnew = 0;
            int infoIDnew = 0;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //patientID increment
            string patientIDadd = "SELECT MAX(patientID) AS max_patientID FROM PatientTBL";
            SqlCommand patientIDaddcmd = new SqlCommand(patientIDadd, con);
            SqlDataReader patientIDaddexe = patientIDaddcmd.ExecuteReader();
            if (patientIDaddexe.HasRows)
            {
                patientIDaddexe.Read();
                try
                {
                    patientIDnew = (patientIDaddexe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    patientIDnew = 10000001;
                }
            }
            con.Close();

            con.Open();
            //infoID increment
            string infoIDadd = "SELECT MAX(patientID) AS max_patientID FROM PatientTBL";
            SqlCommand infoIDaddcmd = new SqlCommand(infoIDadd, con);
            SqlDataReader infoIDaddexe = infoIDaddcmd.ExecuteReader();
            if (infoIDaddexe.HasRows)
            {
                infoIDaddexe.Read();
                try
                {
                    infoIDnew = (infoIDaddexe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    infoIDnew = 10000001;
                }
            }
            con.Close();

            con.Open();
            string InformationTBLadd = "INSERT INTO InformationTBL ([infoID],[age],[sex],[email],[contactNum]) " +
                "VALUES ('" + infoIDnew + "','" + age + "','" + sex + "','" + email + "','" + contactnum + "')";
            SqlCommand InformationTBLaddcmd = new SqlCommand(InformationTBLadd, con);
            InformationTBLaddcmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            string PatientTBLadd = "INSERT INTO PatientTBL ([patientID],[firstName],[lastName],[middleName],[infoID]) " +
                "VALUES ('" + patientIDnew + "','" + firstname + "','" + lastname + "','" + middlename + "','" + infoIDnew + "')";
            SqlCommand PatientTBLaddcmd = new SqlCommand(PatientTBLadd, con);
            PatientTBLaddcmd.ExecuteNonQuery();
            con.Close();
        }

        public static void AdminAddEmployeeQuery(string firstname, string lastname, string middlename, int age, string sex, string email, string contactnum, string occupation, string username, string password)
        {
            int employeeIDnew = 0;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //employeeID increment
            string employeeIDadd = "SELECT MAX(employeeID) AS employeeID FROM EmployeeTBL";
            SqlCommand employeeIDaddcmd = new SqlCommand(employeeIDadd, con);
            SqlDataReader employeeIDaddexe = employeeIDaddcmd.ExecuteReader();
            if (employeeIDaddexe.HasRows)
            {
                employeeIDaddexe.Read();
                try
                {
                    employeeIDnew = (employeeIDaddexe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    employeeIDnew = 20000001;
                }
            }
            con.Close();

            con.Open();
            string EmployeeTBLadd = "INSERT INTO EmployeeTBL (employeeID, firstName, lastName, middleName, age, sex, email, contactNum, occupation, username, password) " +
                "VALUES ('" + employeeIDnew + "','" + firstname + "','" + lastname + "','" + middlename + "','" + age + "','" + sex + "','" + email + "','" + contactnum + "','" + occupation + "','" + username + "','" + password + "')";
            SqlCommand EmployeeTBLaddcmd = new SqlCommand(EmployeeTBLadd, con);
            EmployeeTBLaddcmd.ExecuteNonQuery();
            con.Close();

        }

        public static void InventoryAddItemQuery(string medname, int quantity, int lotnum, double price, string issuedate, string expiredate)
        {
            int medicineIDnew = 0;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //medicineID increment
            string medicineIDadd = "SELECT MAX(medicineID) AS max_medicineID FROM MedicineTBL";
            SqlCommand medicineIDaddcmd = new SqlCommand(medicineIDadd, con);
            SqlDataReader medicineIDaddexe = medicineIDaddcmd.ExecuteReader();
            if (medicineIDaddexe.HasRows)
            {
                medicineIDaddexe.Read();
                try
                {
                    medicineIDnew = (medicineIDaddexe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    medicineIDnew = 5000001;
                }
            }
            con.Close();

            con.Open();
            string PatientTBLadd = "INSERT INTO MedicineTBL (medicineID, medName, quantity, lotNumber, unitPrice, issueDate, expirationDate) " +
                "VALUES ('" + medicineIDnew + "','" + medname + "','" + quantity + "','" + lotnum + "','" + price + "','" + issuedate + "','" + expiredate + "')";
            SqlCommand PatientTBLaddcmd = new SqlCommand(PatientTBLadd, con);
            PatientTBLaddcmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable InventoryScreenSearchQuery(string search)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string InventorySearch = "SELECT * FROM MedicineTBL WHERE medName LIKE '" + search + "%'";
            SqlCommand InventorySearchcmd = new SqlCommand(InventorySearch, con);
            var InventorySearchexe = InventorySearchcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(InventorySearchexe);
            con.Close();
            return table;


        }

        public static void InventoryDeleteSearchQuery(string medID)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string InventoryDelete = "DELETE FROM MedicineTBL WHERE medicineID =" + medID;
            SqlCommand InventoryDeletecmd = new SqlCommand(InventoryDelete, con);
            InventoryDeletecmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable NurseScreenLoadQuery()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string NurseSearch = "SELECT CONCAT(firstName, ' ', middleName, ' ', lastName) AS FullName FROM PatientTBL";
            SqlCommand NurseSearchcmd = new SqlCommand(NurseSearch, con);
            var NurseSearchexe = NurseSearchcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(NurseSearchexe);
            con.Close();
            return table;
        }

        public static DataTable NurseScreenSelectQuery(string getname)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string NurseSelect = "SELECT patientID, CONCAT(firstName, ' ', middleName, ' ', lastName) AS FullName, age, sex, email, contactNum FROM PatientTBL WHERE firstName LIKE '" + getname + "%'";
            SqlCommand NurseSelectcmd = new SqlCommand(NurseSelect, con);
            var NurseSelectexe = NurseSelectcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(NurseSelectexe);
            con.Close();
            return table;
        }

        public static DataTable DoctorScreenPatientSelectQuery(string name, int id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string DoctorSelect = "SELECT CONCAT(firstName, ' ', middleName, ' ', lastName) AS FullName, patientID FROM PatientTBL WHERE firstName LIKE '" + name + "%' OR patientID = " + id;
            SqlCommand DoctorSelectcmd = new SqlCommand(DoctorSelect, con);
            var DoctorSelectexe = DoctorSelectcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(DoctorSelectexe);
            con.Close();
            return table;
        }

        public static DataTable PrescriptionMedicineLoadQuery()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string MedicineSearch = "SELECT medName FROM MedicineTBL";
            SqlCommand MedicineSearchcmd = new SqlCommand(MedicineSearch, con);
            var MedicineSearchexe = MedicineSearchcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(MedicineSearchexe);
            return table;
        }

        public static SqlDataReader PrescriptionMedicineSelectQuery(string medname)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string DoctorSelect = "SELECT MedicineTBL.medName, MedicineLotTBL.quantity FROM MedicineTBL INNER JOIN MedicineLotTBL ON MedicineLotTBL.medicineID = MedicineTBL.medicineID WHERE MedicineTBL.medName = '" + medname + "'";
            SqlCommand DoctorSelectcmd = new SqlCommand(DoctorSelect, con);
            SqlDataReader DoctorSelectexe = DoctorSelectcmd.ExecuteReader();
            return DoctorSelectexe;

        }

        /*public static DataTable PrescriptionMedicineSelectQuery1(string getname)
        {
            int prescriptionIDnew = 0;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //prescriptionID increment
            string prescriptionIDadd = "SELECT MAX(prescriptionID) AS max_prescriptionID FROM TransactInfoTBL";
            SqlCommand prescriptionIDaddcmd = new SqlCommand(prescriptionIDadd, con);
            SqlDataReader prescriptionIDaddexe = prescriptionIDaddcmd.ExecuteReader();
            if (prescriptionIDaddexe.HasRows)
            {
                prescriptionIDaddexe.Read();
                try
                {
                    prescriptionIDnew = (prescriptionIDaddexe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    prescriptionIDnew = 8000001;
                }
            }

            con.Open();
            string select = "";
            SqlCommand selectcmd = new SqlCommand(select, con);
            var selectexe = selectcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(selectexe);
            con.Close();
            return table;
        }*/

        public static int ViewPrescriptionID()
        {
            int refnumber = 0;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //prescription increment
            string refnumberadd = "SELECT MAX(prescriptionID) AS prescriptionID FROM PrescriptionTBL";
            SqlCommand refnumberaddcmd = new SqlCommand(refnumberadd, con);
            SqlDataReader exe = refnumberaddcmd.ExecuteReader();

            if (exe.HasRows)
            {
                exe.Read();
                try
                {
                    refnumber = (exe.GetInt32(0) + 1);
                }
                catch (SqlNullValueException)
                {
                    refnumber = 8000001;
                }
            }
            return refnumber;
        }

        public static SqlDataReader ViewPrescriptionPatientInfo(string id)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            //prescription increment
            string add = "SELECT InformationTBL.age, InformationTBL.sex FROM InformationTBL INNER JOIN PatientTBL ON PatientTBL.infoID = InformationTBL.infoID WHERE PatientTBL.patientID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlDataReader exe = cmd.ExecuteReader();
            return exe;
        }

        public static void ViewPrescriptionTransferQuery(int refnum, int pID, string doctorCnum, string date, string age, string remarks, object[] prescribedMeds, object[] prescribedQuantity, string isreserved, string isactive)
        {
            int doctorID = 0;
            int medID = 0;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string add = "SELECT EmployeeTBL.employeeID FROM EmployeeTBL INNER JOIN InformationTBL ON InformationTBL.infoID = EmployeeTBL.infoID WHERE InformationTBL.contactNum = '" + doctorCnum + "'";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlDataReader exe = cmd.ExecuteReader();
            exe.Read();
            doctorID  = (exe.GetInt32(0));
            con.Close();


            con.Open();
            string add2 = "INSERT INTO PrescriptionTBL ([prescriptionID],[employeeID],[patientID],[doctorNotes],[date],[isReserved],[isActive]) " +
                "VALUES ('" + refnum + "','" + doctorID + "','" + pID + "','" + remarks + "','" + date + "','" + isreserved + "','" + isactive + "')";
            SqlCommand cmd2 = new SqlCommand(add2, con);
            cmd2.ExecuteNonQuery();
            con.Close();

            int i = 0;
            foreach (var currentItem in prescribedMeds.ToArray())
            {

                string meds = prescribedMeds[i].ToString();
                int quantity = Convert.ToInt32(prescribedQuantity[i].ToString());
                i++;

                con.Open();
                string add3 = "SELECT medicineID FROM MedicineTBL WHERE medName = '" + meds + "'";
                SqlCommand cmd3 = new SqlCommand(add3, con);
                SqlDataReader exe3 = cmd3.ExecuteReader();
                exe3.Read();
                medID = (exe3.GetInt32(0));
                con.Close();

                con.Open();
                string add1 = "INSERT INTO MedicinePrescribedTBL ([prescriptionID],[medicineID],[quantity]) " +
                "VALUES ('" + refnum + "','" + medID + "','" + quantity + "')";
                SqlCommand cmd1 = new SqlCommand(add1, con);
                cmd1.ExecuteNonQuery();
                con.Close();

            }
        }

        public static DataTable PharmacyScreenLoadQuery()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string add = "SELECT prescriptionID FROM PrescriptionTBL WHERE isActive = 'TRUE'";
            SqlCommand cmd = new SqlCommand(add, con);
            var exe = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(exe);
            con.Close();
            return table;
        }

        public static SqlDataReader PharmacyScreenInfoLoadQuery(int refnum)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string add = "SELECT CONCAT(PatientTBL.firstName, ' ', PatientTBL.middleName, ' ', PatientTBL.lastName) AS fullname, InformationTBL.age, InformationTBL.sex FROM PatientTBL INNER JOIN InformationTBL ON InformationTBL.infoID = PatientTBL.infoID INNER JOIN PrescriptionTBL ON PrescriptionTBL.patientID = PatientTBL.infoID WHERE PrescriptionTBL.prescriptionID = '" + refnum +"'";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlDataReader exe = cmd.ExecuteReader();
            return exe;
        }

        public static DataTable PharmacyScreenSelectGridViewQuery(int refnum)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string add = "SELECT MedicineTBL.medName AS 'Medicine', MedicineTBL.unitPrice AS 'Unit Price', MedicinePrescribedTBL.quantity AS 'Quantity', (MedicineTBL.unitPrice * MedicinePrescribedTBL.quantity) AS 'Total Price' FROM MedicineTBL INNER JOIN MedicinePrescribedTBL ON MedicinePrescribedTBL.medicineID = MedicineTBL.medicineID WHERE MedicinePrescribedTBL.prescriptionID = '" + refnum + "'";
            SqlCommand cmd = new SqlCommand(add, con);
            var exe = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(exe);
            con.Close();
            return table;
        }

        public static SqlDataReader ReadDoctorRemarksQuery(int refnum)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string add = "SELECT doctorNotes FROM PrescriptionTBL WHERE prescriptionID = '" + refnum + "'";
            SqlCommand cmd = new SqlCommand(add, con);
            SqlDataReader exe = cmd.ExecuteReader();
            return exe;
        }
    }
}
