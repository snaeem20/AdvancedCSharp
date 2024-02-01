using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibrarySystemContext
    {
        static string connectionString = "Database=KIBGEPayRoll;Server=DESKTOP-SO2I7BN;Integrated Security=True;";
        static SqlConnection connection;

        public LibrarySystemContext()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }        

        public static SqlDataAdapter GetCountryAdapter() 
        {   
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Country", connectionString);
            return dataAdapter;
        }

        public static SqlDataAdapter GetNonBusinessDaysAdapter()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From NonBusinessDays", connectionString);
            return dataAdapter;
        }

        public static SqlDataAdapter GetWeekendsAdapter()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Weekends", connectionString);
            return dataAdapter;
        }

        public static void CloseDataContext()
        {
            connection.Close();
        }

        
    }
}
