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
        string constr = "Database=Library;Server=WSAMZN-TB43SPPE\\mainline;Integrated Security=False;uid=samia;Password=pwrds;";
        SqlConnection _con = new SqlConnection(constr);
        SqlDataAdapter _da = new SqlDataAdapter("Select * From Country", constr);
        DataTable _dt = new DataTable();
        _da.Fill(_dt);
    }
}
