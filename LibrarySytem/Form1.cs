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

            cbxCountry.DataSource = countryTable;
            cbxCountry.DisplayMember = "FacultyName";
            cbxCountry.ValueMember = "FacultyID";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days = (dtReturnDate.Value - dtIssueDate.Value).Days;
            lblCalculatedBusinessDays.Text = days.ToString();

            int nonBusinessDays = GetNonBusinessDaysToBeExcluded(dtIssueDate.Value, dtReturnDate.Value, Convert.ToInt32(cbxCountry.SelectedValue));
            int weekends        = GetWeekendsToBeExcluded       (dtIssueDate.Value, dtReturnDate.Value, Convert.ToInt32(cbxCountry.SelectedValue));

            days -= nonBusinessDays + weekends;

            if (days > 10)
            {
                lblCalculatedPenalty.Text = ((days - 10) * 5).ToString();
            }
        }

        private int GetWeekendsToBeExcluded(DateTime value1, DateTime value2, int countryId)
        {
            int weekends = 0;

            DataTable weekendsTable = new DataTable();
            LibrarySystemContext.GetWeekendsAdapter().Fill(weekendsTable);

            var result = weekendsTable
                        .AsEnumerable()
                        .Where(row => row.Field<int>("CountryId") == countryId);
            //todo:exclude

            return weekends;
        }

        private int GetNonBusinessDaysToBeExcluded(DateTime issueDate, DateTime returnDate, int countryId)
        {
            int nonBusinessDays = 0;

            DataTable nonBusinessDaysTable = new DataTable();
            LibrarySystemContext.GetNonBusinessDaysAdapter().Fill(nonBusinessDaysTable);

            var result = nonBusinessDaysTable
                        .AsEnumerable()
                        .Where(row => row.Field<int>("CountryId") == countryId);

            //todo:exclude

            return nonBusinessDays;
        }
    }
}