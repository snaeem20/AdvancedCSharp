using System.Data.Common;
using System.Data;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCountries();
        }

        private void PopulateCountries()
        {
            DataTable countryTable = new DataTable();
            LibrarySystemContext.GetCountryAdapter().Fill(countryTable);

            Dictionary<int, string> countryList = new Dictionary<int, string>();


            foreach (DataRow row in countryTable.Rows)
            {
                countryList.Add((int)row["Id"], row["Name"].ToString());
                //cbxCountry.Items.Add(row["Name"]);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days = (dtReturnDate.Value - dtIssueDate.Value).Days;
            lblCalculatedBusinessDays.Text = days.ToString();

            if (days > 10)
            {
                lblCalculatedPenalty.Text = ((days - 10) * 5).ToString();
            }
        }
    }
}