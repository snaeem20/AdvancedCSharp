using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal static class LibrarySystemContext
    {

        public static SqlDataAdapter GetCountryAdapter() {
            
            string connectionString = "Database=LibrarySystem;Server=FACULTY-PC12;Integrated Security=True;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Country", connectionString);              
            
            return dataAdapter;
        }

        
    }
}
