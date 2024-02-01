using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    internal class DataContext
    {
       public static SqlDataAdapter GetLibrarySystemContext() {
            string connectionString = "Database=LibrarySystem;Server=FACULTY-PC12;Integrated Security=True;";
            //string connectionString = "Database=LibrarySystem;Server=FACULTY-PC12;Integrated Security=False;uid=samia;Password=pwrds;";
            //SqlConnection con = new SqlConnection(connectionString);            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Country", connectionString);           

            return dataAdapter;
        }
    }
}
