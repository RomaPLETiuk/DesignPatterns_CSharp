namespace Report_Bilder_
{
    public class EmployeeReportBilder : IEmployeeReportBilder
    {
        private EmployeeReport _employeeReport;
        private IEnumerable<Employee> _employees;

        public EmployeeReportBilder(IEnumerable<Employee> employees)
        {
            _employees = employees;

            _employeeReport = new();

        }

        public IEmployeeReportBilder BildHead()
        {
            _employeeReport.Head =
                $"EMPLOYEES REPORT ON DATE: {DateTime.Now}" +
                $"\n________________________________________________________________________";

            return this;
        }

        public IEmployeeReportBilder BildBody()
        {
            _employeeReport.Body =
             string.Join(Environment.NewLine,
             _employees.Select(e =>
             $"\nEmployee: {e.Name}\t\t Salary: {e.Salary}"));

            return this;
        }

        public IEmployeeReportBilder BildFoot()
        {
            _employeeReport.Foot =
                $"\n________________________________________________________________________";
            _employeeReport.Foot +=
                $"\n Total employees: {_employees.Count()}," +
                $"\n Total salary: {_employees.Sum(e => e.Salary)}";


            return this;

        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;
            _employeeReport = new();
            return employeeReport;
        }


    }
}
