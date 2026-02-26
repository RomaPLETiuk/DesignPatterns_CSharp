namespace Report_Builder;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private readonly IEnumerable<Employee> _employees;
    private EmployeeReport _report = new();

    public EmployeeReportBuilder(IEnumerable<Employee> employees)
    {
        _employees = employees;
    }

    public void BuildHeader()
    {
        _report = _report with
        {
            Header = $"EMPLOYEE REPORT ({DateTime.Now:d})\n----------------------------"
        };
    }

    public void BuildBody()
    {
        var body = string.Join(Environment.NewLine,
            _employees.Select(e =>
                $"Employee: {e.Name,-10} Salary: {e.Salary,6}"));

        _report = _report with { Body = body };
    }

    public void BuildFooter()
    {
        _report = _report with
        {
            Footer =
                $"----------------------------\n" +
                $"Total employees: {_employees.Count()}\n" +
                $"Total salary: {_employees.Sum(e => e.Salary)}"
        };
    }

    public EmployeeReport GetResult() => _report;
}
