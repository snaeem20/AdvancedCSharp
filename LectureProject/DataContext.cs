using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    internal class DataContext
    {
       public LibrarySystemContext() {
            string connectionString = "Database=LibrarySystem;Server=FACULTY-PC12;Integrated Security=True;";
            //string connectionString = "Database=LibrarySystem;Server=FACULTY-PC12;Integrated Security=False;uid=samia;Password=pwrds;";
            //SqlConnection con = new SqlConnection(connectionString);            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Country", connectionString);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);            
        }
    }
}
