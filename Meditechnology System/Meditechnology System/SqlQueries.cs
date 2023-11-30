using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Meditechnology_System
{
    public class SqlQueries
    {
        public static string ConnectionString = "Data Source=DESKTOP-6ABT2HR\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True";

        public static void AddPatientQuery(string firstname, string lastname, string middlename, int age, string sex, string email, string contactnum)
        {
            int patientIDnew = 0;

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
            string PatientTBLadd = "INSERT INTO PatientTBL (patientID, firstName, lastName, middleName, age, sex, email, contactNum) " +
                "VALUES ('" +  patientIDnew + "','" + firstname + "','" + lastname + "','" + middlename + "','" + age + "','" + sex + "','" + email + "','" + contactnum + "')";
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
    }
}
